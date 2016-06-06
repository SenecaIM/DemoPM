using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string file = "C:\\Users\\Kacper.Lagowski\\Documents\\5.pdf";
            System.Diagnostics.Process.Start(file);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
