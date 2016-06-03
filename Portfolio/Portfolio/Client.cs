using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Client
    {
        public void Delete()
        {
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlCommand cmd = Database.CommandFactory("spClientDelete"))
            {

                cmd.Parameters.Add(new SqlParameter(@"ID", ID));
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
        }

        public void UpdateClient()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            using (SqlCommand cmd = Database.CommandFactory("spClientEdit"))
            {
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
            }
            MessageBox.Show("Operation Completed, Client updated");
            
        }

        public void Create()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            
            using (SqlCommand cmd = Database.CommandFactory("spClientAdd"))
            {
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
                Client cl = new Client(dr);
                

            }
            MessageBox.Show("Operation Completed, Client Added");
            
        }
        public Client(DataRow dr)
        {
            ID = Convert.ToInt32(dr["ID"]);
            ClientName = dr["ClientName"].ToString();
            CurrencyID = dr["CurrencyID"].ToString();
            Address = dr["Address"].ToString();
            Capital = dr["Capital"].ToString();
            ClientType = dr["ClientType"].ToString();
            Company = dr["Company"].ToString();
            TelephoneNumber = dr["TelephoneNumber"].ToString();
        }



        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Client's name")]
        [Category("ClientInformation")]
        [DisplayName("Client name")]
        public string ClientName { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The unique client ID")]
        [Category("ClientInformation")]
        [DisplayName("ID")]
        public int ID { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Client's Currency ID number")]
        [Category("ClientInformation")]
        [DisplayName("Currency ID")]
        public string CurrencyID { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Client's current address")]
        [Category("ClientInformation")]
        [DisplayName("Address")]
        public string Address { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Client's personal capital")]
        [Category("ClientInformation")]
        [DisplayName("Client Capital")]
        public string Capital { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The type of the client ")]
        [Category("ClientInformation")]
        [DisplayName("Client Type")]
        public string ClientType { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Company the client is based in")]
        [Category("ClientInformation")]
        [DisplayName("Company")]
        public string Company { get; set; }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Client's telephone number")]
        [Category("ClientInformation")]
        [DisplayName("Telephone Number")]
        public string TelephoneNumber { get; set; }
    }
}
