using System;

namespace Program.UserInterface
{
    class Dialog
    {
        private Game _game;
        private Menu _menu;

        public Dialog(Game game)
        {
            _game = game;
            _menu = new Menu();
        }

        public void Loop()
        {
            while (!_game.IsOver)
            {
                PrintSituation();
                PrintCommands();
                var input = ReadInput();
                var command = _menu.GetCommandFromInput(input);
                command.Execute(this, _game);
            }
        }

        public void PrintSituation()
        {
            Console.WriteLine();
            Console.WriteLine("You are here: " + _game.Avatar.Location.Name + " | " + _game.Avatar.Location.Description);
            Console.WriteLine("Health: "+  _game.Avatar.Health);
            Console.WriteLine("Items here: ");
            for (int i = 0; i < _game.Avatar.Location.Items.Count; i++)
            {
                var item = _game.Avatar.Location.Items[i];
                Console.WriteLine(i + ": " + item.Name);
            }
          //  Console.WriteLine("Charackter here: " + _game.Avatar.Location.Charackter.Name);
        }

        public void PrintCommands()
        {
            Console.WriteLine();
            Console.WriteLine("What do you do?");
            Console.WriteLine("- Move: go north(n), go east(e), go west(w), go south(s)");
            Console.WriteLine("- Help: For Help please press (h)");
            Console.WriteLine("- Items: take item (t <number>), drop item (d <number>)");
            Console.WriteLine("- Exit: quit application(q)");
        }

        public void PrintInventory()
        {
            Console.WriteLine();
            Console.WriteLine("Inventory:");
            for (int i = 0; i < _game.Avatar.Inventory.Count; i++)
            {
                var item = _game.Avatar.Inventory[i];
                Console.WriteLine(i + ": " + item.Name);
            }
        }
        
        public void PrintHealth ()
        {
             if(_game.Avatar.Health > 0)
            {
                _game.Avatar.Health = _game.Avatar.Health-20;
                Console.WriteLine("Health: " + _game.Avatar.Health);
            }
             if(_game.Avatar.Health <= 0)
             {
                 Console.WriteLine("GAME OVER !!! \r\n You are dead.");
                 _game.Quit();
             }
        }

        public void PrintHelp()
        {
            Console.WriteLine("Help: look around(l), show inventory(i), show commands(c)");
        }

        public void GetPower ()
        {
            _game.Avatar.Health = _game.Avatar.Health + 15;
            Console.WriteLine("Health: " + _game.Avatar.Health);

        }

        public void GetTalk()
        {
            Console.WriteLine("Hello, I am the fairy and I want to help you. Here take the drink and drink it to improve your health. With the (p) key you can use the trunk at any time. Take care of yourself.");
        }

         public void NoFight()
        {
            Console.WriteLine("You are very dear but make a mistake ... I will eat you ... are you afraid? ... No?! ... Okey I leave you alone, actually I don't want to be angry, but people are always that's why I have to look angry. But you are not like everyone else. Take care.");
        }

        public void DoNothing()
        {
             Console.WriteLine("Your entry is invalid, please enter a valid command.");
        }

        private string ReadInput()
        {
            Console.WriteLine();
            Console.Write("> ");
            var input = Console.ReadLine();
            return input;
        }
    }
}