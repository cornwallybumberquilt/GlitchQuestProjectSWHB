//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class Snake : Enemy
    {
        public Snake(int size) : base(size)
        {
            _attack = 1;
            _defense = 1;
        }
    }
}
