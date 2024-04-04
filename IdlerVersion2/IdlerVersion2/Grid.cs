//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    internal class Grid
    {
        int _cellSize;
        int _rows;
        int _columns;
        List<Square> _squares;

        public Grid(int cellSize, int rows, int columns, List<Square> squares)
        {
            _cellSize = cellSize;
            _rows = rows;
            _columns = columns;
            _squares = squares;
        }
    }
}
