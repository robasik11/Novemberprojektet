using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class States
    {
       //Här har vi mina olika nivåer man kan välja på, det jag är mest nöjd med här är att ha fått in användarens tidigare input på name i sjäälva spelet.
        string answer;
       
        Entity E = new Entity();
        
        public void Easy(Player P)
        {
            //jag skapar en ny slime
            Slime S = new Slime();
            while (P.hp >= 0)
            {
                //jag har en while loop som körs så länge spelaren lever.
                if (S.hp >= 0)
                {
                    //här är en if-sats som körs så länge Slimen lever, hinner man döda den så kommer man ut ur loopen.
                    Console.WriteLine("Vad vill du göra?\nSkriv '1' för att slå och '2' för att heala");
                    answer = Console.ReadLine();
                    if (answer == "1")
                    {
                        //kallar på entity metoderna som används 
                        Console.Clear();
                        E.Attack(S);
                        E.Attack(P);

                        Console.ReadKey();
                        Console.Clear();

                    }

                    if (answer == "2")
                    {
                        //if-sats som kallar på min heal metod, slime attackerar fortfarande när man tar en runda och healar.
                        Console.Clear();
                        P.Heal();
                        E.Attack(P);
                    }

                    if (answer != "1" && answer != "2")
                    {
                        //om användaren varken skrev 1 eller 2 så kommer det stå att man skrivit fel och inget kommer hända, då så skriver man 1 eller 2 igen
                        Console.WriteLine("Du skrev antagligen fel");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }

                else
                {
                    break;
                }
                //dör slimen så breakas loopen och man vinner.
            }


        }

        //ALLA ANDRA SVÅRIGHETSGRADER ÄR EXAKT SAMMA MEN JAG HAR BYTT UT DEM OLIKA TARETSARNA SÅ MAN MÖTER FOLK MED MER DMG OCH MER HP
        //Något jag skulle vela förbättra med mitt spel är att sätta in så Enemies använder sig av en random generator och slumpmässa olika skalor av dmg 
        //då skulle spelet bli lite mer intressant och inte samma reslutat samma gång, jag skulle även kunna göra så HEaling och DMG på playern är random 
        //och om man lyckas döda ett monster och överlever så kan man få möta ett nytt monster men då behöver jag yttligare lite tid. sss
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

