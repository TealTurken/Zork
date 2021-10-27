using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Zork.Common;

namespace ZorkBuilder.Forms
{
    public partial class StartUp : Form
    {

        internal WorldViewModel ViewModel { get; private set; }
        public StartUp()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    ViewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
