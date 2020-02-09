namespace Program.GameCharacters
{
    abstract class Character
    {
          public string Name { get; }

        protected Character(string name)
        {
            Name = name;
        }
    }
}