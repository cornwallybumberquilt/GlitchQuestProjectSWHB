//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Inventory;

namespace Glitchquest
{
    /// <summary>
    /// Creates an instance of a square to display on the grid
    /// </summary>
    public class Square
    {
        public string Name;
        public int _size;
        public int _x;
        public int _y;
        public bool _occupied;
        public bool _wasOccupied;
        public bool _removeSquareEvent;
        public bool _ravaged;
        public bool _beingRavaged;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="size"></param>
        public Square()
        {
            Name = "";
            _size = 100;
            _occupied = false;
            _wasOccupied = false;
            _removeSquareEvent = false;
        }
        /// <summary>
        /// Adds travel string to blips recent actions list
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public virtual Blip OccupiedEvent(Blip blip)
        {
            return blip;
        }

        /// <summary>
        /// Returns random number up to given number inclusive
        /// </summary>
        /// <param name="upperLimit"></param>
        /// <returns></returns>
        public int Random(int upperLimit)
        {
            Random r = new Random();
            return r.Next(upperLimit + 1);
        }
        
    }

}
