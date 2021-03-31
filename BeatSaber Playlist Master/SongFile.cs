using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatSaberPlaylistMaster
{
    class SongFile
    {
        public string _songName { set; get; }
        public string _levelAuthorName { set; get; }
        public string _songAuthorName { set; get; }
        public string _beatsPerMinute { set; get; }
        public string _coverImageFilename { set; get; }

        public string filePath;

        //public string fullSongName;

        public DateTime lastModified;
    }
}
