
namespace BeatSaber_Playlist_Master
{
    partial class NewPlaylistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlaylistForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createPlaylistButton = new System.Windows.Forms.Button();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.authorTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // createPlaylistButton
            // 
            resources.ApplyResources(this.createPlaylistButton, "createPlaylistButton");
            this.createPlaylistButton.Name = "createPlaylistButton";
            this.createPlaylistButton.UseVisualStyleBackColor = true;
            this.createPlaylistButton.Click += new System.EventHandler(this.createPlaylistButton_Click);
            // 
            // chooseImageButton
            // 
            resources.ApplyResources(this.chooseImageButton, "chooseImageButton");
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // nameTextbox
            // 
            resources.ApplyResources(this.nameTextbox, "nameTextbox");
            this.nameTextbox.Name = "nameTextbox";
            // 
            // authorTextbox
            // 
            resources.ApplyResources(this.authorTextbox, "authorTextbox");
            this.authorTextbox.Name = "authorTextbox";
            // 
            // descriptionTextBox
            // 
            resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
            this.descriptionTextBox.Name = "descriptionTextBox";
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // NewPlaylistForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.authorTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.chooseImageButton);
            this.Controls.Add(this.createPlaylistButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPlaylistForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createPlaylistButton;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox authorTextbox;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}