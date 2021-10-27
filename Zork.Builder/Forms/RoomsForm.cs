using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace Zork.Builder
{
    public partial class RoomsForm : Form
    {

        internal WorldViewModel viewModel { get; private set; }

        public RoomsForm()
        {
            InitializeComponent();
            viewModel = new WorldViewModel();
        }

        public IList<Room> rooms { get; internal set; }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
