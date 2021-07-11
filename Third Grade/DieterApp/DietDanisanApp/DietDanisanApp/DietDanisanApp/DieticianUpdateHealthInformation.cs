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
    public partial class DieticianUpdateHealthInformation : BaseFormInformation
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianUpdateHealthInformation()
        {
            InitializeComponent();
        }



        private void DieticianUpdateHealthInformation_Load(object sender, EventArgs e)
        {
            this.AcceptButton = updateButton;
            sqlCon.Open();
            refreshGridView();
            sqlCon.Close();
        }

        private void refreshGridView()
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Birthday, Mail, Gender, Height, Weight, BodyFat, CurrentDietProgram, WeeklyExerciseProgram, AdditionalDietPrograms, BloodSugar, BloodPressure, Diseases FROM UserTable WHERE Dietician = '" + loginForm.username + "'", sqlCon);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            dietersGridView.DataSource = dtbl;
        }

        private string getDieterUsername()
        {
            sqlCon.Open();
            string dieterMail = dietersGridView.CurrentRow.Cells[3].Value.ToString();

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

        private void updateButton_Click(object sender, EventArgs e)
        {
            string dieterUsername = getDieterUsername();

            sqlCon.Open();

            try
            {
                string commString = "UPDATE UserTable SET Height = @height, Weight = @weight, BodyFat = @bodyFat, BloodSugar = @bloodSugar, BloodPressure = @bloodPressure," +
                    "Diseases = @diseases WHERE Username = '" + dieterUsername + "'";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = sqlCon;
                    command.CommandText = commString;

                    if (string.IsNullOrEmpty(heightTxt.Text))
                    {
                        command.Parameters.AddWithValue("@height", Convert.ToDouble(dietersGridView.CurrentRow.Cells[5].Value.ToString()));
                    } else
                    {
                        command.Parameters.AddWithValue("@height", SqlDbType.Decimal).Value = heightTxt.Text;
                    }
                    if (string.IsNullOrEmpty(weightTxt.Text))
                    {
                        command.Parameters.AddWithValue("@weight", Convert.ToDouble(dietersGridView.CurrentRow.Cells[6].Value.ToString()));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@weight", SqlDbType.Decimal).Value = weightTxt.Text;
                    }
                    if (string.IsNullOrEmpty(bodyFatTxt.Text))
                    {
                        command.Parameters.AddWithValue("@bodyFat", Convert.ToDouble(dietersGridView.CurrentRow.Cells[7].Value.ToString()));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@bodyFat", SqlDbType.Decimal).Value = bodyFatTxt.Text;
                    }
                    if (string.IsNullOrEmpty(bloodSugarTxt.Text))
                    {
                        command.Parameters.AddWithValue("@bloodSugar", Convert.ToDouble(dietersGridView.CurrentRow.Cells[11].Value.ToString()));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@bloodSugar", SqlDbType.Decimal).Value = bloodSugarTxt.Text;
                    }
                    if (string.IsNullOrEmpty(bloodPressureTxt.Text))
                    {
                        command.Parameters.AddWithValue("@bloodPressure", Convert.ToDouble(dietersGridView.CurrentRow.Cells[12].Value.ToString()));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@bloodPressure", SqlDbType.Decimal).Value = bloodPressureTxt.Text;
                    }
                    if (string.IsNullOrEmpty(diseasesTxt.Text))
                    {
                        command.Parameters.AddWithValue("@diseases", Convert.ToDouble(dietersGridView.CurrentRow.Cells[13].Value.ToString()));
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@diseases", diseasesTxt.Text);
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Health information updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshGridView();
                }
            }
            catch
            {
                MessageBox.Show("An update error has occured while updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            sqlCon.Close();
        }
    }
}
