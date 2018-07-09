using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Armor : Equipment
    {
        public Armor(EnumArmor enumName)
        {
            switch (enumName)
            {
                case EnumArmor.None:
                    name = "None";
                    break;
                default:
                    name = "None";
                    break;
            }
        }
    }
}
