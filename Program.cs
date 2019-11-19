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


          

            //Detta är min while loop som är hela spelet, man kan trycka quit för att lämna spelet
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (i == 0)
                {
                    //Denna körs varje gång man börjar spelet från början, dvs första gången man startar spelet och sen klarat spelet och börjar om
                    Console.WriteLine("Textbaserat fightingspel");
                }


                Console.ReadKey();
                Console.Clear();



                //Här börjar min fina input kod, det är som min meny där man kan välja vad man vill göra
                int index = Input.Selection();
                if (index == 0)
                {


                    Console.Clear();


                }
                else
                {
                    break;
                }

                Input I = new Input();
                int indexx = Input.Spel();
                {
                    States S = new States();
                    if (indexx == 0)
                    {
                        //Här kommer man om man väljer att börja fighta direkt utan att välja svårighetsgrad!
                        //Jag har satt den till att börja spelet på medium om man väljer att inte välja
                        I.Start();
                        //Fighting
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Battle Arena\n");
                        Player P = new Player();
                        //P är en instans av player och det är här spelaren skapar sitt namn till sin spelare. 
                        Console.WriteLine("Vad vill du heta??\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        P.Name();
                        //Denna metod kollar så att spelaren skriver in ett namn som är längre än 2 bokstäver för att se till att hen faktiskt skriver något
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");
                        S.Medium(P);
                        //här startas själva spelet
                        Console.Clear();

                    }
                    //väljer man difficulty så kommer man hit! här kan man välja mellan lätt, medium och svår!!
                    if (indexx == 1)
                    {
                        //svårighetsgrad

                        int index3 = Input.Items();
                        {


                            Console.Clear();
                            if (index3 == 0)
                            {
                                //Här körs samma introduktion till spelet som tidigare där spelaren skriver in sitt namn och får lite info.
                                Console.Clear();
                                Console.Clear();
                                Console.WriteLine("Battle Arena\n");
                                Player P = new Player();
                                Console.WriteLine("Vad vill du heta??\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                P.Name();
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");
                                Console.WriteLine("Lätt");
                                S.Easy(P);
                                //här är "lätta" spelet
                            }

                            if (index3 == 1)
                            {
                                //samma sak som tidigare med intro till spel och namn-input av spelaren
                                Console.Clear();
                                Console.WriteLine("Battle Arena\n");
                                Player P = new Player();
                                Console.WriteLine("Vad vill du heta??\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                P.Name();
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");
                                Console.WriteLine("Medel");
                                S.Medium(P);
                                //spelet i medium, man kan tänka på att P är targeten här vilket gör att jag kan spara namnet som användaren skriver in och använda senare
                            }

                            if (index3 == 2)
                            {
                                //EXAKT SAMMA SAK OM SPELAREN VÄLDJER SVÅR OCH KÖR SPELET
                                Console.Clear();
                                Console.WriteLine("Battle Arena\n");
                                Player P = new Player();
                                Console.WriteLine("Vad vill du heta??\n");
                                Console.ForegroundColor = ConsoleColor.Green;
                                P.Name();
                                Console.ForegroundColor = ConsoleColor.White;

                                Console.WriteLine("\nDu heter " + P.name + " och du börjar med " + P.hp + " HP");
                                Console.WriteLine("Svår");
                                S.Hard(P);
                                //Samma sak
                            }

                            if (index3 == 3)
                            {
                                //Här breakar den och kör spelet från hela början
                                Console.Clear();



                            }
                        }




                    }

                    if (indexx == 2)
                    {
                        //denna break stänger ner hela spelet om man väljer att quitta
                        break;
                    }
                }
            }




        }
    }
}
