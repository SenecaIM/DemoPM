using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class ClientAdd : Form
    {
        public Client cll;
        ClientCollection cc = new ClientCollection();
        
        public List<Client> client = new List<Client>();
        
        internal void EditClient(Client cl)
        {
            nameTextBox.Text = cl.ClientName;
            currencyTextBox.Text = cl.CurrencyID;
            addressTextBox.Text = cl.Address;
            capitalTextBox.Text = cl.Capital;
            clienttypeTextBox.Text = cl.ClientType;
            companyTextBox.Text = cl.Company;
            telephoneTextBox.Text = cl.TelephoneNumber;
            cll = cl;
            this.ShowDialog();
        }
        public ClientAdd()
        {
            InitializeComponent();
            ClientNameColumn.AspectName = "ClientName";
            CompanyColumn.AspectName = "Company";
        }

        public void UpdateClient()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            clienteditOLV.SetObjects(client);
        }
        public void RefreshList()
        {
           
        }

        private void clienteditOLV_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.ObjectListView o = sender as BrightIdeasSoftware.ObjectListView;
            if (o.SelectedItem != null)
            {
                if (o.SelectedItem.RowObject is Client)
                {
                    Client cli = o.SelectedItem.RowObject as Client;
                    EditClient(cli);
                }
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
