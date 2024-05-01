namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for a Random Scribbles enemy
    /// </summary>
    internal class CursedSword : Enemy
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="size"></param>
        public CursedSword()
        {
            Name = "Cursed Sword";
            _attack = 3;
            _defense = 1;
            _monsterLevel = 3;
        }
    }
}
