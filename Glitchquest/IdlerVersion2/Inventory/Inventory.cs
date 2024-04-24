//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Inventory
{
    /// <summary>
    /// Class for modeling an inventory object
    /// </summary>
    public class Inventory
    {
        public List<Item> items;
        public int foodCount;
        public int weaponCount;
        public int armorCount;
        public int shieldCount;
        public int potionCount;
        /// <summary>
        /// Default constructor for the inventory
        /// </summary>
        public Inventory()
        {
            items = new List<Item>();
            foodCount = 0;
            weaponCount = 0;
            armorCount = 0;
            shieldCount = 0;
            potionCount = 0;
        }
        /// <summary>
        /// Adds item to inventory
        /// </summary>
        /// <param name="item"></param>
        public void Add(Item item)
        {
            if (item is Food) { foodCount += 1; }
            else if (item is Weapon) { weaponCount += 1; }
            else if (item is Armor) { armorCount += 1; }
            else if (item is Shield) { shieldCount += 1; }
            else if (item is Potion) { potionCount += 1; }
            items.Add(item);
        }
        /// <summary>
        /// Removes item from inventory
        /// </summary>
        /// <param name="item"></param>
        public void Remove(Item item)
        {
            if (item is Food) { foodCount -= 1; }
            else if (item is Weapon) { weaponCount -= 1; }
            else if (item is Armor) { armorCount -= 1; }
            else if (item is Shield) { shieldCount -= 1; }
            else if (item is Potion) { potionCount -= 1; }
            items.Remove(item);
        }
    }
}
