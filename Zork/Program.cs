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
            Game game = Game.Load(gameFile, output, input);
            game.Run();
        }
        private enum CommandLineArguments
        {
            gameFile = 0
        }
    }
}
