//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Enemies
{
    internal class Enemy : Square
    {
        protected int _attack;
        protected int _defense;
        public Enemy(int size) : base(size)
        {

        }

        public void HandleCollision()
        {
            throw new NotImplementedException();
        }
    }
}
