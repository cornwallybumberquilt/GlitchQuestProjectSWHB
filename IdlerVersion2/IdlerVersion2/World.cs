//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    internal class World
    {
        Grid _grid;
        public List<Square> _squares;
        public int _cellSize;
        public int _numRows;
        public int _numCols;
        Blip _blip;
        public World(int cellSize, int numRows, int numCols, Blip blip)
        {
            _blip = blip;
            _cellSize = cellSize;
            _numRows = numRows;
            _numCols = numCols;
            _squares = new List<Square>();
            _grid = new Grid(cellSize, numRows, numCols, _squares);
        }
        public void CreateLayout(Blip blip)
        {
            _squares.Add(blip);
            while (_squares.Count() < _numRows * _numCols)
            {
                _squares.Add(new Square(_cellSize));
            }
            _squares = _squares.OrderBy(x => Random.Shared.Next()).ToList();
        }

        public void PopulateWorld()
        {
            int i = 0;
            for (int x = 0; x < _numRows; x++)
            {

                for (int y = 0; y < _numCols; y++)
                {

                    _squares[i]._x = x;
                    _squares[i]._y = y;
                }
            }
        }

        public void AdvanceWorld()
        {
            (int x, int y) = _blip.Update();
            for (int i = 0; i < _squares.Count; i++)
            {
                for (int j = 0; j < _squares.Count; j++)
                {
                    _squares[j]._occupied = false;
                    _squares[j]._color = Color.Black;
                    if (_squares[j]._x == x && _squares[j]._y == y)
                    {
                        _squares[j]._occupied = true;
                        _squares[j]._color = Color.Red;
                    }
                }
            }

        }
    }
}
