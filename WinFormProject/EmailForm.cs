using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class EmailForm : Form
    {
        public EmailForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbxFrom.Text) && !String.IsNullOrEmpty(tbxTo.Text))
                {
                    //create an email
                    MailMessage mail = new MailMessage
                    {
                        From = new MailAddress(tbxFrom.Text),
                        Subject = tbxSubject.Text,
                        Body = rtbxContent.Text
                    };
                    mail.To.Add(tbxTo.Text);

                    //send created email
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                    {

                        Credentials = new NetworkCredential(tbxFrom.Text, tbxPassword.Text),
                        EnableSsl = true,
                        UseDefaultCredentials = true
                    };
                    client.Send(mail);
                }
            }
            catch (Exception ex)
            {

            }

            finally { 

}
        }
    }
}
