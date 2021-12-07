using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;
        public event EventHandler<int> MovesChanged;
        public event EventHandler<int> ScoreChanged;
        

        public World World { get; }

        [JsonIgnore]
        public Room Location 
        { 
            get
            { 
               return mLocation;
            }
            private set
            {
                if (mLocation != value)
                {
                    mLocation = value;
                    LocationChanged?.Invoke(this, mLocation);
                }
            }
        }
        [JsonIgnore]
        public string LocationName
        {
            get
            {
                // ?. null-conditional operator, only returns property if is not null.
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string StartingLocation)
        {
            World = world;
            LocationName = StartingLocation;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if (isValidMove) Location = destination;

            return isValidMove;
        }

        [JsonIgnore]
        public int Moves
        {
            get
            {
                return mMoves;
            }
            set
            {
                if (mMoves != value)
                {
                    mMoves = value;
                    MovesChanged?.Invoke(this, mMoves);
                }
            }
        }

        [JsonIgnore]
        public int Score
        {
            get
            {
                return mScore;
            }
            set
            {
                if (mScore != value)
                {
                    mScore = value;
                    ScoreChanged?.Invoke(this, mScore);
                }
            }
        }

        public int ItemCap = 2;

        public Dictionary<string, Item> Items { get; private set; } = new Dictionary<string, Item>();

        private Room mLocation;
        private int mScore;
        private int mMoves;
    }
}
