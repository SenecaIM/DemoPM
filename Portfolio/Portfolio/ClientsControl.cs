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
            //IDColumn.AspectName = "ID";
            IDColumn.AspectGetter += new AspectGetterDelegate(IDColumn_AspectGetter);
            
            ClientNameColumn.AspectName = "ClientName";
            CurrencyID.AspectName = "CurrencyID";
            AddressColumn.AspectName = "Address";

            clientOLV.FormatRow += ClientOLV_FormatRow;
            clientOLV.SetObjects(cli.ClientItems);
            clientOLV.UseSubItemCheckBoxes = true;
        }

        private void ClientOLV_FormatRow(object sender, FormatRowEventArgs e)
        {
            Client cl = e.Model as Client;
            if (cl.ClientType.ToUpper() == "Fund".ToUpper())
            {
                e.Item.ForeColor = Color.Red;
            }
            else if (cl.ClientType.ToUpper() == "Company".ToUpper())
            {
                e.Item.ForeColor = Color.Blue;
            }
        }

        private object IDColumn_AspectGetter(object rowObject)
        {
            Client cl = rowObject as Client;
            return cl.ID.ToString();
        }

        private void clientOLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjectListView o = (ObjectListView)sender;
            ShowObject((Client)o.SelectedObject, e);
            
        }
    }
}

