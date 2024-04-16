//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Potion : Item
    {
        int _potionEffect;
        public Potion(string name, int points) : base(name,points)
        {
            
        }
        public Potion(Item item) : base(item._name, item._points) { }

        public override string ToString()
        {
            return $"Potion: {_name}";
        }
    }
}
