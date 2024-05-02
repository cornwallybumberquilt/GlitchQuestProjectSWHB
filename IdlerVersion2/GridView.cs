using System.ComponentModel;

namespace Glitchquest
{
    /// <summary>
    /// Model for a view containing the grid
    /// </summary>
    public partial class GridView : UserControl
    {
        public BindingList<SquareView> _squaresView;
        /// <summary>
        /// Default constructor
        /// </summary>
        public GridView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the grid into a list
        /// </summary>
        /// <param name="world"></param>
        public void GridLoad(World world)
        {
            _squaresView = new BindingList<SquareView>();
            for (int i = 0; i < world._grid._squares.Count(); i++)
            {
                _squaresView.Add(new SquareView(world._grid._squares[i]));
            }

        }
        /// <summary>
        /// Draws each cell in the _squaresView list to the form
        /// </summary>
        /// <param name="world"></param>
        public void Draw(World world)
        {
            int xSize = Size.Width / world._numCols;
            int ySize = Size.Height / world._numRows;
            int i = 0;
            for (int x = 0; x < world._grid._rows; x++)
            {
                for (int y = 0; y < world._grid._columns; y++)
                {

                    _squaresView[i].Draw(x, y, xSize, ySize);
                    Controls.Add(_squaresView[i]);
                    _squaresView[i].AutoSize = true;
                    i++;
                }
            }
        }

        public void ClearGridUI()
        {
            // Remove all existing SquareView controls from the GridView
            foreach (var squareView in _squaresView)
            {
                Controls.Remove(squareView);
                squareView.Dispose();
            }

            // Clear the list of SquareView controls
            _squaresView.Clear();
        }

        private void GridView_Load(object sender, EventArgs e)
        {

        }

    }
}
