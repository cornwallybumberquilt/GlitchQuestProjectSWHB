//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Armor : Equipment
    {
        int _defense;
        public Armor(string name, int defense) : base(name)
        {
            _defense = defense;
        }

        public void Equip()
        {
            throw new NotImplementedException();
        }
    }
}
