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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDetailsShow_Click(object sender, EventArgs e)
        {
            detailsOLV.Visible = true;
            ChangeSize();

        }

        private void btnDetailsHide_Click_1(object sender, EventArgs e)
        {
            detailsOLV.Visible = false;
            ResizeToHide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeSize();

        }

        private void ChangeSize()
        {
            int width = 1167;
            int height = 697;

            this.Size = new Size(width, height);
        }

        private new void ResizeToHide()
        {
            int width2 = 972;
            int height2 = 697;

            this.Size = new Size(width2, height2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UniversalProductCode.Generate(036241457);
            MessageBox.Show(UniversalProductCode.Generate(100).ToString());
            MessageBox.Show(UniversalProductCode.Generate2(100).ToString());
            MessageBox.Show(UniversalProductCode.isValid(1003).ToString());
        }
    }
}
