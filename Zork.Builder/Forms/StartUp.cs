using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zork.Builder.Forms
{
    public partial class StartUp : Form
    {

        internal WorldViewModel viewModel { get; private set; }
        public StartUp()
        {
            InitializeComponent();
            viewModel = new WorldViewModel();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = openFileDialog.FileName;
                    viewModel.World = JsonConvert.DeserializeObject<World>(jsonString);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
