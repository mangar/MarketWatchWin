using MarketWatch.Helpers;
using MarketWatch.Models;
using MarketWatch.Repositories;
using MarketWatch.Repositories.Calendar;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using WMPLib;


namespace MarketWatch
{
    public partial class Form1 : Form
    {

        public bool FlagMainWindow = true;

        public Form1(bool flagMainWindow)
        {
            this.FlagMainWindow = flagMainWindow;

            InitializeComponent();
            this.TopMost = true;
            InitializeMy();
        }

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            InitializeMy();
        }

        private void InitializeMy()
        {
            //
            // News
            //
            pictureUSFlag.Visible = false;
            pictureBRFlag.Visible = false;
            pictureEUFlag.Visible = false;
            labelNews.Visible = false;


            // Main Window Image
            this.pictureMainWindow.Visible = !this.FlagMainWindow;


            this.ContextMenuStrip = contextMenuStrip1;

            var config = ConfigHelper.LoadConfiguration();

            if (config.Settings.DebugEnabled)
            {
                this.Icon = new Icon(@"Resources/Images/app_dev.ico");  // Set initial icon
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


            //
            //
            //
            labelWatch.Text = DateTimeHelper.GetTimeNow();
            labelDate.Text = DateTimeHelper.GetFullDate();

            labelEx0.Text = ConfigHelper.LoadConfiguration().Exchanges[0].GetFullName();
            labelEx1.Text = ConfigHelper.LoadConfiguration().Exchanges[1].GetFullName();
            labelEx2.Text = ConfigHelper.LoadConfiguration().Exchanges[2].GetFullName();
            labelEx3.Text = ConfigHelper.LoadConfiguration().Exchanges[3].GetFullName();


            Sound.PlayOpenApp();
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
                    if (ExchangeStatusControl.IsStatusChanged(ex))
                    {
                        Sound.PlayOpen();
                    }
                }
                if (status == "close")
                {
                    lbl.ForeColor = Color.Gray;
                    if (ExchangeStatusControl.IsStatusChanged(ex))
                    {
                        Sound.PlayClose();
                    }
                }

            }
            if (status == "preopen")
            {
                text = ex.GetFullName() + " :: |PRE OPEN| " + DateTimeHelper.GetTimeDifferenceMMSS(ex.OpenToday());
                lbl.ForeColor = Color.Yellow;
                if (ExchangeStatusControl.IsStatusChanged(ex))
                {
                    Sound.PlayPreOpen();
                }
            }
            if (status == "preclose")
            {
                text = ex.GetFullName() + " :: |PRE CLOSE| " + DateTimeHelper.GetTimeDifferenceMMSS(ex.CloseToday());
                lbl.ForeColor = Color.Yellow;
                if (ExchangeStatusControl.IsStatusChanged(ex))
                {
                    Sound.PlayPreClose();
                }
            }

            lbl.Text = text;
            return text;
        }

        private void menuItem1_Alarmes_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            clickedItem.Checked = !clickedItem.Checked;

            ConfigHelper.Config.Features.FlagAlarms = clickedItem.Checked;
            ConfigHelper.SaveConfig();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void duplicarJanelaALTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(false);
            form1.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if Alt and C are pressed together
            if (keyData == (Keys.Alt | Keys.C))
            {
                Process.Start("calc.exe");
                return true;
            }
            else if (keyData == (Keys.Alt | Keys.D))
            {
                Form1 form1 = new Form1(false);
                form1.Show();

                return true;
            }
            else if (keyData == (Keys.Alt | Keys.Q))
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timerNews_Tick(object sender, EventArgs e)
        {
            var calendarExt = CalendarEconomicRepository.NextEvent();
            if (!calendarExt.IsEmpty())
            {
                labelNews.Text = calendarExt.FullTitle();
                labelNews.ForeColor = calendarExt.color;
                labelNews.Visible = true;

                if (calendarExt.CalendarModel.Country.ToLower() == "us")
                {
                    pictureUSFlag.Visible = true;
                    pictureBRFlag.Visible = false;
                    pictureEUFlag.Visible = false;
                }
                else if (calendarExt.CalendarModel.Country.ToLower() == "br")
                {
                    pictureUSFlag.Visible = false;
                    pictureBRFlag.Visible = true;
                    pictureEUFlag.Visible = false;
                }
                else if (calendarExt.CalendarModel.Country.ToLower() == "eu")
                {
                    pictureUSFlag.Visible = false;
                    pictureBRFlag.Visible = false;
                    pictureEUFlag.Visible = true;
                }
                else
                {
                    pictureUSFlag.Visible = false;
                    pictureBRFlag.Visible = false;
                    pictureEUFlag.Visible = false;
                }

            }
            else
            {
                pictureUSFlag.Visible = false;
                pictureBRFlag.Visible = false;
                pictureEUFlag.Visible = false;
                labelNews.Visible = false;
            }
        }

        private void fecharTodasAsInstanciasALTQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
