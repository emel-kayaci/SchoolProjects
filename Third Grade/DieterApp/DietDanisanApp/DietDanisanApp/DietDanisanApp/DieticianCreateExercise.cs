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
    public partial class DieticianCreateExercise : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianCreateExercise()
        {
            InitializeComponent();
        }

        private void DieticianCreateExercise_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            refreshGridView();
            sqlCon.Close();
        }

        private void refreshGridView() {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Birthday, Mail, Gender, Height, Weight, BodyFat, CurrentDietProgram, WeeklyExerciseProgram, AdditionalDietPrograms FROM UserTable WHERE Dietician = '" + loginForm.username + "'", sqlCon);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            viewDietersGridView.DataSource = dtbl;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(firstWeekTxt.Text.Equals("") && secondWeekTxt.Text.Equals("") && thirdWeekTxt.Text.Equals("") && fourthWeekTxt.Text.Equals(""))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save blank list for this dieter?", "Save", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    update();
                }
            } else
            {
                update();
            }   
        }

        private void update()
        {
            string dieterUsername = getDieterUsername();

            sqlCon.Open();

            string query = "Select * from Exercises Where DieterUsername= '" + dieterUsername + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);

            DataTable table = new DataTable();

            sda.Fill(table);

            if (table.Rows.Count == 0) //Create
            {
                try
                {
                    string query1 = "INSERT INTO Exercises(DieterUsername, DieticianUsername, FirstWeek, SecondWeek, ThirdWeek, FourthWeek) VALUES" +
                        "(@dieterUsername,@dieticianUsername,@firstWeek,@secondWeek,@thirdWeek,@fourthWeek)";

                    updateAndCreate(query1, dieterUsername);

                    MessageBox.Show("Exercise program created!", "New Exercise Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("A creation error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //Update
            {
                string query2 = "UPDATE Exercises SET DieterUsername = @dieterUsername, DieticianUsername = @dieticianUsername, FirstWeek = @firstWeek, SecondWeek = @secondWeek, ThirdWeek = @thirdWeek, FourthWeek = @fourthWeek WHERE DieterUsername = '" + dieterUsername + "'";
                updateAndCreate(query2, dieterUsername);
            }

            try
            {
                string commString = "UPDATE UserTable SET WeeklyExerciseProgram = @weeklyExerciseProgram WHERE Username = '" + dieterUsername + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlCon;
                    command.CommandText = commString;

                    command.Parameters.AddWithValue("@weeklyExerciseProgram", programNameTxt.Text);

                    command.ExecuteNonQuery();
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
                    command.Parameters.AddWithValue("@firstWeek", firstWeekTxt.Text);
                    command.Parameters.AddWithValue("@secondWeek", secondWeekTxt.Text);
                    command.Parameters.AddWithValue("@thirdWeek", thirdWeekTxt.Text);
                    command.Parameters.AddWithValue("@fourthWeek", fourthWeekTxt.Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Update completed!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("An update error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void currentProgramButton_Click(object sender, EventArgs e)
        {
            string dieterUsername = getDieterUsername();
            sqlCon.Open();

            string nameChecker = "";
            SqlCommand commandGetName = new SqlCommand("SELECT DieterUsername FROM Exercises WHERE DieterUsername = '" + dieterUsername + "'", sqlCon);
            using (SqlDataReader reader = commandGetName.ExecuteReader())
            {
                if (reader.Read())
                {

                    nameChecker = reader["DieterUsername"].ToString();
                }
            }

            if (nameChecker.Equals(""))
            {
                MessageBox.Show("The dieter does not have an exercise program.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstWeekTxt.Clear();
                secondWeekTxt.Clear();
                thirdWeekTxt.Clear();
                fourthWeekTxt.Clear();
                programNameTxt.Clear();
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT FirstWeek, SecondWeek, ThirdWeek, FourthWeek FROM Exercises WHERE DieterUsername = '" + dieterUsername + "'", sqlCon);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstWeekTxt.Text = reader["FirstWeek"].ToString();
                        secondWeekTxt.Text = reader["SecondWeek"].ToString();
                        thirdWeekTxt.Text = reader["ThirdWeek"].ToString();
                        fourthWeekTxt.Text = reader["FourthWeek"].ToString();
                    }
                }
                SqlCommand command2 = new SqlCommand("SELECT WeeklyExerciseProgram FROM UserTable WHERE Username = '" + dieterUsername + "'", sqlCon);

                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        programNameTxt.Text = reader["WeeklyExerciseProgram"].ToString();
                    }
                }
            }
            sqlCon.Close();
        }
    }
}
