namespace EZRATServer.Forms
{
    partial class SystemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemDetails));
            this.lstInfos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstInfos
            // 
            this.lstInfos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstInfos.FormattingEnabled = true;
            this.lstInfos.ItemHeight = 20;
            this.lstInfos.Location = new System.Drawing.Point(-2, 2);
            this.lstInfos.Name = "lstInfos";
            this.lstInfos.Size = new System.Drawing.Size(385, 224);
            this.lstInfos.TabIndex = 0;
            // 
            // SystemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 225);
            this.Controls.Add(this.lstInfos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SystemDetails";
            this.Text = "SystemDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfos;
    }
}