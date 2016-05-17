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
    class CurrencySymbol
    {
        
        public CurrencySymbol(DataRow row)
        {
            CurrencyID = row[("CurrencyID")].ToString();
            ID = Convert.ToInt32(row["ID"]);
            SymbolLarge = row[("SymbolLarge")].ToString();
            SymbolSmall = row[("SymbolSmall")].ToString();
        }
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Unique ID for the currency symbols")]
        [Category("Currency and Exchange")]
        [DisplayName("ID")]
        public int ID { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Unique ID for the currency name")]
        [Category("Currency and Exchange")]
        [DisplayName("CurrencyID")]
        public string CurrencyID { get; set; } 

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The main symbol for the currency")]
        [Category("Currency and Exchange")]
        [DisplayName("SymbolLarge")]
        public string SymbolLarge { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Symbol for the sub-currency of a praticular currency")]
        [Category("Currency and Exchange")]
        [DisplayName("SymbolSmall")]
        public string SymbolSmall { get; set; }
    }
}
