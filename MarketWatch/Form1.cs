using MarketWatch.Helpers;
using MarketWatch.Models;
using static System.Net.Mime.MediaTypeNames;

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

            labelWatch.Text = DateTimeHelper.GetTimeNow();
            labelDate.Text = DateTimeHelper.GetFullDate();

            pictureDevelopMode.Visible = ConfigHelper.Config.settings.debugEnabled;


            var exchanges = new ExchangeFactory().GetExchanges();

            labelBRFUT.Text = exchanges[0].GetFullName();
            labelBRIBOV.Text = exchanges[1].GetFullName();
            labelUSNYSE.Text = exchanges[2].GetFullName();
            labelOperNasdaq.Text = exchanges[3].GetFullName();
            
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
            var exchanges = new ExchangeFactory().GetExchanges();

            UpdateLabel(exchanges[0].GetStatus(), exchanges[0], labelBRFUT);
            UpdateLabel(exchanges[1].GetStatus(), exchanges[1], labelBRIBOV);
            UpdateLabel(exchanges[2].GetStatus(), exchanges[2], labelUSNYSE);
            UpdateLabel(exchanges[3].GetStatus(), exchanges[3], labelOperNasdaq);
        }


        private string UpdateLabel(string status, Exchange ex, Label lbl)
        {
            var text = status;

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
