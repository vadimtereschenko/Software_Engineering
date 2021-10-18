
namespace Laboratory_work_0
{
    partial class UniqueAuthors
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
            this.lstbx_authors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstbx_authors
            // 
            this.lstbx_authors.FormattingEnabled = true;
            this.lstbx_authors.Location = new System.Drawing.Point(13, 13);
            this.lstbx_authors.Name = "lstbx_authors";
            this.lstbx_authors.Size = new System.Drawing.Size(206, 277);
            this.lstbx_authors.TabIndex = 0;
            this.lstbx_authors.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UniqueAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 315);
            this.Controls.Add(this.lstbx_authors);
            this.Name = "UniqueAuthors";
            this.Text = "UniqueAuthors";
            this.Load += new System.EventHandler(this.UniqueAuthors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_authors;
    }
}