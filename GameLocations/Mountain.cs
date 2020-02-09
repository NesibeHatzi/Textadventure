using Program.GameItems;
using Program.GameCharacters;


namespace Program.GameLocations
{
    class Mountain : Location
    {
        public Mountain() : base("Mountain", "A very dangerous mountain and it is so incredibly quiet here !?|\r\n OOoo there comes the dangerous dragon. Want to fight? Yes (f); No (x)")
        {
            Items.Add(new Gun());
            Characters.Add(new Dragon());
        }
    }
}