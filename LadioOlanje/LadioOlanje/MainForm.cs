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
using System.Diagnostics;

namespace LadioOlanje
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        public static OpenFileDialog dialog = new OpenFileDialog();

        public static string[] files, paths;

        private void insertListButton_Click(object sender, EventArgs e)
        {

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {

                string dir = folderDialog.SelectedPath;
                string[] filesFolderBrowse = Directory.GetFiles(dir, "*.mp3", SearchOption.AllDirectories);


                paths = filesFolderBrowse;

                for (int i = 0; i < filesFolderBrowse.Length; i++)
                {
                    tracksListBox.Items.Add(filesFolderBrowse[i]);
                }
            }
        }

        private void insertTrackButton_Click(object sender, EventArgs e)
        {
            dialog.Filter = "MP3 Music files |*.mp3";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                files = dialog.SafeFileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    tracksListBox.Items.Add(files[i]);
                }

                paths = dialog.FileNames;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tracksListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a song to start.");
                }
                else
                {
                    mediaPlayer.URL = paths[tracksListBox.SelectedIndex];
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("bug plz fix \n" + error.Message);

                return;
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
