using System;
using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork.Common
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // To deserialize the World object in Zork.json, you need a class with a Public Property named World.
        // This will convert JSON data into a Game class instance. The World object has attributes that need to be deserialized as well, so you need a World class to create a World class instance.
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        public IOutputService Output { get; set; }

        public IInputService Input { get; set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;
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
        }

        private void InputReceivedHandler(object sender, string input)
        {
            Commands command = ToCommand(input);

            switch (command)
            {
                case Commands.HELP:
                    Output.WriteLine("-Enter NORTH, SOUTH, EAST or WEST to navigate the world.\n-Enter LOOK to examine the area you are in.\n-Enter QUIT to quit the game.\n-Enter SCORE to see your points and REWARD to add 1 point.");
                    Player.Moves++;
                    break;
                case Commands.QUIT:
                    Player.Moves++;
                    IsRunning = false;
                    break;
                case Commands.LOOK:
                    Output.WriteLine(Player.Location.ToString());
                    Output.WriteLine(Player.Location.Description);
                    Player.Moves++;
                    break;

                case Commands.NORTH:
                case Commands.SOUTH:
                case Commands.EAST:
                case Commands.WEST:
                    Directions direction = (Directions)command;
                    if (Player.Move(direction) == false) Output.WriteLine("The way is shut!");
                    else Output.WriteLine(Player.Location.ToString());
                    Player.Moves++;
                    break;

                case Commands.REWARD:
                    Output.WriteLine("+1 SCORE added.");
                    Player.Score++;
                    Player.Moves++;
                    break;

                case Commands.SCORE:
                    Player.Moves++;
                    Output.WriteLine($"Your score is {Player.Score} points in {Player.Moves} move(s).");
                    break;

                default:
                    Output.WriteLine("Unrecognized command.");
                    break;
            }
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
