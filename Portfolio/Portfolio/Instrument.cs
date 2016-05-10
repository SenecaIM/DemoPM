using System;
using System.Collections.Generic;
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
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = Database.CommandFactory("spInstrumentDate");
            da.SelectCommand = cmd;
            da.Fill(ds);
            DataTable dtInstrument = ds.Tables[0];
            foreach (DataRow dr in dtInstrument.Rows)
            {
                InstrumentCollection ins = new InstrumentCollection(Convert.ToInt32(dr["ID"]), );
                Stock.Add(ins);
            }
            
        }
    }
}
