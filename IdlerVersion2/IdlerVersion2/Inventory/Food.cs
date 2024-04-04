//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Food : Item
    {
        int _foodPoints;
        public Food(string name, int foodpoints) : base(name)
        {
            _foodPoints = foodpoints;
        }
        public void ItemEffect()
        {
            throw new NotImplementedException();
        }
    }
}
