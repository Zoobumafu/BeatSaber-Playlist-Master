using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace BeatSaber_Playlist_Master
{
    class Playlist
    {
        public static bool BeatSaverLimitReached = false;
        public string playlistTitle { set; get; }
        public string playlistAuthor { set; get; }
        public string _filename { set; get; }
        public List<PlaylistSong> songs { set; get; }
        public string image { set; get; }

        public Image imageFile;

        public string filePath;
        public string description { set; get; }

        //public Image imageFile;
        //public void setImage()


        public Playlist(string path)
        {
            filePath = path;
        }

        /// <summary>
        /// Read 64bit base string into an image
        /// </summary>
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

        ///<summary>
        ///scans for songs and initializes them.
        ///</summary>
        public void gatherSongList()
        {

        }
    }
}
