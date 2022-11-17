using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookRegistration
{
    static class BookRegistrationDB
    {
        /// <summary>
        /// Takes a Registration object  and inserts it into the Registration table in the database
        /// </summary>
        /// <param name="c">Registration object to be inserted</param>
        public static void RegisterBook(Registration r)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "INSERT INTO Registration(CustomerID, ISBN, RegDate)" +
                " VALUES (@customerID, @ISBN, @regDate)";
            sqlCommand.Parameters.AddWithValue("@customerID", r.CustomerID);
            sqlCommand.Parameters.AddWithValue("@ISBN", r.ISBN);
            sqlCommand.Parameters.AddWithValue("@regDate", r.RegDate);

            con.Open();

            sqlCommand.ExecuteNonQuery();

            con.Close();
        }
    }
}
