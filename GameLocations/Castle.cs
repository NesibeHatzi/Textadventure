using Program.GameItems;
using Program.GameCharacters;

namespace Program.GameLocations
{
    class Castle : Location
    {
        public Castle() : base("The Castle", "A huge castle, but it is so quiet here.|\r\nSomeone comes: it's the fairy. Do you want to talk (o) to her or fight (f)?")
        {
            Items.Add(new VikingShield());
            Characters.Add(new Fairy());
        }
    }
}