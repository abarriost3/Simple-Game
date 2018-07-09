using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class Player : Entity
    {

        public int level { get; set; }

        public int exp { get; set; }

        public int money { get; set; }

        public Weapon rightHand { get; set; }
        public Weapon leftHand { get; set; }

        public Armor helmet { get; set; }
        public Armor necklace { get; set; }
        public Armor top { get; set; }
        public Armor guantlets { get; set; }
        public Armor bottom { get; set; }
        public Armor shoes { get; set; }

        public Ring ring1 { get; set; }
        public Ring ring2 { get; set; }


        public Player(String name)
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

            level = 1;
            exp = 0;
            money = 0;

            //Initializing Equipment
            rightHand = new Weapon(EnumWeapon.None);
            leftHand = new Weapon(EnumWeapon.None);

            helmet = new Armor(EnumArmor.None);
            necklace = new Armor(EnumArmor.None);
            top = new Armor(EnumArmor.None);
            guantlets = new Armor(EnumArmor.None);
            bottom = new Armor(EnumArmor.None);
            shoes = new Armor(EnumArmor.None);

            ring1 = new Ring(EnumRing.None);
            ring2 = new Ring(EnumRing.None);

            skills = new List<Skill>();
        }

        override public void dies()
        {
            GameEngine.playerAlive = false;
        }
    }
}
