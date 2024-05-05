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
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuItem1_Alarmes = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            duplicarJanelaALTDToolStripMenuItem = new ToolStripMenuItem();
            fecharTodasAsInstanciasALTQToolStripMenuItem = new ToolStripMenuItem();
            pictureMainWindow = new PictureBox();
            labelNews = new Label();
            pictureUSFlag = new PictureBox();
            timerNews = new System.Windows.Forms.Timer(components);
            pictureBRFlag = new PictureBox();
            pictureEUFlag = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureDevelopMode).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMainWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUSFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBRFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEUFlag).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.ForeColor = Color.FromArgb(224, 224, 224);
            labelDate.Location = new Point(3, 0);
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
            labelWatch.Location = new Point(3, 20);
            labelWatch.Name = "labelWatch";
            labelWatch.Size = new Size(460, 107);
            labelWatch.TabIndex = 1;
            labelWatch.Text = "00:00:00";
            labelWatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEx0
            // 
            labelEx0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx0.ForeColor = Color.Gray;
            labelEx0.Location = new Point(3, 163);
            labelEx0.Name = "labelEx0";
            labelEx0.Size = new Size(222, 20);
            labelEx0.TabIndex = 2;
            labelEx0.Text = "Loading...";
            labelEx0.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx1
            // 
            labelEx1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx1.ForeColor = Color.Gray;
            labelEx1.Location = new Point(3, 183);
            labelEx1.Name = "labelEx1";
            labelEx1.Size = new Size(261, 20);
            labelEx1.TabIndex = 3;
            labelEx1.Text = "Loading...";
            labelEx1.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx2
            // 
            labelEx2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx2.ForeColor = Color.Gray;
            labelEx2.Location = new Point(3, 203);
            labelEx2.Name = "labelEx2";
            labelEx2.Size = new Size(222, 20);
            labelEx2.TabIndex = 4;
            labelEx2.Text = "Loading...";
            labelEx2.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelEx3
            // 
            labelEx3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEx3.ForeColor = Color.Gray;
            labelEx3.Location = new Point(3, 223);
            labelEx3.Name = "labelEx3";
            labelEx3.Size = new Size(261, 20);
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
            pictureDevelopMode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureDevelopMode.Image = (Image)resources.GetObject("pictureDevelopMode.Image");
            pictureDevelopMode.Location = new Point(465, 253);
            pictureDevelopMode.Name = "pictureDevelopMode";
            pictureDevelopMode.Size = new Size(10, 10);
            pictureDevelopMode.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureDevelopMode.TabIndex = 6;
            pictureDevelopMode.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuItem1_Alarmes, calculadoraToolStripMenuItem, duplicarJanelaALTDToolStripMenuItem, fecharTodasAsInstanciasALTQToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(206, 92);
            contextMenuStrip1.Text = "Aaaaa";
            // 
            // menuItem1_Alarmes
            // 
            menuItem1_Alarmes.Checked = true;
            menuItem1_Alarmes.CheckState = CheckState.Checked;
            menuItem1_Alarmes.Name = "menuItem1_Alarmes";
            menuItem1_Alarmes.Size = new Size(205, 22);
            menuItem1_Alarmes.Text = "Som de Alarme";
            menuItem1_Alarmes.Click += menuItem1_Alarmes_Click;
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(205, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora [ALT+C]";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // duplicarJanelaALTDToolStripMenuItem
            // 
            duplicarJanelaALTDToolStripMenuItem.Name = "duplicarJanelaALTDToolStripMenuItem";
            duplicarJanelaALTDToolStripMenuItem.Size = new Size(205, 22);
            duplicarJanelaALTDToolStripMenuItem.Text = "Duplicar Janela [ALT + D]";
            duplicarJanelaALTDToolStripMenuItem.Click += duplicarJanelaALTDToolStripMenuItem_Click;
            // 
            // fecharTodasAsInstanciasALTQToolStripMenuItem
            // 
            fecharTodasAsInstanciasALTQToolStripMenuItem.Name = "fecharTodasAsInstanciasALTQToolStripMenuItem";
            fecharTodasAsInstanciasALTQToolStripMenuItem.Size = new Size(205, 22);
            fecharTodasAsInstanciasALTQToolStripMenuItem.Text = "Fechar [ALT + Q]";
            fecharTodasAsInstanciasALTQToolStripMenuItem.Click += fecharTodasAsInstanciasALTQToolStripMenuItem_Click;
            // 
            // pictureMainWindow
            // 
            pictureMainWindow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureMainWindow.Image = (Image)resources.GetObject("pictureMainWindow.Image");
            pictureMainWindow.Location = new Point(12, 253);
            pictureMainWindow.Name = "pictureMainWindow";
            pictureMainWindow.Size = new Size(10, 10);
            pictureMainWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMainWindow.TabIndex = 7;
            pictureMainWindow.TabStop = false;
            // 
            // labelNews
            // 
            labelNews.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelNews.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNews.ForeColor = Color.Gray;
            labelNews.ImageAlign = ContentAlignment.MiddleRight;
            labelNews.Location = new Point(81, 127);
            labelNews.Name = "labelNews";
            labelNews.Size = new Size(331, 36);
            labelNews.TabIndex = 8;
            labelNews.Text = "[9:30] Leilão Americano Bill a 8 semanas | 10:30";
            labelNews.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureUSFlag
            // 
            pictureUSFlag.Anchor = AnchorStyles.Right;
            pictureUSFlag.Image = (Image)resources.GetObject("pictureUSFlag.Image");
            pictureUSFlag.Location = new Point(55, 135);
            pictureUSFlag.Name = "pictureUSFlag";
            pictureUSFlag.Size = new Size(20, 20);
            pictureUSFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureUSFlag.TabIndex = 11;
            pictureUSFlag.TabStop = false;
            // 
            // timerNews
            // 
            timerNews.Enabled = true;
            timerNews.Interval = 1000;
            timerNews.Tick += timerNews_Tick;
            // 
            // pictureBRFlag
            // 
            pictureBRFlag.Anchor = AnchorStyles.Right;
            pictureBRFlag.Image = (Image)resources.GetObject("pictureBRFlag.Image");
            pictureBRFlag.Location = new Point(3, 135);
            pictureBRFlag.Name = "pictureBRFlag";
            pictureBRFlag.Size = new Size(20, 20);
            pictureBRFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBRFlag.TabIndex = 12;
            pictureBRFlag.TabStop = false;
            // 
            // pictureEUFlag
            // 
            pictureEUFlag.Anchor = AnchorStyles.Right;
            pictureEUFlag.Image = (Image)resources.GetObject("pictureEUFlag.Image");
            pictureEUFlag.Location = new Point(29, 135);
            pictureEUFlag.Name = "pictureEUFlag";
            pictureEUFlag.Size = new Size(20, 20);
            pictureEUFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureEUFlag.TabIndex = 13;
            pictureEUFlag.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelDate);
            flowLayoutPanel1.Controls.Add(labelWatch);
            flowLayoutPanel1.Controls.Add(pictureBRFlag);
            flowLayoutPanel1.Controls.Add(pictureEUFlag);
            flowLayoutPanel1.Controls.Add(pictureUSFlag);
            flowLayoutPanel1.Controls.Add(labelNews);
            flowLayoutPanel1.Controls.Add(labelEx0);
            flowLayoutPanel1.Controls.Add(labelEx1);
            flowLayoutPanel1.Controls.Add(labelEx2);
            flowLayoutPanel1.Controls.Add(labelEx3);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(468, 238);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 26, 26);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(488, 275);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureMainWindow);
            Controls.Add(pictureDevelopMode);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketWatch";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureDevelopMode).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureMainWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUSFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBRFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEUFlag).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuItem1_Alarmes;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem duplicarJanelaALTDToolStripMenuItem;
        private PictureBox pictureMainWindow;
        private Label labelNews;
        private PictureBox pictureUSFlag;
        private System.Windows.Forms.Timer timerNews;
        private ToolStripMenuItem fecharTodasAsInstanciasALTQToolStripMenuItem;
        private PictureBox pictureBRFlag;
        private PictureBox pictureEUFlag;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
