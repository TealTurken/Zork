﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Newtonsoft.Json;

namespace Zork.Common
{
    public class Item : IEquatable<Item>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string Description { get; set; }

        [JsonProperty(Order = 3)]
        public bool Takable { get; set; }
        
        [JsonProperty(Order = 4)]
        public bool IsContainer { get; set; }
        
        [JsonProperty(Order = 5)]
        public bool IsOpen { get; set; }

        [JsonProperty(PropertyName = "Storage", Order = 6)]
        private List<string> ItemsNames { get; set; }

        [JsonIgnore]
        public Dictionary<string, Item> Storage { get; private set; } = new Dictionary<string, Item>();

        public void UpdateStorage(World world)
        {
            foreach (var entry in ItemsNames)
            {
                for (int x = 0; x < world.Items.Count; x++)
                {
                    if (entry == world.Items[x].Name.ToString())
                    {
                        Storage.Add(entry, world.Items[x]);
                        break;
                    }
                }
            }
        }

        public static bool operator ==(Item lhs, Item rhs)
        {
            if (ReferenceEquals(lhs, rhs)) return true;

            if (lhs is null || rhs is null) return false;

            return lhs.Name == rhs.Name;
        }

        public static bool operator !=(Item lhs, Item rhs) => !(lhs == rhs);

        public override bool Equals(object obj) => obj is Item item ? this == item : false;

        public bool Equals(Item other) => this == other;

        public override int GetHashCode() => Name.GetHashCode();

        public override string ToString() => Name;
    }
}
