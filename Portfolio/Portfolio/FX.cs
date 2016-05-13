using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FX
    {
   
        public FX(Instrument instrument)
        {
            ID = instrument.ID;
            CurrencyName = instrument.Identifier.InstrumentName;
            ISOLocal = instrument.Identifier.Ticker.Substring(3, 3);
            ISOReporting = instrument.Identifier.Ticker.Substring(0, 3);
            RateLocal = 1;
            RateReporting = instrument.PriceLocal;
        }

        [Browsable(true)] 
        [ReadOnly(true)]
        [Description("Unique ID number assigned to each price")]
        [Category("Information")]
        [DisplayName("ID")]
        public int ID { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ID number of the instrument assigned to that price")]
        [Category("Information")]
        [DisplayName("InstrumentID")]
        public int InstrumentID{ get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ISO standard for local price")]
        [Category("Information")]
        [DisplayName("ISOLocal")]
        public string ISOLocal{ get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("ISO standard for the converted price")]
        [Category("Information")]
        [DisplayName("ISOReporting")]
        public string ISOReporting{ get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Name of the currency the price is assigned to")]
        [Category("Information")]
        [DisplayName("CurrencyName")]
        public string CurrencyName{ get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Local price rate for an instrument")]
        [Category("Price")]
        [DisplayName("RateLocal")]
        public decimal RateLocal { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Converted price for the instrument")]
        [Category("Price")]
        [DisplayName("RateReporting")]
        public decimal RateReporting { get; set; }
    }
}
