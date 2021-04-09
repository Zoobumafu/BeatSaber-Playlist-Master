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
using System.IO.Compression;

namespace BeatSaberPlaylistMaster
{
    public class playlistSong
    {
        static string appName = "BeatSaber Playlist Master";


        public string key { set; get; }
        public string uploader { set; get; }
        public string hash { set; get; }
        public string songName  { set; get; }
        public int _beatsPerMinute { set; get; }

        public string downloadURL;


        string mapName;

        public SongFile file;

        Task download;

        public static int erroredSongs = 0;

        // Set Time OUT
        

        public async Task populateByHashAsync()
        {


            // Setup the client's HTTP User Agent 
            HttpOptions options = new HttpOptions(name: appName, version: new Version(1, 0, 0));

            // Use this to interact with the API
            BeatSaver beatsaver = new BeatSaver(options);

            Beatmap map = new Beatmap(beatsaver, null, hash);

            await map.Populate();

            hash = map.Hash;
            key = map.Key;
            songName = map.Name;
            downloadURL = map.DownloadURL;
            uploader = map.Uploader.Username;
        }

        public async void populateSongByName()
        {
            try
            {
                if (file == null)
                {
                    populateByHashAsync();
                }
                else
                {
                    // Setup the client's HTTP User Agent 
                    HttpOptions options = new HttpOptions(name: appName, version: new Version(1, 0, 0));

                    // Use this to interact with the API
                    BeatSaver beatsaver = new BeatSaver(options);

                    DirectoryInfo fileDirectory = new DirectoryInfo(file.filePath);
                    string path = fileDirectory.Name;
                    path.Substring(0, path.IndexOf(' '));
                    mapName = path.Substring(0, path.IndexOf(' '));
                    Beatmap map = new Beatmap(beatsaver, mapName);
                    await map.Populate();
                    await map.RefreshStats();
                    this.hash = map.Hash;
                    this.downloadURL = map.DirectDownload;
                    this.uploader = map.Uploader.Username;
                    
                }
            }

            catch(Exception e)
            {
                var warining = Task.Run(() => { MessageBox.Show("Exception getting hash" + e); });
            }
        }

        public async Task downloadSong(string beatSaberDirectory)
        {
            // Setup the client's HTTP User Agent 
            TimeSpan timeOut = new TimeSpan(0, 1, 1);
            HttpOptions options = new HttpOptions(name: "Test Client", version: new Version(1, 0, 0), timeOut);

            // Use this to interact with the API
            BeatSaver beatsaver = new BeatSaver(options);

            Beatmap mp = new Beatmap(beatsaver, null, hash);
            try
            {

                //await populateByHashAsync();
                await mp.Populate();

                await mp.ZipBytes();
                //this.songName = mp.Name;
            }

            catch (Exception e)
            {
                if (e is BeatSaverSharp.Exceptions.RateLimitExceededException rateLimitException)
                {
                    var warining = Task.Run(() => { MessageBox.Show("Reached download limit, I will attempt to continue the download where we left off in 10 minutes."); });
                    Playlist.BeatSaverLimitReached = true;
                    var wait = Task.Run(() =>  Thread.Sleep(600000));
                    Playlist.BeatSaverLimitReached = false;
                    await mp.Populate();
                    await mp.ZipBytes();
                    //this.songName = mp.Name;
                }
                else
                {
                    var warining = Task.Run(() => { MessageBox.Show("DownloadError " + e); });
                    return;
                }
            }
            System.Byte[] file = mp.ZipBytes().Result;

            File.WriteAllBytes(@"C:\TEMP\" + mp.Key + @".zip", file);
            string validSongName;
            try
            {
                if (songName != null)
                {
                    validSongName = @songName;
                }
                else
                {
                    validSongName = mp.Name;
                }
                
                string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
                foreach (char c in invalid)
                {
                    validSongName = validSongName.Replace(c.ToString(), "");
                }
            }
            catch(Exception e)
            {
                var warining = Task.Run(() => { MessageBox.Show("Error interacting with some name"); });
                validSongName = "" + erroredSongs;
            }
            

            string newPath = beatSaberDirectory + @"\Beat Saber_Data\CustomLevels\" + @mp.Key + @" " + validSongName;
            string tempPath = @"C:\TEMP\" + mp.Key + @".zip";
            ZipArchive zip = ZipFile.OpenRead(tempPath);
            if (Directory.Exists(@newPath))
            {
                Directory.Delete(@newPath, true);
            }
            zip.ExtractToDirectory(@newPath);
            try
            {

                File.Delete(@tempPath);

            }
            catch
            {

            }
        }



    }

    
}
