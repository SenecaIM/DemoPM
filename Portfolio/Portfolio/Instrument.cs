using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    public class Instrument
    {
       

        public Instrument(DataRow dr)
        {

            ID = Convert.ToInt32(dr["ID"]);
            InstrumentID = Convert.ToInt32(dr["InstrumentID"]);
            InstrumentDate = Convert.ToDateTime(dr["InstrumentDate"]);
            InstrumentName = dr["InstrumentName"].ToString();
        }

        public int ID { get; set; }
        public int InstrumentID { get; set; }
        public DateTime InstrumentDate { get; set; }
        public string InstrumentName { get; set; }

    }
}
