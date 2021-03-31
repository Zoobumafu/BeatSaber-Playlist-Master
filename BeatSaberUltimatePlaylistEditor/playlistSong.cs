using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeatSaverSharp;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Net;

namespace BeatSaberUltimatePlaylistEditor
{
    class playlistSong
    {
        public string uploader { set; get; }
        public string hash { set; get; }
        public string songName  { set; get; }
        public int _beatsPerMinute { set; get; }

        public string downloadURL;

        string mapName;

        public SongFile file;


        public void populateSong()
        {
            // Setup the client's HTTP User Agent 
            HttpOptions options = new HttpOptions(name: "Test Client", version: new Version(1, 0, 0));

            // Use this to interact with the API
            BeatSaver beatsaver = new BeatSaver(options);

            DirectoryInfo fileDirectory = new DirectoryInfo(file.filePath);
            string path = fileDirectory.Name;
            path.Substring(0, path.IndexOf(' '));
            mapName = path.Substring(0, path.IndexOf(' '));
            Beatmap map = new Beatmap(beatsaver, mapName);
            map.Populate();
            map.RefreshStats();
            Thread.Sleep(2500);
            this.hash = map.Hash;
            this.downloadURL = map.DirectDownload;
            this.uploader = map.Uploader.Username;
            
        }

        public void downloadSong(string beatSaberDirectory)
        {
            using (var client = new WebClient())
            {
                client.DownloadFile(@"C:\TEMP\", mapName);
            }
        }


    }

    
}
