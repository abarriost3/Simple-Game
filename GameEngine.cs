using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class GameEngine
    {
        /// <summary>
        /// RNG of the whole game
        /// </summary>
        public static SuperRandom rng;

        //Entities of the game
        public static Player player;
        public static Enemy enemy;

        //Misc statistics
        public static int defeatedEnemies;
        public static bool playerAlive;
        public static int level;

        /// <summary>
        /// Exit condition of the program
        /// </summary>
        public static bool exit;

        /// <summary>
        /// SkillBar of the player
        /// </summary>
        public static Skill[] skillBar;

        /// <summary>
        /// ItemBar of the player
        /// </summary>
        public static Item[] itemBar;


        public static TextBox textBox;


        public static Place currentPlace;


        public static List<Place> choiceOfPlaces;




        /// <summary>
        /// Constructor
        /// </summary>
        public GameEngine(int ConsoleSizeX, int ConsoleSizeY)
        {
            Console.WindowWidth = ConsoleSizeX;
            Console.WindowHeight = ConsoleSizeY;

            rng = new SuperRandom();

            player = new Player("abarriost3");
            enemy = new Enemy("The Enemy");

            level = 0;
            defeatedEnemies = 0;
            playerAlive = true;
            exit = false;

            //Init bars
            skillBar = new Skill[10];
            itemBar = new Item[10];

            for(int i = 0; i < 10; i++)
            {
                skillBar[i] = new Skill(EnumSkill.None);
                itemBar[i] = new Item();
            }

            //TEST
            skillBar[0] = new Skill(EnumSkill.Fireball);

            textBox = Screen.createTextBox();
        }

        /// <summary>
        /// Renders the game screen
        /// </summary>
        public void Render()
        {
            //Cleans screen
            SGConsole.Clear();

            //Shows GUI
            Screen.showInterface();

            

            
        }

        /// <summary>
        /// Reads the game input
        /// </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter your command!");
            String input = Console.ReadLine();

            switch (input)
            {
                case "":
                    GameEngine.attack(GameEngine.player, GameEngine.enemy);
                    GameEngine.attack(GameEngine.enemy, GameEngine.player);
                    break;
                //Skills input
                case "0":
                    if(skillBar[0].ID != EnumSkill.None)
                        skillBar[0].castSkill(player, enemy);
                    break;
                case "1":
                    if (skillBar[1].ID != EnumSkill.None)
                        skillBar[1].castSkill(player, enemy);
                    break;
                case "2":
                    if (skillBar[2].ID != EnumSkill.None)
                        skillBar[2].castSkill(player, enemy);
                    break;
                case "3":
                    if (skillBar[3].ID != EnumSkill.None)
                        skillBar[3].castSkill(player, enemy);
                    break;
                case "4":
                    if (skillBar[4].ID != EnumSkill.None)
                        skillBar[4].castSkill(player, enemy);
                    break;
                case "5":
                    if (skillBar[5].ID != EnumSkill.None)
                        skillBar[5].castSkill(player, enemy);
                    break;
                case "6":
                    if (skillBar[6].ID != EnumSkill.None)
                        skillBar[6].castSkill(player, enemy);
                    break;
                case "7":
                    if (skillBar[7].ID != EnumSkill.None)
                        skillBar[7].castSkill(player, enemy);
                    break;
                case "8":
                    if (skillBar[8].ID != EnumSkill.None)
                        skillBar[8].castSkill(player, enemy);
                    break;
                case "9":
                    if (skillBar[9].ID != EnumSkill.None)
                        skillBar[9].castSkill(player, enemy);
                    break;
                case "a":
                    break;
                case "b":
                    break;
                case "c":
                    break;
                case "d":
                    break;
                case "e":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                case "h":
                    break;
                case "i":
                    break;
                case "j":
                    break;
                //CheckBox Control
                case "<":
                    textBox.setPage(textBox.getPage() - 1);
                    break;
                case ">":
                    textBox.setPage(textBox.getPage() + 1);
                    break;
                //repeat
                case "r":
                    GameEngine.player = new Player("abarriost3");
                    GameEngine.enemy = new Enemy("The Enemy");
                    break;
                case "run":
                    GameEngine.enemy = new Enemy("The Enemy");
                    break;

                default:
                    break;
            }
        }

        public void Update()
        {
            //Game Over condition
            if (GameEngine.playerAlive == false)
            {
                Screen.showGameOver();

                String input = Console.ReadLine();
                exit = true;
            }
        }



        /// <summary>
        /// Entity attacks another entity
        /// </summary>
        /// <param name="target"></param>
        public static void attack(Entity caster, Entity target)
        {
            //The notification
            String log = "";

            //Damage calculations
            int damage = caster.ATK - target.DEF;

            //Only applies if the damage was positive
            if (damage > 0)
            {
                target.HP = target.HP - damage;

                //If HP is below 0, the target dies
                if (target.HP <= 0)
                {
                    target.dies();
                }
            }
            else damage = 0;


            log = caster.name + " hits " + target.name + " for " + damage + " damage.";
            GameEngine.textBox.addLine(log);
        }


        /// <summary>
        /// Entity attacks another entity with magic/skill
        /// </summary>
        /// <param name="target"></param>
        public static void attackMagic(Entity caster, Entity target, Skill skill)
        {
            //The notification
            String log = "";

            //Damage calculations
            int damage = caster.ATK - target.DEF;

            //Only applies if the damage was positive
            if (damage > 0)
            {
                target.HP = target.HP - damage;

                //If HP is below 0, the target dies
                if (target.HP <= 0)
                {
                    target.dies();
                }
            }
            else damage = 0;


            log = caster.name + " uses " + skill.name + " and hits " + target.name + " for " + damage + " damage.";
            GameEngine.textBox.addLine(log);
        }

        /// <summary>
        /// Entity attacks another entity with magic/skill
        /// </summary>
        /// <param name="target"></param>
        public static void attackMagicSelf(Entity caster, Skill skill)
        {
            //The notification
            String log = "";

            //Damage calculations
            int damage = caster.ATK - caster.DEF;

            //Only applies if the damage was positive
            if (damage > 0)
            {
                caster.HP = caster.HP - damage;

                //If HP is below 0, the target dies
                if (caster.HP <= 0)
                {
                    caster.dies();
                }
            }
            else damage = 0;


            log = log + caster.name + " uses " + skill.name + " and self inflicts " + damage + " damage.";
            GameEngine.textBox.addLine(log);
        }

        /// <summary>
        /// Entity attacks another entity with magic/skill
        /// </summary>
        /// <param name="target"></param>
        public static void heal(Entity caster, Entity target, Skill skill)
        {
            //The notification
            String log = "";

            //Heal calculations
            if(target.HP + skill.healAmount <= target.MAXHP)
            {
                target.HP = target.HP + skill.healAmount;
            }
            else
            {
                target.HP = target.MAXHP;
            }


            log = log + caster.name + " casts " + skill.name + " and heals " + target.name + " for " + skill.healAmount + " health.";
            GameEngine.textBox.addLine(log);
        }

        /// <summary>
        /// Entity attacks another entity with magic/skill
        /// </summary>
        /// <param name="target"></param>
        public static void healSelf(Entity caster, Skill skill)
        {
            //The notification
            String log = "";

            //Heal calculations
            if (caster.HP + skill.healAmount <= caster.MAXHP)
            {
                caster.HP = caster.HP + skill.healAmount;
            }
            else
            {
                caster.HP = caster.MAXHP;
            }


            log = log + caster.name + " uses " + skill.name + " and heals for " + skill.healAmount + " health.";
            GameEngine.textBox.addLine(log);
        }


    }
}
