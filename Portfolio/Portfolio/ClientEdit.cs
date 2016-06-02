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
        public List<Client> Client = new List<Client>();
        public List<Client> Clients { get { return Client; } set { Client = value; } }
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
                Client cl = new Client(dr);
                Clients.Add(cl);
            }
        }

        public static Client New(int ID, string ClientName, string CurrencyID, string Address, string Capital, string ClientType, string Company, string TelephoneNumber)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();


            SqlCommand cmd = Database.CommandFactory("spMotorbikeAdd");



            cmd.Parameters.Add(new SqlParameter(@"ID", ID));
            cmd.Parameters.Add(new SqlParameter(@"ClientName", ClientName));
            cmd.Parameters.Add(new SqlParameter(@"CurrencyID", CurrencyID));
            cmd.Parameters.Add(new SqlParameter(@"Address", Address));
            cmd.Parameters.Add(new SqlParameter(@"Capital", Capital));
            cmd.Parameters.Add(new SqlParameter(@"ClientType", ClientType));
            cmd.Parameters.Add(new SqlParameter(@"Company", Company));
            cmd.Parameters.Add(new SqlParameter(@"TelephoneNumber", TelephoneNumber));
            da.SelectCommand = cmd;
            da.Fill(dt);

            DataRow dr = dt.Rows[0];
            Client monroe = new Client(dr);
                
                
                //(Convert.ToInt32(dr["ID"]), dr["ClientName"].ToString(), dr["CurrencyID"].ToString(), dr["Address"].ToString(), dr["Capital"].ToString(), dr["ClientType"].ToString(), dr["Company"].ToString(), dr["TelephoneNumber"]);


            return monroe;

        }


    }
}
