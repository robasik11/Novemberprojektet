using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Entity
    {
        //hÄR skriver jag grundstatsen för en typisk entity
        public int hp = 100;
        public string name;
        public int dmg = 7;
        Random generator = new Random();
        public int heal = 15;


        //här har jag min klass ENTITIES och jag har skapat subklasser i dem, Player, Slime, Monster och Devil är olika sorters Entities och faller alltså i denna klass.


        //detta är min attackmetod och det är som smöret till mitt fightingspel, jag har gjort den till en target så jag kan välja vem som ska ta skadan och därefter även skriva ut VEM som tar skadan och dess resterande HP

        public void Attack(Entity target)
        {
            target.hp -= dmg;
            Console.WriteLine(target.name + " har " + target.hp + " hp kvar, och gjorde " + target.dmg + " dmg");
        }


        //min Heal metod är samma sak som min Atackmetod men istället för att göra dmg så får man tillbaka hp, Jag har valt at inte göra denna till Target player eftersom att
        //Player är den enda som ska kunna hela. och jag är nöjd med att ha gjort så att man inte kan ha mer än 100 hp, så du kan inte heala dig till mer hå än du har
        //då ändras ditt värde till 100 direkt. 

        public void Heal()
        {


            if (hp >= 1)
            {
                hp += heal;
                Console.WriteLine(hp);
            }

            if (hp >= 100)
            {
                hp = 100;
                Console.WriteLine(hp);

            }

        }


        //print dmg skriver bara ut ens dmg man gör, används inte för tillfället.

        public void Printdmg()
        {
            Console.WriteLine(dmg);
            Console.ReadLine();

        }


        //Name metoden är yttligare en väldigt simpel metod men som jag är väldigt nöjd med för att den kollar ifall att användaren skriver in ett input som är 2 eller mer karaktärer
        //om inte så måste man skriva om, den är simpel men jag är så nöjd med att jag kom på idén.
        public void Name()
        {

            name = Console.ReadLine();

            if (name.Length < 2)
            {
                Console.Clear();
                Console.WriteLine("Du måste ha ett namn...\n");
                Name();

            }


        }

        //Health skriver bara ut hp, jag använder inte denna för tillfället.
        public void Health()
        {

            hp = 100;
            Console.WriteLine(hp);
        }


        //printar stats på en target som jag väljer, den används inte för tillfärllet men kan komma till välidgt väldigt bra nytta om jag har mer tid,
        //kan göra en ny meny där man kan kolla álla targets resterande stats
        public void Printstats(Entity target)
        {


            Console.WriteLine(target.name + " har " + target.hp + " hp kvar, och gjorde " + target.dmg + " dmg");



        }


    }
}
