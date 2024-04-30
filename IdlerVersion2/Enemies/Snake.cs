//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class Snake : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public Snake()
        {
            Name = "Snake";
            _attack = 1;
            _defense = -1;
            _monsterLevel = 1;
        }

    }
}
