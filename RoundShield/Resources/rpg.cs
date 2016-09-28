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
}
