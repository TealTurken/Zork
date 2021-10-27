using System;
using System.ComponentModel;
using Zork.Common;

namespace ZorkBuilder.Forms
{
    internal class WorldViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public BindingList<Room> Rooms { get; set; }

        public World World { get; set; }
        
    }
}
