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
    public partial class Main : Form
    {

        PropertyForm prop1 = new PropertyForm();

        private void removeControls()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(InstrumentControl))
                {
                    this.Controls.Remove(ctrl);
                }
                else if (ctrl.GetType() == typeof(PortfolioControl))
                {
                    this.Controls.Remove(ctrl);
                }
                else if (ctrl.GetType() == typeof(ClientsControl))
                {                     
                    this.Controls.Remove(ctrl);
                }
                else if (ctrl.GetType() == typeof(TransactionControl))
                {
                    this.Controls.Remove(ctrl);
                }
            }

        }
        private void AddInstruments()
        {
            InstrumentControl con = new InstrumentControl();
            LayoutControl(con);
            con.ShowObject += new EventHandler(con1_ShowObj);
        }

        private void LayoutControl(Control con)
        {
            removeControls();
            con.Location = panel1.Location;
            con.Size = panel1.Size;
            con.Anchor = panel1.Anchor;
            this.Controls.Add(con);
        }

        private void AddClients()
        {

            ClientsControl cl1 = new ClientsControl();
            LayoutControl(cl1);
            cl1.ShowObject += new EventHandler(cl1_ShowObject);

        }

        private void AddTransactions()
        {
            TransactionControl tc = new TransactionControl();
            LayoutControl(tc);
            tc.ShowObject += new EventHandler(tc_ShowObject);
        }
       
        private void cl1_ShowObject(object sender, EventArgs e)
        {
            Client cll = sender as Client;
            prop1.SetObject(cll);
        }
        private void tc_ShowObject(object sender, EventArgs e)
        {
            Transaction tc = sender as Transaction;
            prop1.SetObject(tc);
        }

        private void con1_ShowObj(object sender, EventArgs e)
        {
            Instrument ill = sender as Instrument;
            prop1.SetObject(ill);
        }
        private void AddPortfolio()
        {
            removeControls();
            PortfolioControl por = new PortfolioControl();
            por.Location = new Point(1, 1);
            this.Controls.Add(por);
        }
        public Main()
        {
            InitializeComponent();
            navibar1.showClients += new EventHandler(navibar1_showClients);
            navibar1.showInstruments += new EventHandler(navibar1_showInstruments);
            navibar1.showPortfolio += new EventHandler(navibar1_showPortfolio);
            navibar1.showTransactions += new EventHandler(navibar1_showTransactions);


        }

        private void navibar1_showPortfolio(object sender, EventArgs e)
        {
            AddPortfolio();
        }

        private void navibar1_showInstruments(object sender, EventArgs e)
        {
            AddInstruments();
        }

        private void navibar1_showClients(object sender, EventArgs e)
        {
            AddClients();
        }
        private void navibar1_showTransactions(object sender, EventArgs e)
        {
            AddTransactions();
        }

        private void clientsControl1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            AddInstruments();
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

        private void navibar1_Load(object sender, EventArgs e)
        {

        }
    }
}
