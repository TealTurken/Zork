using System;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {
        private static (int Column, int Row) Location = (1, 1);
        public static Room currentRoom // getting specific Room class instance data
        {
            get
            {
                return roomNames[Location.Column, Location.Row]; // pull data from Rooms array
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Zork!\nEnter HELP for a list of commands.");
            InitializeRoomDescriptions(); // call this function to ACTUALLY set the room descriptions!
            Room previousRoom = currentRoom;

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison
            while (command != Commands.QUIT)
            {
                Console.WriteLine(">");
                string inputString = Console.ReadLine();

                command = ToCommand(inputString.Trim());

                string outputString;
                switch (command)
                {
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
                        if (Move(command)) outputString = $"You moved {command} to {currentRoom}"; // $...{command} uses the enumeration as part of the string

                        else outputString = "The way is shut!"; // if Move method returns a false, inform the player the path is shut.

                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }
                Console.WriteLine(outputString);
                if (previousRoom != currentRoom)
                {
                    previousRoom = currentRoom;
                    Console.WriteLine(currentRoom.Description);
                }
            }
        }

        private static bool Move(Commands command) // A "Move" method to move the player, called upon by Main to determine if the player can actually move.
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when Location.Column < (roomNames.Length / 3) - 1: // Diving by 3 to avoid going outside array's expected range
                    Location.Column++;
                    didMove = true;
                    break;
                case Commands.SOUTH when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;

                case Commands.EAST when Location.Row < (roomNames.Length / 3) - 1:
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
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static readonly Room[,] roomNames = { // this 'map' is upside down (listed as 'Y,X' instead of 'X,Y')
            { new Room("Rocky Trail(0,0)"), new Room("South of House(0,1)"), new Room("Canyon View(0,2)") },
            { new Room("Forest(1,0)"), new Room("West of House(1,1)"), new Room("Behind House(1,2)") },
            { new Room("Dense Woods(2,0)"), new Room("North of House(2,1)"), new Room("Clearing(2,2)") }
        };

        private static void InitializeRoomDescriptions() /* Changed hard code variant over to an associative array. Now associates keys to values (names of rooms in this case).
                                                            Requires 'using System.Collections.Generic' to function. */
        {
            var roomMap = new Dictionary<string, Room>(); // NEW
            foreach (Room room in roomNames)
            {
                roomMap[room.Name] = room; // NEW adds all your room names into the dictionary. The name of the room is the key and creates an entry of the reference of the Room object.
            }                              // An alternative to this string of code would be: roomMap.Add(room.Name, room);

            roomMap["Rocky Trail(0,0)"].Description = "You are on a rocky trail.";
            roomMap["South of House(0,1)"].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Canyon View(0,2)"].Description = "You are at the top of the great canyon on its south wall.";

            roomMap["Forest(1,0)"].Description = "This is a forest, with trees in all directions around you.";
            roomMap["West of House(1,1)"].Description = "This is an open field west of a white house, with a boarded front door.";
            roomMap["Behind House(1,2)"].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";

            roomMap["Dense Woods(2,0)"].Description = "This is a dimly lit forest, with large trees al around.\nTo the east, there appears to be sunlight.";
            roomMap["North of House(2,1)"].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";
            roomMap["Clearing(2,2)"].Description = "You are in a clearing, with a forest surrounding you on the west and south.";
        }
    }
}