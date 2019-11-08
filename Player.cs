using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Player
    {
        public int hp;
        public string name;
        public int dmg;
        Random generator = new Random();

        public Item equippedItem;



        public Player(string _name, int damage, int health)
        {
            name = _name;
            dmg = damage;
            hp = health;
        }

        public void Print()
        {

            Console.WriteLine("{0 stats}", name);
            Console.WriteLine("");
            Console.WriteLine("Attack value is: {0}", dmg);
            Console.WriteLine("Health value: {0}" , hp);

        }

        public void Attack(Player target)
        {
            target.hp -= dmg;

        }
        


/*
        public void Dmg()
        {
            if (equippedItem != null)
            {
                Console.WriteLine();
                dmg = generator.Next(10 + equippedItem.damageBonus, 15 + equippedItem.damageBonus);
            }

            else
            {

                dmg = generator.Next(10, 15);

            }
                   
        }
        



        public void Printdmg()
        {
            Console.WriteLine(dmg);
            Console.ReadLine();

        }

        public void Name()
        {

            name = Console.ReadLine();

            if (name.Length < 2)
            {

                Console.WriteLine("Du måste ha ett namn...\n");
                Name();

            }


        }

        public void Hp()
        {

            hp = 100;

        }

        public void PrintName()
        {
            Console.WriteLine(name);

        }*/


    }
}
