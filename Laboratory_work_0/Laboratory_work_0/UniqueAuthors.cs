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
    public partial class UniqueAuthors : Form
    {
        public BindingList<Book> RecievedBooks { get; set; }

        public UniqueAuthors(BindingList<Book> books)
        {
            InitializeComponent();
            this.RecievedBooks = books;
        }

        private void UniqueAuthors_Load(object sender, EventArgs e)
        {
            BindingList<string> allAuthors = new BindingList<string>();
            foreach (Book book in RecievedBooks)
            {
                allAuthors.Add(book.Author);
            }
            List<string> uniqueAuthors = new List<string>();
            uniqueAuthors.AddRange(allAuthors.Distinct());

            foreach (string author in uniqueAuthors)
            {
                lstbx_authors.Items.Add(author);
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
