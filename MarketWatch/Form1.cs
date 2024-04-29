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
            ConfigHelper.LoadConfiguration();

            if (ConfigHelper.Config.settings.debugEnabled)
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


            labelWatch.Text = DateTimeHelper.GetTimeNow();
            labelDate.Text = DateTimeHelper.GetFullDate();

            labelEx0.Text = ConfigHelper.LoadConfiguration().exchanges[0].GetFullName();
            labelEx1.Text = ConfigHelper.LoadConfiguration().exchanges[1].GetFullName();
            labelEx2.Text = ConfigHelper.LoadConfiguration().exchanges[2].GetFullName();
            labelEx3.Text = ConfigHelper.LoadConfiguration().exchanges[3].GetFullName();
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
            UpdateLabel(ConfigHelper.LoadConfiguration().exchanges[0], labelEx0);
            UpdateLabel(ConfigHelper.LoadConfiguration().exchanges[1], labelEx1);
            UpdateLabel(ConfigHelper.LoadConfiguration().exchanges[2], labelEx2);
            UpdateLabel(ConfigHelper.LoadConfiguration().exchanges[3], labelEx3);
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

    }
}
