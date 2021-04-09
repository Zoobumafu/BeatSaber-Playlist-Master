namespace BeatSaberPlaylistMaster
{
    partial class DownloadQueue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadQueue));
            this.label1 = new System.Windows.Forms.Label();
            this.queueTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.currentlyDownloadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Queue:";
            // 
            // queueTreeView
            // 
            this.queueTreeView.Location = new System.Drawing.Point(12, 30);
            this.queueTreeView.Name = "queueTreeView";
            this.queueTreeView.Size = new System.Drawing.Size(341, 226);
            this.queueTreeView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Downloading:";
            // 
            // currentlyDownloadLabel
            // 
            this.currentlyDownloadLabel.AutoSize = true;
            this.currentlyDownloadLabel.Location = new System.Drawing.Point(90, 259);
            this.currentlyDownloadLabel.Name = "currentlyDownloadLabel";
            this.currentlyDownloadLabel.Size = new System.Drawing.Size(0, 13);
            this.currentlyDownloadLabel.TabIndex = 3;
            // 
            // DownloadQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 300);
            this.Controls.Add(this.currentlyDownloadLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.queueTreeView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DownloadQueue";
            this.Text = "DownloadQueue";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DownloadQueue_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView queueTreeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentlyDownloadLabel;
    }
}