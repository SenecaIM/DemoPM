using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portfolio
{
    public static class UniversalProductCode
    {
        public static bool IsValid(int code)
        {
            string basenumber = code.ToString().Substring(0, code.ToString().Length - 1);
            string check = Append(Convert.ToInt32(basenumber)).ToString();
            if (check == code.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
            
            

        }

        public static int Append(int code)
        {
            int cd = Generate(code);
            return Convert.ToInt32(code.ToString() + cd.ToString());
        }

        public static int Generate(int code)
        {
            int sum = 0;
            string number = code.ToString();
            for (int i = 0; i < number.Length; i += 2)
            {
                sum += Convert.ToInt32(number[i].ToString());
            }
            sum = sum * 3;

            for (int i = 1; i < number.Length; i += 2)
            {
                sum += Convert.ToInt32(number[i].ToString());
            }
            sum = sum % 10;


            return sum;
        }


    }
}
