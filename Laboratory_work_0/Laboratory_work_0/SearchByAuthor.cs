using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_0
{
    public partial class SearchByAuthor : Form
    {
        public BindingList<Book> RecievedBooks { get; set; }
        public BindingList<Book> SearchedBooks { get; set; }

        public SearchByAuthor(BindingList<Book> books)
        {
            InitializeComponent();
            this.RecievedBooks = books;
        }
        
        private void btn_search_Click(object sender, EventArgs e)
        {
            String bufAuthor = txtbx_author.Text;
            BindingList<Book> searchedBooks = new BindingList<Book>();
            foreach(Book book in RecievedBooks)
            {
                if(book.Author.Equals(bufAuthor))
                {
                    searchedBooks.Add(book);
                }
            }
            dataGridView1.DataSource = searchedBooks;
        }

        private void txtbx_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchByAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
