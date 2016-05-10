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
    public partial class Form1 : Form
    {
        InstrumentCollection inst = new InstrumentCollection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetailsShow_Click(object sender, EventArgs e)
        {
            detailsOLV.Visible = !detailsOLV.Visible;
            ChangeSize(detailsOLV.Visible);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inst.Fill(DateTime.Now);
            ID.AspectName = "ID";
            InstrumentID.AspectName = "InstrumentID";
            InstrumentDate.AspectName = "InstrumentDate";
            ISIN.AspectName = "ISIN";
            Ticker.AspectName = "Ticker";
            Sedol1.AspectName = "Sedol1";
            Exchange.AspectName = "Exchange";
            InstrumentName.AspectName = "InstrumentName";
            InstrumentType.AspectName = "InstrumentType";
            PriceMid.AspectName = "PriceMid";
            PriceBid.AspectName = "PriceBid";
            PriceAsk.AspectName = "PriceAsk";
            PriceLast.AspectName = "PriceLast";
            PriceNAV.AspectName = "PriceNAV";
            PriceCurrencyID.AspectName = "PriceCurrencyID";
            PriceFactor.AspectName = "PriceFactor";
            DivGross.AspectName = "DivGross";
            DivCurrencyID.AspectName = "DivCurrencyID";
            DivFactor.AspectName = "DivFactor";
            FixedParAmount.AspectName = "FixedParAmount";
            FixedParValue.AspectName = "FixedParValue";
            FixedCoupon.AspectName = "FixedCoupon";
            FixedAccuredInterest.AspectName = "FixedAccuredInterest";
            Refresh();
            this.portfolioOLV.AddDecoration(new TintedColumnDecoration(PriceLast));

        }

        private void ChangeSize(bool visible)
        {
            if (visible == true)
            {
                //int width = 1167;
                //int height = 697;
                this.Size = new Size(this.Size.Width + 195, this.Size.Height);
                btnDetailsShow.Text = "Hide Details";
            }
            else
            {
                this.Size = new Size(this.Size.Width - 195, this.Size.Height);
                btnDetailsShow.Text = "Show Details";
            }
        }

        private void portfolioOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
