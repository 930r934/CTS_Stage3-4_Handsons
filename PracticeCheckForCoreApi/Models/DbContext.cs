using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckForCoreApi.Models
{

    public class DbContext
    {

        SqlConnection conn;

        public DbContext()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=G04L8IN\\SQLEXPRESS;Initial Catalog=FirstAppC#;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

    }
}
