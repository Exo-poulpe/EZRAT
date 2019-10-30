namespace EZRATServer
{
    partial class FileBrowser
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
            this.components = new System.ComponentModel.Container();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblDrives = new System.Windows.Forms.Label();
            this.cmbDrives = new System.Windows.Forms.ComboBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.uploadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.renameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.HideSelection = false;
            this.lstFiles.Location = new System.Drawing.Point(-1, 22);
            this.lstFiles.MultiSelect = false;
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(660, 296);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.downloadMenu,
            this.uploadMenu,
            this.renameMenu,
            this.deleteMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // downloadMenu
            // 
            this.downloadMenu.Name = "downloadMenu";
            this.downloadMenu.Size = new System.Drawing.Size(180, 22);
            this.downloadMenu.Text = "Download";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblDrives
            // 
            this.lblDrives.AutoSize = true;
            this.lblDrives.Location = new System.Drawing.Point(12, 5);
            this.lblDrives.Name = "lblDrives";
            this.lblDrives.Size = new System.Drawing.Size(46, 13);
            this.lblDrives.TabIndex = 2;
            this.lblDrives.Text = "Drives : ";
            // 
            // cmbDrives
            // 
            this.cmbDrives.FormattingEnabled = true;
            this.cmbDrives.Location = new System.Drawing.Point(56, 1);
            this.cmbDrives.Name = "cmbDrives";
            this.cmbDrives.Size = new System.Drawing.Size(105, 21);
            this.cmbDrives.TabIndex = 3;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(201, 6);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path";
            // 
            // picUp
            // 
            this.picUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUp.Image = global::EZRATServer.Properties.Resources.up_50;
            this.picUp.Location = new System.Drawing.Point(169, 0);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(25, 23);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 5;
            this.picUp.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(657, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(165, 17);
            this.lblStatus.Text = "Nombre de fichier et dossier : ";
            // 
            // uploadMenu
            // 
            this.uploadMenu.Name = "uploadMenu";
            this.uploadMenu.Size = new System.Drawing.Size(180, 22);
            this.uploadMenu.Text = "Upload";
            // 
            // renameMenu
            // 
            this.renameMenu.Name = "renameMenu";
            this.renameMenu.Size = new System.Drawing.Size(180, 22);
            this.renameMenu.Text = "Rename";
            // 
            // deleteMenu
            // 
            this.deleteMenu.Name = "deleteMenu";
            this.deleteMenu.Size = new System.Drawing.Size(180, 22);
            this.deleteMenu.Text = "Delete";
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 343);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.cmbDrives);
            this.Controls.Add(this.lblDrives);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FileBrowser";
            this.Text = "FileBrowser";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblDrives;
        private System.Windows.Forms.ComboBox cmbDrives;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem downloadMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem uploadMenu;
        private System.Windows.Forms.ToolStripMenuItem renameMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMenu;
    }
}