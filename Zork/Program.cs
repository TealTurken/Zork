using System;

namespace Zork 
{
    class Program 
    {
        private static (int Column, int Row) Location = (1, 1);
        public static Room currentRoom // NEW combines data of Tuple into one simple variable for OOP.
        {
            get
            {
                return Rooms[Location.Column, Location.Row]; // pull data from Rooms array
            }
        }

        static void Main (string[] args) 
        {
            
            Console.WriteLine ("Welcome to Zork!\nEnter HELP for a list of commands.");
            InitializeRoomDescriptions(); // NEW call this function to ACTUALLY set the room descriptions!

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison
            while (command != Commands.QUIT) 
            {
                Console.WriteLine (">");
                string inputString = Console.ReadLine ();

                command = ToCommand (inputString.Trim ());

                string outputString;
                switch (command) {
                    case Commands.HELP:
                        outputString = "-Enter NORTH, SOUTH, EAST or WEST to navigate the world.\n-Enter LOOK to examine the area you are in. Coordinates are listed Y,X.\n-Enter QUIT to quit the game.";
                        break;
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = $"You are at {currentRoom}\n{currentRoom.Description}";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST: // call on your Move method to determine if inputting a direction command actually succeeds.
                        if (Move (command)) outputString = $"You moved {command}\n{currentRoom}"; // $...{command} uses the enumeration as part of the string

                        else outputString = "The way is shut!"; // if Move method returns a false, inform the player the path is shut.

                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }

                Console.WriteLine (outputString);
            }
        }

        private static bool Move (Commands command) // A "Move" method to move the player, called upon by Main to determine if the player can actually move.
        {
            bool didMove = false;

            switch (command) {
                case Commands.NORTH when Location.Column < (Rooms.Length / 3) - 1: // Diving by 3 to avoid going outside array's expected range
                    Location.Column++;
                    didMove = true;
                    break;
                case Commands.SOUTH when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;

                case Commands.EAST when Location.Row < (Rooms.Length / 3) - 1:
                    Location.Row++;
                    didMove = true;
                    break;

                case Commands.WEST when Location.Row > 0:
                    Location.Row--;
                    didMove = true;
                    break;
            }
            return didMove;
        }
        private static Commands ToCommand (string commandString) => Enum.TryParse<Commands> (commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        
        // private static readonly string changed to => private static readonly Room
        private static readonly Room[, ] Rooms = { // this 'map' is upside down (listed as 'Y,X' instead of 'X,Y')
            { new Room("Rocky Trail(0,0)"), new Room("south of House(0,1)"), new Room("Canyon View(0,2)") },
            { new Room("Forest(1,0)"), new Room("West of House(1,1)"), new Room("Behind House(1,2)") },
            { new Room("Dense Woods(2,0)"), new Room("North of House(2,1)"), new Room("Clearing(2,2)") }
        };

        private static void InitializeRoomDescriptions() /* NEW function to set room descriptions.
                                                            This is hard-coded currently and "smells", change later.
                                                          */ 
        {
            Rooms[0, 0].Description = "You are on a rocky trail.";
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            Rooms[0, 2].Description = "You are at the top of the great canyon on its south wall.";

            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";
            Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";

            Rooms[2, 0].Description = "This is a dimly lit forest, with large trees al around.\nTo the east, there appears to be sunlight.";
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
        }
    }
}