using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaberPlaylistMaster
{
    public partial class CreatePlaylistForm : Form
    {
        MainForm myMainForm;
        public CreatePlaylistForm(MainForm mainForm)
        {
            myMainForm = mainForm;
            InitializeComponent();
        }

        private void createNewPlaylistButton_Click(object sender, EventArgs e)
        {
            bool success = myMainForm.createNewPlaylist(playlistNameTextbox.Text, authorNameTextbox.Text);
            if (success)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Name of playlist already exists, try a new name");
            }
        }
    }
}
