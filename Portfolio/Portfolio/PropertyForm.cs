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
    public partial class PropertyForm : Form
    {
        public PropertyForm()
        {
            InitializeComponent();
        }

        public void SetLocation(Form parent)
        {
            this.Top = parent.Top;
            this.Height = parent.Height;
            this.Left = parent.Left + parent.Width;
        
        }
        public void SetObject(object obj)
        {
            propertyGrid.SelectedObject = obj;
        }

        private void propertyGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
