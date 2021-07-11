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
    public partial class UserDieticianInformation : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        string dieticianName;
        public UserDieticianInformation(string dietician)
        {
            InitializeComponent();
            dieticianName = dietician;
        }

        private void UserDieticianInformation_Load(object sender, EventArgs e)
        {
            sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT FirstName, LastName, Phone, Mail, University, City FROM DieticianTable Where Username = '" + dieticianName + "'", sqlCon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            viewDieticianInfoGridView.DataSource = dtbl;
            sqlCon.Close();
        }
    }
}
