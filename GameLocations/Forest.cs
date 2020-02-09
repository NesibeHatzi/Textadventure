using Program.GameItems;



namespace Program.GameLocations
{
    class Forest : Location
    {
        public Forest() : base("The Forest", "A forest full of lush trees.")
        {
            Items.Add(new ShortSword());
            
        }
    }
}