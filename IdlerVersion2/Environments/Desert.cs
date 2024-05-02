//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Environments
{
    /// <summary>
    /// Creates an instance of a desert environment object
    /// </summary>
    internal class Desert : Square
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public Desert() 
        {
            Name = "Desert";
        }
        /// <summary>
        /// Event triggered when blip moves onto this tile
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {
            blip.RecentActions.Add($"{blip.Name} traveled into a really hot desert and took 10 damage");
            blip.TakeDamage(4, true);
            return blip;
        }
    }
}

