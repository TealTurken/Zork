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
            game.Start(output, input);

            while (game.IsRunning)
            {
                output.Write(">");
                input.ProcessInput();
            }
        }

        private enum CommandLineArguments
        {
            gameFile = 0
        }
    }
}
