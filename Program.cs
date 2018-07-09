using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SimpleGame
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int ConsoleSizeX = 140;

            int ConsoleSizeY = 40;



            GameEngine engine = new GameEngine(ConsoleSizeX, ConsoleSizeY);


            String input = "";

            

            while(GameEngine.exit == false)
            {
                engine.Render();
                engine.ReadInput();
                engine.Update(); 
            }


        }

        
    }
}
