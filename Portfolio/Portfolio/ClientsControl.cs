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
        PropertyForm prop1 = new PropertyForm();
        ClientCollection cli = new ClientCollection();
        public ClientsControl()
        {
            InitializeComponent();
        }
        private void ChangeSize(bool visible)
        {
            if (visible == true)
            {
                //int width = 1167;
                //int height = 697;
                this.Size = new Size(this.Size.Width + 195, this.Size.Height);
                clientOLV.Size = new Size(clientOLV.Size.Width - 215, clientOLV.Size.Height);
                btnDetailsShow.Text = "Hide Details";
            }
            else
            {
                this.Size = new Size(this.Size.Width - 195, this.Size.Height);
                clientOLV.Size = new Size(clientOLV.Size.Width + 215, clientOLV.Size.Height);
                btnDetailsShow.Text = "Show Details";
            }
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
                prop1.SetLocation((Form)this.Parent);
                btnDetailsShow.Text = "Hide Details";
            }
            

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
            prop1.SetObject((Client)o.SelectedObject);

        }

        private void btnDetailsShow_Click_1(object sender, EventArgs e)
        {
            if (prop1.Visible)
            {
                prop1.Hide();
                btnDetailsShow.Text = "Show Details";
            }
            else
            {
                prop1.Show();
                prop1.SetLocation((Form)this.Parent);
                btnDetailsShow.Text = "Hide Details";
            }
        }
    }
}
