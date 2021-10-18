
namespace Laboratory_work_0
{
    partial class Main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addBook = new System.Windows.Forms.Button();
            this.txtbx_year = new System.Windows.Forms.TextBox();
            this.txtbx_numOfPages = new System.Windows.Forms.TextBox();
            this.txtbx_author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_authors = new System.Windows.Forms.Button();
            this.btn_saveToFile = new System.Windows.Forms.Button();
            this.btn_loadFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_addBook
            // 
            this.btn_addBook.Location = new System.Drawing.Point(258, 22);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(75, 23);
            this.btn_addBook.TabIndex = 1;
            this.btn_addBook.Text = "add book";
            this.btn_addBook.UseVisualStyleBackColor = true;
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // txtbx_year
            // 
            this.txtbx_year.Location = new System.Drawing.Point(94, 25);
            this.txtbx_year.Name = "txtbx_year";
            this.txtbx_year.Size = new System.Drawing.Size(76, 20);
            this.txtbx_year.TabIndex = 3;
            this.txtbx_year.TextChanged += new System.EventHandler(this.txtbx_year_TextChanged);
            // 
            // txtbx_numOfPages
            // 
            this.txtbx_numOfPages.Location = new System.Drawing.Point(176, 25);
            this.txtbx_numOfPages.Name = "txtbx_numOfPages";
            this.txtbx_numOfPages.Size = new System.Drawing.Size(76, 20);
            this.txtbx_numOfPages.TabIndex = 4;
            this.txtbx_numOfPages.TextChanged += new System.EventHandler(this.txtbx_numOfPages_TextChanged);
            // 
            // txtbx_author
            // 
            this.txtbx_author.Location = new System.Drawing.Point(12, 25);
            this.txtbx_author.Name = "txtbx_author";
            this.txtbx_author.Size = new System.Drawing.Size(76, 20);
            this.txtbx_author.TabIndex = 5;
            this.txtbx_author.TextChanged += new System.EventHandler(this.txtbx_author_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Author";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year of release";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of pages";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(13, 293);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(13, 371);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_authors
            // 
            this.btn_authors.Location = new System.Drawing.Point(282, 371);
            this.btn_authors.Name = "btn_authors";
            this.btn_authors.Size = new System.Drawing.Size(75, 23);
            this.btn_authors.TabIndex = 11;
            this.btn_authors.Text = "authors";
            this.btn_authors.UseVisualStyleBackColor = true;
            this.btn_authors.Click += new System.EventHandler(this.btn_authors_Click);
            // 
            // btn_saveToFile
            // 
            this.btn_saveToFile.Location = new System.Drawing.Point(279, 293);
            this.btn_saveToFile.Name = "btn_saveToFile";
            this.btn_saveToFile.Size = new System.Drawing.Size(75, 23);
            this.btn_saveToFile.TabIndex = 12;
            this.btn_saveToFile.Text = "save to file";
            this.btn_saveToFile.UseVisualStyleBackColor = true;
            this.btn_saveToFile.Click += new System.EventHandler(this.btn_saveToFile_Click);
            // 
            // btn_loadFromFile
            // 
            this.btn_loadFromFile.Location = new System.Drawing.Point(279, 323);
            this.btn_loadFromFile.Name = "btn_loadFromFile";
            this.btn_loadFromFile.Size = new System.Drawing.Size(75, 23);
            this.btn_loadFromFile.TabIndex = 13;
            this.btn_loadFromFile.Text = "load from file";
            this.btn_loadFromFile.UseVisualStyleBackColor = true;
            this.btn_loadFromFile.Click += new System.EventHandler(this.btn_loadFromFile_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 406);
            this.Controls.Add(this.btn_loadFromFile);
            this.Controls.Add(this.btn_saveToFile);
            this.Controls.Add(this.btn_authors);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_author);
            this.Controls.Add(this.txtbx_numOfPages);
            this.Controls.Add(this.txtbx_year);
            this.Controls.Add(this.btn_addBook);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addBook;
        private System.Windows.Forms.TextBox txtbx_year;
        private System.Windows.Forms.TextBox txtbx_numOfPages;
        private System.Windows.Forms.TextBox txtbx_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_authors;
        private System.Windows.Forms.Button btn_saveToFile;
        private System.Windows.Forms.Button btn_loadFromFile;
    }
}

