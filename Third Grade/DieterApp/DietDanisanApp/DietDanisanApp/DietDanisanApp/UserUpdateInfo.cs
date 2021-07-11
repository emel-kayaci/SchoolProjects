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
    public partial class UserUpdateInfo : Form
    {
        public UserUpdateInfo()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            int mailCount;
            using (SqlCommand sqlCommand2 = new SqlCommand("SELECT COUNT(*) from UserTable Where Mail = '" + userMailTxt.Text.Trim() + "'", sqlcon))
            {
                mailCount = (int)sqlCommand2.ExecuteScalar();
            }

            int idCount;
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from UserTable Where IDNumber = '" + Convert.ToDouble(userIDNumTxt.Text) + "'", sqlcon))
            {
                idCount = (int)sqlCommand.ExecuteScalar();
            }

            string userMail = "";
            long userID = 0;
            SqlCommand commandInfo = new SqlCommand("SELECT IDNumber, Mail FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlcon);
            using (SqlDataReader reader = commandInfo.ExecuteReader())
            {
                if (reader.Read())
                {
                    userID = Convert.ToInt64(reader["IDNumber"].ToString());
                    userMail = reader["Mail"].ToString();
                }
            }

            if (userIDNumTxt.Text == "" || userMailTxt.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mailCount > 0 && !(userMailTxt.Text.Trim().Equals(userMail)))
            {
                MessageBox.Show("Mail already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (idCount > 0 && (Convert.ToDouble(userIDNumTxt.Text)) != userID)
            {
                MessageBox.Show("ID number already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string commString = "UPDATE UserTable SET IDNumber = @idNum, FirstName = @firstName, LastName = @lastName, Birthday = @birthDay, Phone = @phone, " +
                        "Mail = @mail, Address = @address, Gender = @gender WHERE Username = '" + loginForm.username + "'";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sqlcon;
                        command.CommandText = commString;

                        command.Parameters.AddWithValue("@idNum", userIDNumTxt.Text);
                        command.Parameters.AddWithValue("@firstName", userFirstNameTxt.Text);
                        command.Parameters.AddWithValue("@lastName", userLastNameTxt.Text);
                        command.Parameters.AddWithValue("@birthday", SqlDbType.Date).Value = dateTimePickerUser.Value.Date;
                        command.Parameters.AddWithValue("@phone", userPhoneTxt.Text);
                        command.Parameters.AddWithValue("@mail", userMailTxt.Text);
                        command.Parameters.AddWithValue("@address", userAddressTxt.Text);
                        string gender;
                        if (femaleButton.Checked)
                        {
                            gender = femaleButton.Text;
                        }
                        else if (maleButton.Checked)
                        {
                            gender = maleButton.Text;
                        }
                        else
                        {
                            gender = "Unknown";
                        }
                        command.Parameters.AddWithValue("@gender", gender);

                        command.ExecuteNonQuery();
                        MessageBox.Show("An update completed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            sqlcon.Close();
        }

        private void UserUpdateInfo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = updateButton;
            sqlcon.Open();
            SqlCommand command = new SqlCommand("SELECT IDNumber, FirstName, LastName, Birthday, Phone, Mail, Address, Gender FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlcon);

            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    userIDNumTxt.Text = reader["IDNumber"].ToString();
                    userFirstNameTxt.Text = reader["FirstName"].ToString();
                    userLastNameTxt.Text = reader["LastName"].ToString();
                    dateTimePickerUser.Text = reader["Birthday"].ToString();
                    userPhoneTxt.Text = reader["Phone"].ToString();
                    userMailTxt.Text = reader["Mail"].ToString();
                    userAddressTxt.Text = reader["Address"].ToString();
                    if (reader["Gender"].ToString().Trim().Equals("Female"))
                    {
                        femaleButton.Checked = true;
                    }
                    else if (reader["Gender"].ToString().Equals("Male"))
                    {
                        maleButton.Checked = true;
                    }
                }
            }

            sqlcon.Close();
        }
    }
}

