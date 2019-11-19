using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class States
    {

        string answer;

        Entity E = new Entity();
        //Entity P = new Player();
        public void Easy(Player P)
        {
            //Player P = new Player();
            Slime S = new Slime();
            while (P.hp >= 0)
            {
                if (S.hp >= 0)
                {

                    Console.WriteLine("Vad vill du göra?\nSkriv '1' för att slå och '2' för att heala");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        E.Attack(S);
                        E.Attack(P);

                        Console.ReadKey();
                        Console.Clear();

                    }

                    if (answer == "2")
                    {
                        Console.Clear();
                        P.Heal();

                    }

                    if (answer != "1" && answer != "2")
                    {
                        Console.WriteLine("Du skrev antagligen fel");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else
                {
                    break;
                }

            }


        }

        public void Medium(Player P)
        {
            Monster M = new Monster();
            while (P.hp >= 0)
            {
                if (M.hp >= 0)
                {

                    Console.WriteLine("Vad vill du göra?\nSkriv '1' för att slå och '2' för att heala");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        E.Attack(M);
                        E.Attack(P);

                        Console.ReadKey();
                        Console.Clear();

                    }

                    if (answer == "2")
                    {
                        Console.Clear();
                        P.Heal();

                    }

                    if (answer != "1" && answer != "2")
                    {
                        Console.WriteLine("Du skrev antagligen fel");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else
                {
                    break;
                }

            }


        }

        public void Hard(Player P)
        {
            Devil D = new Devil();
            while (P.hp >= 0)
            {
                if (D.hp >= 0)
                {

                    Console.WriteLine("Vad vill du göra?\nSkriv '1' för att slå och '2' för att heala");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        Console.Clear();
                        E.Attack(D);
                        E.Attack(P);

                        Console.ReadKey();
                        Console.Clear();

                    }

                    if (answer == "2")
                    {
                        Console.Clear();
                        P.Heal();

                    }

                    if (answer != "1" && answer != "2")
                    {
                        Console.WriteLine("Du skrev antagligen fel");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else
                {
                    break;
                }

            }


        }

    }
}

