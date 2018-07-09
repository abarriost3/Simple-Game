using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Place
    {
        public String name { get; set; }

        public List<Item> lootableItems { get; set; }

        public List<Enemy> probableEnemies { get; set; }

        public List<Enemy> bosses { get; set; }

        public Place()
        {

        }
    }
}
