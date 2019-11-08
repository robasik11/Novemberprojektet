using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Enemy
    {
        public int enemy;
        protected int enemydamage = 7;
        protected int hp = 20;
        protected string name = "Harry";

        public virtual int Attack()
        {
            return enemydamage;

        }


        public void Inusult(Enemy target)
        {
            Console.WriteLine(target.name + " är dum");

        }
    }
}
