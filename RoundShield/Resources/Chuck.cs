using System;
    using rpg;

namespace chuck
{
    //THIS DEFINES THE PATICULAR RPG
    public class Chuck
    {
        //USE THE NUMBER OF ITEMS CREATED IN THE ITEM
        Item[] ItemList;
        public Chuck()
        {
            //Chuck the Chicken
            NPC wisegoat = new NPC(); // NPC for Initial Tutorial
            NPC npc1 = new NPC(); //Random NPC
            NPC npc2 = new NPC(); // Random NPC
            NPC npc3 = new NPC(); // Random NPC



            Tile Ground = new Tile(); //Ground Tile
            Tile Path = new Tile(); //Path Tile

            LoadItems();

        }
        private void LoadItems()
        {
            const int numberofitems = 3;
            

            ItemList = new Item[numberofitems];

            for (int i = 0; i < numberofitems; i++)
            {
                
                //Read In XML Document for Items into Array of Items
                //use the Item number from the xml
                ItemList[i] = new Item();
            }
        }
    }
}


