//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Environments
{
    /// <summary>
    /// Creates an instance of a mountain environment object
    /// </summary>
    [Serializable]
    public class Mountain : Square
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public Mountain() 
        {
            Name = "Mountian";
        }

        /// <summary>
        /// Event triggered when blip moves onto this tile
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {

            blip.RecentActions.Add($"{blip.Name} was turned back by a mountain!");
            return blip;
        }
    }
}
