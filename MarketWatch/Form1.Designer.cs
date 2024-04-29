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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelDate = new Label();
            labelWatch = new Label();
            labelEx0 = new Label();
            labelEx1 = new Label();
            labelEx2 = new Label();
            labelEx3 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            timerEx = new System.Windows.Forms.Timer(components);
            pictureDevelopMode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureDevelopMode).BeginInit();
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
            // labelEx0
            // 
            labelEx0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx0.ForeColor = Color.Gray;
            labelEx0.Location = new Point(12, 179);
            labelEx0.Name = "labelEx0";
            labelEx0.Size = new Size(460, 16);
            labelEx0.TabIndex = 2;
            labelEx0.Text = "Loading...";
            labelEx0.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx1
            // 
            labelEx1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx1.ForeColor = Color.Gray;
            labelEx1.Location = new Point(12, 202);
            labelEx1.Name = "labelEx1";
            labelEx1.Size = new Size(460, 16);
            labelEx1.TabIndex = 3;
            labelEx1.Text = "Loading...";
            labelEx1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx2
            // 
            labelEx2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx2.ForeColor = Color.Gray;
            labelEx2.Location = new Point(12, 225);
            labelEx2.Name = "labelEx2";
            labelEx2.Size = new Size(460, 16);
            labelEx2.TabIndex = 4;
            labelEx2.Text = "Loading...";
            labelEx2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx3
            // 
            labelEx3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx3.ForeColor = Color.Gray;
            labelEx3.Location = new Point(12, 248);
            labelEx3.Name = "labelEx3";
            labelEx3.Size = new Size(460, 15);
            labelEx3.TabIndex = 5;
            labelEx3.Text = "Loading...";
            labelEx3.TextAlign = ContentAlignment.TopCenter;
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
            // pictureDevelopMode
            // 
            pictureDevelopMode.Image = (Image)resources.GetObject("pictureDevelopMode.Image");
            pictureDevelopMode.Location = new Point(462, 2);
            pictureDevelopMode.Name = "pictureDevelopMode";
            pictureDevelopMode.Size = new Size(20, 20);
            pictureDevelopMode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDevelopMode.TabIndex = 6;
            pictureDevelopMode.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(484, 281);
            Controls.Add(pictureDevelopMode);
            Controls.Add(labelEx3);
            Controls.Add(labelEx2);
            Controls.Add(labelEx1);
            Controls.Add(labelEx0);
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
            ((System.ComponentModel.ISupportInitialize)pictureDevelopMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelDate;
        private Label labelWatch;
        private Label labelEx0;
        private Label labelEx1;
        private Label labelEx2;
        private Label labelEx3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerEx;
        private Button button1;
        private PictureBox pictureDevelopMode;
    }
}
