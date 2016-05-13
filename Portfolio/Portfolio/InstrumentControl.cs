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
        PropertyForm prop = new PropertyForm();
        InstrumentCollection inst = new InstrumentCollection();
        public InstrumentControl()
        {
            InitializeComponent();
        }

        private void btnDetailsShow_Click(object sender, EventArgs e)
        {
            if (prop.Visible)
            {
                prop.Hide();
                btnDetailsShow.Text = "Show Details";
            }
            else
            {
                prop.Show();
                prop.SetLocation((Form)this.Parent);
                btnDetailsShow.Text = "Hide Details";
            }

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
            PriceReportingColumn.AspectName = "PriceReporting";
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

        private void ChangeSize(bool visible)
        {
            if (visible == true)
            {
                //int width = 1167;
                //int height = 697;
                this.Size = new Size(this.Size.Width + 195, this.Size.Height);
                portfolioOLV.Size = new Size(portfolioOLV.Size.Width - 215, portfolioOLV.Size.Height);
                btnDetailsShow.Text = "Hide Details";
            }
            else
            {
                this.Size = new Size(this.Size.Width - 195, this.Size.Height);
                portfolioOLV.Size = new Size(portfolioOLV.Size.Width + 215, portfolioOLV.Size.Height);
                btnDetailsShow.Text = "Show Details";
            }
        }

        private void portfolioOLV_SelectedIndexChanged(object sender, EventArgs e)
        {

            ObjectListView o = (ObjectListView)sender;
            prop.SetObject((Instrument)o.SelectedObject);
            
            //propertyGrid1.SelectedObject = (Instrument)o.SelectedObject;
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh(string currencyID)
        {
            inst.Fill(fromDatePicker.Value, currencyID);
            portfolioOLV.SetObjects(inst.InstrumentItems);
        }
        private void Refresh2(string currencyID)
        {
            inst.Fill(fromDatePicker.Value, currencyID);
            portfolioOLV.SetObjects(inst.InstrumentItems.Where(p=>p.InstrumentDate > toDatePicker.Value.Date).ToList<Instrument>());
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh2("GBP");
        }
    }
}
