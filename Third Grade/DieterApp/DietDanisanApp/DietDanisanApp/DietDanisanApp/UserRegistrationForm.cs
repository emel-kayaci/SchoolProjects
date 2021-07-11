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
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void userRegisterButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sqlcon.Open();

            int usernameCount;
            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from UserTable Where Username = '" + userUsernameRegTxt.Text.Trim() + "'", sqlcon))
            {
                usernameCount = (int)sqlCommand.ExecuteScalar();
            }

            int mailCount;
            using (SqlCommand sqlCommand2 = new SqlCommand("SELECT COUNT(*) from UserTable Where Mail = '" + userMailTxt.Text.Trim() + "'", sqlcon))
            {
                mailCount = (int)sqlCommand2.ExecuteScalar();
            }

            int idCount = 0;
            if (!userIDNumTxt.Text.Equals(""))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from UserTable Where IDNumber = '" + Convert.ToDouble(userIDNumTxt.Text) + "'", sqlcon))
                {
                    idCount = (int)sqlCommand.ExecuteScalar();
                }
            }

            if (usernameCount > 0)
            {
                MessageBox.Show("Username already taken!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (mailCount > 0)
            {
                MessageBox.Show("Mail already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idCount > 0)
            {
                MessageBox.Show("ID number already registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (userIDNumTxt.Text == "" || userMailTxt.Text == "" || userUsernameRegTxt.Text == "" || userPasswordRegTxt.Text == "")
            {
                MessageBox.Show("Please fill mandatory fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!(userPasswordRegTxt.Text.Equals(userPasConfirmTxt.Text)))
            {
                MessageBox.Show("Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string commString = "INSERT INTO UserTable(IDNumber, FirstName, LastName, Birthday, Phone, Mail, Address, Gender, Height, Weight, BodyFat, CurrentDietProgram, WeeklyExerciseProgram, AdditionalDietPrograms, Username, Password) VALUES" +
                        "(@idNumber,@firstName,@lastName,@birthday,@phone,@mail,@address,@gender,@height,@weight,@bodyFat,@currentDietProgram,@weeklyExerciseProgram,@additionalDietPrograms,@username,@password)";

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sqlcon;
                        command.CommandText = commString;

                        command.Parameters.AddWithValue("@idNumber", userIDNumTxt.Text);
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
                        command.Parameters.AddWithValue("@height", userHeightTxt.Text);
                        command.Parameters.AddWithValue("@weight", userWeightTxt.Text);
                        command.Parameters.AddWithValue("@bodyFat", userBodyFatText.Text);

                        string currentDiet;
                        if (userCurrentDietComboBox.SelectedItem != null)
                        {
                            currentDiet = userCurrentDietComboBox.SelectedItem.ToString();
                        }
                        else
                        {
                            currentDiet = "Unknown";
                        }
                        command.Parameters.AddWithValue("@currentDietProgram", currentDiet);

                        string weeklyExercise;
                        if (userWeeklyExerciseComboBox.SelectedItem != null)
                        {
                            weeklyExercise = userWeeklyExerciseComboBox.SelectedItem.ToString();
                        }
                        else
                        {
                            weeklyExercise = "Unknown";
                        }
                        command.Parameters.AddWithValue("@weeklyExerciseProgram", weeklyExercise);


                        string additionalPrograms = "";

                        foreach (object itemChecked in userAddittionalPrograms.CheckedItems)
                        {
                            string selectedItem = itemChecked.ToString();

                            if (additionalPrograms == "")
                            {
                                additionalPrograms = selectedItem;
                            }
                            else
                            {
                                additionalPrograms += "," + selectedItem;
                            }
                        }

                        command.Parameters.AddWithValue("@additionalDietPrograms", additionalPrograms);
                        command.Parameters.AddWithValue("@username", userUsernameRegTxt.Text);
                        command.Parameters.AddWithValue("@password", userPasswordRegTxt.Text);
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

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = userRegisterButton;
        }
    }
}
