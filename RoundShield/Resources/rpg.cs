using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    static class RPGTypes
    {
        public enum MoveType
        {
            Locked,Free
        }
        public enum CombatType
        {
            Turn,Free
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
    public class Item
    {
        //Numeric ID Index
        static int id = 0;
        //Name of the Item
        String name;
        //Item Properties

        
        public Item()
        {
            name = " ";
            id = id + 1;

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
    //All Stores use this
    public class Store
    {
       

    }
}
