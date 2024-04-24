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
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            SpeedSliderText = new PictureBox();
            InventoryPlaceholder = new ListBox();
            trackBar1 = new TrackBar();
            pictureBox3 = new PictureBox();
            tiredBar = new ProgressBar();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            hungerBar = new ProgressBar();
            pictureBox7 = new PictureBox();
            healthBar = new ProgressBar();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView1.Location = new Point(12, 42);
            gridView1.Name = "gridView1";
            gridView1.Size = new Size(1144, 1140);
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
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(54, 29);
            toolStripMenuItem1.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(204, 34);
            newGameToolStripMenuItem.Text = "New Game";
            // 
            // saveGameToolStripMenuItem
            // 
            saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            saveGameToolStripMenuItem.Size = new Size(204, 34);
            saveGameToolStripMenuItem.Text = "Save Game";
            // 
            // loadGameToolStripMenuItem
            // 
            loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            loadGameToolStripMenuItem.Size = new Size(204, 34);
            loadGameToolStripMenuItem.Text = "Load Game";
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
            timer1.Interval = 1500;
            timer1.Tick += timer1_Tick;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(1169, 871);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(341, 204);
            listBox2.TabIndex = 25;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1169, 634);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 179);
            listBox1.TabIndex = 24;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackgroundImage = Properties.Resources.ProtectiveShape;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1347, 424);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 143);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackgroundImage = Properties.Resources.PointyShapeSword;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1347, 287);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 143);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.TwinShapedArmor;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1181, 424);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 143);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // SpeedSliderText
            // 
            SpeedSliderText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SpeedSliderText.BackgroundImage = Properties.Resources.GameSpeed;
            SpeedSliderText.BackgroundImageLayout = ImageLayout.Stretch;
            SpeedSliderText.Location = new Point(1169, 1081);
            SpeedSliderText.Name = "SpeedSliderText";
            SpeedSliderText.Size = new Size(341, 46);
            SpeedSliderText.TabIndex = 19;
            SpeedSliderText.TabStop = false;
            // 
            // InventoryPlaceholder
            // 
            InventoryPlaceholder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InventoryPlaceholder.FormattingEnabled = true;
            InventoryPlaceholder.ItemHeight = 25;
            InventoryPlaceholder.Location = new Point(1169, 275);
            InventoryPlaceholder.Name = "InventoryPlaceholder";
            InventoryPlaceholder.Size = new Size(341, 304);
            InventoryPlaceholder.TabIndex = 18;
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            trackBar1.Location = new Point(1169, 1133);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(341, 69);
            trackBar1.TabIndex = 17;
            trackBar1.Value = 5;
            trackBar1.Scroll += TimeChange;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackgroundImage = Properties.Resources.Sir_Blip;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1181, 287);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 143);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // tiredBar
            // 
            tiredBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            pictureBox8.Location = new Point(1169, 819);
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
            pictureBox9.Location = new Point(1169, 582);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(341, 46);
            pictureBox9.TabIndex = 33;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox10.BackgroundImage = Properties.Resources.Equipment;
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(1169, 223);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(341, 46);
            pictureBox10.TabIndex = 34;
            pictureBox10.TabStop = false;
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
            // WorldView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 1214);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
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
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(SpeedSliderText);
            Controls.Add(InventoryPlaceholder);
            Controls.Add(trackBar1);
            Controls.Add(gridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "WorldView";
            Text = "WorldView";
            Load += WorldView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox SpeedSliderText;
        private ListBox InventoryPlaceholder;
        private TrackBar trackBar1;
        private PictureBox pictureBox3;
        private ProgressBar tiredBar;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private ProgressBar hungerBar;
        private PictureBox pictureBox7;
        private ProgressBar healthBar;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}