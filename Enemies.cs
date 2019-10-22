using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Enemies
    {
        protected int damage = 7;
        protected int hp = 20;
        protected string name = "Harry";

        public virtual int Attack()
        {
            return damage;

        }


        public void Inusult(Enemies target)
        {
            Console.WriteLine(target.name + " är dum");

        }
    }
}
