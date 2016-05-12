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
        private void AddInstruments()
        {
            InstrumentControl con = new InstrumentControl();
            con.Location = new Point(25, 25);
            this.Controls.Add(con);

        }
        public Main()
        {
            InitializeComponent();
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
