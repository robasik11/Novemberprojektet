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

            Enemies e = new Enemies();
            Enemies s = new Enemies();

            List<Enemies> enemiesList = new List<Enemies>();
            enemiesList.Add(s);
            enemiesList.Add(s);
            Console.WriteLine(s.Attack());
            s.Inusult(s);


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Textbaserat fightingspel");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Battle Arena\n\n");
                Player P = new Player();
                Console.WriteLine("Vad vill du heta??\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                P.Name();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");

                Console.ReadKey();

                Console.Clear();
                Input I = new Input();
                int index = Input.Selection();
                if (index == 0)
                {
                    I.Spel();


                }
                else
                {
                    break;
                }

            }




        }
    }
}
