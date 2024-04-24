//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for a food object
    /// </summary>
    internal class Food : Item
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="foodpoints"></param>
        public Food(string name = "", int index = 0) : base(name, index)
        {
            if (index == 0)
            {
                _name = "Rotten Fishstick";
                _points = 1;

            }
            else if (index == 1)
            {
                _name = "Bowl of Cereal";
                _points = 10;

            }
            else if (index == 2)
            {
                _name = "Fried Shrimp";
                _points = 20;
            }
            else if (index == 3)
            {
                _name = "Imaginary Peanut Butter";
                _points = 30;
            }
            else if (index == 4)
            {
                _name = "Gourmet Chicken Nugget";
                _points = 40;
            }
            else if (index == 5)
            {
                _name = "Caloric Ice Cube";
                _points = 50;
            }
            else if (index == 6)
            {
                _name = "Onion";
                _points = 60;
            }
        }
        /// <summary>
        /// ToString override to better display food object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Food: {_name}  -   Calories: {_points}";
        }
    }
}
