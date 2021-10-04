using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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

            const string defaultRoomsFile = "Rooms.json"; // specify which file to pass for getting room data.
            string roomsFile = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFile); // potentially remove later
            InitializeRooms(roomsFile); // pass a file into

            Room previousRoom = currentRoom;
            // --GAME START--
            Console.WriteLine("Welcome to Zork!\nEnter HELP for a list of commands.");

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison

            // --MAIN GAME LOOP--
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
                    case Commands.WEST:
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

        // --MOVEMENT METHOD--
        //  Determines whether or not the player can actually move and performs appropriate action if they can
        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when Location.Column < roomNames.GetLength(0) - 1:
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
        // --PLAYER COMMAND PARSING--
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static Room[,] roomNames = { // this 'map' is upside down (listed as 'Y,X' instead of 'X,Y')
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        // --ROOM INITIALIZATION--
        private static void InitializeRooms(string roomsFile) => roomNames = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFile));

            private enum CommandLineArguments
        {
            RoomsFilename = 0
        }

        }
}
