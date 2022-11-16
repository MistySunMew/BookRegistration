using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace BookRegistration
{
    static class CustomerDB
    {
        /// <summary>
        /// Gets a list of all Customers in the database
        /// </summary>
        /// <returns>A list of Customers</returns>
        public static List<Customer> GetAllCustomers()
        {
            SqlConnection conn = DBHelper.GetConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = "SELECT CustomerID, DateOfBirth, FirstName, LastName, Title" +
                " FROM Customer";
            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<Customer> customers = new List<Customer>();
            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                c.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                c.FirstName = Convert.ToString(reader["FirstName"]);
                c.LastName = Convert.ToString(reader["LastName"]);
                c.Title = Convert.ToString(reader["Title"]);

                customers.Add(c);
            }
            conn.Close();
            return customers;
        }

        /// <summary>
        /// Takes a Customer and inserts it into the customers table in the database
        /// </summary>
        /// <param name="c">Customer to be inserted</param>
        public static void AddCustomer(Customer c)
        {
            SqlConnection con = DBHelper.GetConnection();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = "INSERT INTO Customer(DateOfBirth, FirstName, LastName, Title)" +
                "VALUES (@dateOfBirth, @firstName, @lastName, @title)";
            sqlCommand.Parameters.AddWithValue("@dateOfBirth", c.DateOfBirth);
            sqlCommand.Parameters.AddWithValue("@firstName", c.FirstName);
            sqlCommand.Parameters.AddWithValue("@lastName", c.LastName);
            sqlCommand.Parameters.AddWithValue("@title", c.Title);

            con.Open();


            sqlCommand.ExecuteNonQuery();

            con.Close();
        }
    }
}
