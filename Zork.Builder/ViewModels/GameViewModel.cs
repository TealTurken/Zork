using System;
using System.ComponentModel;
using Zork.Common;

namespace Zork.Builder.ViewModels
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool GameIsLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game game 
        { 
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
                }

        private Game _game;
    }
}
