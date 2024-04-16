//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal abstract class Equipment : Item
    {
        public Equipment(string name,int points) : base(name, points) { }

        public void Equip() { }
    }
}
