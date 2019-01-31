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

        string[] files, paths;
        string[] filesFolderBrowse = Directory.GetFiles(@"C:\\Users\\User\\Music", "*.mp3");

        private void insertListButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                //filesFolderBrowse = dialog.

                for (int i = 0; i < filesFolderBrowse.Length; i++)
                {
                    tracksListBox.Items.Add(filesFolderBrowse[i]);
                }
            }
        }

        private void insertTrackButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 Music files |*.mp3";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                files = dialog.SafeFileNames;
                paths = dialog.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    tracksListBox.Items.Add(files[i]);
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {

            try
            {
                mediaPlayer.URL = paths[tracksListBox.SelectedIndex];
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("bug plz fix ");
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void mediaPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
