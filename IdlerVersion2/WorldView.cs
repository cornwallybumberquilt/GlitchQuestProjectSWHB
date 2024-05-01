﻿namespace Glitchquest
{
    /// <summary>
    /// Model for main form of program
    /// </summary>
    public partial class WorldView : Form
    {
        World _world;
        AudioManager audioManager;
        

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="world"></param>
        public WorldView(World world)
        {
            InitializeComponent();
            audioManager = new AudioManager();
            audioManager.PlaySound(AudioManager.Soundtrack1);
            _world = world;
            listBox1.DataSource = _world._blip.inventory.items;
            listBox2.DataSource = _world._blip.RecentActions;
            expBar.Minimum = 0;
            expBar.Maximum = _world._blip.expToLevel;
            cooldownBar.Minimum = 0;
            cooldownBar.Maximum = Convert.ToInt32(_world._blip.actionCooldown); 
            healthBar.Minimum = 0;
            healthBar.Maximum = _world._blip.maxHealth;
            hungerBar.Minimum = 0;
            hungerBar.Maximum = _world._blip.maxHunger;
            tiredBar.Minimum = 0;
            tiredBar.Maximum = _world._blip.maxTired;
            weaponLabel.Text = $"{_world._blip.weapon}";
            shieldLabel.Text = $"{_world._blip.shield}";
            armorLabel.Text = $"{_world._blip.armor}";
            levelValueLabel.Text = $"{_world._blip.level}";
            deathsValueLabel.Text = $"{_world._blip.deathCounter}";
                    }

        private void gridView1_Load(object sender, EventArgs e)
        {
            gridView1.GridLoad(_world);
        }

        /// <summary>
        /// Performs methods every tick of the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            WorldController();
        }

        /// <summary>
        /// Advances the gamestate and updates the grid
        /// </summary>
        public void WorldController() 
        {
            bool blipDied = false;
            if (_world._blip.health == 0)
            {
                blipDied = true;
            }
            _world.AdvanceWorld();
            if (blipDied)
            {


                for (int i = 0; i < gridView1._squaresView.Count; i++)
                {
                    gridView1._squaresView[i].Visible = false;
                    gridView1._squaresView[i].Dispose();
                }
                gridView1.GridLoad(_world);

                blipDied = false;
            }

            gridView1.Draw(_world);
            audioManager.ActionSoundPlayer(_world._blip.LastAction);
            listBox1.DataSource = null;
            listBox1.DataSource = _world._blip.inventory.items;
            listBox2.DataSource = null;
            listBox2.DataSource = _world._blip.RecentActions;
            listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            listBox2.SelectedIndex = this.listBox2.Items.Count - 1;
            hungerBar.Value = _world._blip.hunger;
            healthBar.Value = _world._blip.health;
            tiredBar.Value = _world._blip.tired;
            expBar.Value = _world._blip.currentExp;
            cooldownBar.Value = Convert.ToInt32(_world._blip.currentActionCooldown);

            weaponLabel.Text = $"{_world._blip.weapon}";
            shieldLabel.Text = $"{_world._blip.shield}";
            armorLabel.Text = $"{_world._blip.armor}";
            levelValueLabel.Text = $"{_world._blip.level}";
            deathsValueLabel.Text = $"{_world._blip.deathCounter}";
        }


        /// <summary>
        /// Changes speed of time based off of trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeChange(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) { _world.gameSpeedModifier = 0.01; }
            else if (trackBar1.Value == 1) { _world.gameSpeedModifier = 0.10; }
            else if (trackBar1.Value == 2) { _world.gameSpeedModifier = 0.25; }
            else if (trackBar1.Value == 3) { _world.gameSpeedModifier = 0.5; }
            else if (trackBar1.Value == 4) { _world.gameSpeedModifier = 0.75; }
            else if (trackBar1.Value == 5) { _world.gameSpeedModifier = 1; }
            else if (trackBar1.Value == 6) { _world.gameSpeedModifier = 2; }
            else if (trackBar1.Value == 7) { _world.gameSpeedModifier = 4; }
            else if (trackBar1.Value == 8) { _world.gameSpeedModifier = 6; }
            else if (trackBar1.Value == 9) { _world.gameSpeedModifier = 8; }
            else { _world.gameSpeedModifier = 10; }
        }

        private void WorldView_Load(object sender, EventArgs e)
        {

        }

    }
}
