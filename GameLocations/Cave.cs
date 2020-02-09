using Program.GameItems;
using Program.GameCharacters;

namespace Program.GameLocations
{
    class Cave : Location
    {
        public Cave() : base("The Cave", "The cave is dark and damp, it stinks here too!")
       
        {
           
            Items.Add(new LongSword());
            
        }
    }
}