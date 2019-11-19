using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novemberprojektet
{
    class Player : Entity
    {

        public Player()
        {
            //Här har jag valt att göra en specifik konstruktor för vad PLayer ska ha för specifika stats
            hp = 100;
            dmg = 14;

        }

    }
}
