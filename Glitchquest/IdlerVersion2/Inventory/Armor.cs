//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for an Armor object
    /// </summary>
    internal class Armor : Equipment
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Armor(string name = "", int index = 0) : base(name, index)
        {
            if (index == 0)
            {
                _name = "Bad Armor";
                _points = 0;

            }
            else if (index == 1)
            {
                _name = "Aerodynamic Parachute";
                _points = 1;

            }
            else if (index == 2)
            {
                _name = "Portable Air Conditioner";
                _points = 2;
            }
            else if (index == 3)
            {
                _name = "Mountain Climbing Documentary.mp4";
                _points = 3;
            }
            else if (index == 4)
            {
                _name = "Mystical 20MPH Tailwind";
                _points = 4;
            }
            else if (index == 5)
            {
                _name = "Solar Powered Robo Doctor";
                _points = 5;
            }
            else if (index == 6)
            {
                _name = "Mountain Magnet";
                _points = 6;
            }
        }
        public Armor(Item item) : base(item._name, item._points) { }

        /// <summary>
        /// Returns Armor name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Armor: {_name} ";
        }

    }
}
