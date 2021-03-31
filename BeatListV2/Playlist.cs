using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BeatSaberUltimatePlaylistEditor
{
    class Playlist
    {
        public string playlistTitle { set; get; }
        public string playlistAuthor { set; get; }
        public string _filename { set; get; }
        public List<playlistSong> songs { set; get; }
        public string image { set; get; }

        public Image imageFile;

        public string filePath;

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
    }
}
