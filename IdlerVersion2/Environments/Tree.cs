//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Inventory;

namespace Glitchquest.Environments
{
    /// <summary>
    /// Creates an instance of a tree environment object
    /// </summary>
    [Serializable]
    public class Tree : Square
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public Tree() 
        {
            Name = "Tree";
        }

        /// <summary>
        /// Event to be triggered when Blip moves to this cell
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {
            if (_removeSquareEvent == true)
            {
                return blip;
            }
            blip.RecentActions.Add($"{blip.Name} traveled into a forest and found food!");
            blip.inventory.Add(new Food("", Random(6)));
            _removeSquareEvent = true;
            return blip;
        }
    }
}
