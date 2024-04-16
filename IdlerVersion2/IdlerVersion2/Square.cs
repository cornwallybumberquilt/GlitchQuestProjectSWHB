//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2
{
    /// <summary>
    /// Creates an instance of a square to display on the grid
    /// </summary>
    public class Square : Panel
    {
        public int _size;
        public int _x;
        public int _y;
        public Color _color;
        public bool _occupied;
        public bool _wasOccupied;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="size"></param>
        public Square(int size)
        {
            Name = "";
            _size = size;
            _occupied = false;
            _wasOccupied = false;
            _color = Color.Black;
        }

        public Blip OccupiedEvent(Blip blip)
        {
            blip.RecentActions.Add($"{blip.Name} traveled into an empty field!");
            return blip;
        }

    }

}
