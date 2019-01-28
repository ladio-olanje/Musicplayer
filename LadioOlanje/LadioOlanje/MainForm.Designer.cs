﻿namespace LadioOlanje
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tracksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertTrackButton = new System.Windows.Forms.Button();
            this.insertListButton = new System.Windows.Forms.Button();
            this.removeTrackButton = new System.Windows.Forms.Button();
            this.removeListButton = new System.Windows.Forms.Button();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.loopTrackButton = new System.Windows.Forms.Button();
            this.loopListButton = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tracksListBox
            // 
            this.tracksListBox.FormattingEnabled = true;
            this.tracksListBox.Location = new System.Drawing.Point(12, 87);
            this.tracksListBox.Name = "tracksListBox";
            this.tracksListBox.Size = new System.Drawing.Size(156, 173);
            this.tracksListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlist :";
            // 
            // insertTrackButton
            // 
            this.insertTrackButton.Location = new System.Drawing.Point(12, 27);
            this.insertTrackButton.Name = "insertTrackButton";
            this.insertTrackButton.Size = new System.Drawing.Size(75, 25);
            this.insertTrackButton.TabIndex = 2;
            this.insertTrackButton.Text = "Insert Track";
            this.insertTrackButton.UseVisualStyleBackColor = true;
            // 
            // insertListButton
            // 
            this.insertListButton.Location = new System.Drawing.Point(12, 56);
            this.insertListButton.Name = "insertListButton";
            this.insertListButton.Size = new System.Drawing.Size(75, 25);
            this.insertListButton.TabIndex = 3;
            this.insertListButton.Text = "Insert List";
            this.insertListButton.UseVisualStyleBackColor = true;
            // 
            // removeTrackButton
            // 
            this.removeTrackButton.Location = new System.Drawing.Point(143, 27);
            this.removeTrackButton.Name = "removeTrackButton";
            this.removeTrackButton.Size = new System.Drawing.Size(25, 25);
            this.removeTrackButton.TabIndex = 4;
            this.removeTrackButton.Text = "-";
            this.removeTrackButton.UseVisualStyleBackColor = true;
            // 
            // removeListButton
            // 
            this.removeListButton.Location = new System.Drawing.Point(143, 56);
            this.removeListButton.Name = "removeListButton";
            this.removeListButton.Size = new System.Drawing.Size(25, 25);
            this.removeListButton.TabIndex = 4;
            this.removeListButton.Text = "-";
            this.removeListButton.UseVisualStyleBackColor = true;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(50, 266);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(75, 23);
            this.randomizeButton.TabIndex = 5;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            // 
            // loopTrackButton
            // 
            this.loopTrackButton.Location = new System.Drawing.Point(12, 295);
            this.loopTrackButton.Name = "loopTrackButton";
            this.loopTrackButton.Size = new System.Drawing.Size(75, 23);
            this.loopTrackButton.TabIndex = 6;
            this.loopTrackButton.Text = "Loop Track";
            this.loopTrackButton.UseVisualStyleBackColor = true;
            // 
            // loopListButton
            // 
            this.loopListButton.Location = new System.Drawing.Point(93, 295);
            this.loopListButton.Name = "loopListButton";
            this.loopListButton.Size = new System.Drawing.Size(75, 23);
            this.loopListButton.TabIndex = 7;
            this.loopListButton.Text = "Loop List";
            this.loopListButton.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(242, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(364, 291);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 332);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.loopListButton);
            this.Controls.Add(this.loopTrackButton);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.removeListButton);
            this.Controls.Add(this.removeTrackButton);
            this.Controls.Add(this.insertListButton);
            this.Controls.Add(this.insertTrackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tracksListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Ladio Olanje";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tracksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertTrackButton;
        private System.Windows.Forms.Button insertListButton;
        private System.Windows.Forms.Button removeTrackButton;
        private System.Windows.Forms.Button removeListButton;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button loopTrackButton;
        private System.Windows.Forms.Button loopListButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

