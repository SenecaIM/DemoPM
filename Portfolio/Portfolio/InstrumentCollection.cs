using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class InstrumentCollection
    {
        public List<Instrument> InstrumentItems
        {
            get; set;
        }

        public void Fill()
        {
            InstrumentItems = new List<Instrument>();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = Database.CommandFactory("spInstrumentDate");
            da.SelectCommand = cmd;
            cmd.Parameters.Add("ValuationDate", DateTime.Now);
            da.Fill(ds);
            DataTable dtInstrument = ds.Tables[0];
            foreach (DataRow dr in dtInstrument.Rows)
            {
                Instrument ins = new Instrument(dr);
                InstrumentItems.Add(ins);
            }
            
        }
    }
}
