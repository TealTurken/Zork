using Newtonsoft.Json;
using System;
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
        private void RoomNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomNameText.Text))
            {
            }
        }

        #region Tool Strip Menu
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
                        ViewModel.game = JsonConvert.DeserializeObject<Game>(jsonString);
                        IsGameLoaded = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void menuExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion tool strip menu
    }
}
