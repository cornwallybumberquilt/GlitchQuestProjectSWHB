//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    internal class Square : Panel
    {
        public int _size;
        public int _x;
        public int _y;
        public Color _color;
        public bool _occupied;

        public Square(int size)
        {
            _size = size;
            _occupied = false;
            _color = Color.Black;
        }

        public virtual (int, int) Update()
        {
            return (_x, _y);
        }
    }

}
