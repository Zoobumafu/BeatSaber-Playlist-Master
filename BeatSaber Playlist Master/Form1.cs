using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using BeatSaverSharp;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.Win32;

namespace BeatSaberPlaylistMaster
{

    public partial class MainForm : Form
    {
        //Creating a list of playlists
        List<SongFile> songFiles = new List<SongFile>();
        List<Playlist> playlists = new List<Playlist>();
        List<playlistSong> allSongs = new List<playlistSong>();
        List<SongFile> outOfPlaylistFiles = new List<SongFile>();
        List<playlistSong> missingFile = new List<playlistSong>();
        List<playlistSong> songsWithFiles = new List<playlistSong>();


        //Path to BeatSaber directory
        string beatSaberDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Beat Saber\";

        // GlobalParameters
        bool savingEnabled = true;
        bool isSaved = true;
        string currentSongPath;
        TreeNode lastSelectedPlaylistNode;
        public MainForm()
        {
            checkBeatSaberDirectory();
            InitializeComponent();

            //Populate playlists
            //Populate playlists
            try
            {
                DirectoryInfo playlistsDirectory = new DirectoryInfo(beatSaberDirectory + @"\Playlists");
                var playlistFiles = playlistsDirectory.GetFiles();

                for (int i = 0; i < playlistFiles.Length; i++)
                {
                    string myString = System.IO.File.ReadAllText(playlistFiles[i].FullName);
                    playlists.Add(JsonConvert.DeserializeObject<Playlist>(myString));


                    playlists[i].filePath = playlistFiles[i].FullName;

                    //Save an image, if exists
                    if (playlists[i].image != null)
                    {
                        playlists[i].setImage();
                    }
                }

            }

            catch(Exception e)
            {
                Console.WriteLine("Not found directory: " + e);
            }



            //Get a list of all songs

            for (int i = 0; i < playlists.Count; i++)
            {
                for (int j = 0; j < playlists[i].songs.Count; j++)
                {
                    if (!allSongs.Exists(x => x.songName == playlists[i].songs[j].songName))
                    {
                        allSongs.Add(playlists[i].songs[j]);
                    }

                }
            }

            allSongs = allSongs.Distinct().ToList();

            //allSongs = allSongs.OrderBy(si => si.file.lastModified).ToList();

            associateFilesWithSongs();
            PopulatePlaylistForms(playlists);
            PopulateAllSongsTreeView();
        }
        private void checkBeatSaberDirectory()
        {
            // Find the installation path before launching the form
            if (File.Exists(@beatSaberDirectory + "Beat Saber.exe") == false)
            {
                string previousDirectory = "";
                bool correctDirectory = false;

                var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var myKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 620980");
                string value = (string)(myKey.GetValue("InstallLocation"));
                if (File.Exists(@value + @"\Beat Saber.exe"))
                {
                    correctDirectory = true;
                    beatSaberDirectory = @value;
                }

                // Could not find the location automatically, prompting the user to input it.

                while (correctDirectory == false)
                {
                    string path = Interaction.InputBox("Please enter BeatSaber directory path \nIt must contain Beat Saber.exe file \nType 'Quit' to exit this window", "Could not find installation path", previousDirectory);
                    if (File.Exists(@path + @"\Beat Saber.exe"))
                    {
                        correctDirectory = true;
                        beatSaberDirectory = path;
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
        }

        public void associateFilesWithSongs()
        { 
            DirectoryInfo filesDirectory = new DirectoryInfo(beatSaberDirectory + @"Beat Saber_Data\CustomLevels");
            DirectoryInfo[] files = filesDirectory.GetDirectories();

            // Deassociate with files first, reason being, if the file path is saved in the file, and than the file is deleted, 
            // the object will point to multiple null values, and cause the software to crash

            for (int i = 0; i < allSongs.Count; i ++)
            {
                allSongs[i].file = null;
            }

            for (int i = 0; i < files.Length; i++)
            {
                if (File.Exists(files[i].FullName + @"\info.dat"))
                {
                    string jsonString = File.ReadAllText(files[i].FullName + @"\info.dat");
                    songFiles.Add(JsonConvert.DeserializeObject<SongFile>(jsonString));
                    songFiles[songFiles.Count-1].filePath = files[i].FullName;
                    songFiles[songFiles.Count - 1].lastModified = files[i].LastWriteTime;
                }

            }
            
            for (int j = 0; j < songFiles.Count; j++)
            {
                bool inPlaylist = false;
                for (int i = 0; i < allSongs.Count; i++)
                {
                    if (allSongs[i].songName != null)
                    {
                        if (allSongs[i].songName.IndexOf(songFiles[j]._songName, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            allSongs[i].file = songFiles[j];
                            inPlaylist = true;
                            break;
                        }
                    }

                       
                }
                if (inPlaylist == false)
                {
                    
                    outOfPlaylistFiles.Add(songFiles[j]);
                    playlistSong newSong = new playlistSong();
                    newSong.songName = songFiles[j]._songName;
                    newSong.file = songFiles[j];
                    allSongs.Add(newSong);
                    //Thread getSongDetails = new Thread(allSongs[allSongs.Count - 1].populateSong);
                    //getSongDetails.Start();
                }

            }

            for (int i = 0; i < allSongs.Count; i++)
            {
                if (allSongs[i].file == null)
                {
                    missingFile.Add(allSongs[i]);
                    
                }
                else
                {
                    songsWithFiles.Add(allSongs[i]);
                }
            }

        }

        void PopulatePlaylistForms(List<Playlist> playlists)
        {
            playlistTreeView1.Nodes.Clear();
            for (int i = 0; i < playlists.Count; i++)
            {
                playlistTreeView1.Nodes.Add(playlists[i].playlistTitle);
            }
        }

        void PopulateSongsForm(Playlist playlist, TreeView treeView)
        {
            treeView.Nodes.Clear();
            for (int i = 0; i < playlist.songs.Count; i++)
            {
                if (playlist.songs[i].songName != null)
                {
                    treeView.Nodes.Add(playlist.songs[i].songName);
                }
                else
                {
                    treeView.Nodes.Add(playlist.songs[i].hash);
                }
            }

        }

        void PopulateAllSongsTreeView(string filter = "")
        {
            List<playlistSong> sortedList = new List<playlistSong>(); 
            allSongsTreeView.Nodes.Clear();
            if (lastModifiedRadioButton.Checked == true)
            {
                List<playlistSong> tempMissingFiles = new List<playlistSong>();
                for (int i = 0; i < allSongs.Count; i++)
                {
                    if (allSongs[i].file != null)
                    {
                        sortedList.Add(allSongs[i]);
                    }
                    else
                    {
                        tempMissingFiles.Add(allSongs[i]);
                    }
                }
                sortedList = sortedList.OrderBy(p => p.file.lastModified).ToList();

                sortedList.Reverse();

                for (int i = 0; i < tempMissingFiles.Count; i++)
                {
                    sortedList.Add(tempMissingFiles[i]);
                }

                
            }
            else if (nameRadioButton.Checked == true)
            {
                sortedList = allSongs.OrderBy(si => si.songName).ToList();
            }

            for (int i = 0; i < sortedList.Count; i++)
                {
                if (sortedList[i].songName != null)
                {
                    if (sortedList[i].songName.IndexOf(filter, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        bool alreadyExists = false;
                        for (int k = 0; k < allSongsTreeView.Nodes.Count; k++)
                        {
                            if (allSongsTreeView.Nodes[k].Text == sortedList[i].songName)
                            {
                                alreadyExists = true;
                            }
                        }
                        if (!alreadyExists)
                        {
                            allSongsTreeView.Nodes.Add(sortedList[i].songName);
                        }
                    }
                }
            }
        }

        private void playlistTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lastSelectedPlaylistNode = playlistTreeView1.SelectedNode;
            populatePlaylistSongTreeView();
        }

        private void populatePlaylistSongTreeView()
        {
            Playlist myPlaylist = null;
            for (int i = 0; i < playlists.Count; i++)
            {
                if (playlists[i].playlistTitle == lastSelectedPlaylistNode.Text)
                {
                    myPlaylist = playlists[i];
                    if (playlists[i].imageFile != null)
                    {
                        playlistPictureBox.Image = playlists[i].imageFile;
                    }
                    else
                    {
                        playlistPictureBox.Image = null;
                    }
                }
            }

            for (int i = 0; i < playlistTreeView1.Nodes.Count; i++)
            {
                if (playlistTreeView1.Nodes[i].Text == lastSelectedPlaylistNode.Text)
                {
                    playlistTreeView1.Nodes[i].Checked = true;
                }
            }
            
            PopulateSongsForm(myPlaylist, playlistSongTreeView);
        }

        void populateLabels(string name)
        {
            for (int i = 0; i < allSongs.Count; i++)
            {
                if (allSongs[i].songName == name)
                {
                    appearsInPlaylistTreeView.Nodes.Clear();
                    if (allSongs[i].songName != null)
                    {
                        songNameLabel.Text = allSongs[i].songName;
                    }
                    else
                    {
                        songNameLabel.Text = "";
                    }
                    if (allSongs[i].uploader != null)
                    {
                        authorLabel.Text = allSongs[i].uploader;
                    }
                    else
                    {
                        authorLabel.Text = "";
                    }
                    if (allSongs[i].hash != null)
                    {
                        hashLabel.Text = allSongs[i].hash;
                    }
                    else
                    {
                        hashLabel.Text = "";
                    }
                    for (int j = 0; j < playlists.Count; j++)
                    {
                        for (int k = 0; k < playlists[j].songs.Count; k++)
                        {
                            if (playlists[j].songs[k].songName == name)
                            {
                                appearsInPlaylistTreeView.Nodes.Add(playlists[j].playlistTitle);
                            }
                        }
                    }
                    if (allSongs[i].file != null)
                    {
                        currentSongPath = allSongs[i].file.filePath;
                        if (allSongs[i].file.lastModified != null)
                        {
                            lastModifiedLabel.Text = allSongs[i].file.lastModified.ToString();
                        }
                        if (allSongs[i].file._coverImageFilename != null)
                        {
                            Bitmap bitmap = new Bitmap(allSongs[i].file.filePath + @"\" + allSongs[i].file._coverImageFilename);
                            songPictureBox.Image = bitmap;
                        }
                        downloadedLabel.Text = "";
                    }
                    else
                    {
                        lastModifiedLabel.Text = "";
                        downloadedLabel.Text = "Missing File!";
                        currentSongPath = beatSaberDirectory;
                    }
                    continue;
                }
            }
        }

        void saveAll()
        {
            // NewtonSoft cant save image file properly, therefore it is deleted before saving
            if (savingEnabled)
            {
                for (int i = 0; i < playlists.Count; i++)
                {
                    //@"data:image/gif;base64," + Convert.ToBase64String(File.ReadAllBytes
                    //playlists[i].image = @"data:image/gif;base64," + Convert.ToBase64String(playlists[i].imageFile);
                    playlists[i].imageFile = null;
                    string jsonText = JsonConvert.SerializeObject(playlists[i]);
                    File.WriteAllText(playlists[i].filePath, jsonText);
                }
                MessageBox.Show("All playlists saved successfully");
            }
            else
            {
                MessageBox.Show("Fetching song details, please try again in a few seconds");
            }
            for (int i = 0; i < playlists.Count; i++)
            {
                playlists[i].setImage();
            }

            isSaved = true;
            
        }

        private void addSong(string songName = "currentNode")
        {
            if (songName == "currentNode")
            {
                songName = allSongsTreeView.SelectedNode.Text;
            }
            //Finding the song to add
            for (int i = 0; i < allSongs.Count; i++)
            {

                if (songName == allSongs[i].songName)
                {
                    //Finding what playlist to add it to
                    for (int j = 0; j < playlists.Count; j++)
                    {
                        if (playlistTreeView1.SelectedNode.Text == playlists[j].playlistTitle)
                        {
                            playlists[j].songs.Add(allSongs[i]);
                            playlistSongTreeView.Nodes.Add(allSongs[i].songName);
                            if (allSongs[i].hash == null)
                            {
                                Thread getSongDetails = new Thread(allSongs[i].populateSong);
                                getSongDetails.Start();
                                Thread disableSaveButton = new Thread(temporarlyDisableSaveButton);
                                disableSaveButton.Start();
                            }
                            break;
                        }
                    }
                }
            }

            isSaved = false;
        }

        private void temporarlyDisableSaveButton()
        {
            // Disable save button in order to allow the software to download the hashcode from Bsaber
            // Otherwise the song will be saved without hash and won't appear in the game.
            savingEnabled = false;
            Thread.Sleep(3000);
            savingEnabled = true;
        }

        private void removeSong(string node = "currentNode")
        {
            if (node == "currentNode")
            {
                node = playlistSongTreeView.SelectedNode.Text;
            }

            if (playlistSongTreeView.SelectedNode == null)
            {
                MessageBox.Show("You didn't select a song to remove, noob.");
            }
            else
            {
                Playlist selectedPlaylist = new Playlist();
                for (int i = 0; i < playlists.Count; i++)
                {
                    if (playlists[i].playlistTitle == playlistTreeView1.SelectedNode.Text)
                    {
                        selectedPlaylist = playlists[i];
                    }
                }

                for (int i = 0; i < selectedPlaylist.songs.Count; i++)
                {
                    if (node == selectedPlaylist.songs[i].songName)
                    {
                        selectedPlaylist.songs.RemoveAt(i);
                        playlistSongTreeView.SelectedNode.Remove();
                        break;
                    }
                }
            }
            isSaved = false;
        }

        private void songLocationButton_Click(object sender, EventArgs e)
        {
            if (currentSongPath != null)
            {
                Process.Start(@currentSongPath);
            }
            else
            {
                MessageBox.Show("Pick a song first");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateAllSongsTreeView(searchTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addSong();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeSong();
        }

        public bool createNewPlaylist (string playListName, string playListAuthor)
        {
            if (File.Exists(beatSaberDirectory + @"\playlists\" + playListName))
            {
                MessageBox.Show("Playlist already exists");
                return false;
            }
            Playlist newPlaylist = new Playlist();
            newPlaylist.playlistTitle = playListName;
            newPlaylist.playlistAuthor = playListAuthor;
            newPlaylist._filename = playListName;
            newPlaylist.songs = new List<playlistSong>();
            newPlaylist.filePath = beatSaberDirectory + @"\playlists\" + playListName + @".json";
            playlistTreeView1.Nodes.Add(playListName);
            playlists.Add(newPlaylist);
            playlistTreeView1.SelectedNode = playlistTreeView1.Nodes[playlistTreeView1.Nodes.Count - 1];
            return true;
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            CreatePlaylistForm createNewPlaylist = new CreatePlaylistForm(this);
            createNewPlaylist.Show();
            isSaved = false;
        }

        private void lastModifiedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PopulateAllSongsTreeView(searchTextBox.Text);
        }

        private void replaceImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp; *.jpg; *.jpeg,*.png)|*.BMP; *.JPG; *.JPEG; *.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < playlists.Count; i++)
                    {
                        if (playlistTreeView1.SelectedNode.Text == playlists[i].playlistTitle)
                        {
                            playlists[i].image = @"data:image/gif;base64," + Convert.ToBase64String(File.ReadAllBytes(@dlg.FileName));
                            playlists[i].setImage();
                            playlistPictureBox.Image = playlists[i].imageFile;
                        }
                    }
                }
            }
            isSaved = false;
        }

        private void deletePlaylistButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the playlist " + playlistTreeView1.SelectedNode.Text
                + "? This cannot be undone!", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < playlists.Count; i++)
                {
                    if (playlists[i].playlistTitle == playlistTreeView1.SelectedNode.Text)
                    {
                        File.Delete(playlists[i].filePath);
                        playlistTreeView1.SelectedNode.Remove();
                        break;
                    }
                }
            }

            isSaved = false;
        }

