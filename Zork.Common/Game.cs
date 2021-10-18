﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    public class Game
    {
        // To deserialize the World object in Zork.json, you need a class with a Public Property named World.
        // This will convert JSON data into a Game class instance. The World object has attributes that need to be deserialized as well, so you need a World class to create a World class instance.
        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

        [JsonIgnore]
        private bool IsRunning { get; set; }

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

            Console.WriteLine("Welcome to Zork!");
            Console.WriteLine(Player.Location);
            
            // --LOOP--
            while(IsRunning)
            {
                if (previousRoom != Player.Location)
                {
                    Console.WriteLine(Player.Location.Description);
                    previousRoom = Player.Location;
                }

                Console.Write(">");
                Commands command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {
                    case Commands.HELP:
                        Console.WriteLine("-Enter NORTH, SOUTH, EAST or WEST to navigate the world.\n-Enter LOOK to examine the area you are in.\n-Enter QUIT to quit the game.\n-Enter SCORE to see your points and REWARD to add 1 point.");
                        Player.Moves++;
                        break;
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        Player.Moves++;
                        IsRunning = false;
                        break;
                    case Commands.LOOK:
                        Console.WriteLine(Player.Location);
                        Console.WriteLine(Player.Location.Description);
                        Player.Moves++;
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        Directions direction = (Directions)command;
                        if (Player.Move(direction) == false) Console.WriteLine("The way is shut!");
                        else Console.WriteLine(Player.Location);
                        Player.Moves++;
                        break;

                    case Commands.REWARD:
                        Console.WriteLine("+1 SCORE added.");
                        Player.Score++;
                        Player.Moves++;
                        break;

                    case Commands.SCORE:
                        Player.Moves++;
                        Console.WriteLine($"Your score is {Player.Score} points in {Player.Moves} move(s).");
                        break;

                    default:
                        Console.WriteLine("Unrecognized command.");
                        break;
                }
            }
        }

        // Invoke the Load method from Program.cs
        public static Game Load(string fileName)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(fileName));
            game.Player = game.World.SpawnPlayer(); // Spawn player after game file has deserialized, hence all required data is now present.
            return game;
        }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}