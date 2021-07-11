using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietDanisanApp
{
    public partial class DieticianContact : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        string dieticianMail = "";
        public DieticianContact()
        {
            InitializeComponent();
        }

        private void DieticianContact_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Birthday, Phone, Mail, Gender, Height, Weight, BodyFat, CurrentDietProgram, WeeklyExerciseProgram, AdditionalDietPrograms FROM UserTable WHERE Dietician = '" + loginForm.username + "'", sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dieticianInfoGridView.DataSource = dtbl;

            SqlCommand cmd = new SqlCommand("SELECT Mail FROM DieticianTable WHERE Username = '" + loginForm.username + "'", sqlCon);
           
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dieticianMail = reader["Mail"].ToString();
                }
            }
            senderMailTxt.Text = dieticianMail;
            sqlCon.Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            
            if(senderMailTxt.Text.Equals("") || passwordTxt.Text.Equals("") || mailSubjectTxt.Equals("") || mailTxt.Equals(""))
            {
                MessageBox.Show("All fields must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                string dieterMail = "";
                foreach (DataGridViewRow row in dieticianInfoGridView.SelectedRows)
                {
                    dieterMail = row.Cells[4].Value.ToString().Trim();
                }

                string to, from, pass, subject, mail;

                to = dieterMail;
                from = dieticianMail;
                pass = (passwordTxt.Text).ToString();
                subject = (mailSubjectTxt.Text).ToString();
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
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not send mail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sqlCon.Close();
                this.Hide();
            }
        }
    }
}
