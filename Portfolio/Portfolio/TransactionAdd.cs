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
        PropertyForm prop1 = new PropertyForm();
        public event EventHandler ShowObject;
        private InstrumentCollection ic;
        public TransactionAdd()
        {
            InitializeComponent();
            ic = new InstrumentCollection();
            ic.Fill(DateTime.Now.Date, "GBP");
            //textBox1.DataSource = ic.InstrumentItems;

            //comboBox1.DisplayMember = "Identifier.InstrumentName";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
        }

        private void instrumentControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactionAdd_Load(object sender, EventArgs e)
        {
            AddInstruments();
        }
        private void AddInstruments()
        {
            InstrumentControl con = new InstrumentControl();
            LayoutControl(con);
            con.ShowObject += new EventHandler(con1_ShowObj);
        }
        private void LayoutControl(Control con)
        {
            con.Location = panel1.Location;
            con.Size = panel1.Size;
            con.Anchor = panel1.Anchor;
            this.Controls.Add(con);
        }
        private void con1_ShowObj(object sender, EventArgs e)
        {
            Instrument ill = sender as Instrument;
            prop1.SetObject(ill);
        }

        private void btnDetailsShow_Click(object sender, EventArgs e)
        {
            if (prop1.Visible)
            {
                prop1.Hide();
                btnDetailsShow.Text = "Show Details";
            }
            else
            {
                prop1.Show();
                prop1.SetLocation((Form)this);
                btnDetailsShow.Text = "Hide Details";
            }
        }
    }
}
