//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Parent class for armor/shields/weapons
    /// </summary>
    public abstract class Equipment : Item
    {


        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="points"></param>
        public Equipment(string name, int points) : base(name, points) { }

    }
}
