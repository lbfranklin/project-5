using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5___Zork
{
    public class Participant
    {
        protected int health;
        protected double accuracy;
        protected int position;
        protected int damage;

        //Default
        public Participant()
        {
            health = 100;
            accuracy = 0.0;
            position = 0;
            damage = 0;
        }

        //Parameterized
        public Participant(int health, double accuracy, int position, int damage)
        {
            SetHealth(health);
            SetAccuracy(accuracy);
            SetPosition(position);
            SetDamage(damage);
        }

        //Getters

        public int GetHealth()
        {
            return health;
        }
        public double GetAccuracy()
        {
            return accuracy;
        }
        public int GetPosition()
        {
            return position;
        }
        public int GetDamage()
        {
            return damage;
        }

        //Setters

        public void SetHealth(int health)
        {
            this.health = health;
        }
        public void SetAccuracy(double accuracy)
        {
            this.accuracy = accuracy;
        }
        public void SetPosition(int position)
        {
            this.position = position;
        }
        public void SetDamage(int damage)
        {
            this.damage = damage;
        }

    }

}
