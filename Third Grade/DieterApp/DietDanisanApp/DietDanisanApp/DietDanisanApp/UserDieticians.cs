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
    public partial class UserDieticians : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserDieticians()
        {
            InitializeComponent();
        }

        private void UserDieticians_Load(object sender, EventArgs e)
        {
            this.AcceptButton = selectDieticianButton;
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Mail, University, City FROM DieticianTable", sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dieticianGridView.DataSource = dtbl;
            sqlCon.Close();

        }

        private void selectDieticianButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Dietician FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlCon);
            sqlCon.Open();

            string dietician = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dietician = reader["Dietician"].ToString();
                }
            }

            if (dietician != "")
            {
                MessageBox.Show("Please contact your dietician before change.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string mail = "";

                foreach (DataGridViewRow row in dieticianGridView.SelectedRows)
                {

                    mail = row.Cells[3].Value.ToString().Trim();
                }


                SqlCommand command = new SqlCommand("SELECT Username FROM DieticianTable WHERE Mail = '" + mail + "'", sqlCon);

                string dieticianUsername = "";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dieticianUsername = reader["Username"].ToString();
                    }
                }


                int dieterNum;
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from UserTable Where Dietician = '" + dieticianUsername + "'", sqlCon))
                {
                    dieterNum = (int)sqlCommand.ExecuteScalar();
                }

                SqlCommand cmd1 = new SqlCommand("SELECT DieterCapacity FROM DieticianTable WHERE Mail = '" + mail + "'", sqlCon);

                string dieterCapacity = "";
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dieterCapacity = reader["DieterCapacity"].ToString();
                    }
                }

                if (dieterNum == int.Parse(dieterCapacity))
                {
                    MessageBox.Show("Dietician capacity is full! Please select another dietician.", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlCommand command2 = new SqlCommand("UPDATE UserTable SET Dietician = @dieticianUsername WHERE Username = '" + loginForm.username + "'", sqlCon);

                        command2.Parameters.AddWithValue("@dieticianUsername", dieticianUsername);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Dietician registered!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("An registration error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            sqlCon.Close();
        }

    }
}


