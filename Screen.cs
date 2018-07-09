using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Screen
    {
        private static int enemyDataBoxX = 43;
        private static int enemyDataBoxY = 0;

        private static int miscDataBoxX = 87;
        private static int miscDataBoxY = 1;

        private static int miscEquipmentBoxX = 60;
        private static int miscEquipmentBoxY = 7;

        private static int skillBoxX = 0;
        private static int skillBoxY = 6;

        private static int itemBoxX = 30;
        private static int itemBoxY = 6;

        private static int textBoxX = 0;
        private static int textBoxY = 21;
        private static int textBoxLength = 100;
        private static int textBoxHeight = 12;

        public static void showInterface()
        {
            showPlayerData();
            showEnemyData();
            showMiscData();
            showEquipment();
            showSkills();
            showItems();
            showTextBox();

            SGConsole.WriteLine("\n");
        }

        public static void showGameOver()
        {

             Console.WriteLine("++++++++++++++++++++++++++++++++");
             Console.WriteLine("+           GAME OVER :(       +");
             Console.WriteLine("++++++++++++++++++++++++++++++++");
        }

        private static void showPlayerData()
        {
            SGConsole.Write(0, 0, ConsoleColor.White, "*******************************************");
            SGConsole.Write(0, 1, ConsoleColor.White, "* ");
            SGConsole.Write(2, 1, ConsoleColor.Yellow, "Player: ");
            SGConsole.Write(10, 1, ConsoleColor.DarkYellow, GameEngine.player.name);
            SGConsole.Write(30, 1, ConsoleColor.White, "Lvl: " + GameEngine.player.level);
            SGConsole.Write(42, 1, ConsoleColor.White, "*");
            SGConsole.Write(0, 2, ConsoleColor.White, "* ");
            SGConsole.Write(2, 2, ConsoleColor.Red, "HP: " + GameEngine.player.HP + " / " + GameEngine.player.MAXHP);
            SGConsole.Write(30, 2, ConsoleColor.White, "ATK: " + GameEngine.player.ATK);
            SGConsole.Write(42, 2, ConsoleColor.White, "*");
            SGConsole.Write(0, 3, ConsoleColor.White, "* ");
            SGConsole.Write(2, 3, ConsoleColor.Blue, "MP: " + GameEngine.player.MP + " / " + GameEngine.player.MAXMP);
            SGConsole.Write(30, 3, ConsoleColor.White, "DEF: " + GameEngine.player.DEF);
            SGConsole.Write(42, 3, ConsoleColor.White, "*");
            SGConsole.Write(0, 4, ConsoleColor.White, "*******************************************");


            
        }

        private static void showEnemyData()
        {
            SGConsole.Write(enemyDataBoxX, 0, ConsoleColor.White, "*******************************************");
            SGConsole.Write(enemyDataBoxX, 1, ConsoleColor.White, "* ");
            SGConsole.Write(enemyDataBoxX + 2, 1, ConsoleColor.Gray, "Enemy: ");
            SGConsole.Write(enemyDataBoxX + 9, 1, ConsoleColor.Gray, GameEngine.enemy.name);
            SGConsole.Write(enemyDataBoxX + 42, 1, ConsoleColor.White, "*");
            SGConsole.Write(enemyDataBoxX, 2, ConsoleColor.White, "* ");
            SGConsole.Write(enemyDataBoxX + 2, 2, ConsoleColor.Gray, "HP: " + GameEngine.enemy.HP + " / " + GameEngine.enemy.MAXHP);
            SGConsole.Write(enemyDataBoxX + 30, 2, ConsoleColor.White, "ATK: " + GameEngine.enemy.ATK);
            SGConsole.Write(enemyDataBoxX + 42, 2, ConsoleColor.White, "*");
            SGConsole.Write(enemyDataBoxX, 3, ConsoleColor.White, "* ");
            SGConsole.Write(enemyDataBoxX + 2, 3, ConsoleColor.Gray, "MP: " + GameEngine.enemy.MP + " / " + GameEngine.enemy.MAXMP);
            SGConsole.Write(enemyDataBoxX + 30, 3, ConsoleColor.White, "DEF: " + GameEngine.enemy.DEF);
            SGConsole.Write(enemyDataBoxX + 42, 3, ConsoleColor.White, "*");
            SGConsole.Write(enemyDataBoxX, 4, ConsoleColor.White, "*******************************************");

        }

        private static void showMiscData()
        {
            SGConsole.Write(miscDataBoxX, miscDataBoxY, ConsoleColor.White, "Level: " + GameEngine.level);
            SGConsole.Write(miscDataBoxX, miscDataBoxY + 1, ConsoleColor.White, "Killed: " + GameEngine.defeatedEnemies);
        }

        private static void showEquipment()
        {
            int j = 0;
            //Right Hand
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "RHand: " + GameEngine.player.rightHand.name);
            j++;
            //Left Hand
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "LHand: " + GameEngine.player.leftHand.name);
            j++;
            j++;
            //Helmet
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Helmet:    " + GameEngine.player.helmet.name);
            j++;
            //Necklace
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Necklace:  " + GameEngine.player.necklace.name);
            j++;
            //Breastplate
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Top:       " + GameEngine.player.top.name);
            j++;
            //Guantlets
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Guantlets: " + GameEngine.player.guantlets.name);
            j++;
            //Pants
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Bottom:    " + GameEngine.player.bottom.name);
            j++;
            //Shoes
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "Shoes:     " + GameEngine.player.shoes.name);
            j++;
            j++;
            //Ring 1
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "R1: " + GameEngine.player.ring1.name);
            j++;
            //Ring 2
            SGConsole.Write(miscEquipmentBoxX, miscEquipmentBoxY + j, ConsoleColor.White, "R2: " + GameEngine.player.ring2.name);
            j++;
        }

        private static void showSkills()
        {
            int j = 0;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "   Skills: ");
            j++;
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[0] " + GameEngine.skillBar[0].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[1] " + GameEngine.skillBar[1].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[2] " + GameEngine.skillBar[2].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[3] " + GameEngine.skillBar[3].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[4] " + GameEngine.skillBar[4].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[5] " + GameEngine.skillBar[5].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[6] " + GameEngine.skillBar[6].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[7] " + GameEngine.skillBar[7].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[8] " + GameEngine.skillBar[8].name);
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[9] " + GameEngine.skillBar[9].name);
            j++;
            j++;
            SGConsole.Write(skillBoxX, skillBoxY + j, ConsoleColor.White, "[1 / 1]");
            j++;
        }

        private static void showItems()
        {
            int j = 0;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "   Items: ");
            j++;
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[a] " + GameEngine.itemBar[0].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[b] " + GameEngine.itemBar[1].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[c] " + GameEngine.itemBar[2].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[d] " + GameEngine.itemBar[3].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[e] " + GameEngine.itemBar[4].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[f] " + GameEngine.itemBar[5].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[g] " + GameEngine.itemBar[6].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[h] " + GameEngine.itemBar[7].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[i] " + GameEngine.itemBar[8].name);
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[j] " + GameEngine.itemBar[9].name);
            j++;
            j++;
            SGConsole.Write(itemBoxX, itemBoxY + j, ConsoleColor.White, "[1 / 1]");
        }

        private static void showTextBox()
        {
            List<String> textBoxLines = GameEngine.textBox.getPageLines(GameEngine.textBox.getPage());
            String output = "";
            int i = 0;
            int j = 1;
            



            while(i < textBoxLength + 2)
            {
                output = output + "*";
                i = i + 1;
            }
            while(j < textBoxHeight-1)
            {
                SGConsole.Write(textBoxX, textBoxY + j, ConsoleColor.White, "*");

                //Writes the content
                if( (j > 0) && (j < textBoxHeight + 1) )
                SGConsole.Write(textBoxX + 2, textBoxY + j, ConsoleColor.White, textBoxLines[j-1]);

                SGConsole.Write(textBoxX + textBoxLength + 1, textBoxY + j, ConsoleColor.White, "*");
                j++;
            }
            i = 0;
            j = 0;


            SGConsole.Write(textBoxX, textBoxY + j, ConsoleColor.White, output);
            SGConsole.Write(textBoxX, textBoxY + j + textBoxHeight-1, ConsoleColor.White, output + " [" + GameEngine.textBox.getPage() + " / " + GameEngine.textBox.calculateMaxPages() + "]" );
        }

        public static TextBox createTextBox()
        {
            return new TextBox(textBoxHeight-2);
        }
    }
}
