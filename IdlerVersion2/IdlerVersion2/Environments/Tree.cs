//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Environments
{
    /// <summary>
    /// Creates an instance of a tree environment object
    /// </summary>
    internal class Tree : Environment
    {
        public Tree(int size) : base(size) { }

        public Blip OccupiedEvent(Blip blip, string direction)
        {

            blip.RecentActions.Add($"{blip.Name} traveled {direction} into an empty field!");
            return blip;
        }
    }
}
