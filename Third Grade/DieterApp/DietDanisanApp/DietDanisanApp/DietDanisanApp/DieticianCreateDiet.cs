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
    public partial class DieticianCreateDiet : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianCreateDiet()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (mondayTxt.Text.Equals("") && tuesdayTxt.Text.Equals("") && wednesdayTxt.Text.Equals("") && thursdayTxt.Text.Equals("") && fridayTxt.Text.Equals("") && saturdayTxt.Text.Equals("") && sundayTxt.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save blank list for this dieter?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    update();
                }
            }
            else
            {
                update();
            }
        }


        private void update()
        {
            string dieterUsername = getDieterUsername();

            sqlCon.Open();

            string query = "Select * from Diets Where DieterUsername= '" + dieterUsername + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

            DataTable table = new DataTable();

            sda.Fill(table);

            if (table.Rows.Count == 0) //Create
            {
                try
                {
                    string query1 = "INSERT INTO Diets(DieterUsername, DieticianUsername, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday) VALUES" +
                        "(@dieterUsername,@dieticianUsername,@monday,@tuesday,@wednesday,@thursday,@friday,@saturday,@sunday)";

                    updateAndCreate(query1, dieterUsername);

                    MessageBox.Show("Diet list created!", "New Diet List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("A creation error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //Update
            {
                string query2 = "UPDATE Diets SET DieterUsername = @dieterUsername, DieticianUsername = @dieticianUsername, Monday = @monday, Tuesday = @tuesday, Wednesday = @wednesday, Thursday = @thursday, Friday = @friday, Saturday = @saturday, Sunday = @sunday WHERE DieterUsername = '" + dieterUsername + "'";
                updateAndCreate(query2, dieterUsername);
            }

            try
            {
                string commString = "UPDATE UserTable SET CurrentDietProgram = @currentDietProgram WHERE Username = '" + dieterUsername + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlCon;
                    command.CommandText = commString;

                    command.Parameters.AddWithValue("@currentDietProgram", programNameTxt.Text.Trim());
                    command.ExecuteNonQuery();
                }

                string queryAdditionalPrograms = "UPDATE UserTable SET AdditionalDietPrograms = @additionalDietPrograms WHERE Username = '" + dieterUsername + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlCon;
                    command.CommandText = queryAdditionalPrograms;

                    string additionalPrograms = "";
                    if (userAddittionalPrograms.SelectedIndex != -1)
                    {
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
                        command.ExecuteNonQuery();

                        foreach (DataGridViewRow row in viewDietersGridView.SelectedRows)
                        {
                            row.Cells[10].Value = additionalPrograms;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("An update error has occured while updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            refreshGridView();
            sqlCon.Close();
        }

        private void updateAndCreate(string commString, string dieterUsername)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlCon;
                    command.CommandText = commString;

                    command.Parameters.AddWithValue("@dieterUsername", dieterUsername);
                    command.Parameters.AddWithValue("@dieticianUsername", loginForm.username);
                    command.Parameters.AddWithValue("@monday", mondayTxt.Text);
                    command.Parameters.AddWithValue("@tuesday", tuesdayTxt.Text);
                    command.Parameters.AddWithValue("@wednesday", wednesdayTxt.Text);
                    command.Parameters.AddWithValue("@thursday", thursdayTxt.Text);
                    command.Parameters.AddWithValue("@friday", fridayTxt.Text);
                    command.Parameters.AddWithValue("@saturday", saturdayTxt.Text);
                    command.Parameters.AddWithValue("@sunday", sundayTxt.Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Update completed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DieticianCreateDiet_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            refreshGridView();
            sqlCon.Close();

        }

        private void refreshGridView()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Birthday, Mail, Gender, Height, Weight, BodyFat, CurrentDietProgram, WeeklyExerciseProgram, AdditionalDietPrograms FROM UserTable WHERE Dietician = '" + loginForm.username + "'", sqlCon);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            viewDietersGridView.DataSource = dtbl;
        }

        private void currentProgramButton_Click(object sender, EventArgs e)
        {
            string dieterUsername = getDieterUsername();
            sqlCon.Open();

            string nameChecker = "";
            SqlCommand commandGetName = new SqlCommand("SELECT DieterUsername FROM Diets WHERE DieterUsername = '" + dieterUsername + "'", sqlCon);
            using (SqlDataReader reader = commandGetName.ExecuteReader())
            {
                if (reader.Read())
                {

                    nameChecker = reader["DieterUsername"].ToString();
                }
            }

            if (nameChecker.Equals(""))
            {
                MessageBox.Show("The dieter does not have a diet program.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mondayTxt.Clear();
                tuesdayTxt.Clear();
                wednesdayTxt.Clear();
                thursdayTxt.Clear();
                fridayTxt.Clear();
                saturdayTxt.Clear();
                sundayTxt.Clear();
                programNameTxt.Clear();
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM Diets WHERE DieterUsername = '" + dieterUsername + "'", sqlCon);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        mondayTxt.Text = reader["Monday"].ToString();
                        tuesdayTxt.Text = reader["Tuesday"].ToString();
                        wednesdayTxt.Text = reader["Wednesday"].ToString();
                        thursdayTxt.Text = reader["Thursday"].ToString();
                        fridayTxt.Text = reader["Friday"].ToString();
                        saturdayTxt.Text = reader["Saturday"].ToString();
                        sundayTxt.Text = reader["Sunday"].ToString();
                    }
                }
                SqlCommand command2 = new SqlCommand("SELECT CurrentDietProgram FROM UserTable WHERE Username = '" + dieterUsername + "'", sqlCon);

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        programNameTxt.Text = reader["CurrentDietProgram"].ToString();
                    }
                }
            }
            sqlCon.Close();
        }

        private string getDieterUsername()
        {
            sqlCon.Open();
            string dieterMail = "";
            foreach (DataGridViewRow row in viewDietersGridView.SelectedRows)
            {
                dieterMail = row.Cells[3].Value.ToString().Trim();
            }

            SqlCommand cmd = new SqlCommand("SELECT Username FROM UserTable WHERE Mail = '" + dieterMail + "'", sqlCon);
            string dieterUsername = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dieterUsername = reader["Username"].ToString();
                }
            }
            sqlCon.Close();
            return dieterUsername;
        }
    }
}
