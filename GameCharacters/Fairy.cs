namespace Program.GameCharacters
{
    class Fairy : Character, IFriendly
    {
          public Fairy() : base("Fairy")
        {
            Power = 15;
           
        }

        public int Power { get; }
    }
}