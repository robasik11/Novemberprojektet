﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Entity
    {

        public int hp = 100;
        public string name;
        public int dmg = 7;
        Random generator = new Random();
        public int heal = 15;





        public void Attack(Entity target)
        {
            target.hp -= dmg;
            Console.WriteLine(target.name + " har " + target.hp + " hp kvar!");
        }




        public void Heal(Entity target)
        {
            if (hp >= 100)
            {
                hp = 100;

            }

            else
            {
                target.hp += heal;
                Console.WriteLine(target.hp);
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
                Console.Clear();
                Console.WriteLine("Du måste ha ett namn...\n");
                Name();

            }


        }

        public void Health()
        {

            hp = 100;
            Console.WriteLine(hp);
        }

        public void Printstats(Entity target)
        {
            target.name = name;
            target.hp = hp;
            target.dmg = dmg;
            Console.WriteLine(target.name);
            Console.WriteLine(target.hp + "hp kvar");
            Console.WriteLine(target.dmg + "dmg");


        }


    }
}
