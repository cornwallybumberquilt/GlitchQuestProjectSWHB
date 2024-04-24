namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for a Bad Grade enemy
    /// </summary>
    internal class BadGrade : Enemy
    {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="size"></param>
        public BadGrade()
        {
            Name = "Bad Grade";
            _attack = 6;
            _defense = 4;
            _monsterLevel = 6;
        }

    }
}
