namespace IdleGame
{
    public partial class Form1 : Form
    {
        private Grid grid;
        private List<TileOccupier> tileOccupiers;

        //split up draw from models

        public Form1()
        {
            InitializeComponent();

            //need to move tileoccupiers stuff to grid class
            // cellSize, numRows numCols, 
            grid = new Grid(50, 25, 25, renderLines: false);

            this.tileOccupiers = new List<TileOccupier>();
            TileOccupier blip = new Blip(50, 1, 1, 1);
            tileOccupiers.Add(blip);
            while (tileOccupiers.Count() < grid.numRows * grid.numCols)
            {
                tileOccupiers.Add(new TileOccupier(grid.cellSize, 1, 1));
            }


            //https://levelup.gitconnected.com/shuffle-a-list-t-in-c-net-7-with-one-line-8b9e3e44db64
            tileOccupiers = tileOccupiers.OrderBy(x => Random.Shared.Next()).ToList();

            //Used for index when cycling through tileOccupiers list
            int i = 0;
            for (int x = 0; x < grid.numRows; x++)
            {

                for (int y = 0; y < grid.numCols; y++)
                {

                    tileOccupiers[i]._x = x;
                    tileOccupiers[i]._y = y;
                    // sets the visibility of the grid to true
                    tileOccupiers[i].Visible = true;

                    this.Controls.Add(tileOccupiers[i]);

                    // add the grid to the forms controls
                    Controls.Add(tileOccupiers[i]);

                    this.tileOccupiers[i].Draw(x * grid.cellSize, y * grid.cellSize);
                    i++;
                }
            }



            // Calculate the size of the form based on the size of the grid
            this.ClientSize = new System.Drawing.Size(grid.Width + 20, grid.Height + 20); // Add some padding


            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            grid.Draw(sender, e);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}