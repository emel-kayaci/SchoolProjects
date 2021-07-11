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
using System.Windows.Forms.Integration;

namespace DietDanisanApp
{
    public partial class UserMainMenu : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        string dietician;
        public UserMainMenu()
        {
            InitializeComponent();

        }

        private void UserMainMenu_Load(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT FirstName, LastName FROM UserTable WHERE Username = '" + loginForm.username + "'", conn);
            string firstName = "";
            string lastName = "";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                }
            }
            userWelcomeLabel.Text = firstName + " " + lastName;
            conn.Close();
        }


        private void checkDietician()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Dietician FROM UserTable WHERE Username = '" + loginForm.username + "'", conn);

            dietician = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dietician = reader["Dietician"].ToString();
                }
            }
            conn.Close();
        }

        private void UserMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userReturnToLogin_Click(object sender, EventArgs e)
        {
            loginForm loginScreen = new loginForm();
            loginScreen.Show();
            this.Hide();
        }

        private void userUpdateInfo_Click(object sender, EventArgs e)
        {
            UserUpdateInfo userUpdateForm = new UserUpdateInfo();
            userUpdateForm.Show();

        }

        private void userDieticiansShow_Click(object sender, EventArgs e)
        {
            UserDieticians dieticianChooserForm = new UserDieticians();
            dieticianChooserForm.Show();
        }

        private void userContact_Click(object sender, EventArgs e)
        {
            checkDietician();
            conn.Open();
            if (dietician.Equals(""))
            {
                MessageBox.Show("In order to contact register to a dietician!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand command2 = new SqlCommand("SELECT Mail FROM DieticianTable WHERE Username = '" + dietician + "'", conn);
                string dieticianMail = "";
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dieticianMail = reader["Mail"].ToString();
                    }
                }

                UserContact contactForm = new UserContact(dieticianMail);
                contactForm.Show();

            }
            conn.Close();
        }

        private void userDietListsShow_Click(object sender, EventArgs e)
        {
            checkDietician();
            if (dietician.Equals(""))
            {
                MessageBox.Show("Program information is not available due to no registered dietician!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserPrograms userProgramsForm = new UserPrograms();
                userProgramsForm.Show();
            }
        }

        private void bmiCalculator_Click(object sender, EventArgs e)
        {
            UserBMICalculator.MainWindow bmiCalculatorForm = new UserBMICalculator.MainWindow();
            ElementHost.EnableModelessKeyboardInterop(bmiCalculatorForm);
            bmiCalculatorForm.Show();
        }

        private void updatePhysicalInfo_Click(object sender, EventArgs e)
        {
            UserUpdatePhysicalInformation updatePhyInfoForm = new UserUpdatePhysicalInformation();
            updatePhyInfoForm.Show();
        }

        private void userAppointment_Click(object sender, EventArgs e)
        {
            checkDietician();
            if (dietician.Equals(""))
            {
                MessageBox.Show("No registered dietician found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserAppointment userAppointmentForm = new UserAppointment();
                userAppointmentForm.Show();
            }
        }

        private void showDieticianInformation_Click(object sender, EventArgs e)
        {
            checkDietician();
            if (dietician.Equals(""))
            {
                MessageBox.Show("No registered dietician found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserDieticianInformation userDieticianInformationInfo = new UserDieticianInformation(dietician);
                userDieticianInformationInfo.Show();
            }
        }

        private void userSettings_Click(object sender, EventArgs e)
        {
            UserSettings settingsUser = new UserSettings();
            settingsUser.Show();
        }
    }
}
