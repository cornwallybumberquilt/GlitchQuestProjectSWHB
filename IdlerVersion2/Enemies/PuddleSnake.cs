namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of a Strange Horse Enemy
    /// </summary>
    internal class PuddleSnake : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public PuddleSnake()
        {
            Name = "Puddle Snake";
            _attack = 5;
            _defense = 3;
            _monsterLevel = 5;
        }
    }
}
