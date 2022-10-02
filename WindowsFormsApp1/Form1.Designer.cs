
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VLCPlugin = new AxAXVLC.AxVLCPlugin2();
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.buttonNextVideo = new System.Windows.Forms.Button();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.labelVideoName = new System.Windows.Forms.Label();
            this.panelRecentFolders = new System.Windows.Forms.Panel();
            this.labelRecentFolders = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonUncheck = new System.Windows.Forms.Button();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.buttonSaveFolders = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSaveSeen = new System.Windows.Forms.Button();
            this.buttonLoadSeen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).BeginInit();
            this.SuspendLayout();
            // 
            // VLCPlugin
            // 
            this.VLCPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VLCPlugin.Enabled = true;
            this.VLCPlugin.Location = new System.Drawing.Point(15, 33);
            this.VLCPlugin.Name = "VLCPlugin";
            this.VLCPlugin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VLCPlugin.OcxState")));
            this.VLCPlugin.Size = new System.Drawing.Size(510, 290);
            this.VLCPlugin.TabIndex = 0;
            this.VLCPlugin.Enter += new System.EventHandler(this.axVLCPlugin21_Enter);
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.Location = new System.Drawing.Point(15, 9);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFiles.TabIndex = 1;
            this.buttonOpenFiles.Text = "Open Files";
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // buttonNextVideo
            // 
            this.buttonNextVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNextVideo.Location = new System.Drawing.Point(13, 355);
            this.buttonNextVideo.Name = "buttonNextVideo";
            this.buttonNextVideo.Size = new System.Drawing.Size(75, 23);
            this.buttonNextVideo.TabIndex = 2;
            this.buttonNextVideo.Text = "Next Video";
            this.buttonNextVideo.UseVisualStyleBackColor = true;
            this.buttonNextVideo.Click += new System.EventHandler(this.buttonNextVideo_Click);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFolder.Location = new System.Drawing.Point(531, 329);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFolder.TabIndex = 3;
            this.buttonAddFolder.Text = "Add Folder";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // labelVideoName
            // 
            this.labelVideoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelVideoName.AutoSize = true;
            this.labelVideoName.Location = new System.Drawing.Point(12, 334);
            this.labelVideoName.Name = "labelVideoName";
            this.labelVideoName.Size = new System.Drawing.Size(0, 13);
            this.labelVideoName.TabIndex = 5;
            // 
            // panelRecentFolders
            // 
            this.panelRecentFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRecentFolders.AutoScroll = true;
            this.panelRecentFolders.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRecentFolders.Location = new System.Drawing.Point(531, 33);
            this.panelRecentFolders.Name = "panelRecentFolders";
            this.panelRecentFolders.Size = new System.Drawing.Size(237, 290);
            this.panelRecentFolders.TabIndex = 0;
            // 
            // labelRecentFolders
            // 
            this.labelRecentFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRecentFolders.AutoSize = true;
            this.labelRecentFolders.Location = new System.Drawing.Point(528, 9);
            this.labelRecentFolders.Name = "labelRecentFolders";
            this.labelRecentFolders.Size = new System.Drawing.Size(49, 13);
            this.labelRecentFolders.TabIndex = 6;
            this.labelRecentFolders.Text = "Move to:";
            this.labelRecentFolders.Click += new System.EventHandler(this.labelRecentFolders_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileName.Location = new System.Drawing.Point(531, 358);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(237, 20);
            this.textBoxFileName.TabIndex = 7;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            this.textBoxFileName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxFileName_MouseDown);
            // 
            // buttonMove
            // 
            this.buttonMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMove.AutoSize = true;
            this.buttonMove.Location = new System.Drawing.Point(531, 384);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(89, 23);
            this.buttonMove.TabIndex = 8;
            this.buttonMove.Text = "Rename/Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_click);
            // 
            // buttonUncheck
            // 
            this.buttonUncheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUncheck.Location = new System.Drawing.Point(612, 329);
            this.buttonUncheck.Name = "buttonUncheck";
            this.buttonUncheck.Size = new System.Drawing.Size(75, 23);
            this.buttonUncheck.TabIndex = 9;
            this.buttonUncheck.Text = "Uncheck";
            this.buttonUncheck.UseVisualStyleBackColor = true;
            this.buttonUncheck.Click += new System.EventHandler(this.buttonUncheck_Click);
            // 
            // buttonOpenLocation
            // 
            this.buttonOpenLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenLocation.AutoSize = true;
            this.buttonOpenLocation.Location = new System.Drawing.Point(94, 355);
            this.buttonOpenLocation.Name = "buttonOpenLocation";
            this.buttonOpenLocation.Size = new System.Drawing.Size(95, 23);
            this.buttonOpenLocation.TabIndex = 10;
            this.buttonOpenLocation.Text = "Open in Explorer";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // buttonSaveFolders
            // 
            this.buttonSaveFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveFolders.AutoSize = true;
            this.buttonSaveFolders.Location = new System.Drawing.Point(612, 4);
            this.buttonSaveFolders.Name = "buttonSaveFolders";
            this.buttonSaveFolders.Size = new System.Drawing.Size(79, 23);
            this.buttonSaveFolders.TabIndex = 11;
            this.buttonSaveFolders.Text = "Save Folders";
            this.buttonSaveFolders.UseVisualStyleBackColor = true;
            this.buttonSaveFolders.Click += new System.EventHandler(this.buttonSaveFolders_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(693, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Load Folders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonLoadFolders_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(15, 385);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete File";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSaveSeen
            // 
            this.buttonSaveSeen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveSeen.AutoSize = true;
            this.buttonSaveSeen.Location = new System.Drawing.Point(310, 9);
            this.buttonSaveSeen.Name = "buttonSaveSeen";
            this.buttonSaveSeen.Size = new System.Drawing.Size(105, 23);
            this.buttonSaveSeen.TabIndex = 14;
            this.buttonSaveSeen.Text = "Save Seen Files";
            this.buttonSaveSeen.UseVisualStyleBackColor = true;
            this.buttonSaveSeen.Click += new System.EventHandler(this.buttonSaveSeen_Click);
            // 
            // buttonLoadSeen
            // 
            this.buttonLoadSeen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadSeen.AutoSize = true;
            this.buttonLoadSeen.Location = new System.Drawing.Point(421, 9);
            this.buttonLoadSeen.Name = "buttonLoadSeen";
            this.buttonLoadSeen.Size = new System.Drawing.Size(104, 23);
            this.buttonLoadSeen.TabIndex = 15;
            this.buttonLoadSeen.Text = "Load Seen Files";
            this.buttonLoadSeen.UseVisualStyleBackColor = true;
            this.buttonLoadSeen.Click += new System.EventHandler(this.buttonLoadSeen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 431);
            this.Controls.Add(this.buttonLoadSeen);
            this.Controls.Add(this.buttonSaveSeen);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSaveFolders);
            this.Controls.Add(this.buttonOpenLocation);
            this.Controls.Add(this.buttonUncheck);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelRecentFolders);
            this.Controls.Add(this.panelRecentFolders);
            this.Controls.Add(this.labelVideoName);
            this.Controls.Add(this.buttonAddFolder);
            this.Controls.Add(this.buttonNextVideo);
            this.Controls.Add(this.buttonOpenFiles);
            this.Controls.Add(this.VLCPlugin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VLCPlugin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 VLCPlugin;
        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.Button buttonNextVideo;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Label labelVideoName;
        private System.Windows.Forms.Panel panelRecentFolders;
        private System.Windows.Forms.Label labelRecentFolders;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonUncheck;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.Button buttonSaveFolders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSaveSeen;
        private System.Windows.Forms.Button buttonLoadSeen;
    }
}

