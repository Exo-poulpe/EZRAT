namespace EZRATServer
{
    partial class MessageBoxEditor
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.pnlIcon = new System.Windows.Forms.Panel();
            this.cmbIcon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title : ";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(10, 56);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(37, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text : ";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(14, 29);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(286, 20);
            this.tbxTitle.TabIndex = 2;
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(13, 75);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(286, 96);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = "";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(331, 148);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.Text = "OK";
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // pnlIcon
            // 
            this.pnlIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIcon.Location = new System.Drawing.Point(331, 75);
            this.pnlIcon.Name = "pnlIcon";
            this.pnlIcon.Size = new System.Drawing.Size(47, 40);
            this.pnlIcon.TabIndex = 5;
            // 
            // cmbIcon
            // 
            this.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIcon.FormattingEnabled = true;
            this.cmbIcon.Location = new System.Drawing.Point(317, 29);
            this.cmbIcon.Name = "cmbIcon";
            this.cmbIcon.Size = new System.Drawing.Size(121, 21);
            this.cmbIcon.TabIndex = 6;
            // 
            // MessageBoxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 207);
            this.Controls.Add(this.cmbIcon);
            this.Controls.Add(this.pnlIcon);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBoxEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Panel pnlIcon;
        private System.Windows.Forms.ComboBox cmbIcon;
    }
}