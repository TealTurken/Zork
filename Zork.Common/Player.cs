using System;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;

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
        public int Score;

        [JsonIgnore]
        public int Moves;
        
        private Room mLocation;
    }
}
