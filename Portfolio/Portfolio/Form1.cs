using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Portfolio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetailsShow_Click(object sender, EventArgs e)
        {
            detailsOLV.Visible = !detailsOLV.Visible;
            ChangeSize(detailsOLV.Visible);

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void ChangeSize(bool visible)
        {
            if (visible == true)
            {
                //int width = 1167;
                //int height = 697;
                this.Size = new Size(this.Size.Width + 195, this.Size.Height);
                btnDetailsShow.Text = "Hide Details";
            }
            else
            {
                this.Size = new Size(this.Size.Width - 195, this.Size.Height);
                btnDetailsShow.Text = "Show Details";
            }
        }
    }
}
