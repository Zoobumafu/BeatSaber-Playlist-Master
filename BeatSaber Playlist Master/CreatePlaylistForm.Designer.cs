namespace BeatSaberPlaylistMaster
{
    partial class CreatePlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlaylistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.createNewPlaylistButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.playlistNameTextbox = new System.Windows.Forms.TextBox();
            this.authorNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // createNewPlaylistButton
            // 
            this.createNewPlaylistButton.Location = new System.Drawing.Point(85, 107);
            this.createNewPlaylistButton.Name = "createNewPlaylistButton";
            this.createNewPlaylistButton.Size = new System.Drawing.Size(75, 23);
            this.createNewPlaylistButton.TabIndex = 1;
            this.createNewPlaylistButton.Text = "Submit";
            this.createNewPlaylistButton.UseVisualStyleBackColor = true;
            this.createNewPlaylistButton.Click += new System.EventHandler(this.createNewPlaylistButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author Name:";
            // 
            // playlistNameTextbox
            // 
            this.playlistNameTextbox.Location = new System.Drawing.Point(143, 10);
            this.playlistNameTextbox.Name = "playlistNameTextbox";
            this.playlistNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.playlistNameTextbox.TabIndex = 3;
            // 
            // authorNameTextbox
            // 
            this.authorNameTextbox.Location = new System.Drawing.Point(143, 43);
            this.authorNameTextbox.Name = "authorNameTextbox";
            this.authorNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.authorNameTextbox.TabIndex = 4;
            // 
            // CreatePlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 142);
            this.Controls.Add(this.authorNameTextbox);
            this.Controls.Add(this.playlistNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createNewPlaylistButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreatePlaylistForm";
            this.Text = "CreatePlaylistForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createNewPlaylistButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playlistNameTextbox;
        private System.Windows.Forms.TextBox authorNameTextbox;
    }
}