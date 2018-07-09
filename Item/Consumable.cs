using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Consumable : Item
    {
        public Consumable(EnumConsumable enumName)
        {

            switch (enumName)
            {
                case EnumConsumable.None:
                    name = "None";
                    break;
                default:
                    name = "None";
                    break;
            }
        }
    }
}
