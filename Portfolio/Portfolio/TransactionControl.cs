using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Portfolio
{
    public partial class TransactionControl : UserControl
    {
        public event EventHandler ShowObject;
        TransactionCollection tran = new TransactionCollection();
        public TransactionControl()
        {
            InitializeComponent();
        }

        private void transactionOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView o = (ObjectListView)sender;
            ShowObject((Transaction)o.SelectedObject, e);
        }

        private void TransactionControl_Load(object sender, EventArgs e)
        {
            
            ID.AspectName = "ID";
            TransactionIDColumn.AspectName = "TransactionID";
            QuantityColumn.AspectName = "Quantity";
            BookCostColumn.AspectName = "BookCost";
            InstrumentIDColumn.AspectName = "Instrument.Identifier.InstrumentID";
            TransactionDateColumn.AspectName = "TransactionDate";
            transactionOLV.SetObjects(tran.TransactionItems);
            Refresh();
        }

        private void Refresh(string currencyID)
        {
            tran.Fill(fromDatePicker.Value, currencyID);
            transactionOLV.SetObjects(tran.TransactionItems);
        }

        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Refresh("GBP");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            TransactionAdd ad = new TransactionAdd();
            ad.ShowDialog();
        }
    }
}
