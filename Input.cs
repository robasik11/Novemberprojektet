using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Input
    {


        //Detta är min välidgt väldigt fina Inputklass!! 
        //Här har jag valt att sätta in all min input för att ha den lite lite mer på samma plats
        //Jag har gjort mina input arrays här och satt dem i olika kategorier och även definerat index som är 0
        static string[] option = { " Start", " Quit" };
        static int index = 0;
        static string[] fight = { " Fight", " Difficulty", " Quit" };
        static string[] items = { " Easy", " Medium", " Hard", " Go Back" };

        public void Start()
        {
            //här försökte jag göra en "Start" metod som jag endast skulle behöva kalla på när jag skulle behöva börja spelet 
            //eller på varje svårighetsgrad, men mitt problem som uppstod är att i själva fighten så hade användarens namn inte poppat upp
            // under själva matchen, jag skulle dock väldigt lätt kunna fixa det om jag fick lite mer tid.
            Console.Clear();
            Console.WriteLine("Battle Arena\n");
            Entity P = new Entity();
            Console.WriteLine("Vad vill du heta??\n");
            Console.ForegroundColor = ConsoleColor.Green;
            P.Name();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");
        }
        public static int Selection()
        {
            //Min första inputmetod är i en whileloop så om användaren vill stänga ner spelet så har den möjlighet att göra det. 
            //Därefter använder jag mig av Visual studios färdiga input kod, ConsoleKeyInfo som gör det möjligt för mig att göra så 
            //användaren endast behöver trycka med pilarna för att bläddra mellan mina olika alternativ i min array. 
            //Den räknar att första alternativet är 0 och den går upp oändligt MEN det är därför jag gjort if - satser längre ner för att stoppa "pekaren"

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
                    //här gör jag så enterknappen är metod för att välja sitt alternativ på texten som pekaren pekar på
                    return index;
                }

                Console.Clear();
                if (index <= 0)
                {
                    index = 0;
                    //Här är en if-sats som jag är stolt över att jag kom på då den stoppar pilen från att gå under 0 


                }

                if (index >= 1)

                {
                    index = 1;
                    //och här stoppar if satsen pilen att gå över 1
                    //denna input metod har jag använt mig av i resten av spelet och jag har gjort så man kommer till olika menyer beroende vilket alternativ
                    //som enter returnar. 

                }
            }


        }
        //detta är samma input metod men jag har 3 alternativ istället för 2 och jag har gjort så att pilen inte fortsätter gå upp eller ner
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
                ConsoleKeyInfo input = Console.ReadKey(); //här får man knapptryck från spelaren.
                if (input.Key == ConsoleKey.UpArrow) //är det -- så går pilen upp
                    indexx--;
                if (input.Key == ConsoleKey.DownArrow) //++ gör så att pilen går ner istället
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

        //samma metod fast med 4 alternativ istället för 3 eller 2 men den har exakt samma princip 
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
                ConsoleKeyInfo input = Console.ReadKey(); //användare input
                if (input.Key == ConsoleKey.UpArrow)
                    index3--;
                if (input.Key == ConsoleKey.DownArrow)
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



