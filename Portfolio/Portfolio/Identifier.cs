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
    public class Identifier
    {
        public Identifier(DataRow dr)
        {
            ID = Convert.ToInt32(dr["ID"]);
            InstrumentID = Convert.ToInt32(dr["InstrumentID"]);
            Sedol1 = dr["Sedol1"].ToString();
            ISIN = dr["ISIN"].ToString();
            Ticker = dr["Ticker"].ToString();
            InstrumentName = dr["InstrumentName"].ToString();
        }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The personal ID number of a particular stock")]
        [Category("Information")]
        [DisplayName("ID")]
        public int ID { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ID number of the instrument")]
        [Category("Information")]
        [DisplayName("InstrumentID")]
        public int InstrumentID { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Identification number for the stock market")]
        [Category("Information")]
        [DisplayName("Sedol1")]
        public string Sedol1 { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("International security information number of the instrument ")]
        [Category("Information")]
        [DisplayName("ISIN")]
        public string ISIN { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("An abbreviation used to uniquely identify publicly traded shares of a particular stock on a particular stock market.")]
        [Category("Information")]
        [DisplayName("Ticker")]
        public string Ticker { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The actual market name of the instrument")]
        [Category("Information")]
        [DisplayName("InstrumentName")]
        public string InstrumentName { get; set; }
    }
}