namespace IdleGame
{
    public partial class Form1 : Form
    {
        private Grid grid;

        public Form1()
        {
            InitializeComponent();
            
                    // cellSize, numRows numCols, 
            grid = new Grid(50, 25, 25, renderLines: false);

            // sets the visibility of the grid to true
            grid.Visible = true;

            this.Controls.Add(grid);


            // Calculate the size of the form based on the size of the grid
            this.ClientSize = new System.Drawing.Size(grid.Width + 20, grid.Height + 20); // Add some padding


            // Center the form on the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // add the grid to the forms controls
            Controls.Add(grid);

            // attach paint event handler to the panel
            grid.Paint += Grid_Paint;
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