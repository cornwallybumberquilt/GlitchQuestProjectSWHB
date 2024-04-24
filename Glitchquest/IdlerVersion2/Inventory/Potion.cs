//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for a potion object
    /// </summary>
    internal class Potion : Item
    {
        int _potionEffect;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Potion(string name, int points) : base(name, points)
        {

        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="item"></param>
        public Potion(Item item) : base(item._name, item._points) { }

        public override string ToString()
        {
            return $"Potion: {_name}";
        }
    }
}
