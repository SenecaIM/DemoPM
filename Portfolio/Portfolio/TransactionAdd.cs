using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class TransactionAdd : Form
    {
        private InstrumentCollection ic;
        public TransactionAdd()
        {
            InitializeComponent();
            ic = new InstrumentCollection();
            ic.Fill(DateTime.Now.Date, "GBP");
            comboBox1.DataSource = ic.InstrumentItems;

            comboBox1.DisplayMember = "Identifier.InstrumentName";
            comboBox1.ValueMember = "Instrument";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
        }
    }
}
