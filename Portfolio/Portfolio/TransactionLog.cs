using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    class TransactionLog
    {

        public static Transaction LogInTransaction(decimal buyquantity, decimal sellquantity, int buyinstrumentid, int sellinstrumentid, decimal bookcost, DateTime transactiondate)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlCommand cmd = Database.CommandFactory("spTransactionAdd");


            cmd.Parameters.Add(new SqlParameter(@"BuyQuantity", buyquantity));
            cmd.Parameters.Add(new SqlParameter(@"SellQuantity", sellquantity));
            cmd.Parameters.Add(new SqlParameter(@"BuyInstrumentID", buyinstrumentid));
            cmd.Parameters.Add(new SqlParameter(@"SellInstrumentID", sellinstrumentid));
            cmd.Parameters.Add(new SqlParameter(@"BookCost", bookcost));
            cmd.Parameters.Add(new SqlParameter(@"TransactionDate", transactiondate));
            da.SelectCommand = cmd;
            da.Fill(dt);


            DataRow dr = dt.Rows[0];
            Transaction tr = new Transaction(Convert.ToDecimal(dr["BuyQuantity"]), Convert.ToDecimal(dr["SellQuantity"]), Convert.ToInt32(dr["BuyInstrumentID"]), Convert.ToInt32(dr["SellInstrumentID"]), Convert.ToDecimal(dr["BookCost"]), Convert.ToDateTime(dr["TransactionDate"]));
            return tr;
        }
    }
}
