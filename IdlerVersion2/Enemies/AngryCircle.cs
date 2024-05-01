namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for an AngryCircle Enemy
    /// </summary>
    internal class AngryCircle : Enemy
    {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="size"></param>
        public AngryCircle()
        {
            Name = "AngryCircle";
            _attack = 4;
            _defense = 2;
            _monsterLevel = 4;
        }

    }
}
