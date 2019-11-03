using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace University_Management_System.Gateway
{
    public class Gateway
    {
        public string Query { get; set; }

        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }
        public SqlDataReader Reader { get; set; }

        private string connectionString = WebConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;


        public Gateway()
        {
            Connection = new SqlConnection(connectionString);
        }
    }
}