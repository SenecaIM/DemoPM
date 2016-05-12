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
        private void removeInstrument()
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
            InstrumentControl con = new InstrumentControl();
            con.Location = new Point(1, 1);
            this.Controls.Add(con);

        }
        private void AddClients()
        {
            ClientsControl cl1 = new ClientsControl();
            cl1.Location = new Point(1, 1);
            this.Controls.Add(cl1);
        }
        public Main()
        {
            InitializeComponent();
            navibar1.showClients += new EventHandler(navibar1_showClients);
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
    }
}
