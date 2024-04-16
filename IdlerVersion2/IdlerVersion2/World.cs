//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    /// <summary>
    /// Creates an instance of a world object
    /// </summary>
    public class World
    {
        public Grid _grid;
        //public List<Square> _squares;
        public int _cellSize;
        public int _numRows;
        public int _numCols;
        public Blip _blip;
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="numRows"></param>
        /// <param name="numCols"></param>
        /// <param name="blip"></param>
        public World(int cellSize, int numRows, int numCols, Blip blip)
        {
            _blip = blip;
            _cellSize = cellSize;
            _numRows = numRows;
            _numCols = numCols;
            //_squares = new List<Square>();
            _grid = new Grid(cellSize, numRows, numCols);
            CreateLayout();
            PopulateWorld();
        }

        /// <summary>
        /// Creates a shuffled grid layout using rows and collumns
        /// </summary>
        public void CreateLayout()
        {
            while (_grid._squares.Count() < _numRows * _numCols)
            {
                _grid._squares.Add(new Square(_cellSize));
            }
            _grid._squares = _grid._squares.OrderBy(x => Random.Shared.Next()).ToList();
        }
        /// <summary>
        /// gives each square in the grid an x or y coordinate, and assigns an occupied true flag to the square where blip is currently located
        /// </summary>
        public void PopulateWorld()
        {
            int i = 0;
            for (int x = 0; x < _numRows; x++)
            {

                for (int y = 0; y < _numCols; y++)
                {

                    _grid._squares[i]._x = x;
                    _grid._squares[i]._y = y;
                    if (x == _blip._x && y == _blip._y) { _grid._squares[i]._occupied = true; }
                    i++;
                }
            }
        }
        /// <summary>
        /// makes blip move arround the grid
        /// </summary>
        public void AdvanceWorld()
        {
            bool foundBlip = false;
            _blip.GetAdjacentCells(_grid._squares);
            _blip.Update();


            int i = 0;

            for (int j = 0; j < _grid._rows; j++)
            {
                for (int k = 0; k < _grid._columns; k++)
                {
                    _grid._squares[i]._wasOccupied = false;
                    if (_grid._squares[i]._occupied == true)
                    {
                        _grid._squares[i]._wasOccupied = true;
                        _grid._squares[i]._occupied = false;
                    }
                    if ((_grid._squares[i]._x == _blip._x && _grid._squares[i]._y == _blip._y) && foundBlip == false)
                    {
                        _grid._squares[i]._occupied = true;
                        _grid._squares[i].OccupiedEvent(_blip);
                        foundBlip = true;

                    }
                    i++;
                }
            }

        }
    }
}
