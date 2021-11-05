using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Common;

namespace Zork.Builder
{
    public partial class RoomsWindow : Form
    {
        private bool IsGameLoaded
        {
            // This enables/disables controls relevant to whether the Game file is loaded or not.
            get
            {
                return _viewModel.GameIsLoaded;
            }
            set
            {
                _viewModel.GameIsLoaded = value;
                // add/remove options from _gameDependentControls to easily enable/disable controls.
                foreach (var control in _gameDependentControls)
                {
                    control.Enabled = _viewModel.GameIsLoaded;
                }
                foreach (var menuControl in _gameDependentMenuItems)
                {
                    menuControl.Enabled = _viewModel.GameIsLoaded;
                }
            }
        }

        internal GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }
        public RoomsWindow()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();

            _gameDependentControls = new Control[]
            {
                addRoomButton,
                deleteRoomButton,
                roomNameText,
                roomDescriptionTextBox,
                roomPropertiesTabs,
            };
            _gameDependentMenuItems = new ToolStripMenuItem[]
            {
                menuSaveAsButton,
                menuSaveButton,
                menuCloseButton,
            };
            
            IsGameLoaded = false;
        }


        private GameViewModel _viewModel;
        private Control[] _gameDependentControls;
        private ToolStripMenuItem[] _gameDependentMenuItems;

        private void RoomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsList.SelectedItem != null;
        }
        #region Game Dependent Controls
        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", "Zork Builder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomsList.SelectedItem);
                roomsList.SelectedItem = ViewModel.Rooms.LastOrDefault();
            }
        }
        int newRoomCount = 0;
        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            if (newRoomCount == 0) room.Name = "new room";
            else room.Name = $"new room {newRoomCount}";
            ViewModel.Rooms.Add(room);
            roomsList.SelectedItem = ViewModel.Rooms.LastOrDefault();
            newRoomCount++;
        }

        public string RoomName
        {
            get => roomNameText.Text;
            set => roomNameText.Text = value;
        }

        string originalRoomName;
        public void RoomNameText_Enter(object sender, EventArgs e)
        {
            originalRoomName = roomsList.SelectedItem.ToString();
        }
        private void RoomNameText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomNameText.Text))
            {
                MessageBox.Show("Name cannot be left blank");
                roomNameText.Text = originalRoomName;
            }
        }
        #endregion game dependent controls
        #region Tool Strip Menu
        private void MenuNewButton_Click(object sender, EventArgs e)
        {
            // KNOWN ISSUE: Neighbors comes back Null and cannot reopen file after closing.
            // Create a new series of classes and lists for the brand new file
            World NewWorld = new World();
            NewWorld.Rooms = new List<Room>(Array.Empty<Room>());
            string newStart = "New Room";
            Player NewPlayer = new Player(NewWorld, newStart);
            Game NewGame = new Game(NewWorld, NewPlayer);

            // Once you've constructed all you need for a Game class, pass it into the view model.
            ViewModel.Game = NewGame;

            IsGameLoaded = true;
        }

        private void MenuSaveButton_Click(object sender, EventArgs e)
        {
            string filename = "Save Test Game.json";
            ViewModel.SaveGame(filename);
        }

        private void MenuSaveAsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.SaveGame(saveFileDialog.FileName);
            }    
        }
        private void MenuOpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    {
                        string jsonString = File.ReadAllText(openFileDialog.FileName);
                        ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                        IsGameLoaded = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void CloseMenuButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this game file?", "Zork Builder", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                ViewModel.Game = null;
                IsGameLoaded = false;
            }
        }
        private void MenuExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion tool strip menu


    }
}
