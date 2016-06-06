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
    public class Instrument
    {


        public Instrument(DataRow dr)
        {
            Identifier = new Identifier(dr);
            InstrumentDate = Convert.ToDateTime(dr["InstrumentDate"]);
            Exchange = dr["Exchange"].ToString();
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
        public string PriceDisplay { get { return this.FXPrice.SymbolReporting.SymbolLarge + this.PriceReporting.ToString("#,##0.00") + this.FXPrice.SymbolReporting.SymbolSmall; } }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Price to be used in valuation of the Instrument")]
        [Category("Price and Income")]
        [DisplayName("Price")]
        public decimal PriceLocal { get
            {
                if (PriceMid != 0)
                {
                    return PriceMid;
                }
                else if (PriceBid != 0 && PriceAsk != 0)
                {
                    return (PriceBid + PriceAsk) / 2;
                }
                else if (PriceBid != 0)
                {
                    return PriceBid;
                }
                else if (PriceAsk != 0)
                {
                    return PriceAsk;
                }
                else
                {
                    return PriceLast;
                }
            } }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Price to be used in valuation of the Instrument")]
        [Category("Price and Income")]
        [DisplayName("Price Reporting")]
        public decimal PriceReporting
        { get { return PriceLocal / FXPrice.RateReporting; } }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The personal ID number of a particular stock")]
        [Category("Information")]
        [DisplayName("ID")]
        public int ID { get { return Identifier.ID; } }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Contains Instrument identifier information")]
        [Category("Information")]
        [DisplayName("Identifier")]
        public Identifier Identifier { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Date the stock was issued")]
        [Category("Information")]
        [DisplayName("InstrumentDate")]
        public DateTime InstrumentDate { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Market Exchange")]
        [Category("Information")]
        [DisplayName("Exchange")]
        public string Exchange { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Describes the type of the stock")]
        [Category("Information")]
        [DisplayName("InstrumentType")]
        public string InstrumentType { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Middle price for the stock")]
        [Category("Price and Income")]
        [DisplayName("PriceMid")]
        public decimal PriceMid { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Bid price for the stock")]
        [Category("Price and Income")]
        [DisplayName("PriceBid")]
        public decimal PriceBid { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The price stockholder is asking for")]
        [Category("Price and Income")]
        [DisplayName("PriceAsk")]
        public decimal PriceAsk { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The last price for the stock")]
        [Category("Price and Income")]
        [DisplayName("PriceLast")]
        public decimal PriceLast { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("NAV price for the stock")]
        [Category("Price and Income")]
        [DisplayName("PriceNAV")]
        public decimal PriceNAV { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ID number for the stock currency")]
        [Category("Information")]
        [DisplayName("PriceCurrencyID")]
        public string PriceCurrencyID { get; set; }
       
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Factor of the price")]
        [Category("Price and Income")]
        [DisplayName("PriceFactor")]
        public decimal PriceFactor { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Gross divident of the instrument")]
        [Category("Price and Income")]
        [DisplayName("DivGross")]
        public decimal DivGross { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ID number for the divident currency")]
        [Category("Information")]
        [DisplayName("DivCurrencyID")]
        public string DivCurrencyID { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Factor of the divident of the instrument")]
        [Category("Price and Income")]
        [DisplayName("DivFactor")]
        public decimal DivFactor { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The minimum amount of the bond you have to buy")]
        [Category("Price and Income")]
        [DisplayName("FixedParAmount")]
        public decimal FixedParAmount { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The market value of the bond")]
        [Category("Price and Income")]
        [DisplayName("FixedParValue")]
        public decimal FixedParValue { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The coupon rate of the issued bond")]
        [Category("Price and Income")]
        [DisplayName("FixedCoupon")]
        public decimal FixedCoupon { get; set; }
        
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The value added to the bond after selling it")]
        [Category("Price and Income")]
        [DisplayName("FixedAccuredIntrest")]
        public decimal FixedAccuredInterest { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("FX used in calculating the price")]
        [Category("Price")]
        [DisplayName("FXPrice")]
        public FX FXPrice { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Describes the income of a particular stock")]
        [Category("Price")]
        [DisplayName("FXIncome")]
        public FX FXIncome { get; set; }

        public override string ToString()
        {
            return
                "Local Price " + this.PriceLocal.ToString("#,##0.00") + "(" + this.FXPrice.ISOLocal + ")," + 
                " Reporting Price " + this.PriceReporting.ToString("#,##0.00") + "(" + this.FXPrice.ISOReporting + ")";
        }
    }
}
