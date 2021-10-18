using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace Laboratory_work_0
{
    public partial class Main : Form
    {
        public BindingList<Book> Books { get; set; }

        public Main()
        {
            Books = GetBooks();
            InitializeComponent();
            
        }

        private BindingList<Book> GetBooks()
        {
            var list = new BindingList<Book>();
            list.Add(new Book("Test Author #1", 1995, 1024));
            list.Add(new Book("Test Author #2", 1996, 1025));
            list.Add(new Book("Test Author #3", 1997, 1026));
            list.Add(new Book("Test Author #4", 1998, 1027));
            list.Add(new Book("Test Author #5", 1999, 1028));

            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var books = this.Books;
            dataGridView1.DataSource = books;
        }

        private void btn_addBook_Click(object sender, EventArgs e)
        {
            String bufAuthor = txtbx_author.Text;
            int bufYear = int.Parse(txtbx_year.Text);
            int bufNumOfPages = int.Parse(txtbx_numOfPages.Text);
            Books.Add(new Book(bufAuthor, bufYear, bufNumOfPages));
        }

        private void txtbx_author_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_year_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_numOfPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Books.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchByAuthor searchByAuthor = new SearchByAuthor(Books);
            searchByAuthor.Show();
        }

        private void btn_authors_Click(object sender, EventArgs e)
        {
            UniqueAuthors uniqueAuthors = new UniqueAuthors(Books);
            uniqueAuthors.Show();
        }

        private void btn_saveToFile_Click(object sender, EventArgs e)
        {
            var books = this.Books;
            XmlSerializer serializer = new XmlSerializer(books.GetType());
            using (StreamWriter writer = new StreamWriter("data.xml"))
            {
                serializer.Serialize(writer, books);
            }
        }

        private void btn_loadFromFile_Click(object sender, EventArgs e)
        {
            Books = null;
            string path = Path.Combine(Environment.CurrentDirectory, "data.xml");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(BindingList<Book>));
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                Books = (BindingList<Book>)xmlSerializer.Deserialize(stream);
            }
            dataGridView1.DataSource = Books;
        }
    }
}
