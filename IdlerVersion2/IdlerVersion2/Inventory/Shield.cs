using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdlerVersion2.Inventory
{
    internal class Shield: Equipment
    {
        public Shield(string name,int defense) : base(name,defense) 
        { 
        }
        public Shield(Item item) : base(item._name, item._points) { }

        public override string ToString()
        {
            return $"Shield: {_name}  -   Defense: {_points}";
        }
    }
}