        private void installationPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playlistPictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void changePlaylistNameButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if(playlistTreeView1.SelectedNode.Text == playlists[i].playlistTitle)
                {
                    string input = Interaction.InputBox("Please choose a new name", "Choose a new name", playlists[i].playlistTitle);
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        playlists[i].playlistTitle = input;
                        playlistTreeView1.SelectedNode.Text = input;
                    }
                }
            }
            isSaved = false;
        }

        private void allSongsTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            addSong();
        }

        private void songTreeView1_DoubleClick(object sender, EventArgs e)
        {
            removeSong();
        }

        private void songTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            populateLabels(e.Node.Text);
        }

        private void allSongsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            populateLabels(e.Node.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveAll();
        }

        private void addAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to add all songs in the current filter to the playlist " + playlistTreeView1.SelectedNode.Text
                + "?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < allSongsTreeView.Nodes.Count; i++)
                {
                    addSong(allSongsTreeView.Nodes[i].Text);
                }
            }
            
        }

        private void addUnplaylistedButton_Click(object sender, EventArgs e)
        {
            List<playlistSong> unplaylisted = new List<playlistSong>();

            for (int i = 0; i < allSongs.Count; i++)
            {
                bool isUnplaylisted = true;
                for (int j = 0; j < playlists.Count; j++)
                {
                    for (int k = 0; k < playlists[j].songs.Count; k++)
                    {
                        if (allSongs[i].songName == playlists[j].songs[k].songName)
                        {
                            isUnplaylisted = false;
                            continue;
                        }
                    }
                    
                }
                if (isUnplaylisted == true)
                {
                    unplaylisted.Add(allSongs[i]);
                }
            }

            for (int i = 0; i < unplaylisted.Count; i++)
            {
                addSong(unplaylisted[i].songName);
            }
        }

        private void removeDuplicatesButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                if (playlists[i].playlistTitle == lastSelectedPlaylistNode.Text)
                {
                    playlists[i].songs = playlists[i].songs.Distinct().ToList();
                    PopulatePlaylistForms(playlists);
                    populatePlaylistSongTreeView();
                }
            }

            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save before leaving?", "You have unsaved data!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    saveAll();
                }
            }
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
