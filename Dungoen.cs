using Project_5___Zork;
using System;
//Laura

public class Dungeon
{
    //list of rooms
    //fields
    public List<Room> DungeonList = new List<Room>();
    public Player P = new Player();
    public Monster M;
    public Weapon W;
    // public int currentRoom;
    // public int currentIndexOfPlayer = DungeonList.IndexOf(currentRoom);
    public int currentIndexPlayerRoom = 0;
    public Room playerRoom;
    //public Room PlayerRoom = new Room(P, M, W);
    //constructor should generate how many cells/rooms are in the Dungeon array/list

    public Dungeon()
	{
        //adding the starting room
        Room starterRoom = new Room(P, M, W);
        DungeonList.Add(starterRoom);

        Random r = new Random();
        int numberOfRooms = r.Next(5, 10);
        
        for (int i = 1; i < numberOfRooms; i++)
        {
            Room room = new Room();
            DungeonList.Add(room);
        } 
    }

    public override string ToString()
    {
        Console.WriteLine(DungeonList.Count);

        string display = "";

        for (int i = 0; i < DungeonList.Count; i++)
        {
            display += DungeonList[i];      
        }
        return display;
    }


    //direction - go east or west through the list/array

    //access to player and all the cells, movement might be in dungeon
    public void PlayerMovement(string direction)
    {
        // if 

        P.GetPosition();

        //var tempPlayer = new Participant();

        //tempPlayer.SetHealth(tempPlayer.GetHealth());
       // tempPlayer.SetDamage(tempPlayer.GetDamage());
       // tempPlayer.SetPosition(tempPlayer.GetPosition());
       // tempPlayer.SetAccuracy(tempPlayer.GetAccuracy());

        if (direction == "noMove")
        {
            return;
        }
        else if (direction == "east")
        {
            for (int i = 0; i < DungeonList.Count; i++)
            {
                P.SetPosition(i);
                return;
            }
        }
        else if (direction == "west")
        {
            for (int i = 0; i < DungeonList.Count; i--)
            {
                P.SetPosition(i);
                return;
            }
        }
    }
}




