﻿using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using Zork.Common;

namespace Zork.Builder.ViewModels
{
    internal class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public bool GameIsLoaded { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game game
        {
            get => _game; // This line needed for the save function in RoomsForm.cs
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
        public void SaveGame(string filename)
        {
            if (!GameIsLoaded)
            {
                throw new InvalidOperationException("No game loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}
