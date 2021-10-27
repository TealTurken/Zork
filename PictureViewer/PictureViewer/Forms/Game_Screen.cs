using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ZorkBuilder
{
    public partial class Game_Screen : Form
    {
        public Game_Screen()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void stripMenuExit(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSaveAs_Click(object sender, EventArgs e)
        {
            fileSave.ShowDialog();
        }

        private void fileOpen_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileSave_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void MenuNewGame_Click(object sender, EventArgs e)
        {
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
            }
        }




    }
}
