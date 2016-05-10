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
            ISIN = dr["ISIN"].ToString();
            Ticker = dr["Ticker"].ToString();
            Sedol1 = dr["Sedol1"].ToString();
            Exchange = dr["Exchange"].ToString();
            InstrumentName = dr["InstrumentName"].ToString();
            InstrumentType = dr["InstrumentType"].ToString();
            PriceMid = Convert.ToDecimal(dr["PriceMid"]);
            PriceBid = Convert.ToDecimal(dr["PriceBid"]);
            PriceAsk = Convert.ToDecimal(dr["PriceAsk"]);
            PriceLast = Convert.ToDecimal(dr["PriceLast"]);
            PriceNAV = Convert.ToDecimal(dr["PriceNAV"]);
            PriceCurrencyID = dr["PriceCurrencyID"].ToString();
            PriceFactor = Convert.ToDecimal(dr["PriceFactor"]);
            DivGross = Convert.ToDecimal(dr["DivGross"]);
            DivCurrencyID = dr["DivCurrencyID"].ToString();
            DivFactor = Convert.ToDecimal(dr["DivFactor"]);
            FixedParAmount = Convert.ToDecimal(dr["FixedParAmount"]);
            FixedParValue = Convert.ToDecimal(dr["FixedParValue"]);
            FixedCoupon = Convert.ToDecimal(dr["FixedCoupon"]);
            FixedAccuredInterest = Convert.ToDecimal(dr["FixedAccuredInterest"]);

        }

        public int ID { get; set; }
        public int InstrumentID { get; set; }
        public DateTime InstrumentDate { get; set; }
        public string ISIN { get; set; }
        public string Ticker { get; set; }
        public string Sedol1 { get; set; }
        public string Exchange { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentType { get; set; }
        public decimal PriceMid { get; set; }
        public decimal PriceBid { get; set; }
        public decimal PriceAsk { get; set; }
        public decimal PriceLast { get; set; }
        public decimal PriceNAV { get; set; }
        public string PriceCurrencyID { get; set; }
        public decimal PriceFactor { get; set; }
        public decimal DivGross { get; set; }
        public string DivCurrencyID { get; set; }
        public decimal DivFactor { get; set; }
        public decimal FixedParAmount { get; set; }
        public decimal FixedParValue { get; set; }
        public decimal FixedCoupon { get; set; }
        public decimal FixedAccuredInterest { get; set; }



    }
}
