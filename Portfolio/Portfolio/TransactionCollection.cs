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
    class TransactionCollection
    {
        public List<Transaction> TransactionItems
        {
            get; set;
        }


        public void Fill(DateTime valuationDate, string valuationISO)
        {
            InstrumentCollection ic = new InstrumentCollection();
            TransactionItems = new List<Transaction>();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            SqlCommand cmd = Database.CommandFactory("spTransactions");
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dtTransactions = ds.Tables[0];
            ic.Fill(valuationDate, valuationISO);


            foreach (DataRow dr in dtTransactions.Rows)
            {


                Instrument instrument = ic.InstrumentItems.First(p => p.Identifier.InstrumentID == Convert.ToInt32(dr["InstrumentID"].ToString()));

                Transaction transaction = new Transaction(dr, instrument);
                TransactionItems.Add(transaction);
            }
        }
    }
}
