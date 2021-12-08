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
                { "HELP", new Command("HELP", new string[] { "HELP" }, Help) },
                { "REWARD", new Command("REWARD", new string[] { "REWARD", "R", "ADD" }, Reward) },
                { "SCORE", new Command("SCORE", new string[] { "SCORE", "POINTS", "P" }, Score) },
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "CLEAR", new Command("CLEAR", new string[] { "CLEAR" }, Clear) },
                { "LOOK", new Command("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Command("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.NORTH)) },
                { "SOUTH", new Command("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.SOUTH)) },
                { "EAST", new Command("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.EAST)) },
                { "WEST", new Command("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.WEST)) },
                { "TAKE", new Command("TAKE", new string[] { "TAKE" }, Take) },
                { "DROP", new Command("DROP", new string[] { "DROP" }, Drop) },
                { "INVENTORY", new Command("INVENTORY", new string[] { "INVENTORY", "I" }, Inventory) },
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
            game.previousRoom = game.Player.Location;
            return game;
        }

        public void Start(IOutputService output, IInputService input)
        {
            Output = output;
            Input = input;
            Input.InputReceived += InputReceivedHandler;
            IsRunning = true;

            Output.WriteLine("Welcome to Zork!\n");
            Output.WriteLine(Player.Location.ToString());
            Output.WriteLine(Player.Location.Description);
            Output.WriteLine("");
            if (Player.Location.Items.Count != 0)
            {
                Output.WriteLine($"Strewn around you can see;");
                foreach (var item in Player.Location.Items)
                {
                    Output.WriteLine($"a {item.Key}");
                    if (item.Key == "Mat") Output.Write(" that says 'Look at me!'");
                }
                Output.WriteLine("\nEnter HELP to see a list of commands and verbs.");
            }
        }

        public string[] inputString;
        public const char delimiter = ' ';
        private void InputReceivedHandler(object sender, string input)
        {
            inputString = null;
            inputString = input.Split(delimiter);
            // Search for a command by it's list of Verbs
            Command foundCommand = null;
            foreach (Command command in Commands.Values)
            {
                if (command.Verbs.Contains(inputString[0]))
                {
                    foundCommand = command;
                    break;
                }
            }
            // if you found a Verb, execute the command's assigned Action.
            if (foundCommand != null) foundCommand.Action(this);
            else Output.WriteLine("Unknown command.");
        }

        #region Command functions
        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false) game.Output.WriteLine("The way is shut!");
            
            if (game.previousRoom != game.Player.Location)
            {
                Look(game);
                game.previousRoom = game.Player.Location;
            }
        }

        private static void Look(Game game)
        {
            string[] command = game.inputString;

            // Normal LOOK command
            if (command.Length == 1)
            {
                game.Output.WriteLine(game.Player.Location.ToString());
                game.Output.WriteLine(game.Player.Location.Description);
                game.Output.WriteLine("");
                if (game.Player.Location.Items.Count != 0)
                {
                    game.Output.WriteLine("Strewn around you can see;");
                    foreach (var item in game.Player.Location.Items)
                    {
                        game.Output.WriteLine($"a {item.Key}");
                    }
                    game.Output.WriteLine("");
                }
            }

            // LOOK AT command
            else if (command.Length > 1)
            {
                bool NoMatch = false;
                if (command[1] == "AT")
                {
                    if (command.Length <= 2)
                    {
                        game.Output.WriteLine("Enter the name of the item you want to look at.");
                        return;
                    }
                    // Search room for the item 1st
                    bool foundItem = false;
                    foreach (var item in game.Player.Location.Items)
                    {
                        NoMatch = false;
                        if (command[2].Contains(item.Key.ToString().ToUpper()))
                        {
                            foundItem = true;
                            game.Output.WriteLine($"{item.Value.Description}");
                            break;
                        }
                        else NoMatch = true;
                    }
                    // Search player's inventory for item 2nd, if it was not found in the room
                    if (foundItem == false)
                    {
                        foreach (var item in game.Player.Items)
                        {
                            NoMatch = false;
                            if (command[2].Contains(item.Key.ToString().ToUpper()))
                            {
                                game.Output.WriteLine($"{item.Value.Description}");
                                break;
                            }
                            else NoMatch = true;
                        }
                    }
                    if (NoMatch == true) game.Output.WriteLine("Enter a valid item name.");
                }
                else
                {
                    game.Output.WriteLine("'Look' or 'Look at [item name]' are valid loom commands.");
                    return;
                }
            }
            game.Player.Moves++;
        }

        private static void Inventory(Game game)
        {
            if (game.Player.Items.Count >= 1)
                {
                    game.Output.WriteLine("You are carrying;");
                    foreach (var item in game.Player.Items)
                    {
                        game.Output.WriteLine($"{item.Key}");
                    }
                    game.Output.WriteLine("");
            }
            else game.Output.WriteLine("You have nothing in your inventory.");

            game.Player.Moves++;
        }

        private static void Take(Game game)
        {
            string[] command = game.inputString;
            bool NoMatch = false;

            if (command.Length == 1) game.Output.WriteLine("Enter the name of the item you want to take.");

            else if (command.Length > 1)
            {
                game.Player.Moves++;
                if (game.Player.Items.Count >= game.Player.ItemCap) game.Output.WriteLine("You can't carry anymore items!");
                else
                { 
                    // Grab each item in the current room and check if it matches the item searched for.
                    foreach (var item in game.Player.Location.Items)
                    {
                        // If the item was found to be in the room, check if it can be taken
                        if (command[1].Contains(item.Key.ToString().ToUpper()))
                        {
                            if (item.Value.Takable == false)
                            {
                                game.Output.WriteLine("You can't take this!");
                                return;
                            }

                            NoMatch = false;
                            // iterate through the world's list of items to get the proper
                            // matching item to add to the Player's inventory.
                            for (int x = 0; x < game.World.Items.Count; x++)
                            {
                                if (command[1] == game.World.Items[x].Name.ToString().ToUpper())
                                {
                                    game.Player.Items.Add(item.Key, item.Value);
                                    break;
                                }
                            }
                            // then remove the item from the Room's items' list and output response.
                            game.Player.Location.Items.Remove(item.Key);
                            game.Output.WriteLine($"You took the {item.Key}");
                            break;
                        }
                        else NoMatch = true;
                    }
                    if (NoMatch == true)
                    {
                        game.Output.WriteLine("That item does not exist!");
                    }
                }
            }
        }

        private static void Drop(Game game)
        {
            string[] command = game.inputString;
            bool NoMatch = false;

            if (command.Length == 1) game.Output.WriteLine("Enter the name of the item you want to drop.");

            else if (command.Length > 1)
            {
                game.Player.Moves++;
                if (game.Player.Items.Count > 0)
                {
                    foreach (var item in game.Player.Items)
                    {
                        if (command[1].Contains(item.Key.ToString().ToUpper()))
                        {
                            NoMatch = false;
                            for (int x = 0; x < game.World.Items.Count; x++)
                            {
                                if (command[1] == game.World.Items[x].Name.ToString().ToUpper())
                                {
                                    game.Player.Items.Remove(item.Key);
                                    break;
                                }
                            }
                            game.Player.Location.Items.Add(item.Key, item.Value);
                            game.Output.WriteLine($"You dropped the {item.Key}");
                            break;
                        }
                        else NoMatch = true;
                    }
                    if (NoMatch == true)
                    {
                        game.Output.WriteLine("You have no such item!");
                    }
                }
                else game.Output.WriteLine("You have no items to drop!");
            }
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

        private static void Clear(Game game)
        {
            game.Output.Clear();
        }

        private static void Help(Game game)
        {
            foreach (var command in game.Commands)
            {
            if (command.Key == "HELP") continue;
            game.Output.WriteLine($"--For {command.Key}--");
                for (var x = 0; x < command.Value.Verbs.Length; x++)
                {
                    game.Output.Write($" '{command.Value.Verbs[x]}'");
                }
                if (command.Key == "LOOK")
                {
                    game.Output.WriteLine(" 'LOOK AT [item name]'\n");
                }
                else game.Output.WriteLine("\n");
            }
        }
        #endregion command functions
    }
}
