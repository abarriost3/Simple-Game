using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Entity
    {
        public string name { get; set; }

        public int HP { get; set; }
        public int MAXHP { get; set; }

        public int MP { get; set; }
        public int MAXMP { get; set; }

        public int BASEATK { get; set; }
        public int ATK { get; set; }
        public int BASEDEF { get; set; }
        public int DEF { get; set; }

        public List<Skill> skills;





        

        /// <summary>
        /// Entity dies (rip)
        /// </summary>
        public virtual void dies()
        {
            
        }
    }
}
