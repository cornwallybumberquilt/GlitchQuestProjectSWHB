//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for a weapon object
    /// </summary>
    internal class Weapon : Equipment
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Weapon(string name = "", int index = 0) : base(name, index)
        {
            if (index == 0)
            {
                _name = "Bad Sword";
                _points = 0;

            }
            else if (index == 1)
            {
                _name = "Meh Sword";
                _points = 1;
            }
            else if (index == 2)
            {
                _name = "Okay Sword";
                _points = 2;
            }
            else if (index == 3)
            {
                _name = "Good Sword";
                _points = 3;
            }
            else if (index == 4)
            {
                _name = "Great Sword";
                _points = 4;
            }
            else if (index == 5)
            {
                _name = "Super Sword";
                _points = 5;
            }
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="item"></param>
        public Weapon(Item item) : base(item._name, item._points) { }

        /// <summary>
        /// Returns string of name and attack
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Weapon: {_name}  -   Attack: {_points}";
        }
    }
}
