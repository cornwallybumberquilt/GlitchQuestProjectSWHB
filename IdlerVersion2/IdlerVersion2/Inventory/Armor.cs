//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Armor : Equipment
    {
        public Armor(string name, int defense) : base(name,defense)
        {
            
        }
        public Armor(Item item) : base(item._name, item._points) { }

        public void Equip()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Armor: {_name}  -   Defense: {_points}";
        }
    }
}
