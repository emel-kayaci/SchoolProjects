using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DietDanisanApp
{
    public partial class DieticianRegistrationForm : Form
    {
        public DieticianRegistrationForm()
        {
            InitializeComponent();
        }

        private void dieticianRegister_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");

            sqlcon.Open();
            int usernameCount;
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from DieticianTable Where Username = '" + dieticianUsernameRegTxt.Text.Trim() + "'", sqlcon))
            {
                usernameCount = (int)sqlCommand.ExecuteScalar();
            }

            int mailCount;
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from DieticianTable Where Mail = '" + dieticianUsernameRegTxt.Text.Trim() + "'", sqlcon))
            {
                mailCount = (int)sqlCommand.ExecuteScalar();
            }

            int idCount = 0;

            if(!dieticianIDNumTxt.Text.Equals(""))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from DieticianTable Where IDnumber = '" + Convert.ToDouble(dieticianIDNumTxt.Text) + "'", sqlcon))
                {
                    idCount = (int)sqlCommand.ExecuteScalar();
                }

            }
           

            if (usernameCount > 0)
            {
                MessageBox.Show("Username already taken!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else if(mailCount > 0)
            {
                MessageBox.Show("Mail already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (idCount > 0)
            {
                MessageBox.Show("ID number already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dieticianUsernameRegTxt.Text == "" || dieticianPasswordRegTxt.Text == "" || dieticianIDNumTxt.Text =="" || dieticianMailTxt.Text == "" || dieterCapacityTxt.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (!(dieticianPasswordRegTxt.Text.Equals(dieticianPassConfirmTxt.Text)))
            {
                MessageBox.Show("Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string commString = "INSERT INTO DieticianTable(IDnumber, FirstName, LastName, Phone, Mail, Username, Password, University, City, DieterCapacity) VALUES" +
                        "(@IDnumber,@firstName,@lastName,@phone,@mail,@userName,@password,@university,@city,@dieterCapacity)";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sqlcon;
                        command.CommandText = commString;

                        command.Parameters.AddWithValue("@IDnumber", dieticianIDNumTxt.Text);
                        command.Parameters.AddWithValue("@firstName", dieticianNameTxt.Text);
                        command.Parameters.AddWithValue("@lastName", dieticianLastNameTxt.Text);
                        command.Parameters.AddWithValue("@phone", dieticianPhoneTxt.Text);
                        command.Parameters.AddWithValue("@mail", dieticianMailTxt.Text);
                        command.Parameters.AddWithValue("@userName", dieticianUsernameRegTxt.Text);
                        command.Parameters.AddWithValue("@password", dieticianPasswordRegTxt.Text);
                        command.Parameters.AddWithValue("@university", dieticianUniversityTxt.Text);
                        command.Parameters.AddWithValue("@city", dieticianCityTxt.Text);
                        command.Parameters.AddWithValue("@dieterCapacity", SqlDbType.Int).Value = Convert.ToInt32(dieterCapacityTxt.Text);


                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Registration completed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("A registration error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            sqlcon.Close();
        }

        private void DieticianRegistrationForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = dieticianRegister;
        }
    }
}
