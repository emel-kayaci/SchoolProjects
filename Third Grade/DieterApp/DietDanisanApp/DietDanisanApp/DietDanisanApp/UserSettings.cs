using Microsoft.VisualBasic;
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
    public partial class UserSettings : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserSettings()
        {
            InitializeComponent();
        }

        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account? Deleting your account is permanent and will remove all content including diet lists, dieticians and appointments.", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                sqlcon.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM UserTable WHERE Username = @username", sqlcon))
                    {
                        command.Parameters.AddWithValue("@username", loginForm.username);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }
                sqlcon.Close();
                MessageBox.Show("The account has been deleted successfully. See you on new adventures dieter!", "Goodbye!", MessageBoxButtons.OK);
                foreach (Form var in Application.OpenForms)
                {
                    var.Hide();
                }
                loginForm login = new loginForm();
                login.Show();
            }
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {
                string commString = "UPDATE UserTable SET Password = @password WHERE Username = '" + loginForm.username + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlcon;
                    command.CommandText = commString;

                    string password = Interaction.InputBox("Enter your new password.", "Change Password");
                    if (password.Equals(""))
                    {
                        MessageBox.Show("Password field should can not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        password = Interaction.InputBox("Enter your new password.", "Change Password");
                    }
                    else
                    {
                        MessageBox.Show("New Password: " + password, "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        command.Parameters.AddWithValue("@password", password);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlcon.Close();
        }
    }
}