﻿//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
using Glitchquest.Environments;
using Glitchquest.Inventory;

namespace Glitchquest
{
    /// <summary>
    /// Creates an instance of the blip object
    /// </summary>
    [Serializable]
    public class Blip
    {
        public string Name;
        public int _x;
        public int _y;
        public double actionCooldown;
        public double currentActionCooldown;
        public List<(int, int)> validMoves;
        public List<string> RecentActions;
        public Inventory.Inventory inventory;
        public List<Armor> armors;
        public Weapon weapon;
        public Shield shield;
        public Armor armor;
        public int maxHunger;
        public int hunger;
        public int maxTired;
        public int tired;
        public double happiness;
        public int maxHealth;
        public int health;
        public int defense;
        public int attack;
        public int deathCounter;
        public int LastAction;
        public int movementModifier;
        public int desertModifier;
        public int Teleporter = 0;
        public int fear;
        public int level;
        public int currentExp;
        public int expToLevel;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="actionCooldownSeconds"></param>
        public Blip()
        {
            Name = "Blip";
            RecentActions = new List<string>();
            this.actionCooldown = 4;
            this.currentActionCooldown = actionCooldown;
            this.validMoves = new List<(int, int)>();
            inventory = new Inventory.Inventory();
            _x = 0;
            _y = 0;
            inventory.Add(new Food("Apple", 10));
            shield = new Shield("", 0);
            armors = new List<Armor>();
            weapon = new Weapon("", 0);
            armor = new Armor("", 0);
            inventory.Add(new Potion("Mysterious Drink", 0));
            maxTired = 20;
            maxHunger = 100;
            hunger = 80;
            tired = maxTired;
            maxHealth = 20;
            health = maxHealth;
            deathCounter = 0;
            LastAction = 0;
            movementModifier = 1;
            desertModifier = 1;
            fear = 0;
            currentExp = 0;
            expToLevel = 20;
            level = 1;
        }
        /// <summary>
        /// Updates blips position on the grid
        /// </summary>
        public bool Update()
        {
            bool performedAction = false;
            string message = "";
            if (currentActionCooldown >= actionCooldown + fear)
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


                int actionChoice = r.Next(0, 4);
                LastAction = actionChoice;
                if (actionChoice == 0 && inventory.foodCount > 0 && 20 >= (100 * hunger) / maxHunger) { Eat(); }
                else if (actionChoice == 1 && inventory.potionCount > 0) { DrinkPotion(); }
                else if (actionChoice == 2 && 20 >= (100 * tired) / maxTired) { Sleep(); }
                else if (actionChoice == 3 && canEquip == true) { Equip(); }
                else
                {
                    performedAction = Move();
                }
                if (hunger > 0)
                {
                    hunger -= 1;
                }
                if (tired > 0)
                {
                    tired -= 1;
                }
                if (hunger == 0)
                {
                    TakeDamage(maxHealth);
                }
                currentActionCooldown = 0;
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
            if (happiness < 75) { currentActionCooldown += 3; }
            else if(happiness < 50) { currentActionCooldown += 2; }
            else if (happiness < 25) { currentActionCooldown += 1; }
            else { currentActionCooldown += 4; }
            if (currentActionCooldown > actionCooldown) {currentActionCooldown = actionCooldown;}
            return performedAction;
        }
        /// <summary>
        /// Updates list of valid moves for Blip
        /// </summary>
        /// <param name="squares"></param>
        public void GetAdjacentCells(List<Square> squares)
        {
            int adjustedMovementModifier = movementModifier - fear;
            List<(int, int)> adjacentCells = new List<(int, int)>();
            for (int i = 0; i < squares.Count; i++)
            {
                for (int j = 0; j < squares.Count; j++)
                {
                    if (Teleporter == 2)
                    {
                        
                            adjacentCells.Add((squares[j]._x, squares[j]._y));
                        
                    }
                    if ((squares[j]._x >= this._x - adjustedMovementModifier && squares[j]._x <= this._x + adjustedMovementModifier) && (squares[j]._y >= this._y - adjustedMovementModifier && squares[j]._y <= this._y + adjustedMovementModifier))
                    {
                        if (adjacentCells.Contains((squares[j]._x, squares[j]._y)) || (squares[j]._x, squares[j]._y) == (_x, _y)) { continue; }
                        if (Teleporter == 0)
                        {
                            if (squares[j] is Mountain) { continue; }
                        }
                        if (squares[j]._ravaged == true || squares[j]._beingRavaged == true) { continue; }
                        adjacentCells.Add((squares[j]._x, squares[j]._y));
                    }
                }
            }
            validMoves = adjacentCells;
        }
        /// <summary>
        /// Moves blip on the grid
        /// </summary>
        /// <returns></returns>
        public bool Move()
        {
            if (validMoves.Count() == 0)
            {
                return false;
            }
            Random r = new Random();
            int moveChoice = (validMoves.Count());
            moveChoice = r.Next(moveChoice);

            _x = validMoves[moveChoice].Item1;
            _y = validMoves[moveChoice].Item2;
            return true;
        }
        /// <summary>
        /// Method for blip to eat food from inventory
        /// </summary>
        public void Eat()
        {
            string message = "Food?";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Food)
                {

                    hunger += inventory.items[i]._points;
                    if (hunger > 100) { hunger = 100; }
                    message = $"{Name} devoured the {inventory.items[i]._name} and restored {inventory.items[i]._points} of hunger!";
                    inventory.Remove(inventory.items[i]);

                    break;
                }
            }
            RecentActions.Add(message);
        }
        /// <summary>
        /// Method for making blip sleep to restored tired meter
        /// </summary>
        public void Sleep()
        {
            tired = maxTired;
            RecentActions.Add($"{Name} took a nap and is now fully rested!");
        }
        /// <summary>
        /// Inflicts damage on the blip
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage, bool fromDesert = false)
        {
            if (fromDesert)
            {
                damage = damage * desertModifier;
                if (health - damage > maxHealth)
                {
                    health = maxHealth;
                }
            }
            if (damage < 0)
            {
                damage = 0;
            }
            if (health - damage > 0)
            {
                health -= damage;
            }
            else
            {
                health = 0;
            }
        }

        /// <summary>
        /// Method for making blip drink potions
        /// </summary>
        public void DrinkPotion()
        {
            string message = "potion?";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Potion)
                {
                    Random r = new Random();
                    int rand = r.Next(0, 4);
                    if (rand == 0)
                    {
                        message = $"{Name} drank the {inventory.items[i]._name} and nothing happened.";
                    }
                    else if (rand == 1) 
                    {
                        health = maxHealth;
                        message = $"{Name} drank the {inventory.items[i]._name} and was fully healed!";
                    }
                    else if (rand == 2)
                    {
                        TakeDamage(r.Next(maxHealth));
                        message = $"{Name} drank the {inventory.items[i]._name} and took damage!";
                    }
                    else
                    {
                        _x = 0;
                        _y = 0;
                        message = $"{Name} drank the {inventory.items[i]._name} and was teleported away!.";
                    }
                    inventory.Remove(inventory.items[i]);
                    break;
                }
            }
            RecentActions.Add(message);
        }
        /// <summary>
        /// Equips armor/shields/weapons to blip
        /// </summary>
        public void Equip()
        {
            string message = "";
            for (int i = 0; i < inventory.items.Count; i++)
            {
                if (inventory.items[i] is Equipment)
                {
                    if (inventory.items[i]._points <= level || inventory.items[i]._points == 99)
                    {
                        if (inventory.items[i] is Weapon)
                        {
                            try
                            {
                                if (inventory.items[i]._points > weapon._points)
                                {
                                    message = $"{Name} equipped the {inventory.items[i]._name}!";
                                    attack -= weapon._points;
                                    weapon = new Weapon(inventory.items[i]);
                                    attack += weapon._points;
                                    inventory.Remove(inventory.items[i]);
                                    break;

                                }
                            }
                            catch (NullReferenceException)
                            {
                                message = $"{Name} equipped the {inventory.items[i]._name}!";
                                weapon = new Weapon(inventory.items[i]);
                                attack += weapon._points;
                                inventory.Remove(inventory.items[i]);
                                break;

                            }
                        }
                        else if (inventory.items[i] is Armor)
                        {
                            try
                            {
                                message = $"{Name} equipped the {inventory.items[i]._name}!";
                                armor = new Armor(inventory.items[i]);
                                if (armors.Contains(armor))
                                    { break; }
                                else if (armor._points == 1)
                                {
                                    movementModifier += 1;
                                }
                                else if (armor._points == 2)
                                {
                                    desertModifier = 0;
                                }
                                else if (armor._points == 3)
                                {
                                    Teleporter = 1;
                                }
                                else if (armor._points == 4)
                                {
                                    movementModifier += 2;
                                }
                                else if (armor._points == 5)
                                {
                                    desertModifier = -1;
                                }
                                else if (armor._points == 6)
                                {
                                    Teleporter = 2;
                                }
                                inventory.Remove(inventory.items[i]);
                                armors.Add(armor);
                                break;

                            }
                            catch (Exception)
                            {
                                
                                break;
                            }
                        }
                        else
                        {
                            try
                            {
                                if (inventory.items[i]._points > shield._points)
                                {
                                    message = $"{Name} equipped the {inventory.items[i]._name}!";
                                    defense -= shield._points;
                                    shield = new Shield(inventory.items[i]);
                                    defense += shield._points;
                                    inventory.Remove(inventory.items[i]);
                                    break;
                                }

                            }
                            catch (NullReferenceException)
                            {
                                message = $"{Name} equipped the {inventory.items[i]._name}!";
                                shield = new Shield(inventory.items[i]);
                                defense += shield._points;
                                inventory.Remove(inventory.items[i]);
                                break;
                            }
                        }
                    }
                }
            }
            if (message != "")
            {
                RecentActions.Add(message);
            }
        }
        /// <summary>
        /// Method for assigning new exp to blip
        /// </summary>
        /// <param name="exp"></param>
        public void GainExp(int exp) 
        { 
        if ( exp + currentExp > expToLevel ) 
            {
                exp = expToLevel;
            }
            else 
            {
                currentExp += exp;
            }
        if ( currentExp >=expToLevel && weapon._points >= level && shield._points >= level) 
            {
                level += 1;
                currentExp = 0;
                RecentActions.Add($"{Name} is now level {level}!");
                if ( actionCooldown > 1) 
                { 
                actionCooldown -= 1;
                }
            }
        }

    }
}
