namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of a Strange Horse Enemy
    /// </summary>
    internal class StrangeHorse : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public StrangeHorse()
        {
            Name = "Strange Horse";
            _attack = 5;
            _defense = 3;
            _monsterLevel = 5;
        }
    }
}
