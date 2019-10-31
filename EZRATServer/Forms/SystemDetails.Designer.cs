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
            this.lstInfos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstInfos
            // 
            this.lstInfos.FormattingEnabled = true;
            this.lstInfos.Location = new System.Drawing.Point(-2, 2);
            this.lstInfos.Name = "lstInfos";
            this.lstInfos.Size = new System.Drawing.Size(296, 225);
            this.lstInfos.TabIndex = 0;
            // 
            // SystemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 225);
            this.Controls.Add(this.lstInfos);
            this.MaximizeBox = false;
            this.Name = "SystemDetails";
            this.ShowIcon = false;
            this.Text = "SystemDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfos;
    }
}