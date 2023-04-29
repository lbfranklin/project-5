using System;

public class Room
{
    //cells within a cell (weapon, monster, player, etc within a cell)

    //fields
    bool chanceOfMonster;
    bool chanceOfWeapon;
    bool playerPosition { get; set; }

    Player P;
    Monster M;
    Weapon W;

    //default
    public Room()
    {
        //Player P = null;
        //Monster M = null;
        //Weapon W = null;

        IfPlayer();
        ChanceOfMonster();
        ChanceOfWeapon();
    }   

    //paramaterized
    public Room(Player P, Monster M, Weapon W)
    {
        playerPosition = true;
        chanceOfWeapon = false;
        chanceOfMonster = false; 
    }     

    public void IfPlayer()
    {
        //player should start at index 0
        //if(Player player)
        //if player position is the same index as the room
        //then the player is in the room
    }

    public void ChanceOfMonster()
    {   
        Random r = new Random();

        if (r.Next(10000) < 5000)
        {
            //add a monster
            chanceOfMonster = true;
            Monster M = new Monster();
        }
        else
        {
            chanceOfMonster = false;
        }
        //ToString when you enter a room
        
    }   

    public void ChanceOfWeapon()
    {
        Random r = new Random();

        if (r.Next(10000) < 3000)
        {
            //add a weapon in the room
            chanceOfWeapon = true;
            Weapon W = new Weapon();
        }
        else
        {
            chanceOfWeapon = false;
        }
        
    }

    //method: if monster and player postion equals the same, start the combat

    //Display Cell/Room
    public override string ToString()
    {
        string display = "";

        if (chanceOfMonster == true && playerPosition == true && chanceOfWeapon == true)
        {
            display = "|P_W_M|";
        }
        if (chanceOfMonster == true && chanceOfWeapon == true)
        {
            display = "|__W_M|";
        }
        if (chanceOfMonster == true && playerPosition == true)
        {
            display = "|P___M|";
        }
        if (chanceOfWeapon == true && playerPosition == true)
        {
            display = "|P_W__|";
        }
        if (chanceOfMonster == true)
        {
            display = "|____M|";
        }
        if (chanceOfWeapon == true)
        {
            display = "|__W__|";
        }
        if (playerPosition == true)
        {
            display = "|P____|";
        }
        if (playerPosition == false && chanceOfWeapon == false && chanceOfMonster == false)
        {
            display = "|_____|";
        }

        return display;
    }
    public void SetPlayerPosition(bool playerPosition)
    {
        this.playerPosition = playerPosition;
    }

}
