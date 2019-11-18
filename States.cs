using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class States
    {
        Monster M = new Monster();
        string answer;
        Devil D = new Devil();
        Entity E = new Entity();
        Entity P = new Player();
        public void Easy()
        {
            Player P = new Player();
            Slime S = new Slime();
            while (P.hp >= 0)
            {
                if (S.hp >= 0)
                {
                    Console.WriteLine("Vad vill du göra?\nSkriv '1' för att slå och '2' för att heala");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        E.Attack(S);

                    }

                    if (answer == "2")
                    {
                        E.Heal(P);

                    }

                    else
                    {
                        Console.WriteLine("Du skrev antagligen fel");

                    }


                }

                else
                {
                    break;
                }


            }


        }

        public void Medium()
        {


        }

        public void Hard()
        {


        }

    }
}

