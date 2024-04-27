namespace MarketWatch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelDate = new Label();
            labelWatch = new Label();
            labelBRFUT = new Label();
            labelBRIBOV = new Label();
            labelUSNYSE = new Label();
            labelOperNasdaq = new Label();
            timer = new System.Windows.Forms.Timer(components);
            timerEx = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.ForeColor = Color.FromArgb(224, 224, 224);
            labelDate.Location = new Point(12, 15);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(460, 20);
            labelDate.TabIndex = 0;
            labelDate.Text = "Loading...";
            labelDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWatch
            // 
            labelWatch.Font = new Font("Tahoma", 60F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWatch.ForeColor = Color.White;
            labelWatch.Location = new Point(12, 44);
            labelWatch.Name = "labelWatch";
            labelWatch.Size = new Size(460, 97);
            labelWatch.TabIndex = 1;
            labelWatch.Text = "00:00:00";
            labelWatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBRFUT
            // 
            labelBRFUT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBRFUT.ForeColor = Color.Gray;
            labelBRFUT.Location = new Point(12, 179);
            labelBRFUT.Name = "labelBRFUT";
            labelBRFUT.Size = new Size(460, 16);
            labelBRFUT.TabIndex = 2;
            labelBRFUT.Text = "Loading...";
            labelBRFUT.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelBRIBOV
            // 
            labelBRIBOV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelBRIBOV.ForeColor = Color.Gray;
            labelBRIBOV.Location = new Point(12, 202);
            labelBRIBOV.Name = "labelBRIBOV";
            labelBRIBOV.Size = new Size(460, 16);
            labelBRIBOV.TabIndex = 3;
            labelBRIBOV.Text = "Loading...";
            labelBRIBOV.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelUSNYSE
            // 
            labelUSNYSE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelUSNYSE.ForeColor = Color.Gray;
            labelUSNYSE.Location = new Point(12, 225);
            labelUSNYSE.Name = "labelUSNYSE";
            labelUSNYSE.Size = new Size(460, 16);
            labelUSNYSE.TabIndex = 4;
            labelUSNYSE.Text = "Loading...";
            labelUSNYSE.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelOperNasdaq
            // 
            labelOperNasdaq.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelOperNasdaq.ForeColor = Color.Gray;
            labelOperNasdaq.Location = new Point(12, 248);
            labelOperNasdaq.Name = "labelOperNasdaq";
            labelOperNasdaq.Size = new Size(460, 15);
            labelOperNasdaq.TabIndex = 5;
            labelOperNasdaq.Text = "Loading...";
            labelOperNasdaq.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // timerEx
            // 
            timerEx.Interval = 1000;
            timerEx.Tick += timerEx_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(484, 281);
            Controls.Add(labelOperNasdaq);
            Controls.Add(labelUSNYSE);
            Controls.Add(labelBRIBOV);
            Controls.Add(labelBRFUT);
            Controls.Add(labelWatch);
            Controls.Add(labelDate);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "MarketWatch";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelDate;
        private Label labelWatch;
        private Label labelBRFUT;
        private Label labelBRIBOV;
        private Label labelUSNYSE;
        private Label labelOperNasdaq;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerEx;
        private Button button1;
    }
}
