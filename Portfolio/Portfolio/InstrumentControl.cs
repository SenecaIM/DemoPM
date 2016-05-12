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
            prop.Show();
            prop.SetLocation((Form)this.Parent);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inst.Fill(DateTime.Now);
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
            PriceColumn.AspectName = "Price";
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

            //ObjectListView o = sender as ObjectListView;
            ObjectListView o = (ObjectListView)sender;
            //propertyGrid1.SelectedObject = (Instrument)o.SelectedObject;
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            inst.Fill(fromDatePicker.Value);
            portfolioOLV.SetObjects(inst.InstrumentItems);
        }
        private void Refresh2()
        {
            inst.Fill(fromDatePicker.Value);
            portfolioOLV.SetObjects(inst.InstrumentItems.Where(p=>p.InstrumentDate > toDatePicker.Value.Date).ToList<Instrument>());
        }

        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh2();
        }
    }
}
