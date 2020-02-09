namespace Program.GameCharacters
{
    class Dragon : Character, IHostile
    {
          public Dragon() : base("Dragon")
        {
            Attack = 20;
           
        }

        public int Attack { get; }

    }
}