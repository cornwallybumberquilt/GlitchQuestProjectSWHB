using System.ComponentModel;

namespace IdlerVersion2
{
    public partial class GridView : UserControl
    {


        BindingList<SquareView> _squaresView;
        public GridView()
        {
            InitializeComponent();
            //world = world;
            //_squaresView = new BindingList<SquareView>();
            //ClientSize = new Size((_world._grid._rows * _world._grid._cellSize), (_world._grid._columns * _world._grid._cellSize));

        }

        public void GridLoad(World world)
        {
            _squaresView = new BindingList<SquareView>();
            for (int i = 0; i < world._grid._squares.Count(); i++)
            {
                _squaresView.Add(new SquareView(world._grid._squares[i]));
            }

        }
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

        private void GridView_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_world.AdvanceWorld();
            //Draw();
        }
    }
}
