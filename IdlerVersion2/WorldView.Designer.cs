namespace Glitchquest
{
    partial class WorldView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridView1 = new GridView();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            saveGameToolStripMenuItem = new ToolStripMenuItem();
            loadGameToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            SpeedSliderText = new PictureBox();
            trackBar1 = new TrackBar();
            tiredBar = new ProgressBar();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            hungerBar = new ProgressBar();
            pictureBox7 = new PictureBox();
            healthBar = new ProgressBar();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            cooldownBar = new ProgressBar();
            pictureBox13 = new PictureBox();
            expBar = new ProgressBar();
            pictureBox1 = new PictureBox();
            armorLabel = new Label();
            pictureBox2 = new PictureBox();
            weaponLabel = new Label();
            shieldLabel = new Label();
            levelLabel = new Label();
            deathsLabel = new Label();
            deathsValueLabel = new Label();
            levelValueLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView1.Location = new Point(12, 42);
            gridView1.Name = "gridView1";
            gridView1.Size = new Size(1144, 1009);
            gridView1.TabIndex = 0;
            gridView1.Load += gridView1_Load;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(140, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, saveGameToolStripMenuItem, loadGameToolStripMenuItem });
            toolStripMenuItem1.ForeColor = SystemColors.InfoText;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 29);
            toolStripMenuItem1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(204, 34);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            saveGameToolStripMenuItem.Size = new Size(204, 34);
            saveGameToolStripMenuItem.Text = "Save Game";
            saveGameToolStripMenuItem.Click += saveGameToolStripMenuItem_Click;
            // 
            // loadGameToolStripMenuItem
            // 
            loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            loadGameToolStripMenuItem.Size = new Size(204, 34);
            loadGameToolStripMenuItem.Text = "Load Game";
            loadGameToolStripMenuItem.Click += loadGameToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listBox2.BackColor = SystemColors.InfoText;
            listBox2.ForeColor = SystemColors.Window;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(1169, 845);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(341, 79);
            listBox2.TabIndex = 25;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.InfoText;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1169, 607);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 179);
            listBox1.TabIndex = 24;
            // 
            // SpeedSliderText
            // 
            SpeedSliderText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SpeedSliderText.BackgroundImage = Properties.Resources.GameSpeed;
            SpeedSliderText.BackgroundImageLayout = ImageLayout.Stretch;
            SpeedSliderText.Location = new Point(1169, 930);
            SpeedSliderText.Name = "SpeedSliderText";
            SpeedSliderText.Size = new Size(341, 46);
            SpeedSliderText.TabIndex = 19;
            SpeedSliderText.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            trackBar1.Location = new Point(1169, 982);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(341, 69);
            trackBar1.TabIndex = 17;
            trackBar1.Value = 5;
            trackBar1.Scroll += TimeChange;
            // 
            // tiredBar
            // 
            tiredBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tiredBar.BackColor = SystemColors.InfoText;
            tiredBar.Location = new Point(1337, 172);
            tiredBar.Name = "tiredBar";
            tiredBar.Size = new Size(173, 46);
            tiredBar.TabIndex = 26;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackgroundImage = Properties.Resources.Tiredness;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(1169, 172);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(162, 46);
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.BackgroundImage = Properties.Resources.Hunger;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(1169, 120);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(162, 46);
            pictureBox6.TabIndex = 29;
            pictureBox6.TabStop = false;
            // 
            // hungerBar
            // 
            hungerBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hungerBar.BackColor = SystemColors.InfoText;
            hungerBar.Location = new Point(1337, 120);
            hungerBar.Name = "hungerBar";
            hungerBar.Size = new Size(173, 46);
            hungerBar.TabIndex = 28;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.BackgroundImage = Properties.Resources.Health;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(1169, 68);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(162, 46);
            pictureBox7.TabIndex = 31;
            pictureBox7.TabStop = false;
            // 
            // healthBar
            // 
            healthBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            healthBar.BackColor = SystemColors.InfoText;
            healthBar.Location = new Point(1337, 68);
            healthBar.Name = "healthBar";
            healthBar.Size = new Size(173, 46);
            healthBar.TabIndex = 30;
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox8.BackgroundImage = Properties.Resources.TravelLog;
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(1169, 792);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(341, 46);
            pictureBox8.TabIndex = 32;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox9.BackgroundImage = Properties.Resources.Inventory;
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(1169, 555);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(341, 46);
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox11.BackgroundImage = Properties.Resources.CurrentStatus;
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(1169, 16);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(341, 46);
            pictureBox11.TabIndex = 35;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox12.BackgroundImage = Properties.Resources.Cooldown1;
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(1169, 276);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(162, 46);
            pictureBox12.TabIndex = 40;
            pictureBox12.TabStop = false;
            // 
            // cooldownBar
            // 
            cooldownBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cooldownBar.BackColor = SystemColors.InfoText;
            cooldownBar.Location = new Point(1337, 276);
            cooldownBar.Name = "cooldownBar";
            cooldownBar.Size = new Size(173, 46);
            cooldownBar.TabIndex = 39;
            // 
            // pictureBox13
            // 
            pictureBox13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox13.BackgroundImage = Properties.Resources.Experience1;
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Location = new Point(1169, 224);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(162, 46);
            pictureBox13.TabIndex = 44;
            pictureBox13.TabStop = false;
            // 
            // expBar
            // 
            expBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            expBar.BackColor = SystemColors.InfoText;
            expBar.Location = new Point(1337, 224);
            expBar.Name = "expBar";
            expBar.Size = new Size(173, 46);
            expBar.TabIndex = 43;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.Equipment;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1169, 398);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 46);
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // armorLabel
            // 
            armorLabel.AutoSize = true;
            armorLabel.BackColor = SystemColors.InfoText;
            armorLabel.ForeColor = SystemColors.Control;
            armorLabel.Location = new Point(1169, 521);
            armorLabel.MaximumSize = new Size(341, 29);
            armorLabel.MinimumSize = new Size(341, 29);
            armorLabel.Name = "armorLabel";
            armorLabel.Size = new Size(341, 29);
            armorLabel.TabIndex = 49;
            armorLabel.Text = "label3";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImage = Properties.Resources.Equipment;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1169, 402);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(341, 46);
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // weaponLabel
            // 
            weaponLabel.AutoSize = true;
            weaponLabel.BackColor = SystemColors.InfoText;
            weaponLabel.ForeColor = SystemColors.Control;
            weaponLabel.Location = new Point(1169, 451);
            weaponLabel.MaximumSize = new Size(341, 29);
            weaponLabel.MinimumSize = new Size(341, 29);
            weaponLabel.Name = "weaponLabel";
            weaponLabel.Size = new Size(341, 29);
            weaponLabel.TabIndex = 47;
            weaponLabel.Text = "label1";
            // 
            // shieldLabel
            // 
            shieldLabel.AutoSize = true;
            shieldLabel.BackColor = SystemColors.InfoText;
            shieldLabel.ForeColor = SystemColors.Control;
            shieldLabel.Location = new Point(1169, 486);
            shieldLabel.MaximumSize = new Size(341, 29);
            shieldLabel.MinimumSize = new Size(341, 29);
            shieldLabel.Name = "shieldLabel";
            shieldLabel.Size = new Size(341, 29);
            shieldLabel.TabIndex = 48;
            shieldLabel.Text = "label2";
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.BackColor = SystemColors.InfoText;
            levelLabel.ForeColor = SystemColors.Control;
            levelLabel.Location = new Point(1169, 325);
            levelLabel.MaximumSize = new Size(162, 29);
            levelLabel.MinimumSize = new Size(162, 29);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(162, 29);
            levelLabel.TabIndex = 50;
            levelLabel.Text = "LEVEL";
            levelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deathsLabel
            // 
            deathsLabel.AutoSize = true;
            deathsLabel.BackColor = SystemColors.InfoText;
            deathsLabel.ForeColor = SystemColors.Control;
            deathsLabel.Location = new Point(1169, 366);
            deathsLabel.MaximumSize = new Size(162, 29);
            deathsLabel.MinimumSize = new Size(162, 29);
            deathsLabel.Name = "deathsLabel";
            deathsLabel.Size = new Size(162, 29);
            deathsLabel.TabIndex = 51;
            deathsLabel.Text = "DEATHS";
            deathsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deathsValueLabel
            // 
            deathsValueLabel.AutoSize = true;
            deathsValueLabel.BackColor = SystemColors.InfoText;
            deathsValueLabel.ForeColor = SystemColors.Control;
            deathsValueLabel.Location = new Point(1337, 366);
            deathsValueLabel.MaximumSize = new Size(173, 29);
            deathsValueLabel.MinimumSize = new Size(173, 29);
            deathsValueLabel.Name = "deathsValueLabel";
            deathsValueLabel.Size = new Size(173, 29);
            deathsValueLabel.TabIndex = 52;
            deathsValueLabel.Text = "label3";
            // 
            // levelValueLabel
            // 
            levelValueLabel.AutoSize = true;
            levelValueLabel.BackColor = SystemColors.InfoText;
            levelValueLabel.ForeColor = SystemColors.Control;
            levelValueLabel.Location = new Point(1337, 325);
            levelValueLabel.MaximumSize = new Size(173, 29);
            levelValueLabel.MinimumSize = new Size(173, 29);
            levelValueLabel.Name = "levelValueLabel";
            levelValueLabel.Size = new Size(173, 29);
            levelValueLabel.TabIndex = 53;
            levelValueLabel.Text = "label4";
            // 
            // WorldView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1518, 1065);
            Controls.Add(levelValueLabel);
            Controls.Add(deathsValueLabel);
            Controls.Add(deathsLabel);
            Controls.Add(levelLabel);
            Controls.Add(armorLabel);
            Controls.Add(shieldLabel);
            Controls.Add(weaponLabel);
            Controls.Add(pictureBox13);
            Controls.Add(expBar);
            Controls.Add(pictureBox12);
            Controls.Add(cooldownBar);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(healthBar);
            Controls.Add(pictureBox6);
            Controls.Add(hungerBar);
            Controls.Add(pictureBox5);
            Controls.Add(tiredBar);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(SpeedSliderText);
            Controls.Add(trackBar1);
            Controls.Add(gridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WorldView";
            Text = "WorldView";
            Load += WorldView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GridView gridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem saveGameToolStripMenuItem;
        private ToolStripMenuItem loadGameToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox2;
        private ListBox listBox1;
        private PictureBox SpeedSliderText;
        private TrackBar trackBar1;
        private ProgressBar tiredBar;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ProgressBar hungerBar;
        private PictureBox pictureBox7;
        private ProgressBar healthBar;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox11;
        private ListBox weaponBox;
        private ListBox shieldBox;
        private ListBox armorBox;
        private PictureBox pictureBox12;
        private ProgressBar cooldownBar;
        private PictureBox pictureBox13;
        private ProgressBar expBar;
        private PictureBox pictureBox1;
        private Label weaponLabel;
        private Label shieldLabel;
        private Label armorLabel;
        private PictureBox pictureBox2;
        private Label levelLabel;
        private Label deathsLabel;
        private Label deathsValueLabel;
        private Label levelValueLabel;
    }
}