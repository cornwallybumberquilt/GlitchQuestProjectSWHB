namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for a Random Scribbles enemy
    /// </summary>
    internal class RandomScribbles : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public RandomScribbles()
        {
            Name = "Random Scribbles";
            _attack = 3;
            _defense = 1;
            _monsterLevel = 3;
        }
    }
}
