
namespace WinFormsApp6
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new WinFormsApp6.CircuralButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.circuralButton2 = new WinFormsApp6.CircuralButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.poziomTrudnościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łatwyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozpocznijOdNowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.circuralButton2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 931);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::BounceQuestGame.Properties.Resources.serduszko;
            this.pictureBox6.Location = new System.Drawing.Point(738, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BounceQuestGame.Properties.Resources.serduszko;
            this.pictureBox5.Location = new System.Drawing.Point(700, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BounceQuestGame.Properties.Resources.serduszko;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::BounceQuestGame.Properties.Resources.serduszko;
            this.pictureBox4.Location = new System.Drawing.Point(662, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pictureBox1.Image = global::BounceQuestGame.Properties.Resources.ballX;
            this.pictureBox1.Location = new System.Drawing.Point(361, 813);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(314, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // circuralButton2
            // 
            this.circuralButton2.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.circuralButton2.FlatAppearance.BorderSize = 0;
            this.circuralButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circuralButton2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.circuralButton2.Image = global::BounceQuestGame.Properties.Resources.startButton;
            this.circuralButton2.Location = new System.Drawing.Point(287, 354);
            this.circuralButton2.Name = "circuralButton2";
            this.circuralButton2.Size = new System.Drawing.Size(213, 205);
            this.circuralButton2.TabIndex = 4;
            this.circuralButton2.UseVisualStyleBackColor = true;
            this.circuralButton2.Click += new System.EventHandler(this.circuralButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::BounceQuestGame.Properties.Resources.plytaXY;
            this.pictureBox3.Location = new System.Drawing.Point(274, 889);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poziomTrudnościToolStripMenuItem,
            this.graToolStripMenuItem,
            this.rozpocznijOdNowaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // poziomTrudnościToolStripMenuItem
            // 
            this.poziomTrudnościToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.poziomTrudnościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.łatwyToolStripMenuItem,
            this.średniToolStripMenuItem,
            this.trudnyToolStripMenuItem});
            this.poziomTrudnościToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.poziomTrudnościToolStripMenuItem.Name = "poziomTrudnościToolStripMenuItem";
            this.poziomTrudnościToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.poziomTrudnościToolStripMenuItem.Text = "Poziom trudności";
            this.poziomTrudnościToolStripMenuItem.Click += new System.EventHandler(this.poziomTrudnościToolStripMenuItem_Click);
            // 
            // łatwyToolStripMenuItem
            // 
            this.łatwyToolStripMenuItem.Name = "łatwyToolStripMenuItem";
            this.łatwyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.łatwyToolStripMenuItem.Text = "Łatwy";
            this.łatwyToolStripMenuItem.Click += new System.EventHandler(this.łatwyToolStripMenuItem_Click);
            // 
            // średniToolStripMenuItem
            // 
            this.średniToolStripMenuItem.Name = "średniToolStripMenuItem";
            this.średniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.średniToolStripMenuItem.Text = "Średni";
            this.średniToolStripMenuItem.Click += new System.EventHandler(this.średniToolStripMenuItem_Click);
            // 
            // trudnyToolStripMenuItem
            // 
            this.trudnyToolStripMenuItem.Name = "trudnyToolStripMenuItem";
            this.trudnyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trudnyToolStripMenuItem.Text = "Trudny";
            this.trudnyToolStripMenuItem.Click += new System.EventHandler(this.trudnyToolStripMenuItem_Click);
            // 
            // graToolStripMenuItem
            // 
            this.graToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem});
            this.graToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graToolStripMenuItem.Name = "graToolStripMenuItem";
            this.graToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.graToolStripMenuItem.Text = "Gra";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // rozpocznijOdNowaToolStripMenuItem
            // 
            this.rozpocznijOdNowaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rozpocznijOdNowaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rozpocznijOdNowaToolStripMenuItem.Name = "rozpocznijOdNowaToolStripMenuItem";
            this.rozpocznijOdNowaToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.rozpocznijOdNowaToolStripMenuItem.Text = "Rozpocznij od nowa";
            this.rozpocznijOdNowaToolStripMenuItem.Click += new System.EventHandler(this.rozpocznijOdNowaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(783, 953);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Timer timer1;
        private CircuralButton circuralButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CircuralButton pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem poziomTrudnościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łatwyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozpocznijOdNowaToolStripMenuItem;
    }
}

