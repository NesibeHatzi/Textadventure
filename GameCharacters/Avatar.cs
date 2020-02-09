using System.Collections.Generic;
using Program.GameCharacters;
using Program.GameItems;
using Program.GameLocations;

namespace Program
{
    //class Avatar : Character
     class Avatar 
    {
        public Location Location { get; set; }
        public List<Item> Inventory { get; }
       public List<Character> Characters { get; }
        public int Health = 100;
        public Avatar()
        {
            Inventory = new List<Item>();
            Characters = new List<Character>();
            Health = 100;

           
    }
}
}