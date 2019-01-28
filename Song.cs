using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public string Path;
        public string Artist;
        public string Title;

        public override string ToString()
        {
            return string.Format("{0} - {1} ({2})", Artist, Title, Path);
        }

        public static bool TryParseSongInfo(string songPath, out string artist, out string title)
        {
            byte[] tagBytes = new byte[3];
            string tag;

            // Credits: https://social.msdn.microsoft.com/Forums/en-US/a5f60510-0c24-464b-83f7-d988987a7120/get-music-file-info-based-off-of-file-path?forum=vblanguage
            FileStream fs = new FileStream(songPath, FileMode.Open);

            // The song information is in the Last 128 bytes:
            // MP3 files have a 'TAG' identifier in the file.
            // So imagine the file being something like this:
            // 2a 4d 75 7a 69 65 6b 20 68 69 65 72 2a 20 54 41 47 20 54 68 65 50 72 6f 64 69 67 79 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 53 70 69 74 66 69 72 65 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 20 45 69 6e 64 65 20 76 61 6e 20 62 65 73 74 61 6e 64
            // Which is litterally translated:
            // *Muziek hier* TAGThe Prodigy                  Spitfire                     Einde van bestand
            //                  |___________________________||___________________________|
            //                   This part always has artist  This part always has title
            fs.Seek(-128, SeekOrigin.End);
            fs.Read(tagBytes, 0, 3);

            // Get the Tag
            tag = System.Text.Encoding.Default.GetString(tagBytes);

            if (tag.ToUpper().Equals("TAG"))
            {
                // Get the title of this song.
                byte[] titleBytes = new byte[30];
                byte[] artistBytes = new byte[30];

                // The first 30 bytes are the title
                fs.Read(titleBytes, 0, 30);

                // Convert the bytes to human readable strings (using the default encoding)
                title = System.Text.Encoding.Default.GetString(titleBytes);

                // Get the Artist of this song wich is in the next 30 bytes
                fs.Read(artistBytes, 0, 30);

                artist = System.Text.Encoding.Default.GetString(artistBytes);

                // Since we always get 30 bytes, some will be NULL. We're going to strip those
                title = title.Replace("\0", "");
                artist = artist.Replace("\0", "");

                return true;
            }
            else
            {
                title = "Unknown";
                artist = "Unknown";

                return false;
            }
        }
    }
}
