﻿using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();

            Commands command = ToCommand(inputString.Trim());
            Console.WriteLine(command);
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }
}