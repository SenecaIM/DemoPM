using Portfolio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class ClientEdit
    {
        public void ContactBook()
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = Database.CommandFactory("spClientEdit");
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dtClient = ds.Tables[0];
            foreach (DataRow dr in dtClient.Rows)
            {
                Client cla = new Client(dr["ClientName"].ToString(), dr["CurrencyID"].ToString(), dr["Address"].ToString(), dr["Capital"].ToString(), dr["ClientType"].ToString(), dr["Company"].ToString(), dr["TelephoneNumber"].ToString()));
                Clients.Add(cla);
            }
        }

            

        public List<Client> Client = new List<Client>();
        public List<Client> Clients { get { return Client; } set { Client = value; } }
    }
}
