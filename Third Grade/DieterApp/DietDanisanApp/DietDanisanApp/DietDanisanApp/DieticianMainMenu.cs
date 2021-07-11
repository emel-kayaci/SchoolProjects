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
    public partial class DieticianMainMenu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianMainMenu()
        {
            InitializeComponent();

        }

        private void DieticianMainMenu_Load(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";
            
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM DieticianTable WHERE Username = '" + loginForm.username + "'", conn);
           
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                }
            }

            conn.Close();

            dieticianWelcomeLabel.Text = firstName + " " + lastName;
        }

        private void DieticianMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dieticianReturnLogin_Click(object sender, EventArgs e)
        {
            loginForm loginScreen = new loginForm();
            loginScreen.Show();
            this.Hide();
        }

        private void dieticianUpdatePerInfo_Click(object sender, EventArgs e)
        {
            DieticianUpdateInfo updateDieticianForm = new DieticianUpdateInfo();
            updateDieticianForm.Show();
        }

        private void dieticianContactDieters_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT Username FROM UserTable WHERE Dietician = '" + loginForm.username + "'", conn);
            string username = "";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                }
            }
            if (username.Equals(""))
            {
                MessageBox.Show("No registered patients found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DieticianContact dieticianContactFrom = new DieticianContact();
                dieticianContactFrom.Show();
            }
            conn.Close();
        }

        private void dieticianCreateDiet_Click(object sender, EventArgs e)
        {
            DieticianCreatePrograms createProgramsForm = new DieticianCreatePrograms();
            createProgramsForm.Show();
        }

        private void dieticianSettings_Click(object sender, EventArgs e)
        {
            DieticianSettings settingsForm = new DieticianSettings();
            settingsForm.Show();
        }

        private void dieticianAppointment_Click(object sender, EventArgs e)
        {
            DieticianAppointment appointmentForm = new DieticianAppointment();
            appointmentForm.Show();
        }

        private void dieticianDeleteDieters_Click(object sender, EventArgs e)
        {
            DieticianDeleteDieters deleteDietersForm = new DieticianDeleteDieters();
            deleteDietersForm.Show();
        }

        private void healthInfoButton_Click(object sender, EventArgs e)
        {
            DieticianUpdateHealthInformation dieterHealthForm = new DieticianUpdateHealthInformation();
            dieterHealthForm.Show();
        }
    }
}
