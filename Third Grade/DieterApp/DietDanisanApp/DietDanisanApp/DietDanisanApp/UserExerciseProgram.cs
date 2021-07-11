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
    public partial class UserExerciseProgram : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserExerciseProgram()
        {
            InitializeComponent();
        }

        private void UserExerciseProgram_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand command = new SqlCommand("SELECT FirstWeek, SecondWeek, ThirdWeek, FourthWeek FROM Exercises WHERE DieterUsername = '" + loginForm.username + "'", sqlCon);


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
            sqlCon.Close();
        }
    }
}
