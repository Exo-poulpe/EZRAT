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
            this.panTools = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.lstIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstWindows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panTools
            // 
            this.panTools.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.btnSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(0, 313);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(93, 39);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Location = new System.Drawing.Point(0, 223);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(93, 39);
            this.btnBuild.TabIndex = 3;
            this.btnBuild.Text = "Builder";
            this.btnBuild.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(0, 130);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(93, 39);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop server";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(0, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 39);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start server";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lstIP,
            this.lstUser,
            this.lstName,
            this.lstWindows,
            this.lstPing});
            this.dgvClients.Location = new System.Drawing.Point(92, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(735, 419);
            this.dgvClients.TabIndex = 1;
            // 
            // lstIP
            // 
            this.lstIP.HeaderText = "IP";
            this.lstIP.Name = "lstIP";
            this.lstIP.ReadOnly = true;
            // 
            // lstUser
            // 
            this.lstUser.HeaderText = "User";
            this.lstUser.Name = "lstUser";
            this.lstUser.ReadOnly = true;
            // 
            // lstName
            // 
            this.lstName.HeaderText = "Name";
            this.lstName.Name = "lstName";
            this.lstName.ReadOnly = true;
            // 
            // lstWindows
            // 
            this.lstWindows.HeaderText = "Windows";
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.ReadOnly = true;
            // 
            // lstPing
            // 
            this.lstPing.HeaderText = "Ping";
            this.lstPing.Name = "lstPing";
            this.lstPing.ReadOnly = true;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 417);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.panTools);
            this.Name = "Server";
            this.Text = "Server EZRAT";
            this.panTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

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
    }
}

