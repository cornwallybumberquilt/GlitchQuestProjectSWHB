namespace IdlerVersion2
{
    public partial class Form1 : Form
    {
        private World _world;
        private Blip _blip;
        public Form1()
        {
            //int cellSize, int numRows, int numCols, Blip blip
            InitializeComponent();
            _blip = new Blip(50, 1);
            _world = new World(50, 25, 25, _blip);
            _world.CreateLayout(_blip);
            _world.PopulateWorld();
            _blip.GetAdjacentCells(_world._squares);
            MakeGridVisible();
            // while (true) { Tick(); }

        }

        public void Tick()
        {
            _blip.GetAdjacentCells(_world._squares);
            _world.AdvanceWorld();
            MakeGridVisible();
        }

        public void MakeGridVisible()
        {
            int i = 0;
            for (int x = 0; x < _world._numRows; x++)
            {

                for (int y = 0; y < _world._numCols; y++)
                {

                    _world._squares[i]._x = x;
                    _world._squares[i]._y = y;
                    // sets the visibility of the grid to true
                    _world._squares[i].Visible = true;

                    this.Controls.Add(_world._squares[i]);

                    // add the grid to the forms controls
                    Controls.Add(_world._squares[i]);

                    this._world._squares[i].Location = new Point(x * _world._cellSize, y * _world._cellSize);
                    i++;
                }
            }
            // Calculate the size of the form based on the size of the grid
            this.ClientSize = new System.Drawing.Size((_world._numRows * _world._cellSize) + 20, (_world._numCols * _world._cellSize) + 20); // Add some padding


            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GridDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
