using Glitchquest.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Team Mystic: Cecil, Clayton, Ash, Billy, Alex, Logan
namespace Glitchquest.Environments
{
    internal class Chest:Square
    {


        public Chest() 
        {
            Name = "Chest";
        }
        /// <summary>
        /// Event triggered when blip moves onto this tile
        /// </summary>
        /// <param name="blip"></param>
        /// <returns></returns>
        public override Blip OccupiedEvent(Blip blip)
        {
            blip.RecentActions.Add($"{blip.Name} found a chest!");
            Random random = new Random();
            int r = random.Next( 0, 5 );
            if( r == 0 )
            { 
                blip.inventory.Add(new Shield("", blip.level +1)); 
            }
            else if( r == 1)
            { 
                blip.inventory.Add(new Weapon("", blip.level + 1)); 
            }
            else if( r == 2)
            { 
                blip.inventory.Add(new Armor("", blip.level + 1)); 
            }
            else if(r == 3)
                { 
                blip.inventory.Add(new Food("Secret Food",6)); 
            }
            else 
            { 
                blip.inventory.Add(new Potion("Mysterious Potion", 1)); 
            }

            blip.RecentActions.Add($"{blip.Name} found a chest!");
            return blip;
        }
    }
}
