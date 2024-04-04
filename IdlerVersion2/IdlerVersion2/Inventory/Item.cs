//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    abstract class Item
    {
        protected string _name;

        public Item(string name)
        {
            _name = name;
        }

        public void ItemEffect() { }


    }

}
