using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BeatSaberPlaylistMaster
{
    public class Downloader
    {
        string beatSaberDirectory;

        public static bool currentlyDownloading = false;
        DownloadQueue downloadQueue;
        public Downloader(string directory, DownloadQueue downloadQueueTmp)
        {
            beatSaberDirectory = directory;
            downloadQueue = downloadQueueTmp;
        }

        public async Task download(string beatSaberDirectory)
        {
            if (!currentlyDownloading)
            {
                currentlyDownloading = true;
                while (DownloadQueue.downloadQueue.Count > 0)
                {
                    try
                    {
                        for (int i = 0; i < DownloadQueue.downloadQueue.Count; i++)
                        {
                            int timeout = 60000;
                            var task = DownloadQueue.downloadQueue[0].downloadSong(beatSaberDirectory);
                            if (await Task.WhenAny(task, Task.Delay(timeout)) == task)
                            {
                                DownloadQueue.downloadQueue.RemoveAt(0);
                            }
                            else
                            {
                                playlistSong currentSong = DownloadQueue.downloadQueue[0];
                                var warining = Task.Run(() => { MessageBox.Show("Download of song " + DownloadQueue.downloadQueue[0].songName + " Timed out, moving song to the end of the queue for a retry"); });
                                DownloadQueue.downloadQueue.RemoveAt(0);
                                DownloadQueue.downloadQueue.Add(currentSong);

                            }
                            //await DownloadQueue.downloadQueue[0].downloadSong(beatSaberDirectory);
                            //DownloadQueue.downloadQueue.RemoveAt(0);

                        }



                    }
                    catch (Exception e)
                    {
                        var warining = Task.Run(() => { MessageBox.Show("Download Error " + e.ToString()); });
                    }
                }

                if (DownloadQueue.downloadQueue.Count != 0)
                {
                    download(beatSaberDirectory);
                }
                else
                {
                    currentlyDownloading = false;
                }
            }

        }
    }
}
