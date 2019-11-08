using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;



            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i == 0)
                {
                    Console.WriteLine("Textbaserat fightingspel");
                }


                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Battle Arena\n");
                Player P = new Player();
                Console.WriteLine("Vad vill du heta??\n");
                Console.ForegroundColor = ConsoleColor.Green;
                P.Name();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");

                Console.ReadKey();

                Console.Clear();
                Input I = new Input();
                int index = Input.Selection();
                if (index == 0)
                {


                    Console.Clear();


                }
                else
                {
                    break;
                }

                Item N = new Item();
                int indexx = Input.Spel();
                {
                    if (indexx == 0)
                    {

                        //Fighting
                        P.PrintName();
                        Console.WriteLine("Test");

                    }

                    if (indexx == 1)
                    {
                        //Items
                        P.Dmg();
                        P.Printdmg();
                        P.equippedItem = new Item();
                        
                        Console.Clear();
                        Console.WriteLine(P.equippedItem);
                        P.Printdmg();

                    }

                    if (indexx == 2)
                    {
                        break;
                    }
                }
            }




        }
    }
}
