using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN; // assign command a value so it can run the initial comparison
            while (command != Commands.QUIT)
            {
                string inputString = Console.ReadLine();

                command = ToCommand(inputString.Trim());

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing.";
                        break;
                    case Commands.LOOK:
                        outputString = "This is an open field of a white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        outputString = $"You moved {command}"; // $...{command} uses the enumeration as part of the string 
                        break;

                    default:
                        outputString = "Unrecognized command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }
}
