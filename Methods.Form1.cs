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
    public partial class Form1
    {
        // BeatsaverSharp parameters

        HttpOptions options;
        BeatSaver beatSaver;

        /// <summary>
        /// Detect and read all playlist files 
        /// </summary>
        void ReadPlaylist(List<Playlist> playlists)
        {
            DirectoryInfo playlistsDirectory = new DirectoryInfo(Data.installPath + @"\Playlists");
            var playlistFiles = playlistsDirectory.GetFiles();

            for (int i = 0; i < playlistFiles.Length; i++)
            {
                string tempString = System.IO.File.ReadAllText(playlistFiles[i].FullName);
                string myString = tempString.Substring(tempString.IndexOf('{'));
                playlists.Add(JsonConvert.DeserializeObject<Playlist>(myString));

                playlists[i].filePath = playlistFiles[i].FullName;

                //Save an image, if exists
                if (playlists[i].image != null)
                {
                    playlists[i].setImage();
                }
            }
        }



        /// <summary>
        /// Detect location of installation directory
        /// </summary>
        public void FindBeatSaberDirectory()
        {
            string previousDirectory = "";
            bool correctDirectory = false;

            // Check by registry
            var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            var myKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 620980");
            string value = (string)(myKey.GetValue("InstallLocation"));
            if (File.Exists(@value + @"\Beat Saber.exe"))
            {
                correctDirectory = true;
                Data.installPath = @value;
            }

            // If the registry did not locate the correct install directory, prompt user to input it himself
            while (correctDirectory == false)
            {
                string path = Interaction.InputBox("Please enter BeatSaber directory path \nIt must contain Beat Saber.exe file \nType 'Quit' to exit this window", "Could not find installation path", previousDirectory);
                if (File.Exists(@path + @"\Beat Saber.exe"))
                {
                    correctDirectory = true;
                    Data.installPath = path;
                }
                else if (path == "Quit")
                {
                    correctDirectory = true;
                    Environment.Exit(1);
                }
                else
                {
                    previousDirectory = path;
                }
            }

        }



        /// <summary>
        /// Get list of all songs by name and files
        /// </summary>
        void FindAllSongs(List<PlaylistSong> allSongs, List<Playlist> playlists)
        {
            //Initially get a list of all songs inside of playlists
            List<PlaylistSong> songsInPlaylists = new List<PlaylistSong>();

            for (int i = 0; i < this.playlists.Count; i++)
            {
                for (int j = 0; j < this.playlists[i].songs.Count; j++)
                {
                    songsInPlaylists.Add(playlists[i].songs[j]);
                }
            }

            // Get a list of all songs currently installed
            List<SongFile> songsInDirectory = new List<SongFile>();

            DirectoryInfo filesDirectory = new DirectoryInfo(Data.installPath + @"\Beat Saber_Data\CustomLevels");
            DirectoryInfo[] files = filesDirectory.GetDirectories();

            for (int i = 0; i < files.Length; i++)
            {
                // Read info file into an object
                string jsonString = File.ReadAllText(files[i].FullName + @"\info.dat");
                songsInDirectory.Add(JsonConvert.DeserializeObject<SongFile>(jsonString));
            }

            try
            {
                for (int i = 0; i < songsInDirectory.Count; i++)
                {
                    // Get Key if possible
                    DirectoryInfo info = new DirectoryInfo(files[i].FullName);
                    string folderName = info.Name;
                    int index = folderName.IndexOf(' ');
                    if (index - 1 > 0)
                    {
                        songsInDirectory[i].key = folderName.Substring(0, index - 1);
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error assaigning key to song" + e.Message);
            }

            //string test = "";
            //for (int i = 0; i < songsInDirectory.Count; i++)
            //{
            //    test = test + songsInDirectory[i].key + " ";
            //}
            //MessageBox.Show(test);

        }

        async void FetchSongDetails()
        {

        }

        /// <summary>
        /// Clear and re-populate AllSongs TreeView
        /// </summary>
        public void populateAllSongsForm()
        {
            // Clear TreeView
            foreach (TreeNode treenode in allSongsTreeView.Nodes)
            {
                treenode.Remove();
            }

            // Populate TreeView
            foreach (PlaylistSong song in allSongs)
            {
                TreeNode node = new TreeNode();
                node.Tag = song;
                node.Text = song.songName;
                allSongsTreeView.Nodes.Add(node);
            }
        }

    }
}
