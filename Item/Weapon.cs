using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Weapon : Equipment
    {
        public Weapon(EnumWeapon enumName)
        {

            switch (enumName)
            {
                case EnumWeapon.None:
                    name = "None";
                    break;
                default:
                    name = "None";
                    break;
            }
        }
    }
}
