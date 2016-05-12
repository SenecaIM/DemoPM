using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Client
    {
        public Client(DataRow dr)
        {
            ID = Convert.ToInt32(dr["ID"]);
            ClientName = dr["ClientName"].ToString();
            CurrencyID = dr["CurrencyID"].ToString();
            Address = dr["Address"].ToString();
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
        public string Address { get; private set; }
    }
}
