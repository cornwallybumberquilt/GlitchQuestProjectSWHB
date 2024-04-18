//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using IdlerVersion2.Inventory;
using NAudio.Wave;
using System.Windows.Forms;


namespace IdlerVersion2
{
    /// <summary>
    /// Creates an instance of the blip object
    /// </summary>
    public class Blip : Square
    {
        int actionCooldown;
        int currentActionCooldown;
        public List<(int, int)> validMoves;
        public List<string> RecentActions;
        public Inventory.Inventory inventory;
        Armor armor;
        Weapon weapon;
        Shield shield;
        int maxHunger;
        int hunger;
        int maxTired;
        int tired;
        int happiness;
        Bitmap icon;
        public int LastAction;
        
        

        

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="actionCooldownSeconds"></param>
        public Blip(int size, int actionCooldownSeconds) : base(size)
        {
            Name = "Blip";
            RecentActions = new List<string>();
            this.actionCooldown = actionCooldownSeconds;
            this.currentActionCooldown = actionCooldown;
            this.validMoves = new List<(int, int)>();
            inventory = new Inventory.Inventory();
            this.BackColor = Color.Black;
            _x = 0;
            _y = 0;
            inventory.Add(new Food("Apple", 10));
            shield = new Shield("Bad Shield", 0);
            armor = new Armor("Bad Armor", 0);
            weapon = new Weapon("Bad Sword", 0);
            inventory.Add(new Potion("Mysterious Drink", 0));
            maxTired = 20;
            maxHunger = 100;
            hunger = 80;
            tired = 20;
        }
        /// <summary>
        /// Updates blips position on the grid
        /// </summary>
        public void Update()
        {
            int actionChoice = 0;
            string message = "";
            if (currentActionCooldown <= actionCooldown)
            {
                Random r = new Random();
                bool canEquip = false;

                for (int i = 0; i < inventory.items.Count; i++)
                {
                    if (inventory.items[i] is Equipment)
                    {
                        canEquip = true;
                    }
                }


                actionChoice = r.Next(0, 4);
                if (actionChoice == 0 && inventory.foodCount > 0) { Eat(); }
                else if (actionChoice == 1 && inventory.potionCount > 0) { DrinkPotion(); }
                else if (actionChoice == 2) { Sleep(); }
                else if (actionChoice == 3 && canEquip == true) { Equip(); }
                else
                {
                    int moveChoice = (validMoves.Count() - 1);
                    moveChoice = r.Next(moveChoice);
                    
                    _x = validMoves[moveChoice].Item1;
                    _y = validMoves[moveChoice].Item2;
                }
                
                hunger -= 1;
                tired -= 1;
            }
            int hungerPercent = (hunger * 100) / maxHunger;
            int tiredPercent = (tired * 100) / maxTired;
            if (hungerPercent > tiredPercent) 
            { 
            happiness = hungerPercent;
            }
            else 
            { 
            happiness = tiredPercent;
            }
            currentActionCooldown -= (1 * happiness) / 100;
            LastAction = actionChoice;
            
        }
        /// <summary>
        /// Updates list of valid moves for Blip
        /// </summary>
        /// <param name="squares"></param>
        public void GetAdjacentCells(List<Square> squares)
        {
            int movementModifier = 1;

            List<(int, int)> adjacentCells = new List<(int, int)>();
            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares.Count; j++)
                {
                    if ((squares[j]._x >= this._x - movementModifier && squares[j]._x <= this._x + movementModifier) && (squares[j]._y >= this._y - movementModifier && squares[j]._y <= this._y + movementModifier))
                    {
                        if (adjacentCells.Contains((squares[j]._x, squares[j]._y)) || (squares[j]._x, squares[j]._y) == (_x, _y)) { continue; }
                        adjacentCells.Add((squares[j]._x, squares[j]._y));
                    }
                }
            }
            validMoves = adjacentCells;
            
        }
        public string Eat() 
        {
            string message = "";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Food)
                {

                    hunger += inventory.items[i]._points;
                    message = $"{Name} devoured the {inventory.items[i]._name} and restored {inventory.items[i]._points} of hunger!";
                    inventory.Remove(inventory.items[i]);
                    
                    break;
                }
            }
            return message;
        }
        public void Sleep() 
        {
            tired = maxTired;
            RecentActions.Add($"{Name} took a nap and is now fully rested!");
        }
        public void DrinkPotion() 
        {
            string message = "";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Potion)
                {
                    message = $"{Name} drank the {inventory.items[i]._name} and nothing happened.";
                    inventory.Remove(inventory.items[i]);
                    break;
                }
            }
            RecentActions.Add(message);
        }
        public void Equip() 
        {
            string message = "";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Equipment)
                {
                    if (inventory.items[i] is Weapon)
                    {
                        if (inventory.items[i]._points > weapon._points) 
                        {
                            message = $"{Name} equipped the {inventory.items[i]._name}!";
                            weapon = new Weapon(inventory.items[i]);
                            inventory.Remove(inventory.items[i]);
                            break;

                        }
                    }
                    else if (inventory.items[i] is Armor) 
                    {
                        if (inventory.items[i]._points > weapon._points)
                        {
                            message = $"{Name} equipped the {inventory.items[i]._name}!";
                            armor = new Armor(inventory.items[i]);
                            inventory.Remove(inventory.items[i]);
                            break;

                        }
                    }
                    else 
                    {
                        if (inventory.items[i]._points > weapon._points)
                        {
                            message = $"{Name} equipped the {inventory.items[i]._name}!";
                            shield = new Shield(inventory.items[i]);
                            inventory.Remove(inventory.items[i]);
                            break;

                        }
                    }
                }
            }
            RecentActions.Add(message);
        }       
    }
}
