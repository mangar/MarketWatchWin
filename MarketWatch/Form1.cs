using MarketWatch.Helpers;
using MarketWatch.Models;
using System.Reflection;

namespace MarketWatch
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            InitializeMy();
        }

        private void InitializeMy()
        {
            this.ContextMenuStrip = contextMenuStrip1;

            var config = ConfigHelper.LoadConfiguration();

            if (config.Settings.DebugEnabled)
            {
                this.Icon = new Icon(@"Resources/app_dev.ico");  // Set initial icon
                pictureDevelopMode.Visible = true;
                this.Text = "DEV MarketWatch";
            }
            else
            {
                pictureDevelopMode.Visible = false;
            }

            // Version
            Assembly assembly = Assembly.GetExecutingAssembly();
            this.Text += $" - {assembly.GetName().Version}";

            // Context Menu
            menuItem1_Alarmes.Checked = config.Features.FlagAlarms;
            //this.menuItem1_Alarmes.Checked = false;

            //contextMenuStrip1.Items[0].check
            //this.ContextMenuStrip.Items[0].checked
            //config.features.flagAlarms;


            //
            //
            //
            labelWatch.Text = DateTimeHelper.GetTimeNow();
            labelDate.Text = DateTimeHelper.GetFullDate();

            labelEx0.Text = ConfigHelper.LoadConfiguration().Exchanges[0].GetFullName();
            labelEx1.Text = ConfigHelper.LoadConfiguration().Exchanges[1].GetFullName();
            labelEx2.Text = ConfigHelper.LoadConfiguration().Exchanges[2].GetFullName();
            labelEx3.Text = ConfigHelper.LoadConfiguration().Exchanges[3].GetFullName();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            labelWatch.Text = labelWatch.Text = DateTimeHelper.GetTimeNow();
            labelDate.Text = DateTimeHelper.GetFullDate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            timerEx.Start();
        }

        private void timerEx_Tick(object sender, EventArgs e)
        {
            UpdateLabel(ConfigHelper.LoadConfiguration().Exchanges[0], labelEx0);
            UpdateLabel(ConfigHelper.LoadConfiguration().Exchanges[1], labelEx1);
            UpdateLabel(ConfigHelper.LoadConfiguration().Exchanges[2], labelEx2);
            UpdateLabel(ConfigHelper.LoadConfiguration().Exchanges[3], labelEx3);
        }


        private string UpdateLabel(Exchange ex, Label lbl)
        {
            var text = ex.GetStatus();
            var status = ex.GetStatus();

            if (status == "open" || status == "close")
            {
                text = ex.GetFullName();
                if (status == "open")
                {
                    lbl.ForeColor = Color.Green;
                }
                if (status == "close")
                {
                    lbl.ForeColor = Color.Gray;
                }

            }
            if (status == "preopen")
            {
                text = ex.GetFullName() + " :: |PRE OPEN| " + GetTimeDifference(ex.OpenToday());
                lbl.ForeColor = Color.Yellow;
            }
            if (status == "preclose")
            {
                text = ex.GetFullName() + " :: |PRE CLOSE| " + GetTimeDifference(ex.CloseToday());
                lbl.ForeColor = Color.Yellow;
            }

            lbl.Text = text;
            return text;
        }

        public string GetTimeDifference(DateTime inputTime)
        {
            TimeSpan difference = DateTime.Now - inputTime;
            return $"{Math.Abs(difference.Minutes):00}:{Math.Abs(difference.Seconds):00}";
        }

        private void menuItem1_Alarmes_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            clickedItem.Checked = !clickedItem.Checked;

            ConfigHelper.Config.Features.FlagAlarms = clickedItem.Checked;
            ConfigHelper.SaveConfig();
        }
    }
}
