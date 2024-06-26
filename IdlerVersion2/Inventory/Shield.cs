﻿//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for a shield object
    /// </summary>
    public class Shield : Equipment
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Shield(string name = "", int index = 0) : base(name, index)
        {
            if (index == 0)
            {
                _name = "Bad Shield";
                _points = 0;

            }
            else if (index == 1)
            {
                _name = "Meh Shield";
                _points = 1;
            }
            else if (index == 2)
            {
                _name = "Okay Shield";
                _points = 2;
            }
            else if (index == 3)
            {
                _name = "Good Shield";
                _points = 3;
            }
            else if (index == 4)
            {
                _name = "Great Shield";
                _points = 4;
            }
            else if (index == 5)
            {
                _name = "Super Shield";
                _points = 5;
            }
            else if (index == 6)
            {
                _name = "Debugged Shield";
                _points = 99;
            }
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="item"></param>
        public Shield(Item item) : base(item._name, item._points) { }

        /// <summary>
        /// Returns string of name and defense points
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Shield: {_name}  -   Defense: {_points}";
        }
    }
}
