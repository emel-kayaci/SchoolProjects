using InheritanceBaseForm;
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
    public partial class UserUpdatePhysicalInformation : BaseFormInformation
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserUpdatePhysicalInformation()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            try
            {
                string commString = "UPDATE UserTable SET Height = @height, Weight = @weight, BodyFat = @bodyfat WHERE Username = '" + loginForm.username + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlcon;
                    command.CommandText = commString;

                    if (heightTxt.Text.Equals(""))
                    {
                        command.Parameters.AddWithValue("@height", 0);
                    } else
                    {
                        command.Parameters.AddWithValue("@height", SqlDbType.Decimal).Value = heightTxt.Text;
                    }
                    if (weightTxt.Text.Equals(""))
                    {
                        command.Parameters.AddWithValue("@weight", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@weight", SqlDbType.Decimal).Value = weightTxt.Text;
                    }
                    if (bodyFatTxt.Text.Equals(""))
                    {
                        command.Parameters.AddWithValue("@bodyFat", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@bodyFat", SqlDbType.Decimal).Value = bodyFatTxt.Text;
                    }
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Update completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlcon.Close();
        }

        private void UserUpdatePhysicalInformation_Load(object sender, EventArgs e)
        {
            this.AcceptButton = updateButton;
            sqlcon.Open();
            SqlCommand command = new SqlCommand("SELECT Height, Weight, BodyFat FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlcon);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    heightTxt.Text = reader["Height"].ToString();
                    weightTxt.Text = reader["Weight"].ToString();
                    bodyFatTxt.Text = reader["BodyFat"].ToString();
                }
            }
            sqlcon.Close();
        }
    }
}
