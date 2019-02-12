namespace WinFormProject
{
    partial class About
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
            this.rtbxAbout = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxAbout
            // 
            this.rtbxAbout.Location = new System.Drawing.Point(24, 25);
            this.rtbxAbout.Name = "rtbxAbout";
            this.rtbxAbout.Size = new System.Drawing.Size(321, 190);
            this.rtbxAbout.TabIndex = 0;
            this.rtbxAbout.Text = "";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 627);
            this.Controls.Add(this.rtbxAbout);
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxAbout;
    }
}