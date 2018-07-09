using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Ring : Equipment
    {
        public Ring(EnumRing enumName)
        {

            switch (enumName)
            {
                case EnumRing.None:
                    name = "None";
                    break;
                default:
                    name = "None";
                    break;
            }
        }
    }
}
