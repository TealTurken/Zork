using System;
using System.Collections.Generic;
using System.IO;

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

            const string defaultRoomsFile = "Rooms.txt"; // specify which file to pass for getting room data.
            string roomsFile = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFile); // potentially remove later
            //string roomsFile = Console.ReadLine();
            InitializeRoomDescriptions(roomsFile); // pass a file into
            Room previousRoom = currentRoom;
            Console.WriteLine("Welcome to Zork!\nEnter HELP for a list of commands.");

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison
            while (command != Commands.QUIT)
            {
                Console.Write(">");
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
                case Commands.NORTH when Location.Column < roomNames.GetLength(0) - 1: // Diving by 3 to avoid going outside array's expected range
                    Location.Column++;
                    didMove = true;
                    break;
                case Commands.SOUTH when Location.Column > 0:
                    Location.Column--;
                    didMove = true;
                    break;

                case Commands.EAST when Location.Row < roomNames.GetLength(1) - 1:
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

        private static void InitializeRoomDescriptions(string roomDescriptionsFile)
        /* Changed hard code variant over to an associative array. Now associates keys to values (names of rooms in this case).
           Requires 'using System.Collections.Generic' to function. */
        {
            var roomMap = new Dictionary<string, Room>();
            foreach (Room room in roomNames)
            {
                roomMap[room.Name] = room;
            }

            string[] lines = File.ReadAllLines(roomDescriptionsFile); // requires using System.IO. Recieves an array.
            foreach (string line in lines)
            {
                const string delimiter = "##";
                const int expectedFieldCount = 2; // expect to see 2 fields (name and description)

                string[] fields = line.Split(delimiter); //splits at delimiter. Names assigned to [0], descriptions [1]

                if (fields.Length != expectedFieldCount) throw new InvalidDataException("Invalid room");

                (string name, string description) = (fields[0], fields[1]); // touple for assignment per line
                roomMap[name].Description = description; // assigning description pulled from file to room
            }
        }

            private enum CommandLineArguments
        {
            RoomsFilename = 0
        }

        }
}
