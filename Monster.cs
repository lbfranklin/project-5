using Project_5___Zork;
using System;
using static System.Net.Mime.MediaTypeNames;

public class Monster : Participant
{
    public string monsterType;

    public Monster() : base()
    {
        this.health = 20;
        this.accuracy = .8;
        this.position = 0;
        this.damage = 4;
    }
    public Monster(int health, double accuracy, int position, int damage) : base(health, accuracy, position, damage)
    {
        this.monsterType = " ";
        this.damage = 0;
    }
    public Monster(int health, double accuracy, int damage, int position, string monsterType)
        : base(health, accuracy, position, damage)
    {
        this.monsterType = monsterType;
        this.damage = damage;
    }

    //Getters
    public string GetMonsterType()
    {
        return monsterType;
    }

    //Setters
    public void SetMonsterType(string monsterType)
    {
        this.monsterType = monsterType;
    }
    public void SetDamage(int damage)
    {
        this.damage = damage;
    }

    public void MonsterHit(Player p)
    {
        Random r = new Random();

        if (r.Next(10000) < 8000)
        {
            Console.WriteLine("You were hit by the monster that you were fighting.");
            p.SetHealth(health - damage);
            Console.WriteLine($"You now have {p.GetHealth} HP left");
        }
        else
        {
            Console.WriteLine("The monster missed the hit on you.");
        }
    }
}

