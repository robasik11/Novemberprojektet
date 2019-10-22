using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Input : Program
    {


        static string question;
        static string[] option = { " Start", " Quit" };
        static int index = 0;
        static int d = 0;
        public static int Selection()
        {
            while (true)
            {
                for (int i = 0; i < option.Length; i++)
                {
                    string text = "";
                    if (index == i)
                        text += ">";
                    text += option[i];
                    Console.WriteLine(text);
                }
                ConsoleKeyInfo input = Console.ReadKey(); //get a key input from the player
                if (input.Key == ConsoleKey.UpArrow) //go up
                    index--;
                if (input.Key == ConsoleKey.DownArrow) //go up
                    index++;
                if (input.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    return index;
                }
                Console.Clear();


            }
        }
        
        

        public void Spel()
        {
            if (index == 0)
            {
                Console.WriteLine("");

            }

        }

       

    }

}





