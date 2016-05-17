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
    public partial class PortfolioForm : Form
    {
        PropertyForm prop1 = new PropertyForm();
        public PortfolioForm()
        {
            InitializeComponent();
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
