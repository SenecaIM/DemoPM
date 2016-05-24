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
    class Transaction
    {
        public Transaction(DataRow dr, Instrument instrument)
        {
            
            ID = Convert.ToInt32(dr["ID"]);
            TransactionID = Convert.ToInt32(dr["TransactionID"]);
            Quantity = Convert.ToDecimal(dr["Quantity"]);
            BookCost = Convert.ToDecimal(dr["BookCost"]);
            Instrument = instrument;
            TransactionDate = Convert.ToDateTime(dr["TransactionDate"]);
        }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Unique database row ID")]
        [Category("Transaction Information")]
        [DisplayName("ID")]
        public int ID{ get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Unique transaction ID number")]
        [Category("Transaction Information")]
        [DisplayName("Transaction ID")]
        public int TransactionID { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Quantity of stocks held")]
        [Category("Transaction Information")]
        [DisplayName("Quantity")]
        public decimal Quantity { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The cost of booking the trade")]
        [Category("Transaction Information")]
        [DisplayName("Book Cost")]
        public decimal BookCost { get;  set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The Instrument involved in the transaction")]
        [Category("Transaction Information")]
        [DisplayName("Instrument")]
        public Instrument Instrument { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The date trade was closed")]
        [Category("Transaction Information")]
        [DisplayName("Transaction Date")]
        public DateTime TransactionDate { get; set; }

    }
}
