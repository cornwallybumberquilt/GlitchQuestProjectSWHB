//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class Hungry : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Hungry()
        {
            Name = "Hungry";
            _attack = 2;
            _defense = 0;
            _monsterLevel = 2;
        }

    }
}
