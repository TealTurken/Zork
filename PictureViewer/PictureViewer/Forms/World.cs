using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Zork.Common;

namespace ZorkBuilder
{
    public partial class World : Form
    {
        public World()
        {
            InitializeComponent();
        }

        public IList<Room> rooms { get; internal set; }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
