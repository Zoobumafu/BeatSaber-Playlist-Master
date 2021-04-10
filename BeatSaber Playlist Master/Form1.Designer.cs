namespace BeatSaberPlaylistMaster
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
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.lastModifiedRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lastModifiedLabel = new System.Windows.Forms.Label();
            this.songLocationButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.deletePlaylistButton = new System.Windows.Forms.Button();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.downloadedLabel = new System.Windows.Forms.Label();
            this.replaceImageButton = new System.Windows.Forms.Button();
            this.changePlaylistNameButton = new System.Windows.Forms.Button();
            this.addAllButton = new System.Windows.Forms.Button();
            this.addUnplaylistedButton = new System.Windows.Forms.Button();
            this.removeDuplicatesButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.songUpdateLabel = new System.Windows.Forms.Label();
            this.downloadMissingSongsButton = new System.Windows.Forms.Button();
            this.currentlyDownloadingLabel = new System.Windows.Forms.Label();
            this.updateAlertLabel = new System.Windows.Forms.Label();
            this.downloadLimitReachedAlert = new System.Windows.Forms.Label();
            this.downloadAllMissingSongsButton = new System.Windows.Forms.Button();
            this.playlistDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.playlistPictureBox = new System.Windows.Forms.PictureBox();
            this.songPictureBox = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.songDownloadLabel = new System.Windows.Forms.Label();
            this.sortGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playlistTreeView1
            // 
            this.playlistTreeView1.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Playlists";
            // 
            // playlistSongTreeView
            // 
            this.playlistSongTreeView.BackColor = System.Drawing.Color.NavajoWhite;
            this.playlistSongTreeView.HideSelection = false;
            this.playlistSongTreeView.Location = new System.Drawing.Point(514, 237);
            this.playlistSongTreeView.Name = "playlistSongTreeView";
            this.playlistSongTreeView.Size = new System.Drawing.Size(539, 400);
            this.playlistSongTreeView.TabIndex = 2;
            this.playlistSongTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.songTreeView1_AfterSelect);
            this.playlistSongTreeView.DoubleClick += new System.EventHandler(this.songTreeView1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Songs";
            // 
            // allSongsTreeView
            // 
            this.allSongsTreeView.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Song Name -";
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameLabel.Location = new System.Drawing.Point(106, 707);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 20);
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
            this.appearsInPlaylistTreeView.BackColor = System.Drawing.Color.NavajoWhite;
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
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Window;
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
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.lastModifiedRadioButton);
            this.sortGroupBox.Controls.Add(this.nameRadioButton);
            this.sortGroupBox.Location = new System.Drawing.Point(12, 25);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Size = new System.Drawing.Size(160, 38);
            this.sortGroupBox.TabIndex = 19;
            this.sortGroupBox.TabStop = false;
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
            this.label8.Location = new System.Drawing.Point(486, 801);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Last Modified -";
            // 
            // lastModifiedLabel
            // 
            this.lastModifiedLabel.AutoSize = true;
            this.lastModifiedLabel.Location = new System.Drawing.Point(562, 801);
            this.lastModifiedLabel.Name = "lastModifiedLabel";
            this.lastModifiedLabel.Size = new System.Drawing.Size(0, 13);
            this.lastModifiedLabel.TabIndex = 21;
            // 
            // songLocationButton
            // 
            this.songLocationButton.Location = new System.Drawing.Point(486, 817);
            this.songLocationButton.Name = "songLocationButton";
            this.songLocationButton.Size = new System.Drawing.Size(164, 23);
            this.songLocationButton.TabIndex = 22;
            this.songLocationButton.Text = "Open Song Folder";
            this.songLocationButton.UseVisualStyleBackColor = true;
            this.songLocationButton.Click += new System.EventHandler(this.songLocationButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
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
            // downloadedLabel
            // 
            this.downloadedLabel.AutoSize = true;
            this.downloadedLabel.ForeColor = System.Drawing.Color.Red;
            this.downloadedLabel.Location = new System.Drawing.Point(658, 822);
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
            this.removeDuplicatesButton.Location = new System.Drawing.Point(678, 643);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(169, 23);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Update List!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // songUpdateLabel
            // 
            this.songUpdateLabel.AutoSize = true;
            this.songUpdateLabel.Location = new System.Drawing.Point(385, 9);
            this.songUpdateLabel.Name = "songUpdateLabel";
            this.songUpdateLabel.Size = new System.Drawing.Size(0, 13);
            this.songUpdateLabel.TabIndex = 36;
            // 
            // downloadMissingSongsButton
            // 
            this.downloadMissingSongsButton.Location = new System.Drawing.Point(514, 643);
            this.downloadMissingSongsButton.Name = "downloadMissingSongsButton";
            this.downloadMissingSongsButton.Size = new System.Drawing.Size(161, 23);
            this.downloadMissingSongsButton.TabIndex = 37;
            this.downloadMissingSongsButton.Text = "Download Missing Songs";
            this.downloadMissingSongsButton.UseVisualStyleBackColor = true;
            this.downloadMissingSongsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // currentlyDownloadingLabel
            // 
            this.currentlyDownloadingLabel.AutoSize = true;
            this.currentlyDownloadingLabel.ForeColor = System.Drawing.Color.Blue;
            this.currentlyDownloadingLabel.Location = new System.Drawing.Point(511, 697);
            this.currentlyDownloadingLabel.Name = "currentlyDownloadingLabel";
            this.currentlyDownloadingLabel.Size = new System.Drawing.Size(0, 13);
            this.currentlyDownloadingLabel.TabIndex = 38;
            // 
            // updateAlertLabel
            // 
            this.updateAlertLabel.AutoSize = true;
            this.updateAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAlertLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.updateAlertLabel.Location = new System.Drawing.Point(319, 9);
            this.updateAlertLabel.Name = "updateAlertLabel";
            this.updateAlertLabel.Size = new System.Drawing.Size(0, 13);
            this.updateAlertLabel.TabIndex = 39;
            // 
            // downloadLimitReachedAlert
            // 
            this.downloadLimitReachedAlert.AutoSize = true;
            this.downloadLimitReachedAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadLimitReachedAlert.ForeColor = System.Drawing.Color.Red;
            this.downloadLimitReachedAlert.Location = new System.Drawing.Point(514, 736);
            this.downloadLimitReachedAlert.Name = "downloadLimitReachedAlert";
            this.downloadLimitReachedAlert.Size = new System.Drawing.Size(0, 16);
            this.downloadLimitReachedAlert.TabIndex = 40;
            // 
            // downloadAllMissingSongsButton
            // 
            this.downloadAllMissingSongsButton.Location = new System.Drawing.Point(514, 672);
            this.downloadAllMissingSongsButton.Name = "downloadAllMissingSongsButton";
            this.downloadAllMissingSongsButton.Size = new System.Drawing.Size(333, 23);
            this.downloadAllMissingSongsButton.TabIndex = 41;
            this.downloadAllMissingSongsButton.Text = "Download ALL Missing Songs";
            this.downloadAllMissingSongsButton.UseVisualStyleBackColor = true;
            this.downloadAllMissingSongsButton.Click += new System.EventHandler(this.downloadAllMissingSongsButton_Click);
            // 
            // playlistDescriptionTextBox
            // 
            this.playlistDescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.playlistDescriptionTextBox.Location = new System.Drawing.Point(486, 755);
            this.playlistDescriptionTextBox.Name = "playlistDescriptionTextBox";
            this.playlistDescriptionTextBox.Size = new System.Drawing.Size(358, 40);
            this.playlistDescriptionTextBox.TabIndex = 42;
            this.playlistDescriptionTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 727);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 23);
            this.label11.TabIndex = 43;
            this.label11.Text = "Playlist Description";
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
            // songPictureBox
            // 
            this.songPictureBox.Location = new System.Drawing.Point(853, 643);
            this.songPictureBox.Name = "songPictureBox";
            this.songPictureBox.Size = new System.Drawing.Size(200, 200);
            this.songPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.songPictureBox.TabIndex = 23;
            this.songPictureBox.TabStop = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 852);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 28);
            this.label12.TabIndex = 44;
            this.label12.Text = "Downloading Song -";
            // 
            // songDownloadLabel
            // 
            this.songDownloadLabel.AutoSize = true;
            this.songDownloadLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDownloadLabel.Location = new System.Drawing.Point(199, 852);
            this.songDownloadLabel.Name = "songDownloadLabel";
            this.songDownloadLabel.Size = new System.Drawing.Size(0, 28);
            this.songDownloadLabel.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1065, 889);
            this.Controls.Add(this.songDownloadLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.playlistDescriptionTextBox);
            this.Controls.Add(this.downloadAllMissingSongsButton);
            this.Controls.Add(this.downloadLimitReachedAlert);
            this.Controls.Add(this.updateAlertLabel);
            this.Controls.Add(this.currentlyDownloadingLabel);
            this.Controls.Add(this.downloadMissingSongsButton);
            this.Controls.Add(this.songUpdateLabel);
            this.Controls.Add(this.button1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BeatSaber Playlist Master";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sortGroupBox.ResumeLayout(false);
            this.sortGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songPictureBox)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label songUpdateLabel;
        private System.Windows.Forms.Button downloadMissingSongsButton;
        private System.Windows.Forms.Label currentlyDownloadingLabel;
        private System.Windows.Forms.Label updateAlertLabel;
        private System.Windows.Forms.Label downloadLimitReachedAlert;
        private System.Windows.Forms.Button downloadAllMissingSongsButton;
        private System.Windows.Forms.RichTextBox playlistDescriptionTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label songDownloadLabel;
    }
}

