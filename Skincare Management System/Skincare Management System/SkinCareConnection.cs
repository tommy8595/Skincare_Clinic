using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Skincare_Management_System
{
    public class SkinCareConnection
    {
        public static SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

        public static SqlConnection Conn =
            new SqlConnection();

        public static void OpenConnection()
        {

            builder.DataSource = ".";
            builder.InitialCatalog = "skin_cilinic";
            builder.IntegratedSecurity = true;

            if (Conn.State.Equals(ConnectionState.Open))
            {
                Conn.Close();
            }

            Conn.ConnectionString = builder.ToString();
            Conn.Open();
        }

        public static void CloseConnection()
        {
            Conn.Close();
        }
    }
}
