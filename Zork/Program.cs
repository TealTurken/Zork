using System;
using Zork.Common;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFile = "Zork.json";
            string gameFile = (args.Length > 0 ? args[(int)CommandLineArguments.gameFile] : defaultGameFile);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();
            Game game = Game.LoadFromFile(gameFile);

            output.WriteLine("Welcome to Zork!");
            game.Start(output, input);
            output.WriteLine(game.Player.Location.ToString());

            while (game.IsRunning)
            {
                if (game.previousRoom != game.Player.Location)
                {
                    output.WriteLine(game.Player.Location.Description);
                    game.previousRoom = game.Player.Location;
                }

                output.Write(">");
                input.ProcessInput();
                
            }

            output.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            gameFile = 0
        }
    }
}
