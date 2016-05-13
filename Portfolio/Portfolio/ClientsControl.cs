using BrightIdeasSoftware;
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
    public partial class ClientsControl : UserControl
    {
        public event EventHandler ShowObject;
        ClientCollection cli = new ClientCollection();
        public ClientsControl()
        {
            InitializeComponent();
        }
       

        private void ClientsControl_Load(object sender, EventArgs e)
        {
            cli.Fill(DateTime.Now);
            IDColumn.AspectName = "ID";
            ClientNameColumn.AspectName = "ClientName";
            CurrencyID.AspectName = "CurrencyID";
            AddressColumn.AspectName = "Address";

            clientOLV.SetObjects(cli.ClientItems);
            
        }

        private void clientOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView o = (ObjectListView)sender;
            ShowObject((Client)o.SelectedObject, e);

        }
        }
    }

