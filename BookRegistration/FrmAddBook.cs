using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistration
{
    public partial class FrmAddBook : Form
    {
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.ISBN = txtISBN.Text;
            book.Price = Convert.ToDouble(txtPrice.Text);

            BookDB.AddBook(book);
            MessageBox.Show("Book added successfully!");
            Close();
        }
    }
}
