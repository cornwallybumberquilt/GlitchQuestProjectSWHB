//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Model for item objects
    /// </summary>
    [Serializable]
    public class Item
    {
        public string _name;
        public int _points;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        public Item(string name, int points)
        {
            _name = name;
            _points = points;

        }


    }

}
