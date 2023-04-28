namespace Project_5___Zork
{
    internal class Driver
    {
        static void Main(string[] args)
        {   
            //Laura
            string position;
            string name;
            Player P = null;
            Monster M = null;
            Weapon W = null;
            Room startRoom;
            //Room playerRoom;

            Console.WriteLine("---------------------------------------Welcome to the Game--------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("The goal of the game is to go through the different rooms while defeating monsters along to way.");
            Console.WriteLine("You may come across weapons that can help you defeat the monsters");
            Console.WriteLine("You will comeplete the game when you successfully get to the last room and defeat all the monsters.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Enter player name: ");

            //name = Console.ReadLine();

            //default position, default player health, user inputed player name
            // Player P = new Player(name);

            //generate dungeon and cells in dungeon method
            List<Room> DungeonList = new List<Room>();
            Dungeon dungeon = new Dungeon();
            int index;

            
            //alter the first room with the player in it
            //DungeonList.RemoveAt(0);
            startRoom = new Room(P, M, W);
            //playerRoom = new Room(P, M, W);
            DungeonList.Insert(0, startRoom);
            
            
            //display dungeon method

            Console.WriteLine(dungeon.ToString());
            //Menu for player options

            //while (P.GetHealth() > 0)
            //{
                //Console.WriteLine("Player Health: " + P.health);
                //Console.WriteLine("Room: " + DungeonList[P.GetPosition()]);

                Console.WriteLine("What would you like to do? Choose a direction to go (go east/ go west): ");
                string direction = Console.ReadLine();
                dungeon.PlayerMovement(direction);
            //}/



            Console.WriteLine(dungeon.ToString());
            //if(userInput = "go east")
            //{
            //do stuff
            //}

            //if(userInput = "go west")
            //{
            //do other stuff
            //}
            //position = Console.ReadLine();         



        }
    }
}