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
    public partial class loginForm : Form
    {
        int panelWidth;
        bool hidden;
        public static string username;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public loginForm()
        {
            InitializeComponent();
            panelWidth = slidingPanel.Width;
            hidden = false;
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (hidden)
            {
                slidingPanel.Width += 20;
                if (slidingPanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                slidingPanel.Width -= 20;
                if (slidingPanel.Width <= 0)
                {
                    timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void userRegistrationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistrationForm userRegForm = new UserRegistrationForm();
            userRegForm.Show();
        }

        private void loginUserButton_Click(object sender, EventArgs e)
        {
            username = usernameUserTextBox.Text.Trim();
            string query = "SELECT Username, Password FROM UserTable WHERE Username = '" + username + "' AND Password = '" + passwordUserTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            sda.Fill(userTable);

            if (userTable.Rows.Count == 1)
            {
                UserMainMenu userMainMenu = new UserMainMenu();
                userMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DieticianRegistrationForm dieticianRegForm = new DieticianRegistrationForm();
            dieticianRegForm.Show();
        }

        private void changePanelLabel_Click_1(object sender, EventArgs e)
        {
            if (changePanelLabel.Text == "Click for Dietician Login")
            {
                changePanelLabel.Text = "Click for User Login";
                timer.Start();
                bottomPanel.BackColor = Color.FromArgb(139, 0, 139);

            }
            else if (changePanelLabel.Text == "Click for User Login")
            {
                changePanelLabel.Text = "Click for Dietician Login";
                timer.Start();
                bottomPanel.BackColor = Color.FromArgb(192, 192, 0);
            }
        }

        private void loginDieticianButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Username, Password FROM DieticianTable WHERE Username = '" + usernameDieticianTextBox.Text.Trim() + "' AND Password = '" + passwordDieticianTextBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            sda.Fill(userTable);

            if (userTable.Rows.Count == 1)
            {
                username = usernameDieticianTextBox.Text;
                DieticianMainMenu dieticianMainMenu = new DieticianMainMenu();
                dieticianMainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string getCurrentUsername()
        {
            return username;
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void passwordUserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginUserButton_Click(this, new EventArgs());
            }

            
        }

        private void passwordDieticianTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loginDieticianButton_Click(this, new EventArgs());
            }
        }
    }
}
