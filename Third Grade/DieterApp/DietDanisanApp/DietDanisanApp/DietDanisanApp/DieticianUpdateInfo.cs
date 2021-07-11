using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietDanisanApp
{
    public partial class DieticianUpdateInfo : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        public DieticianUpdateInfo()
        {
            InitializeComponent();
        }

        private void DieticianUpdateInfo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = updateButton;

            sqlcon.Open();
            SqlCommand command = new SqlCommand("SELECT IDnumber, FirstName, LastName, Phone, Mail, University, City, DieterCapacity FROM DieticianTable WHERE Username = '" + loginForm.username + "'", sqlcon);

            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    dieticianIDNumTxt.Text = reader["IDnumber"].ToString();
                    dieticianNameTxt.Text = reader["FirstName"].ToString();
                    dieticianLastNameTxt.Text = reader["LastName"].ToString();
                    dieticianPhoneTxt.Text = reader["Phone"].ToString();
                    dieticianMailTxt.Text = reader["Mail"].ToString(); 
                    dieticianUniversityTxt.Text = reader["University"].ToString();
                    dieticianCityTxt.Text = reader["City"].ToString();
                    dieterCapacityTxt.Text = reader["DieterCapacity"].ToString();
                }
            }

            sqlcon.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            int mailCount;
            using (SqlCommand sqlCommand2 = new SqlCommand("SELECT COUNT(*) from DieticianTable Where Mail = '" + dieticianMailTxt.Text.Trim() + "'", sqlcon))
            {
                mailCount = (int)sqlCommand2.ExecuteScalar();
            }

            int idCount = 0;

            if(!dieticianIDNumTxt.Text.Equals(""))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from DieticianTable Where IDnumber = '" + Convert.ToDouble(dieticianIDNumTxt.Text) + "'", sqlcon))
                {
                    idCount = (int)sqlCommand.ExecuteScalar();
                }
            }

            SqlCommand commandInfo = new SqlCommand("SELECT IDnumber, Mail FROM DieticianTable WHERE Username = '" + loginForm.username + "'", sqlcon);

            string dieticianMail = "";
            long IDnumber = 0;

            using (SqlDataReader reader = commandInfo.ExecuteReader())
            {
                if (reader.Read())
                {
                    IDnumber = Convert.ToInt64(reader["IDnumber"].ToString());
                    dieticianMail = reader["Mail"].ToString();
                }
            }

            if (dieticianIDNumTxt.Text == "" || dieticianMailTxt.Text == "" || dieterCapacityTxt.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idCount > 0 && (Convert.ToInt64(dieticianIDNumTxt.Text)) != IDnumber)
            {
                MessageBox.Show("ID number already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mailCount > 0 && !(dieticianMailTxt.Text.Trim().Equals(dieticianMail)))
            {
                MessageBox.Show("Mail already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string commString = "UPDATE DieticianTable SET IDnumber = @idNum, FirstName = @firstName, LastName = @lastName, Phone = @phone, " +
                        "Mail = @mail, University = @university, City = @city, DieterCapacity = @dieterCapacity WHERE Username = '" + loginForm.username + "'";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sqlcon;
                        command.CommandText = commString;

                        command.Parameters.AddWithValue("@idNum", SqlDbType.BigInt).Value = Convert.ToInt64(dieticianIDNumTxt.Text);
                        command.Parameters.AddWithValue("@firstName", dieticianNameTxt.Text);
                        command.Parameters.AddWithValue("@lastName", dieticianLastNameTxt.Text);
                        command.Parameters.AddWithValue("@phone", dieticianPhoneTxt.Text);
                        command.Parameters.AddWithValue("@mail", dieticianMailTxt.Text);
                        command.Parameters.AddWithValue("@university", dieticianUniversityTxt.Text);
                        command.Parameters.AddWithValue("@city", dieticianCityTxt.Text);
                        command.Parameters.AddWithValue("@dieterCapacity", SqlDbType.Int).Value = Convert.ToInt32(dieterCapacityTxt.Text);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Update completed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            sqlcon.Close();
        }
    }
}
