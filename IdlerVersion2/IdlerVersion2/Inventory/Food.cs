//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace IdlerVersion2.Inventory
{
    internal class Food : Item
    {
        public Food(string name, int foodpoints) : base(name,foodpoints)
        {
        }
        public void ItemEffect()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Food: {_name}  -   Calories: {_points}";
        }
    }
}
