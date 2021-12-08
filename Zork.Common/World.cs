using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Zork.Common
{
    public class World : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Room> Rooms { get; set; }

        public List<Item> Items { get; set; }

        // Expose the dictionary of rooms publicly created on line 25
        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName => mRoomsByName;

        [JsonIgnore]
        public Dictionary<string, Item> ItemsByName => mItemsByName;

        public Player SpawnPlayer() => new Player(this, StartingLocation);
        
        // --CREATE DICTIONARY OF ALL ROOMS AFTER DESERIALIZING--
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            mItemsByName = Items.ToDictionary(item => item.Name, item => item);

            // .ToDictionary is an extension method, converts the new Room collection into a Dictionary.
            // The key is the room's Name property and the value is the Room instance.
            mRoomsByName = Rooms.ToDictionary(room => room.Name, room => room);

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this); // calls UpdateNeighbors function from Room class, line 44
                room.UpdateItems(this);
            }
            foreach (Item item in Items)
            {
                item.UpdateStorage(this);
            }


        }

        // JSON.Net only attempts to deserialize JSON attributes into public properties and fields of C# classes. We don't always want some data outside classes, so we make StartingLocation private.
        [JsonProperty]
        private string StartingLocation { get; set; }

        private Dictionary<string, Room> mRoomsByName;

        private Dictionary<string, Item> mItemsByName;
    }
}
