using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFile = "Zork.json";
            string gameFile = (args.Length > 0 ? args[(int)CommandLineArguments.gameFile] : defaultGameFile);

            Game game = Game.Load(gameFile);
            game.Run();
        }
        private enum CommandLineArguments
        {
            gameFile = 0
        }
    }
}
