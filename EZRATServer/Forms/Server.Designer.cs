namespace EZRATServer
{
    partial class Server
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.panTools = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.exeLock = new System.Windows.Forms.ToolStripMenuItem();
            this.exeRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.exeShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClients = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageContextMenu1 = new EZRATServer.Utils.ImageContextMenu();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panTools.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTools
            // 
            this.panTools.BackColor = System.Drawing.Color.LightGray;
            this.panTools.Controls.Add(this.btnSettings);
            this.panTools.Controls.Add(this.btnBuild);
            this.panTools.Controls.Add(this.btnStop);
            this.panTools.Controls.Add(this.btnStart);
            this.panTools.Location = new System.Drawing.Point(0, 0);
            this.panTools.Name = "panTools";
            this.panTools.Size = new System.Drawing.Size(96, 422);
            this.panTools.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSettings.Location = new System.Drawing.Point(0, 313);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(96, 39);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuild.Location = new System.Drawing.Point(0, 223);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(96, 39);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Builder";
            this.btnBuild.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStop.Location = new System.Drawing.Point(0, 130);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 39);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop server";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Location = new System.Drawing.Point(0, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 39);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // menuExecute
            // 
            this.menuExecute.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exeLock,
            this.exeRestart,
            this.exeShutdown});
            this.menuExecute.Image = global::EZRATServer.Properties.Resources.UAC;
            this.menuExecute.Name = "menuExecute";
            this.menuExecute.Size = new System.Drawing.Size(152, 22);
            this.menuExecute.Text = "Execute";
            // 
            // exeLock
            // 
            this.exeLock.Image = global::EZRATServer.Properties.Resources.locked;
            this.exeLock.Name = "exeLock";
            this.exeLock.Size = new System.Drawing.Size(128, 22);
            this.exeLock.Text = "Lock";
            // 
            // exeRestart
            // 
            this.exeRestart.Image = global::EZRATServer.Properties.Resources.restart;
            this.exeRestart.Name = "exeRestart";
            this.exeRestart.Size = new System.Drawing.Size(128, 22);
            this.exeRestart.Text = "Restart";
            // 
            // exeShutdown
            // 
            this.exeShutdown.Image = global::EZRATServer.Properties.Resources.shutdown;
            this.exeShutdown.Name = "exeShutdown";
            this.exeShutdown.Size = new System.Drawing.Size(128, 22);
            this.exeShutdown.Text = "Shutdown";
            // 
            // lstClients
            // 
            this.lstClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1});
            this.lstClients.ContextMenuStrip = this.imageContextMenu1;
            this.lstClients.FullRowSelect = true;
            this.lstClients.GridLines = true;
            this.lstClients.HideSelection = false;
            this.lstClients.Location = new System.Drawing.Point(96, 0);
            this.lstClients.MultiSelect = false;
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(729, 419);
            this.lstClients.TabIndex = 2;
            this.lstClients.UseCompatibleStateImageBehavior = false;
            this.lstClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Id";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ip : Port";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "User";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Windows";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Version";
            // 
            // imageContextMenu1
            // 
            this.imageContextMenu1.Name = "imageContextMenu1";
            this.imageContextMenu1.Size = new System.Drawing.Size(153, 158);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 17);
            this.lblStatus.Text = "Server stoped";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 417);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.panTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server EZRAT";
            this.panTools.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTools;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstWindows;
        private System.Windows.Forms.DataGridViewTextBoxColumn lstPing;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnStop;
        private Utils.ImageContextMenu imageContextMenu1;
        private System.Windows.Forms.ListView lstClients;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem menuExecute;
        private System.Windows.Forms.ToolStripMenuItem exeLock;
        private System.Windows.Forms.ToolStripMenuItem exeRestart;
        private System.Windows.Forms.ToolStripMenuItem exeShutdown;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

