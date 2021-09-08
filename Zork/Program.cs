using System;

namespace Zork
{
    class Program
    {

        private static int LocationColumn = 0; // current "Room"
        // private static string location => Rooms[LocationColumn];
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison
            while (command != Commands.QUIT)
            {
                Console.WriteLine(">");
                string inputString = Console.ReadLine();

                command = ToCommand(inputString.Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = $"You are at {Rooms [LocationColumn]}";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST: // call on your Move method to determine if inputting a direction command actually succeeds.
                        if (Move(command)) outputString = $"You moved {command}\n{Rooms [LocationColumn]}"; // $...{command} uses the enumeration as part of the string

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
                case Commands.NORTH:
                case Commands.SOUTH:
                    break;

                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                LocationColumn++;
                didMove = true;
                    break;

                case Commands.WEST when LocationColumn > 0:
                LocationColumn--;
                didMove = true;
                    break;
            }
            return didMove;
        }
        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        
        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" }; // You want this available outside Main, hence outside Main as private static
    }
}
