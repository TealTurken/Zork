using System;
using Zork.Common;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFile = "World.json";
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
