//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest
{
    /// <summary>
    /// Creates an instance of the grid
    /// </summary>
    public class Grid
    {
        public int _cellSize;
        public int _rows;
        public int _columns;
        public List<Square> _squares;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="cellSize"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        public Grid(int cellSize, int rows, int columns)
        {
            _cellSize = cellSize;
            _rows = rows;
            _columns = columns;
            _squares = new List<Square>();
        }
    }
}
