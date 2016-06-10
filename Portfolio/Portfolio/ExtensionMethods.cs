using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public static class ExtensionMethods
    {
        public static Decimal ToDecimal(this TextBox textbox)
        {
            return Convert.ToDecimal(textbox.Text);
        }

        public static string ToBookCost(this decimal bookCost)
        {
            return bookCost.ToString("#,##0.00");
        }

        public static string ToQuantity(this decimal quantity)
        {
            return quantity.ToString("#,##0.00######");
        }


    }
}
