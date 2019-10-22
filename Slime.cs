using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Slime : Enemies
    {
        static Random generator = new Random();
       public override int Attack()
        {
            return generator.Next(damage);

        }
      
        

    }
}
