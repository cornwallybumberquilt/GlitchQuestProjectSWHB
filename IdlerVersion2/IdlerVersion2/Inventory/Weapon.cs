//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Weapon : Equipment
    {
        int _attack;
        public Weapon(string name, int attack) : base(name)
        {
            _attack = attack;
        }

        public void Equip()
        {
            throw new NotImplementedException();
        }
    }
}
