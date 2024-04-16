using IdlerVersion2.Inventory;
using System.ComponentModel;
using System.Windows.Forms;

namespace IdlerVersion2
{
    public partial class WorldView : Form
    {
        World _world;
        //BindingList<object> inventory;
        //BindingList<string> events;
        public WorldView(World world)
        {
            InitializeComponent();
            //inventory = new BindingList<Item>();
            //events = new BindingList<string>();
            _world = world;
            listBox1.DataSource = _world._blip.inventory.items;
            //listBox1.DataSource = inventory;
            listBox2.DataSource = _world._blip.RecentActions;
            //listBox2.DataSource = events;
        }

        private void gridView1_Load(object sender, EventArgs e)
        {
            gridView1.GridLoad(_world);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _world.AdvanceWorld();
            gridView1.Draw(_world);
            listBox1.DataSource = null;
            listBox1.DataSource = _world._blip.inventory.items;
            listBox2.DataSource = null;
            listBox2.DataSource = _world._blip.RecentActions;
            listBox1.SelectedIndex = this.listBox1.Items.Count - 1;
            listBox2.SelectedIndex = this.listBox2.Items.Count - 1;


        }

        private void UpdateLists() 
        { 
        //inventory = _world._blip.inventory.items;
        }

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
            else { timer1.Interval = 50; }
            //timer1.Interval = 2000;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void InventoryPlaceholder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void WorldView_Load(object sender, EventArgs e)
        {

        }
    }
}
