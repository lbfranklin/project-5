using Project_5___Zork;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

public class Player : Participant
{
    public string name;
    public int location;
    //For direction, make it an index of room

    public Player() : base()
    {
        this.accuracy = .9;
        this.damage = 5;
    }
    public Player(int health, double accuracy, int position, int damage) : base(health, accuracy, position, damage)
    {
        this.name = " ";
        this.location = 0;
    }
    public Player(int health, double accuracy, int position, int damage, string name, int location)
        : base(health, accuracy, position, damage)
    {
        this.name = name;
        this.location = location;
    }

    //Getters
    public string GetName()
    {
        return name;
    }
    public int GetLocation()
    {
        return location;
    }

    //Setters
    public void SetName(string name)
    {
        this.name = name;
    }
    public void SetLocation(int location)
    {
        this.location = location;
    }

    public void PlayerHit(Monster m)
    {
        Random r = new Random();

        if (r.Next(10000) < 9000)
        {
            Console.WriteLine("You hit the monster that you were fighting");
            m.SetHealth(health - damage);
            Console.WriteLine($"The monster now has {m.GetHealth()} HP left");
        }
        else
        {
            Console.WriteLine("You missed the hit on the monster you were fighting.");
        }
    }
}
