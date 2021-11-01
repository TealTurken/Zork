using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Zork.Builder.ViewModels;
using Zork.Common;

namespace Zork.Builder
{
    public partial class RoomsWindow : Form
    {
        int newRoomCount = 0;
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
            };
            
            IsGameLoaded = false;
        }

        private void menuExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuOpenButton_Click(object sender, EventArgs e)
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
        private GameViewModel _viewModel;
        private Control[] _gameDependentControls;
        private ToolStripMenuItem[] _gameDependentMenuItems;

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            if (newRoomCount == 0) room.Name = "new room";
            else room.Name = $"new room {newRoomCount}";
            ViewModel.Rooms.Add(room);
            newRoomCount++;
        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
        }
    }
}
