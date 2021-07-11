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
    public partial class UserDietLists : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public UserDietLists()
        {
            InitializeComponent();
        }

        private void UserDietLists_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlCommand command = new SqlCommand("SELECT Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday FROM Diets WHERE DieterUsername = '" + loginForm.username + "'", sqlCon);


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
            sqlCon.Close();
        }
    }
}
