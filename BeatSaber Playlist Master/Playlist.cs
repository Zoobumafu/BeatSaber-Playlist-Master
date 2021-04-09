using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BeatSaberPlaylistMaster
{
    public class Playlist
    {
        public static bool BeatSaverLimitReached = false;
        public string playlistTitle { set; get; }
        public string playlistAuthor { set; get; }
        public string _filename { set; get; }
        public List<playlistSong> songs { set; get; }
        public string image { set; get; }

        public Image imageFile;

        public string filePath;
        public string description { set; get; }

        public bool currentlyDownloading = false;
        public void setImage()
        {
            if (image != null)
            {
                string cleanImageString = "";
                int index = this.image.LastIndexOf(@",");
                if (index > 0)
                    cleanImageString = this.image.Split(',').Last();

                byte[] bytes = Convert.FromBase64String(@cleanImageString);


                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    try
                    {
                        this.imageFile = Image.FromStream(ms);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            
        }


        public async Task downloadAllSongs(string beatSaberDirectory)
        {
            if (!currentlyDownloading)
            {
                currentlyDownloading = true;
                for (int i = 0; i < songs.Count; i++)
                {
                    if (songs[i].file == null)
                    {
                        await songs[i].downloadSong(beatSaberDirectory);
                    }
                }
                currentlyDownloading = false;
            }
        }
    }
}
