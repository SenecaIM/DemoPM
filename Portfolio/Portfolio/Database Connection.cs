using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public static class Database
    {
        public static SqlConnection ConnectionFactory()
        {
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.InitialCatalog = "Portfolio";
            csb.DataSource = @"VMPC049";
            csb.IntegratedSecurity = true;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = csb.ConnectionString;
            return cnn;
        }
        public static SqlCommand CommandFactory(string sp)
        {
            SqlCommand cmd = new SqlCommand(sp);
            cmd.Connection = Database.ConnectionFactory();
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }
    }
}
