//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Inventory;

namespace Glitchquest.Enemies
{
    /// <summary>
    /// Creates an instance of an enemy object
    /// </summary>
    internal class Enemy : Square
    {
        protected int _attack;
        protected int _defense;
        public bool _alive;
        protected int _monsterLevel;
        /// <summary>
        /// Default constructor
        /// </summary>
        public Enemy()
        {
            _alive = true;
        }
        /// <summary>
        /// Triggers if blip moves to this square
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {
            if (_removeSquareEvent == true)
            {
                return blip;
            }
            blip.RecentActions.Add($"{blip.Name} stumbled across {Name}!");
            int damage = _attack - blip.defense;
            blip.TakeDamage(damage);
            if (blip.attack > _defense)
            {
                _removeSquareEvent = true;
                blip.RecentActions.Add($"{blip.Name} took {damage} damage but defeated the {Name}!");
                blip = DropTable(blip, _monsterLevel);
                blip.RecentActions.Add($"The {Name} dropped some cool stuff.");
            }
            else
            {
                blip.RecentActions.Add($"{blip.Name} took {damage} damage but was too weak to harm the {Name}.");
            }
            return blip;
        }
        /// <summary>
        /// Chooses drops based off monster level
        /// </summary>
        /// <param name="blip"></param>
        /// <param name="monsterLevel"></param>
        /// <returns></returns>
        public Blip DropTable(Blip blip, int monsterLevel)
        {
            int random = Random(10);
            if (random >= 0 && random < 5)
            {
                blip.inventory.Add(new Shield("", monsterLevel));
            }
            else if (random >= 5 && random < 10)
            {
                blip.inventory.Add(new Weapon("", monsterLevel));
            }
            else
            {
                blip.inventory.Add(new Armor("", monsterLevel));
            }
            return blip;
        }
    }
}
