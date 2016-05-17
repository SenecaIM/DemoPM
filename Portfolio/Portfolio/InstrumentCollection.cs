using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class InstrumentCollection
    {
        public List<Instrument> InstrumentItems
        {
            get; set;
        }
        public List<FX> FXItems
        {
            get;set;
        }
        public List<CurrencySymbol> SymbolItems
        {
            get;set;
        }

        public void Fill(DateTime valuationDate, string reportingISO)
        {
            InstrumentItems = new List<Instrument>();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlCommand cmd = Database.CommandFactory("spInstrumentDate");
            da.SelectCommand = cmd;
            cmd.Parameters.Add("ValuationDate", valuationDate.Date);
            da.Fill(ds);
            DataTable dtInstrument = ds.Tables[0];
            DataTable dtSymbols = ds.Tables[1];
            foreach (DataRow dr in dtInstrument.Rows)
            {
                Instrument ins = new Instrument(dr);
                InstrumentItems.Add(ins);
            }

            SymbolItems = new List<CurrencySymbol>();

            foreach(DataRow dr in dtSymbols.Rows)
            {
                CurrencySymbol crs = new CurrencySymbol(dr);
                SymbolItems.Add(crs);
            }

            FXItems = new List<FX>();

            InstrumentItems.Where(p => p.InstrumentType == "CURNCY").ToList().ForEach(p => FXItems.Add(
                new FX(p, getSymbol(p.PriceCurrencyID), getSymbol(reportingISO))));

            foreach(Instrument i in InstrumentItems)
            {
                i.FXPrice = FXItems.First(p => p.ISOLocal == i.PriceCurrencyID && p.ISOReporting == reportingISO);
                i.FXIncome = FXItems.First(p => p.ISOLocal == i.DivCurrencyID && p.ISOReporting == reportingISO);
            }
        }

        private CurrencySymbol getSymbol(string currencyID)
        {
            return SymbolItems.Find(p => p.CurrencyID == currencyID);
        }
        
    }
}
