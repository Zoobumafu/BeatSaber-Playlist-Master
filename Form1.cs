using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Windows.Forms;
using BeatSaverSharp;

namespace BeatSaber_Playlist_Master
{
    public partial class Form1 : Form
    {

        List<Playlist> playlists = new List<Playlist>();
        List<PlaylistSong> allSongs = new List<PlaylistSong>();
        public Form1()
        {

            InitializeComponent();

            // Startup processes
            FindBeatSaberDirectory();
            ReadPlaylist(playlists);
            FindAllSongs(allSongs, playlists);

            // Populate GUI
            populatePlaylists(playlists);

            // Assaigning BeatSaverSharp parameters
            options = new HttpOptions(Data.appName, Data.version);
            beatSaver = new BeatSaver(options);
        }


        /// <summary>
        /// Add playlists to the treeview control
        /// </summary>
        /// <param name="playlists"></param>
        void populatePlaylists(List<Playlist> playlists)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = playlists[i].playlistTitle;
                treeNode.Tag = playlists[i];
                playlistTreeView.Nodes.Add(treeNode);
            }
        }
        

    }
}
