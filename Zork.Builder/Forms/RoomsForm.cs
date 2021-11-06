using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Common;
using Zork.Builder.UserControls;

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
            mNeighborsControlMap = new Dictionary<Directions, NeighborsControl>
            {
                { Directions.NORTH, neighborsNorthControl },
                { Directions.SOUTH, neighborsSouthControl },
                { Directions.EAST, neighborsEastControl },
                { Directions.WEST, neighborsWestControl }
            };
            
            IsGameLoaded = false;
        }


        private GameViewModel _viewModel;
        private Control[] _gameDependentControls;
        private ToolStripMenuItem[] _gameDependentMenuItems;
        private readonly Dictionary<Directions, NeighborsControl> mNeighborsControlMap;

        private void RoomsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsList.SelectedItem != null;

            Room selectedRoom = roomsList.SelectedItem as Room;
            foreach (var control in mNeighborsControlMap.Values)
            {
                control.SelectedRoom = selectedRoom;
            }
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

        string originalRoomName = null;
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
            else
            {
                // Current room's name must NOT reflect it's live adapted name on the View Model
                // in order to apply, so capture the new name and assign a temporary one.
                string newRoomName = roomNameText.Text;
                roomNameText.Text = "VALIDATING";

                bool roomExists = false;
                foreach (Room room in ViewModel.Rooms)
                {
                    if (newRoomName.Equals(room.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        roomExists = true;
                        break;
                    }
                }
                if (roomExists == true)
                {
                    MessageBox.Show("A room with that name already exists.");
                    roomNameText.Text = originalRoomName;
                }
                else
                {
                    roomNameText.Text = newRoomName;
                }
            }
        }
        #endregion game dependent controls
        #region Tool Strip Menu
        // name of the current open file. Will be Null initially when New is selected.
        string jsonString;
        private void MenuNewButton_Click(object sender, EventArgs e)
        {
            if (jsonString != null)
            {
                if (MessageBox.Show("Are you sure you want to close the current game file and open a new one?", "Zork Builder", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            }
            jsonString = null;
            // KNOWN ISSUE: Neighbors comes back Null and cannot reopen file after closing.
            // Create a new series of classes and lists for the brand new file
            World NewWorld = new World();
            NewWorld.Rooms = new List<Room>(Array.Empty<Room>());
            Player NewPlayer = new Player(NewWorld, "");
            Game NewGame = new Game(NewWorld, NewPlayer);

            // Once you've constructed all you need for a Game class, pass it into the view model.
            ViewModel.Game = NewGame;

            IsGameLoaded = true;
        }

        private void MenuSaveButton_Click(object sender, EventArgs e)
        {
            if (jsonString == null) // if the file is new and has never been saved before...
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ViewModel.SaveGame(saveFileDialog.FileName);
                    jsonString = saveFileDialog.FileName;
                }
                if (jsonString != null)
                {
                    ViewModel.SaveGame(jsonString);
                }
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
                        jsonString = File.ReadAllText(openFileDialog.FileName);
                        ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);

                        Room selectedRoom = roomsList.SelectedItem as Room;
                        foreach (var control in mNeighborsControlMap.Values)
                        {
                            control.SelectedRoom = selectedRoom;
                        }

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
