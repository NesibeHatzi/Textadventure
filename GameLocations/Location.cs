using System.Collections.Generic;
using Program.GameItems;
using Program.GameCharacters;

namespace Program.GameLocations
{
    abstract class Location
    {
        public string Name { get; }
        public string Description { get; }
        public List<Item> Items { get; }
        public List<Character> Characters { get; }

        protected Location(string name, string description)
        {
            Name = name;
            Description = description;
            Items = new List<Item>();
            Characters = new List<Character>();
        }
    }
}