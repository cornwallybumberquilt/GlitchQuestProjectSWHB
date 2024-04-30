//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class MadGuy : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MadGuy()
        {
            Name = "Mad Guy";
            _attack = 2;
            _defense = 0;
            _monsterLevel = 2;
        }

    }
}
