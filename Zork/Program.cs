using System;

namespace Zork
{
    class Program
    {

        private static int LocationColumn = 1;
        private static int LocationRow = 1;
        // private static string location => Rooms[LocationColumn];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!\nEnter HELP for a list of commands.");

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
                        outputString = $"You are at {Rooms[LocationColumn, LocationRow]}";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST: // call on your Move method to determine if inputting a direction command actually succeeds.
                        if (Move(command)) outputString = $"You moved {command}\n{Rooms[LocationColumn, LocationRow]}"; // $...{command} uses the enumeration as part of the string

                        else outputString = "The way is shut!"; // if Move method returns a false, inform the player the path is shut.

                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command) // A "Move" method to move the player, called upon by Main to determine if the player can actually move.
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH when LocationColumn < (Rooms.Length/3) - 1: // Diving by 3 to avoid going outside array's expected range
                    LocationColumn++;
                    didMove = true;
                    break;
                case Commands.SOUTH when LocationColumn > 0:
                    LocationColumn--;
                    didMove = true;
                    break;

                case Commands.EAST when LocationRow < (Rooms.Length/3) - 1:
                    LocationRow++;
                    didMove = true;
                    break;

                case Commands.WEST when LocationRow > 0:
                    LocationRow--;
                    didMove = true;
                    break;
            }
            return didMove;
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;

        private static readonly string[,] Rooms = { // bear in mind this 'map' is upside down (listed as 'Y,X' instead of 'X,Y')
            { "Rocky Trail(0,0)", "south of House(0,1)", "Canyon View(0,2)" },
            { "Forest(1,0)", "West of House(1,1)", "Behind House(1,2)" },
            { "Dense Woods(2,0)", "North of House(2,1)",  "Clearing(2,2)" }
        };
    }
}