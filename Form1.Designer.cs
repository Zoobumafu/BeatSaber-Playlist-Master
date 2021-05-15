
namespace BeatSaber_Playlist_Master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allSongsTreeView = new System.Windows.Forms.TreeView();
            this.playlistTreeView = new System.Windows.Forms.TreeView();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.Location = new System.Drawing.Point(12, 70);
            this.allSongsTreeView.Name = "allSongsTreeView";
            this.allSongsTreeView.Size = new System.Drawing.Size(282, 817);
            this.allSongsTreeView.TabIndex = 0;
            // 
            // playlistTreeView
            // 
            this.playlistTreeView.Location = new System.Drawing.Point(332, 70);
            this.playlistTreeView.Name = "playlistTreeView";
            this.playlistTreeView.Size = new System.Drawing.Size(257, 194);
            this.playlistTreeView.TabIndex = 1;
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Location = new System.Drawing.Point(460, 41);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(129, 23);
            this.createPlaylistButton.TabIndex = 2;
            this.createPlaylistButton.Text = "New Playlist";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 899);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.playlistTreeView);
            this.Controls.Add(this.allSongsTreeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView allSongsTreeView;
        private System.Windows.Forms.TreeView playlistTreeView;
        private System.Windows.Forms.Button createPlaylistButton;
    }
}

