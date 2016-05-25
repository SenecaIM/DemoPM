using BrightIdeasSoftware;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Portfolio
{
    
    public partial class InstrumentControl : UserControl
    {
        public event EventHandler ShowObject;
        
        InstrumentCollection inst = new InstrumentCollection();
        public InstrumentControl()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            inst.Fill(DateTime.Now, "GBP");
            IDColumn.AspectName = "ID";
            InstrumentIDColumn.AspectName = "Identifier.InstrumentID";
            InstrumentDateColumn.AspectName = "InstrumentDate";
            ISINColumn.AspectName = "Identifier.ISIN";
            TickerColumn.AspectName = "Identifier.Ticker";
            Sedol1Column.AspectName = "Identifier.Sedol1";
            //Exchange.AspectName = "Exchange";
            InstrumentNameColumn.AspectName = "Identifier.InstrumentName";
            //InstrumentType.AspectName = "InstrumentType";
            //PriceMid.AspectName = "PriceMid";
            //PriceBid.AspectName = "PriceBid";
            //PriceAsk.AspectName = "PriceAsk";
            //PriceLast.AspectName = "PriceLast";
            //PriceNAV.AspectName = "PriceNAV";
            //PriceCurrencyID.AspectName = "PriceCurrencyID";
            PriceDisplayColumn.AspectName = "PriceDisplay";
            DetailColumn.AspectName = "ToString";
            //DivGross.AspectName = "DivGross";
            //DivCurrencyID.AspectName = "DivCurrencyID";
            //DivFactor.AspectName = "DivFactor";
            //FixedParAmount.AspectName = "FixedParAmount";
            //FixedParValue.AspectName = "FixedParValue";
            //FixedCoupon.AspectName = "FixedCoupon";
            //FixedAccuredInterest.AspectName = "FixedAccuredInterest";
            Refresh();
           

        }

        private void portfolioOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ObjectListView o = (ObjectListView)sender;
            ShowObject((Instrument)o.SelectedObject, e);
            portfolioOLV.IsSimpleDragSource = true;
            portfolioOLV.AllowDrop = true;
            portfolioOLV.IsSimpleDropSink = true;
            
            
            
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh("GBP");
        }

        private void Refresh(string currencyID)
        {
            inst.Fill(fromDatePicker.Value, currencyID);
            portfolioOLV.SetObjects(inst.InstrumentItems);
        }

        private void portfolioOLV_FormatRow(object sender, FormatRowEventArgs e)
        {
            Instrument ins = e.Model as Instrument;
            if (ins.InstrumentType.ToUpper() == "CURNCY".ToUpper())
            {
                e.Item.ForeColor = Color.Purple;
            }

        }

    }
}
