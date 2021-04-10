using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace BeatSaberPlaylistMaster
{
    public partial class DownloadQueue : Form
    {
        public static ObservableCollection<playlistSong> downloadQueue = new ObservableCollection<playlistSong>();

        //Task downloadTask;
        Downloader downloader;
        bool currentlyDownloading = false;
        bool currentlyUpdating = false;
        public DownloadQueue(string directory)
        {
            downloader = new Downloader(directory, this);
            InitializeComponent();
            downloadQueue.CollectionChanged += DownloadQueue_CollectionChanged;
        }

        //private void DownloadQueue_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task addToQueueAsync(Playlist list, string beatSaberDirectory, bool ignoreDuplicates = false)
        {
            //try
            //{
                for (int i = 0; i < list.songs.Count; i++)
                {
                    if (list.songs[i].file == null)
                    {
                    if (!ignoreDuplicates && !downloadQueue.Contains(list.songs[i]))
                    {
                        if (list.songs[i].songName == null)
                        {
                            await list.songs[i].populateByHashAsync();
                        }
                        downloadQueue.Add(list.songs[i]);
                    }
                        
                    }
                }

                this.Show();

                if (!currentlyDownloading)
                {
                    downloader.download(beatSaberDirectory);
                    //downloadTask = Task.Factory.StartNew(() => downloader.download(beatSaberDirectory));
                }
            //}
            
            //catch(Exception e)
            //{
            //    MessageBox.Show("Adding to queue error\n" + e.Message);
            //}

        }

        public void addToQueue(playlistSong song, string beatSaberDirectory)
        {
            //try
            //{
                if (!downloadQueue.Contains(song))
                {
                    downloadQueue.Add(song);

                }

                this.Show();
                
                if (Downloader.currentlyDownloading == false)
                {
                    //downloadTask = Task.Factory.StartNew(() => downloader.download(beatSaberDirectory));
                    downloader.download(beatSaberDirectory);
                }
            //}

            //catch (Exception e)
            //{
            //    MessageBox.Show("Adding to queue error\n" + e.Message);
            //}

        }

        private async Task updateQueueTreeView(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //try
            //{
                while (currentlyUpdating)
                {
                    Thread.Sleep(1000);
                }
                currentlyUpdating = true;
                //list changed - an item was added.
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    //Do what ever you want to do when an item is added here...
                    //the new items are available in e.NewItems

                    for (int i = 0; i < e.NewItems.Count; i++)
                    {
                        playlistSong temp = (playlistSong)e.NewItems[i];
                        queueTreeView.Nodes.Add(temp.songName);
                    }

                }

                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
                {
                    for (int i = 0; i < e.OldItems.Count; i++)
                    {
                        bool found = false;
                        for (int j = 0; j < queueTreeView.Nodes.Count; j++)
                        {
                            playlistSong temp = (playlistSong)e.OldItems[i];
                            if (temp.songName == queueTreeView.Nodes[j].Text)
                            {
                                queueTreeView.Nodes[j].Remove();
                                found = true;
                            }
                        }
                    if (!found)
                    {
                        for (int j = 0; j < queueTreeView.Nodes.Count; j++)
                        {
                            playlistSong temp = (playlistSong)e.OldItems[i];
                            await temp.populateByHashAsync();
                            if (temp.songName == queueTreeView.Nodes[j].Text)
                            {
                                queueTreeView.Nodes[j].Remove();
                            }
                        }
                    }

                    }
                }
                currentlyDownloadLabel.Text = downloadQueue[0].songName;

                if (currentlyDownloadLabel.Text != DownloadQueue.downloadQueue[0].songName || DownloadQueue.downloadQueue[0].songName != queueTreeView.Nodes[0].Text)
            {
                currentlyDownloadLabel.Text = DownloadQueue.downloadQueue[0].songName;
                queueTreeView.Nodes.Clear();
                for (int i = 0; i < downloadQueue.Count; i++)
                {
                    queueTreeView.Nodes.Add(downloadQueue[i].songName);
                }
            }
                currentlyUpdating = false;
            //}
            //catch(Exception k)
            //{
            //    MessageBox.Show("Event Error \n" + k.Message);
            //}
        }



        async void DownloadQueue_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            updateQueueTreeView(e);
        }

        private void DownloadQueue_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
