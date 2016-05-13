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
            }

        }
        private void AddInstruments()
        {
            removeControls();
            InstrumentControl con = new InstrumentControl();
            con.Location = new Point(1, 1);
            con.ShowObject += new EventHandler(con1_ShowObj);
            this.Controls.Add(con);

        }
        private void AddClients()
        {
            removeControls();
            ClientsControl cl1 = new ClientsControl();
            cl1.Location = new Point(1, 1);
            cl1.ShowObject += new EventHandler(cl1_ShowObject);
            this.Controls.Add(cl1);
        }
       
        private void cl1_ShowObject(object sender, EventArgs e)
        {
            Client cll = sender as Client;
            prop1.SetObject(cll);
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
    }
}
