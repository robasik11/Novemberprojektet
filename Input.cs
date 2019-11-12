using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Input
    {


        static string question;
        static string[] option = { " Start", " Quit" };
        static int index = 0;
        static string[] fight = { " Fight", " Difficulty", " Quit" };
        static string[] items = { " Easy", " Medium", " Hard", " Go Back" };


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

                    return index;
                }

                Console.Clear();
                if (index <= 0)
                {
                    index = 0;
                    Console.Clear();
                  
                    Console.ReadKey();
                }

                if (index >= 1)

                {
                    index = 1;


                }
            }


        }
        public static int Spel()
        {
            int indexx = 0;
            while (true)
            {
                for (int i = 0; i < fight.Length; i++)
                {
                    string text = "";
                    if (indexx == i)
                        text += ">";
                    text += fight[i];
                    Console.WriteLine(text);
                }
                ConsoleKeyInfo input = Console.ReadKey(); //get a key input from the player
                if (input.Key == ConsoleKey.UpArrow) //go up
                    indexx--;
                if (input.Key == ConsoleKey.DownArrow) //go up
                    indexx++;
                if (input.Key == ConsoleKey.Enter)
                {

                    return indexx;
                }

                Console.Clear();
                if (indexx <= 0)
                {
                    indexx = 0;
                    Console.Clear();
                }



                if (indexx >= 2)

                {
                    indexx = 2;


                }
            }



        }
        public static int Items()
        {
            Console.Clear();
            int index3 = 0;
            while (true)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    string text = "";
                    if (index3 == i)
                        text += ">";
                    text += items[i];
                    Console.WriteLine(text);
                }
                ConsoleKeyInfo input = Console.ReadKey(); //get a key input from the player
                if (input.Key == ConsoleKey.UpArrow) //go up
                    index3--;
                if (input.Key == ConsoleKey.DownArrow) //go up
                    index3++;
                if (input.Key == ConsoleKey.Enter)
                {

                    return index3;
                }

                Console.Clear();
                if (index3 <= 0)
                {
                    index3 = 0;

                }

                if (index3 >= 3)
                {
                    index3 = 3;


                }

            }

        }
    }

}



