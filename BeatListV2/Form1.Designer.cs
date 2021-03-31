namespace BeatSaberUltimatePlaylistEditor
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
            this.playlistTreeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.playlistSongTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.allSongsTreeView = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.hashLabel = new System.Windows.Forms.Label();
            this.appearsInPlaylistTreeView = new System.Windows.Forms.TreeView();
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.lastModifiedRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lastModifiedLabel = new System.Windows.Forms.Label();
            this.songLocationButton = new System.Windows.Forms.Button();
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.playlistPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadedLabel = new System.Windows.Forms.Label();
            this.replaceImageButton = new System.Windows.Forms.Button();
            this.changePlaylistNameButton = new System.Windows.Forms.Button();
            this.addAllButton = new System.Windows.Forms.Button();
            this.addUnplaylistedButton = new System.Windows.Forms.Button();
            this.removeDuplicatesButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistTreeView1
            // 
            this.playlistTreeView1.HideSelection = false;
            this.playlistTreeView1.Location = new System.Drawing.Point(514, 66);
            this.playlistTreeView1.Name = "playlistTreeView1";
            this.playlistTreeView1.Size = new System.Drawing.Size(402, 130);
            this.playlistTreeView1.TabIndex = 0;
            this.playlistTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.playlistTreeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlists";
            // 
            // playlistSongTreeView
            // 
            this.playlistSongTreeView.HideSelection = false;
            this.playlistSongTreeView.Location = new System.Drawing.Point(514, 237);
            this.playlistSongTreeView.Name = "playlistSongTreeView";
            this.playlistSongTreeView.Size = new System.Drawing.Size(539, 439);
            this.playlistSongTreeView.TabIndex = 2;
            this.playlistSongTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songTreeView1_AfterSelect);
            this.playlistSongTreeView.DoubleClick += new System.EventHandler(this.songTreeView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Songs";
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.HideSelection = false;
            this.allSongsTreeView.Location = new System.Drawing.Point(12, 66);
            this.allSongsTreeView.Name = "allSongsTreeView";
            this.allSongsTreeView.Size = new System.Drawing.Size(452, 610);
            this.allSongsTreeView.TabIndex = 5;
            this.allSongsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.allSongsTreeView_AfterSelect);
            this.allSongsTreeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allSongsTreeView_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 714);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Song Name -";
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Location = new System.Drawing.Point(90, 714);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 13);
            this.songNameLabel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Author - ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 760);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hash -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 782);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Playlists - ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(90, 737);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 13);
            this.authorLabel.TabIndex = 11;
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(90, 760);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(0, 13);
            this.hashLabel.TabIndex = 12;
            // 
            // appearsInPlaylistTreeView
            // 
            this.appearsInPlaylistTreeView.Location = new System.Drawing.Point(73, 782);
            this.appearsInPlaylistTreeView.Name = "appearsInPlaylistTreeView";
            this.appearsInPlaylistTreeView.Size = new System.Drawing.Size(407, 58);
            this.appearsInPlaylistTreeView.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(977, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(277, 40);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(187, 20);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Search:";
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Yu Gothic UI", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(470, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(38, 38);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(470, 307);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(38, 40);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.lastModifiedRadioButton);
            this.sortGroupBox.Controls.Add(this.nameRadioButton);
            this.sortGroupBox.Location = new System.Drawing.Point(12, 25);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(160, 38);
            this.sortGroupBox.TabIndex = 19;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "sortBy";
            // 
            // lastModifiedRadioButton
            // 
            this.lastModifiedRadioButton.AutoSize = true;
            this.lastModifiedRadioButton.Location = new System.Drawing.Point(66, 13);
            this.lastModifiedRadioButton.Name = "lastModifiedRadioButton";
            this.lastModifiedRadioButton.Size = new System.Drawing.Size(88, 17);
            this.lastModifiedRadioButton.TabIndex = 1;
            this.lastModifiedRadioButton.TabStop = true;
            this.lastModifiedRadioButton.Text = "Last Modified";
            this.lastModifiedRadioButton.UseVisualStyleBackColor = true;
            this.lastModifiedRadioButton.CheckedChanged += new System.EventHandler(this.lastModifiedRadioButton_CheckedChanged);
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Checked = true;
            this.nameRadioButton.Location = new System.Drawing.Point(7, 13);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 714);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Last Modified -";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.Location = new System.Drawing.Point(595, 714);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 13);
            this.lastModifiedLabel.TabIndex = 21;
            // 
            // songLocationButton
            // 
            this.songLocationButton.Location = new System.Drawing.Point(516, 732);
            this.songLocationButton.Name = "songLocationButton";
            this.songLocationButton.Size = new System.Drawing.Size(127, 23);
            this.songLocationButton.TabIndex = 22;
            this.songLocationButton.Text = "Open Song Folder";
            this.songLocationButton.UseVisualStyleBackColor = true;
            this.songLocationButton.Click += new System.EventHandler(this.songLocationButton_Click);
            // 
            // songPictureBox
            // 
            this.songPictureBox.Location = new System.Drawing.Point(938, 725);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(115, 115);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 23;
            this.songPictureBox.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Songs in the playlist:";
            // 
            // deletePlaylistButton
            // 
            this.deletePlaylistButton.Location = new System.Drawing.Point(960, 38);
            this.deletePlaylistButton.Name = "deletePlaylistButton";
            this.deletePlaylistButton.Size = new System.Drawing.Size(92, 23);
            this.deletePlaylistButton.TabIndex = 25;
            this.deletePlaylistButton.Text = "Delete Playlist";
            this.deletePlaylistButton.UseVisualStyleBackColor = true;
            this.deletePlaylistButton.Click += new System.EventHandler(this.deletePlaylistButton_Click);
            // 
            // createPlaylistButton
            // 
            this.createPlaylistButton.Location = new System.Drawing.Point(861, 38);
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.Size = new System.Drawing.Size(93, 23);
            this.createPlaylistButton.TabIndex = 26;
            this.createPlaylistButton.Text = "Create Playlist";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // playlistPictureBox
            // 
            this.playlistPictureBox.Location = new System.Drawing.Point(922, 66);
            this.playlistPictureBox.Name = "playlistPictureBox";
            this.playlistPictureBox.Size = new System.Drawing.Size(130, 130);
            this.playlistPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playlistPictureBox.TabIndex = 27;
            this.playlistPictureBox.TabStop = false;
            this.playlistPictureBox.Click += new System.EventHandler(this.playlistPictureBox_Click);
            // 
            // downloadedLabel
            // 
            this.downloadedLabel.AutoSize = true;
            this.downloadedLabel.Location = new System.Drawing.Point(516, 760);
            this.downloadedLabel.Name = "downloadedLabel";
            this.downloadedLabel.Size = new System.Drawing.Size(0, 13);
            this.downloadedLabel.TabIndex = 28;
            // 
            // replaceImageButton
            // 
            this.replaceImageButton.Location = new System.Drawing.Point(922, 203);
            this.replaceImageButton.Name = "replaceImageButton";
            this.replaceImageButton.Size = new System.Drawing.Size(130, 23);
            this.replaceImageButton.TabIndex = 29;
            this.replaceImageButton.Text = "Replace Image";
            this.replaceImageButton.UseVisualStyleBackColor = true;
            this.replaceImageButton.Click += new System.EventHandler(this.replaceImageButton_Click);
            // 
            // changePlaylistNameButton
            // 
            this.changePlaylistNameButton.Location = new System.Drawing.Point(792, 203);
            this.changePlaylistNameButton.Name = "changePlaylistNameButton";
            this.changePlaylistNameButton.Size = new System.Drawing.Size(124, 23);
            this.changePlaylistNameButton.TabIndex = 30;
            this.changePlaylistNameButton.Text = "Change Playlist Name";
            this.changePlaylistNameButton.UseVisualStyleBackColor = true;
            this.changePlaylistNameButton.Click += new System.EventHandler(this.changePlaylistNameButton_Click);
            // 
            // addAllButton
            // 
            this.addAllButton.Location = new System.Drawing.Point(358, 682);
            this.addAllButton.Name = "addAllButton";
            this.addAllButton.Size = new System.Drawing.Size(106, 23);
            this.addAllButton.TabIndex = 31;
            this.addAllButton.Text = "Add All";
            this.addAllButton.UseVisualStyleBackColor = true;
            this.addAllButton.Click += new System.EventHandler(this.addAllButton_Click);
            // 
            // addUnplaylistedButton
            // 
            this.addUnplaylistedButton.Location = new System.Drawing.Point(239, 682);
            this.addUnplaylistedButton.Name = "addUnplaylistedButton";
            this.addUnplaylistedButton.Size = new System.Drawing.Size(113, 23);
            this.addUnplaylistedButton.TabIndex = 32;
            this.addUnplaylistedButton.Text = "Add Unplaylisted";
            this.addUnplaylistedButton.UseVisualStyleBackColor = true;
            this.addUnplaylistedButton.Click += new System.EventHandler(this.addUnplaylistedButton_Click);
            // 
            // removeDuplicatesButton
            // 
            this.removeDuplicatesButton.Location = new System.Drawing.Point(938, 682);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(114, 23);
            this.removeDuplicatesButton.TabIndex = 33;
            this.removeDuplicatesButton.Text = "Remove Duplicates";
            this.removeDuplicatesButton.UseVisualStyleBackColor = true;
            this.removeDuplicatesButton.Click += new System.EventHandler(this.removeDuplicatesButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 687);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Doubleclick to add or remove a song!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 852);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.removeDuplicatesButton);
            this.Controls.Add(this.addUnplaylistedButton);
            this.Controls.Add(this.addAllButton);
            this.Controls.Add(this.changePlaylistNameButton);
            this.Controls.Add(this.replaceImageButton);
            this.Controls.Add(this.downloadedLabel);
            this.Controls.Add(this.playlistPictureBox);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.deletePlaylistButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.songPictureBox);
            this.Controls.Add(this.songLocationButton);
            this.Controls.Add(this.lastModifiedLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.appearsInPlaylistTreeView);
            this.Controls.Add(this.hashLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allSongsTreeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playlistSongTreeView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playlistTreeView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView playlistTreeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView playlistSongTreeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView allSongsTreeView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.TreeView appearsInPlaylistTreeView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.RadioButton lastModifiedRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lastModifiedLabel;
        private System.Windows.Forms.Button songLocationButton;
        private System.Windows.Forms.PictureBox songPictureBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button deletePlaylistButton;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.PictureBox playlistPictureBox;
        private System.Windows.Forms.Label downloadedLabel;
        private System.Windows.Forms.Button replaceImageButton;
        private System.Windows.Forms.Button changePlaylistNameButton;
        private System.Windows.Forms.Button addAllButton;
        private System.Windows.Forms.Button addUnplaylistedButton;
        private System.Windows.Forms.Button removeDuplicatesButton;
        private System.Windows.Forms.Label label10;
    }
}

