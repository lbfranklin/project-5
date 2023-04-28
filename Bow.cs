using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5___Zork
{
    internal class Bow : Weapon
    {
        public Bow()
            : base()
        {
            Damage = 2;
            Name = "Falador";
        }

        public Bow(int damage, string name)
            : base(damage, name)
        {
            // Nothing needs to go in Here :)
        }
    }

}
