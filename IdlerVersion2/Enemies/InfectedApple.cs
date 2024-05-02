namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for a Random Scribbles enemy
    /// </summary>
    internal class InfectedApple : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public InfectedApple()
        {
            Name = "Infected Apple";
            _attack = 3;
            _defense = 1;
            _monsterLevel = 3;
        }
    }
}
