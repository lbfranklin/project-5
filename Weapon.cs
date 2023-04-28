using System;
//Jacob
    public class Weapon
    {
        protected int Damage;
        protected string Name;

        public Weapon()
        {
            Damage = 5;
            Name = "The Weapon of Mass Destruction";
        }

        public Weapon(int damage, string name)
        {
            Damage = damage;
            Name = name;
        }

        public override string ToString()
        {
            string info = "";
            info += $"\n----------------------------------------------------";
            info += $"\n                Item Name: {Name}";
            info += $"\n                   Damage: {Damage}";
            info += $"\n----------------------------------------------------";

            return info;
        }


    }


