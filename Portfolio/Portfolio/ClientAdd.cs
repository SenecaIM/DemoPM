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
        Client cl;
        Client cl2;
        //public Client cl1;
        ClientCollection cc = new ClientCollection();
        public DateTime dtt = new DateTime();
        
        public List<Client> client = new List<Client>();


        internal Client Add()
        {
            Client monroe = ClientEdit.New(Convert.ToInt32(idTextBox.Text), nameTextBox.Text, currencyTextBox.Text, addressTextBox.Text, capitalTextBox.Text, clienttypeTextBox.Text, companyTextBox.Text, telephoneTextBox.Text);
            return monroe;

        }

        public void EditClient()
        {
            nameTextBox.Text = cl.ClientName;
            currencyTextBox.Text = cl.CurrencyID;
            addressTextBox.Text = cl.Address;
            capitalTextBox.Text = cl.Capital;
            clienttypeTextBox.Text = cl.ClientType;
            companyTextBox.Text = cl.Company;
            telephoneTextBox.Text = cl.TelephoneNumber;
            idTextBox.Text = cl.ID.ToString();
        }
        public ClientAdd()
        {
            InitializeComponent();
            ClientNameColumn.AspectName = "ClientName";
            CompanyColumn.AspectName = "Company";
        }
        private void ClientAdd_Load(object sender, EventArgs e)
        {
            cc.Fill(dtt);
            clienteditOLV.SetObjects(cc.ClientItems);
        }

        private void clienteditOLV_SelectionChanged(object sender, EventArgs e)
        {
            BrightIdeasSoftware.ObjectListView o = sender as BrightIdeasSoftware.ObjectListView;
            if (o.SelectedItem != null)
            {
                if (o.SelectedItem.RowObject is Client)
                {
                    cl = o.SelectedItem.RowObject as Client;
                    EditClient();
                }
            }
            idTextBox.Enabled = false;
        }
        public void btnSubmit_Click(object sender, EventArgs e)
        {
            cl.ClientName = nameTextBox.Text;
            cl.CurrencyID = currencyTextBox.Text;
            cl.Address = addressTextBox.Text;
            cl.Capital = capitalTextBox.Text;
            cl.ClientType = clienttypeTextBox.Text;
            cl.Company = companyTextBox.Text;
            cl.TelephoneNumber = telephoneTextBox.Text;
            cl.UpdateClient();
            Clear();
            

        }
        

        public void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            MessageBox.Show("Cells Cleared");
        }

        public void Clear()
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            currencyTextBox.Clear();
            addressTextBox.Clear();
            capitalTextBox.Clear();
            clienttypeTextBox.Clear();
            companyTextBox.Clear();
            telephoneTextBox.Clear();
        }

        public void Register()
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You are about to delete a Client, Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cl.Delete();
                MessageBox.Show("Client succesfully deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cl.Create();
            Clear();
        }
    }
}
