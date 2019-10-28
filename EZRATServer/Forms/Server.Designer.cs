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
            this.lstClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageContextMenu1 = new EZRATServer.Utils.ImageContextMenu();
            this.panTools.SuspendLayout();
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
            // lstClients
            // 
            this.lstClients.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstClients.BackColor = System.Drawing.SystemColors.InfoText;
            this.lstClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstClients.ContextMenuStrip = this.imageContextMenu1;
            this.lstClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClients.ForeColor = System.Drawing.Color.White;
            this.lstClients.FullRowSelect = true;
            this.lstClients.GridLines = true;
            this.lstClients.HideSelection = false;
            this.lstClients.Location = new System.Drawing.Point(93, 0);
            this.lstClients.MultiSelect = false;
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(735, 419);
            this.lstClients.TabIndex = 1;
            this.lstClients.UseCompatibleStateImageBehavior = false;
            this.lstClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ip";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "User";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Windows";
            // 
            // imageContextMenu1
            // 
            this.imageContextMenu1.Name = "imageContextMenu1";
            this.imageContextMenu1.Size = new System.Drawing.Size(138, 48);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 417);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.panTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "Server EZRAT";
            this.panTools.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lstClients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Utils.ImageContextMenu imageContextMenu1;
    }
}

