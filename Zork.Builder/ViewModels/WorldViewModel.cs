using System.ComponentModel;
using Zork.Common;

namespace Zork.Builder
{
    internal class WorldViewModel : INotifyPropertyChanged

    {
            public event PropertyChangedEventHandler PropertyChanged;

            public BindingList<Room> Rooms { get; set; }

            public World World { get; set; }

        }
    }
