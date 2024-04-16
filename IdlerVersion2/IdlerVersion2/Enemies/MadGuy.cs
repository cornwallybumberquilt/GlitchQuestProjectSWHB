//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class MadGuy : Enemy
    {
        public MadGuy(int size) : base(size)
        {
            _attack = 2;
            _defense = 1;
        }
    }
}
