using System;
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
        public int dmg;
        Random generator = new Random();

        public Item equippedItem;

       


        public void Attack(Entity target)
        {
            target.hp -= dmg;
            Console.WriteLine(target.hp);
        }




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

        public void Health()
        {

            hp = 100;
            Console.WriteLine(hp);
        }

        public void PrintName()
        {
            Console.WriteLine(name);

        }


    }
}
