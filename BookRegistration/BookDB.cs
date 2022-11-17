using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRegistration
{
    static class BookDB
    {
        /// <summary>
        /// Takes a Book and inserts it into the Book table in the database
        /// </summary>
        /// <param name="b">Book to be inserted</param>
        public static void AddBook(Book b)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Book(ISBN, Price, Title)" +
                "VALUES (@ISBN, @price, @title)";
            cmd.Parameters.AddWithValue("@ISBN", b.ISBN);
            cmd.Parameters.AddWithValue("@price", b.Price);
            cmd.Parameters.AddWithValue("@title", b.Title);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

        }

        /// <summary>
        /// Gets a list of all Books in the database
        /// </summary>
        /// <returns>A list of Books</returns>
        public static List<Book> GetAllBooks()
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = con;
            sqlCommand.CommandText = "SELECT ISBN, Price, Title" +
                " FROM Book";

            con.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                Book tempBook = new Book();
                tempBook.ISBN = Convert.ToString(reader["ISBN"]);
                tempBook.Price = Convert.ToDouble(reader["Price"]);
                tempBook.Title = Convert.ToString(reader["Title"]);

                books.Add(tempBook);
            }
            con.Close();
            return books;
        }
    }
}
