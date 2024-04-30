namespace Glitchquest
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
            healthBar.Minimum = 0;
            healthBar.Maximum = _world._blip.maxHealth;
            hungerBar.Minimum = 0;
            hungerBar.Maximum = _world._blip.maxHunger;
            tiredBar.Minimum = 0;
            tiredBar.Maximum = _world._blip.maxTired;
        }

        private void gridView1_Load(object sender, EventArgs e)
        {
            gridView1.GridLoad(_world);
        }

        /// <summary>
        /// Updates world based off tick of timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
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


        }

        /// <summary>
        /// Changes speed of time based off of trackbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeChange(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) { timer1.Interval = 8000; }
            else if (trackBar1.Value == 1) { timer1.Interval = 6000; }
            else if (trackBar1.Value == 2) { timer1.Interval = 4000; }
            else if (trackBar1.Value == 3) { timer1.Interval = 3000; }
            else if (trackBar1.Value == 4) { timer1.Interval = 2000; }
            else if (trackBar1.Value == 5) { timer1.Interval = 1500; }
            else if (trackBar1.Value == 6) { timer1.Interval = 1000; }
            else if (trackBar1.Value == 7) { timer1.Interval = 750; }
            else if (trackBar1.Value == 8) { timer1.Interval = 500; }
            else if (trackBar1.Value == 9) { timer1.Interval = 250; }
            else { timer1.Interval = 55; }
        }

        private void WorldView_Load(object sender, EventArgs e)
        {

        }

    }
}
