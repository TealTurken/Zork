using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
        }


        // --MAIN GAME--
        public void Run()
        {
            IsRunning = true;
            Room previousRoom = null;

            Console.WriteLine("Welcome to Zork!");
            Console.WriteLine(Player.Location);
            
            // --LOOP--
            while(IsRunning)
            {
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write(">");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.HELP:
                        Console.WriteLine("-Enter NORTH, SOUTH, EAST or WEST to navigate the world.\n-Enter LOOK to examine the area you are in.\n-Enter QUIT to quit the game.");
                        break;
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        IsRunning = false;
                        break;
                    case Commands.LOOK:
                        Console.WriteLine(Player.Location);
                        Console.WriteLine(Player.Location.Description);
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                        if (Player.Move(direction) == false) Console.WriteLine("The way is shut!");
                        else Console.WriteLine(Player.Location);
                        break;

                    default:
                        Console.WriteLine("Unrecognized command.");
                        break;
                }
            }
        }

        public static Game Load(string fileName)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(fileName));
            game.Player = game.World.SpawnPlayer();
            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
