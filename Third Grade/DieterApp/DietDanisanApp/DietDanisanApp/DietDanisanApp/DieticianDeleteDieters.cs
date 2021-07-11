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
    public partial class DieticianDeleteDieters : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianDeleteDieters()
        {
            InitializeComponent();
        }

        private void deleteDietLists(string username)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Diets WHERE DieterUsername = @username", sqlcon))
                {

                    command.Parameters.AddWithValue("@username", username);

                    command.ExecuteNonQuery();
                    MessageBox.Show("The diet list information is deleted!", "Delete Success", MessageBoxButtons.OK);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Delete error has occured!", ex.Message));
            }

        }

        private void deleteExerciseProgram(string username)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Exercises WHERE DieterUsername = @username", sqlcon))
                {

                    command.Parameters.AddWithValue("@username", username);

                    command.ExecuteNonQuery();
                    MessageBox.Show("The exercise program information is deleted!", "Delete Success", MessageBoxButtons.OK);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Delete error has occured!", ex.Message));
            }

        }

        private void deleteAppointments(string username)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Appointments WHERE DieterUsername = @username", sqlcon))
                {

                    command.Parameters.AddWithValue("@username", username);

                    command.ExecuteNonQuery();
                    MessageBox.Show("The appointments are deleted!", "Delete Success", MessageBoxButtons.OK);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Delete error has occured!", ex.Message));
            }

        }

        private string getDieterUsername()
        {
            sqlcon.Open();
            string dieterMail = "";
            foreach (DataGridViewRow row in dieterDataView.SelectedRows)
            {
                dieterMail = row.Cells[3].Value.ToString().Trim();
            }

            SqlCommand cmd = new SqlCommand("SELECT Username FROM UserTable WHERE Mail = '" + dieterMail + "'", sqlcon);
            string username = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                }

            }
            sqlcon.Close();
            return username;
        }

        private void deleteListBtn_Click(object sender, EventArgs e)
        {
            string username = getDieterUsername();
            sqlcon.Open();
            if (MessageBox.Show("Are you sure you want to delete diet list for this dieter?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteDietLists(username);
            }
            sqlcon.Close();
        }

        private void DieticianDeleteDieters_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            refreshGridView();
            sqlcon.Close();
        }


        private void refreshGridView()
        {
            string query = "SELECT FirstName, LastName, Phone, Mail FROM UserTable WHERE Dietician = '" + loginForm.username + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dieters = new DataTable();
            sda.Fill(dieters);
            dieterDataView.DataSource = dieters;
        }

        private void deleteAppBtn_Click(object sender, EventArgs e)
        {
            string username = getDieterUsername();
            sqlcon.Open();

            if (MessageBox.Show("Are you sure you want to delete appointments for this dieter?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteAppointments(username);
            }
            sqlcon.Close();
        }

        private void deleteDieterBtn_Click(object sender, EventArgs e)
        {
           
            string username = getDieterUsername();
            deleteAppointments(username);
            deleteDietLists(username);
            deleteExerciseProgram(username);
            sqlcon.Open();

            try
            {
                using (SqlCommand command = new SqlCommand("UPDATE UserTable SET Dietician = NULL WHERE Username = '" + username + "'", sqlcon))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("The dieter is deleted!", "Delete Success", MessageBoxButtons.OK);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("Delete error has occured!", ex.Message));
            }
            refreshGridView();
            sqlcon.Close();
        }

        private void deleteExerciseButton_Click(object sender, EventArgs e)
        {
            string username = getDieterUsername();
            sqlcon.Open();
            if (MessageBox.Show("Are you sure you want to delete exercise program for this dieter?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteExerciseProgram(username);
            }
            sqlcon.Close();
        }
    }
}



