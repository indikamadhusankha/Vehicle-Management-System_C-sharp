using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Vehical_Management_System
{
    internal class ConnectionManager
    {
        public static SqlConnection con;
        public static string constr  = ConfigurationManager.ConnectionStrings["VehicleDbConnection"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection(constr);
            return con;
        }

    }
}
