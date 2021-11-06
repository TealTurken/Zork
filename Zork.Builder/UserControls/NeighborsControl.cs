using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder.UserControls
{
    public partial class NeighborsControl : UserControl
    {
        private static readonly Room NoRoom = new Room() { Name = "None" };

        public Room Room
        {
            get => mRoom;
            set
            {
                if (mRoom != value)
                {
                    mRoom = value;
                    if (mRoom != null)
                    {
                        // create a local list of rooms to avoid tampering with real list.
                        var neighborOptions = new List<Room>((IEnumerable<Room>)mRoom.Neighbors);
                        neighborOptions.Remove(mRoom);
                        neighborOptions.Insert(0, NoRoom);
                        neighborsComboBox.SelectedIndexChanged -= NeighborsComboBox_SelectedIndexChanged;
                        neighborsComboBox.DataSource = neighborOptions;
                        
                        if (mRoom.Neighbors.TryGetValue(Direction, out Room selectedRoom))
                        {
                            SelectedRoom = selectedRoom;
                        }
                        else // if there is no Room in the direction
                        {
                            SelectedRoom = NoRoom;
                        }

                        neighborsComboBox.SelectedIndexChanged += NeighborsComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborsComboBox.DataSource = null;
                    }
                }
            }
        }

        // Property for TextBox labeling
        public Directions Direction
        {
            get => mDirection;
            set
            {
                mDirection = value;
                neighborsDirectionTextBox.Text = value.ToString();
            }
        }
        public Room SelectedRoom
        {
            get => (Room)neighborsComboBox.SelectedItem;
            set => neighborsComboBox.SelectedItem = value;
        }

        private void NeighborsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mRoom != null)
            {
                Room selectedRoom = SelectedRoom;
                if (selectedRoom == NoRoom)
                {
                    mRoom.Neighbors.Remove(Direction);
                }
                else
                {
                    mRoom.Neighbors[Direction] = selectedRoom;
                }
            }
        }

        public NeighborsControl()
        {
            InitializeComponent();
        }

        private Directions mDirection;
        private Room mRoom;
    }
}
