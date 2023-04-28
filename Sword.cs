using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5___Zork
{
    internal class Sword : Weapon
    {
        public Sword()
            : base()
        {
            Damage = 3;
            Name = "Shao-Den";
        }
        public Sword(int damage, string name)
            : base(damage, name)
        {
            // Nothing needs to go in Here :)
        }
    }

}
