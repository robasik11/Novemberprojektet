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


            Entity e = new Entity();
            Player p = new Player();
            Monster m = new Monster();

            /*e.Dmg();
            e.Health();
            e.Attack(p);
            Console.ReadKey();
            e.Attack(m);
            */


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i == 0)
                {
                    Console.WriteLine("Textbaserat fightingspel");
                }


                Console.ReadKey();
                Console.Clear();
               
               

                
                int index = Input.Selection();
                if (index == 0)
                {


                    Console.Clear();


                }
                else
                {
                    break;
                }


                int indexx = Input.Spel();
                {
                    if (indexx == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Battle Arena\n");
                        Entity P = new Entity();
                        Console.WriteLine("Vad vill du heta??\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        P.Name();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");

                        //Fighting
                        Console.Clear();

                    }

                    if (indexx == 1)
                    {
                        //Items
                        
                        int index3 = Input.Items();
                        {


                            Console.Clear();
                            if (index3 == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Lätt");
                                
                            }

                            if (index3 == 1)
                            {
                                Console.WriteLine("Medel");

                            }

                            if (index3 == 2)
                            {

                                Console.WriteLine("Svår");
                            }

                            if (index3 == 3)
                            {

                                Console.Clear();
                                


                            }
                        }




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
