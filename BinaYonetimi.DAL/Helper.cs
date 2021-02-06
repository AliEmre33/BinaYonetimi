using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaYonetimi.DAL
{
    public static class Helper
    {
        public static SqlConnection connection;
        public static void Connection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BinaYonetimiVeritabani"].ConnectionString);
        }
        public static void ConnectionOpenClose()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {
                connection.Close();
            }
        }
    }
}
