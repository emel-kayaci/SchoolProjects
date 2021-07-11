using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace DietDanisanApp
{
    public partial class UserContact : Form
    {
        string receiverMail;
        public UserContact(string dieticianMail)
        {
            receiverMail = dieticianMail;
            InitializeComponent();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            string to, from, pass, subject, mail;

            to = (receiverMailTxt.Text).ToString();
            from = (senderMailTxt.Text).ToString();
            pass = (passwordTxt.Text).ToString();
            subject = (subjectTxt.Text).ToString();
            mail = (mailTxt.Text).ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = mail;
            message.Subject = subject;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Mail send successfulyy!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            } catch (Exception)
            {
                MessageBox.Show("Could not send mail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UserContact_Load(object sender, EventArgs e)
        {
            this.AcceptButton = sendMailButton;
            receiverMailTxt.Text = receiverMail;
        }
    }
}
