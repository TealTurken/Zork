using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class World
    {
        // A Hashset is like a dictionary of keys with no values. The keys here are Room objects.
        // Hashset constrains the collection so that it won't allow more than 1 room of the same name. 
        // This is fully accomplished by overriding the GetHashValue method in the Room class, Room.cs line 40
        public List<Room> Rooms { get; set; }

        // Expose the dictionary of rooms publicly created on line 21
        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);
        
        // --CREATE DICTIONARY OF ALL ROOMS AFTER DESERIALIZING--
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            // .ToDictionary is an extension method, converts the new Room collection into a Dictionary.
            // The key is the room's Name property and the value is the Room instance.
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this); // calls UpdateNeighbors function from Room class, line 44
            }
        }

        // JSON.Net only attempts to deserialize JSON attributes into public properties and fields of C# classes. We don't always want some data outside classes, so we make StartingLocation private.
        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

    }
}
