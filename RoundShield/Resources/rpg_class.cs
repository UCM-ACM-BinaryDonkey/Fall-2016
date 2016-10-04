using System;

//THIS DEFINES THE PATICULAR RPG
public class rpg_class
{
    public rpg_class()
	{
        //Chuck the Chicken
        NPC wisegoat = new NPC(); // NPC for Initial Tutorial
        NPC npc1 = new NPC(); //Random NPC
        NPC npc2 = new NPC(); // Random NPC
        NPC npc3 = new NPC(); // Random NPC



        Tile Ground = new Tile(); //Ground Tile
        Tile Path = new Tile(); //Path Tile
	}
}
//ALL NON ENEMY NPCS USE THIS CLASS
public class NPC
{
    public NPC()
	{
        //Default Constructor
	}
}
//ALL TILES WILL USE THIS CLASS
public class Tile
{
    


    public Tile()
    {
        //Default Constructor
    }

}
//Enemies will use this class
public class Mob
{


}

