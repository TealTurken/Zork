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
        private bool IsRunning { get; set; }

        public IOutputService Output { get; set; }

        public IInputService Input { get; set; }

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

            Output.WriteLine("Welcome to Zork!");
            Output.WriteLine(Player.Location);
            
            // --LOOP--
            while(IsRunning)
            {
                if (previousRoom != Player.Location)
                {
                    Output.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Output.Write(">");
                Commands command = ToCommand(Input.ReadLine().Trim());

                switch (command)
                {
                    case Commands.HELP:
                        Output.WriteLine("-Enter NORTH, SOUTH, EAST or WEST to navigate the world.\n-Enter LOOK to examine the area you are in.\n-Enter QUIT to quit the game.\n-Enter SCORE to see your points and REWARD to add 1 point.");
                        Player.Moves++;
                        break;
                    case Commands.QUIT:
                        Output.WriteLine("Thank you for playing!");
                        Player.Moves++;
                        IsRunning = false;
                        break;
                    case Commands.LOOK:
                        Output.WriteLine(Player.Location);
                        Output.WriteLine(Player.Location.Description);
                        Player.Moves++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if (Player.Move(direction) == false) Output.WriteLine("The way is shut!");
                        else Output.WriteLine(Player.Location);
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
        }

        // Invoke the Load method from Program.cs
        public static Game Load(string gameFile, IOutputService output, IInputService input)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFile));
            game.Player = game.World.SpawnPlayer(); // Spawn player after game file has deserialized, hence all required data is now present.
            game.Output = output;
            game.Input = input;
            return game;
        }



        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
