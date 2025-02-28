namespace Ucak_Savasi
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
            dusman_1 = new PictureBox();
            mermi = new PictureBox();
            player = new PictureBox();
            lbl_skor = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            dusman_3 = new PictureBox();
            dusman_2 = new PictureBox();
            lbl_bitis = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dusman_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mermi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dusman_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dusman_2).BeginInit();
            SuspendLayout();
            // 
            // dusman_1
            // 
            dusman_1.Image = (Image)resources.GetObject("dusman_1.Image");
            dusman_1.Location = new Point(105, 54);
            dusman_1.Name = "dusman_1";
            dusman_1.Size = new Size(81, 103);
            dusman_1.SizeMode = PictureBoxSizeMode.Zoom;
            dusman_1.TabIndex = 0;
            dusman_1.TabStop = false;
            // 
            // mermi
            // 
            mermi.Image = (Image)resources.GetObject("mermi.Image");
            mermi.Location = new Point(362, 553);
            mermi.Name = "mermi";
            mermi.Size = new Size(46, 62);
            mermi.SizeMode = PictureBoxSizeMode.Zoom;
            mermi.TabIndex = 3;
            mermi.TabStop = false;
            // 
            // player
            // 
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(344, 621);
            player.Name = "player";
            player.Size = new Size(81, 103);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 4;
            player.TabStop = false;
            // 
            // lbl_skor
            // 
            lbl_skor.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_skor.ForeColor = SystemColors.ButtonHighlight;
            lbl_skor.Location = new Point(86, 3);
            lbl_skor.Name = "lbl_skor";
            lbl_skor.Size = new Size(43, 40);
            lbl_skor.TabIndex = 7;
            lbl_skor.Text = "0";
            lbl_skor.TextAlign = ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainGameTimerEvent;
            // 
            // dusman_3
            // 
            dusman_3.Image = (Image)resources.GetObject("dusman_3.Image");
            dusman_3.Location = new Point(551, 54);
            dusman_3.Name = "dusman_3";
            dusman_3.Size = new Size(81, 103);
            dusman_3.SizeMode = PictureBoxSizeMode.Zoom;
            dusman_3.TabIndex = 8;
            dusman_3.TabStop = false;
            // 
            // dusman_2
            // 
            dusman_2.Image = (Image)resources.GetObject("dusman_2.Image");
            dusman_2.Location = new Point(327, 54);
            dusman_2.Name = "dusman_2";
            dusman_2.Size = new Size(81, 103);
            dusman_2.SizeMode = PictureBoxSizeMode.Zoom;
            dusman_2.TabIndex = 9;
            dusman_2.TabStop = false;
            // 
            // lbl_bitis
            // 
            lbl_bitis.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_bitis.ForeColor = SystemColors.ButtonHighlight;
            lbl_bitis.Location = new Point(39, 301);
            lbl_bitis.Name = "lbl_bitis";
            lbl_bitis.Size = new Size(708, 150);
            lbl_bitis.TabIndex = 10;
            lbl_bitis.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-3, 3);
            label1.Name = "label1";
            label1.Size = new Size(83, 37);
            label1.TabIndex = 11;
            label1.Text = "Skor:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 727);
            Controls.Add(mermi);
            Controls.Add(player);
            Controls.Add(dusman_2);
            Controls.Add(dusman_3);
            Controls.Add(dusman_1);
            Controls.Add(lbl_bitis);
            Controls.Add(label1);
            Controls.Add(lbl_skor);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "savas_alani";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)dusman_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mermi).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)dusman_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dusman_2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox dusman_1;
        private PictureBox mermi;
        private PictureBox player;
        private Label lbl_skor;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox dusman_3;
        private PictureBox dusman_2;
        private Label lbl_bitis;
        private Label label1;
    }
}