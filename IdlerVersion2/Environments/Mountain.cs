//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Environments
{
    /// <summary>
    /// Creates an instance of a mountain environment object
    /// </summary>
    internal class Mountain : Square
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public Mountain() { }

        /// <summary>
        /// Event triggered when blip moves onto this tile
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {

            return blip;
        }
    }
}
