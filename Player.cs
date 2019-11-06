using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Player
    {
        public int hp = 100;
        public string name;
        public int dmg;
        Random generator = new Random();

        public Item equippedItem;

        public void Dmg()
        {
            if (equippedItem != null)
            {
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

        }


    }
}
