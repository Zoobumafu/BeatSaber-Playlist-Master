using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaber_Playlist_Master
{
    public class PlaylistSong
    {
        public string key { set; get; }
        public string uploader { set; get; }
        public string hash { set; get; }
        public string songName { set; get; }
        public int _beatsPerMinute { set; get; }

        public string downloadURL;


        string mapName;

        public SongFile file;

        //Task download;

        // Set Time OUT
    }
}
