﻿using System;
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

        public static string[] files;
        string[]  paths = {  };
        int songCount = 0;


        public MainForm()
        {
            InitializeComponent();
            paths = new string[100];
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

        public static FolderBrowserDialog folderDialog = new FolderBrowserDialog();
        public static OpenFileDialog dialog = new OpenFileDialog();


        

        private void insertListButton_Click(object sender, EventArgs e)
        {

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {

                string dir = folderDialog.SelectedPath;
                string[] filesFolderBrowse = Directory.GetFiles(dir, "*.mp3", SearchOption.AllDirectories);

                for (int i = 0; i < filesFolderBrowse.Length; i++)
                {
                    tracksListBox.Items.Add(filesFolderBrowse[i]);
                    paths[i + songCount] = filesFolderBrowse[i];
                }
                songCount += filesFolderBrowse.Length;
            }
        }

        private void insertTrackButton_Click(object sender, EventArgs e)
        {
            dialog.Filter = "MP3 Music files |*.mp3";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                files = dialog.SafeFileNames;

                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    paths[i + songCount] = dialog.FileNames[i];

                    string artist;
                    string title;
                    bool success = TryParseSongInfo(dialog.FileNames[i], out artist, out title);

                    //if (success == true)
                    //{
                            //tracksListBox.Items.Add(string.Format("{0} - {1}", artist, title));
                    //}
                }
                songCount += dialog.FileNames.Length;

                for (int i = 0; i < files.Length; i++)
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

            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Selecteer een lied");
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
