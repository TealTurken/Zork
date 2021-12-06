using System;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace Zork.Common
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<bool> RunningGame;

        // To deserialize the World object in Zork.json, you need a class with a Public Property named World.
        // This will convert JSON data into a Game class instance. The World object has attributes that need to be deserialized as well, so you need a World class to create a World class instance.
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning
        {
            get
            {
                return mIsRunning;
            }
            set
            {
                if (mIsRunning != value)
                {
                    mIsRunning = value;
                    RunningGame?.Invoke(this, mIsRunning);
                }
            }
        }
        private bool mIsRunning;

        public IOutputService Output { get; set; }

        public IInputService Input { get; set; }

        [JsonIgnore]
        public Dictionary<string, Command> Commands { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Command("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "REWARD", new Command("REWARD", new string[] { "REWARD", "R", "ADD" }, Reward) },
                { "SCORE", new Command("SCORE", new string[] { "SCORE", "POINTS", "P" }, Score) },
                { "NORTH", new Command("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.NORTH)) },
                { "SOUTH", new Command("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.SOUTH)) },
                { "EAST", new Command("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.EAST)) },
                { "WEST", new Command("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.WEST)) },
            };
        }

        public Room previousRoom = null;

        public static Game LoadFromFile(string jsonGameString)
        {
            return Load(File.ReadAllText(jsonGameString));
        }

        public static Game Load(string gameFile)
        {
            Game game = JsonConvert.DeserializeObject<Game>(gameFile);
            game.Player = game.World.SpawnPlayer(); // Spawn player after game file has deserialized, hence all required data is now present.
            return game;
        }

        public void Start(IOutputService output, IInputService input)
        {
            Output = output;
            Input = input;
            Input.InputReceived += InputReceivedHandler;
            IsRunning = true;

            Output.WriteLine("Welcome to Zork!");
            Output.WriteLine(Player.Location.ToString());
        }

        private void InputReceivedHandler(object sender, string input)
        {
            // Search for a command by it's list of Verbs
            Command foundCommand = null;
            foreach (Command command in Commands.Values)
            {
                if (command.Verbs.Contains(input))
                {
                    foundCommand = command;
                    break;
                }
            }
            // if you found a Verb, execute the command's assigned Action.
            if (foundCommand != null) foundCommand.Action(this);
            else Output.WriteLine("Unknown command.");
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false) game.Output.WriteLine("The way is shut!");
            
            if (game.previousRoom != game.Player.Location)
            {
                game.Output.WriteLine(game.Player.Location.ToString());
                game.Output.WriteLine(game.Player.Location.Description);
                game.previousRoom = game.Player.Location;
            }
                game.Player.Moves++;
        }

        private static void Look(Game game)
        {
            game.Output.WriteLine(game.Player.Location.ToString());
            game.Output.WriteLine(game.Player.Location.Description);
            if (game.Player.Location.Items.Count != 0)
            {
                foreach (var item in game.Player.Location.Items)
                {
                    game.Output.WriteLine($"There is a {item.Key}");
                }
            }
            game.Player.Moves++;
        }

        private static void Quit(Game game)
        {
            game.Output.Write("Thank you for playing!");
            game.IsRunning = false;
        }

        private static void Reward(Game game)
        {
            game.Player.Score++;
            game.Output.WriteLine("Score increased by 1");
        }

        private static void Score(Game game)
        {
            game.Output.WriteLine($"Your score is {game.Player.Score} points in {game.Player.Moves} moves.");
        }
    }
}
