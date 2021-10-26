using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Zork.Common
// Room class accessed via object-oriented programming
{

    public class Room : IEquatable<Room>
    {
        [JsonProperty(Order = 1)]
        public string Name { get; private set; } // allows outside programs to read this data

        [JsonProperty(Order = 2)]
        public string Description { get; private set; } // set allows outside program to write to this data. Assign name.

        // should be mapped to the JSON attribute name "Neighbors". In this way, we can provide alternative names to map between JSON objects/attributes and C# data types. 
        [JsonProperty(PropertyName = "Neighbors", Order = 3)]
        private Dictionary<Directions, string> NeighborNames { get; set; }

        // This asks if there is a neighbor to the current room in the asked direction.
        [JsonIgnore]
        public IReadOnlyDictionary<Directions, Room> Neighbors { get; private set; }

        public static bool operator ==(Room lhs, Room rhs)
        {
            if (ReferenceEquals(lhs, rhs)) return true;

            if (lhs is null || rhs is null) return false;

            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Room lhs, Room rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Room room ? this == room : false;

        public bool Equals(Room other) => this == other;

        public override string ToString() => Name;
        public override int GetHashCode() => Name.GetHashCode();

        public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
                                                                 let room = world.RoomsByName.GetValueOrDefault(entry.Value)
                                                                 where room != null
                                                                 select (Direction: entry.Key, Room: room))
                                                                 .ToDictionary(pair => pair.Direction, pair => pair.Room);
    }
}