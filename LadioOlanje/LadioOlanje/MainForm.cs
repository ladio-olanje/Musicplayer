using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LadioOlanje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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


                FileStream fs = new FileStream(songPath, FileMode.Open);

                fs.Seek(-128, SeekOrigin.End);
                fs.Read(tagBytes, 0, 3);


                tag = System.Text.Encoding.Default.GetString(tagBytes);

                if (tag.ToUpper().Equals("TAG"))
                {
                    byte[] titleBytes = new byte[30];
                    byte[] artistBytes = new byte[30];

                    fs.Read(titleBytes, 0, 30);

                    title = System.Text.Encoding.Default.GetString(titleBytes);

                    fs.Read(artistBytes, 0, 30);

                    artist = System.Text.Encoding.Default.GetString(artistBytes);

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

        private void insertListButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            //int tracksParse = int.Parse(dialog.SelectedPath.Length.ToString());

            string[] tracks = new string[]{int.Parse(dialog.SelectedPath.Length)};

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < tracks; i++)
                {
                    tracksListBox.Items.Add(tracks[i]).ToString();
                }
            }
        }

        private void insertTrackButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 Music files |*.mp3";
            dialog.ShowDialog();

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                //tracksListBox.Items.Add();
            }
        }

        private void removeTrackButton_Click(object sender, EventArgs e)
        {
            tracksListBox.SelectedItems.Clear();
        }

        private void removeListButton_Click(object sender, EventArgs e)
        {
            tracksListBox.Items.Clear();
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {

        }

        private void loopTrackButton_Click(object sender, EventArgs e)
        {

        }

        private void loopListButton_Click(object sender, EventArgs e)
        {

        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
