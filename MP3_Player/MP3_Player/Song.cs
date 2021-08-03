using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;

namespace MP3_Player
{
    class Song
    {
        private string title;
        private string interpret;
        private string filename;
        private string pathname;
        private string absPathName;
        private string path;
        private TimeSpan laenge;

        public void ShowSongInfo()
        {

        }

        public void ParseMP3(string songPath)
        {
            filename = Path.GetFileName(songPath);
            pathname = Path.GetDirectoryName(songPath);
            absPathName = songPath;

            TagLib.File tagFile = TagLib.File.Create(songPath);
            laenge = tagFile.Properties.Duration;
            interpret = tagFile.Tag.JoinedAlbumArtists;
            title = tagFile.Tag.Title;
        }
    }
}
