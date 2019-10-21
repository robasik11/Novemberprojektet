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

            Console.WriteLine("Textbaserat fightingspel");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Battle Arena\n\n");
            Player P = new Player();

            Console.WriteLine("Vad vill du heta??\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            P.Name();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDu heter " + P.name + " och du börjar med " +  P.hp + " HP" );

            Console.ReadLine();

        }
    }
}
