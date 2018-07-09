using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Enemy : Entity
    {

        public Enemy(String name)
        {
            //Setting its values randomly
            ATK = GameEngine.rng.Next(5, 15);
            BASEATK = ATK;
            DEF = GameEngine.rng.Next(5, 15);
            BASEDEF = ATK;

            HP = GameEngine.rng.Next(20, 180);
            MAXHP = HP;

            MP = GameEngine.rng.Next(0, 10);
            MAXMP = MP;

            this.name = name;

            skills = new List<Skill>();
        }

        override public void dies()
        {
            GameEngine.enemy = new Enemy("Zombie");

            GameEngine.defeatedEnemies++;
        }
    }
}
