using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookRegistration
{
    static class DBHelper
    {
        /// <summary>
        /// Gets the SqlConnection to the desired database
        /// </summary>
        /// <returns>The SqlConnection to the datbase</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-N31PS9J;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
