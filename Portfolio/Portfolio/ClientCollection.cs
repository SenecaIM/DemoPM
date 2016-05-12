using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    class ClientCollection
    {
        public List<Client> ClientItems
        {
            get; set;
        }

        public void Fill(DateTime valuationDate)
        {
            ClientItems = new List<Client>();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = Database.CommandFactory("spClient");
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dtClient = ds.Tables[0];
            foreach (DataRow dr in dtClient.Rows)
            {
                Client client = new Client(dr);
                ClientItems.Add(client);
            }

        }
    }
}
