namespace IdlerVersion2
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
            pictureBox3 = new PictureBox();
            SpeedSliderText = new PictureBox();
            InventoryPlaceholder = new ListBox();
            trackBar1 = new TrackBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView1.Location = new Point(12, 42);
            gridView1.Name = "gridView1";
            gridView1.Size = new Size(909, 744);
            gridView1.TabIndex = 0;
            gridView1.Load += gridView1_Load;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1283, 33);
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
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(927, 587);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(344, 104);
            listBox2.TabIndex = 25;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(927, 352);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 229);
            listBox1.TabIndex = 24;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.ProtectiveShape;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(1098, 194);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 143);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.PointyShapeSword;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1098, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 143);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.TwinShapedArmor;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(942, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 143);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.Sir_Blip;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(942, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(150, 143);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // SpeedSliderText
            // 
            SpeedSliderText.BackgroundImage = Properties.Resources.GameSpeed;
            SpeedSliderText.BackgroundImageLayout = ImageLayout.Stretch;
            SpeedSliderText.Location = new Point(927, 697);
            SpeedSliderText.Name = "SpeedSliderText";
            SpeedSliderText.Size = new Size(332, 46);
            SpeedSliderText.TabIndex = 19;
            SpeedSliderText.TabStop = false;
            // 
            // InventoryPlaceholder
            // 
            InventoryPlaceholder.FormattingEnabled = true;
            InventoryPlaceholder.ItemHeight = 25;
            InventoryPlaceholder.Location = new Point(927, 42);
            InventoryPlaceholder.Name = "InventoryPlaceholder";
            InventoryPlaceholder.Size = new Size(344, 304);
            InventoryPlaceholder.TabIndex = 18;
            InventoryPlaceholder.SelectedIndexChanged += InventoryPlaceholder_SelectedIndexChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(927, 749);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(332, 69);
            trackBar1.TabIndex = 17;
            trackBar1.Value = 5;
            trackBar1.Scroll += TimeChange;
            // 
            // WorldView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 798);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedSliderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox SpeedSliderText;
        private ListBox InventoryPlaceholder;
        private TrackBar trackBar1;
    }
}