//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Weapon : Equipment
    {
        public Weapon(string name, int attack) : base(name,attack)
        {
        }

        public Weapon(Item item): base(item._name, item._points) { }

        public void Equip()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Weapon: {_name}  -   Attack: {_points}";
        }
    }
}
