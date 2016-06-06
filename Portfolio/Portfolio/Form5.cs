
using Portfolio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;


namespace cars
{
    public partial class Form5 : Form
    {
        void sendEmail()
        {
            string strFrom;
                            string strTo;
                            string strSubject;
                            string strBody;
            MailMessage objMailMessage = new MailMessage();
            System.Net.NetworkCredential objSMTPUserInfo =
                new System.Net.NetworkCredential();
            SmtpClient objSmtpClient = new SmtpClient();
            strTo = "kacper.lagowski@senecaim.com";
            strSubject = "IT Support with application 'Portfolio.olv'";
            strBody = helpTextBox.Text + Environment.NewLine + "Email:" + emailTextBox.Text;
            strFrom = "kacper.lagowski@senecaim.com";
            try
            {
                objMailMessage.IsBodyHtml = true;
                objMailMessage.From = new MailAddress(strFrom);
                objMailMessage.To.Add(new MailAddress(strTo));
                objMailMessage.Subject = strSubject;
                objMailMessage.Body = strBody;
                

                objSmtpClient = new SmtpClient("mail.nero.systems"); /// Server IP
                objSMTPUserInfo = new System.Net.NetworkCredential();
                //("User name", "Password", "Domain");
                objSmtpClient.Credentials = objSMTPUserInfo;
                objSmtpClient.UseDefaultCredentials = false;
                objSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                 
                objSmtpClient.Send(objMailMessage);
            }
            catch (Exception ex)
            { throw ex; }

            finally
            {
                objMailMessage = null;
                objSMTPUserInfo = null;
                objSmtpClient = null;
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendEmail();
           DatabaseLog();
            MessageBox.Show("Thank you for contacting the IT department of Seneca Investment Managers ltd. Someone should contact you withing an hour.");
            this.Close();
        }

        private void DatabaseLog()
        {
            DataTable ds = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlCommand cmd = Database.CommandFactory("spHelpLog"))
            {
                cmd.Parameters.Add(new SqlParameter(@"Problem", helpTextBox.Text));          
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
