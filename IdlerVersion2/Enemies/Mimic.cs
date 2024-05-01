namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for a Mimic enemy
    /// </summary>
    internal class Mimic : Enemy
    {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="size"></param>
        public Mimic()
        {
            Name = "Mimic";
            _attack = 10;
            _defense = 4;
            _monsterLevel = 6;
        }

    }
}
