namespace Glitchquest.Enemies
{
    /// <summary>
    /// Model for an AngryCircle Enemy
    /// </summary>
    internal class EyeballBro : Enemy
    {
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="size"></param>
        public EyeballBro()
        {
            Name = "Eyeball Bro";
            _attack = 4;
            _defense = 2;
            _monsterLevel = 4;
        }

    }
}
