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
    public partial class UserAppointment : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        List<Panel> timePanels = new List<Panel>();
        List<string> times = new List<string>() {"9:30-10:00", "10:00-10:30", "10:30-11:00", "11:00-11:30", "13:00-13:30", "13:30-14:00", "14:00-14:30",
            "14:30-15:00", "15:00-15:30", "15:30-16:00", "16:00-16:30", "16:30-17:00"};

        string dieticianUsername;

        public UserAppointment()
        {
            InitializeComponent();
        }


        public void setColor(bool confirmState, Color color)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = sqlcon;
                cmd.CommandType = CommandType.StoredProcedure;

                string cmdTxt = "SELECT AppTime FROM Appointments WHERE AppDate = '" + monthCalendar.SelectionRange.Start.Date.ToShortDateString() + "' AND ConfirmState = '" + confirmState + "' AND DieticianUsername = '" + dieticianUsername + "'";
                List<string> appTimes = new List<string>(); // The approved appointment times in selected day 

                DataTable appTimeTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdTxt, sqlcon);
                da.Fill(appTimeTable);

                foreach (DataRow row in appTimeTable.Rows)
                {
                    foreach (string time in row.ItemArray)
                    {
                        appTimes.Add(time);
                    }
                }

                int count = 0;
                foreach (string time in times)
                {
                    if (appTimes.Contains(time))
                    {
                        Panel panel = timePanels[count];
                        panel.BackColor = color;

                    }
                    count += 1;
                }
            }
        }

        private void bookAnAppMenuItem_Click(object sender, EventArgs e)
        {
            setColors();

            bookAppDatePanel.Show();
        }

        private void viewMenuItem_Click(object sender, EventArgs e)
        {
            viewAndCancelPanel.Show();
            bookAppDatePanel.Hide();

            sqlcon.Open();   
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT AppDate, AppTime, ConfirmState FROM Appointments WHERE DieterUsername = '" + loginForm.username + "'", sqlcon);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);

            viewAppGridView.DataSource = dtbl;
            sqlcon.Close();
        }


        private void timePanel1_Click(object sender, EventArgs e)
        {
            if ((timePanel1.BackColor != Color.Crimson) && (timePanel1.BackColor != Color.Gold))
            {
                timePanel1.BackColor = (timePanel1.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel2_Click(object sender, EventArgs e)
        {
            if ((timePanel2.BackColor != Color.Crimson) && (timePanel2.BackColor != Color.Gold))
            {
                timePanel2.BackColor = (timePanel2.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel3_Click(object sender, EventArgs e)
        {
            if ((timePanel3.BackColor != Color.Crimson) && (timePanel3.BackColor != Color.Gold))
            {
                timePanel3.BackColor = (timePanel3.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel4_Click(object sender, EventArgs e)
        {
            if ((timePanel4.BackColor != Color.Crimson) && (timePanel4.BackColor != Color.Gold))
            {
                timePanel4.BackColor = (timePanel4.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel5_Click(object sender, EventArgs e)
        {
            if ((timePanel5.BackColor != Color.Crimson) && (timePanel5.BackColor != Color.Gold))
            {
                timePanel5.BackColor = (timePanel5.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel6_Click(object sender, EventArgs e)
        {
            if ((timePanel6.BackColor != Color.Crimson) && (timePanel6.BackColor != Color.Gold))
            {
                timePanel6.BackColor = (timePanel6.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel7_Click(object sender, EventArgs e)
        {
            if ((timePanel7.BackColor != Color.Crimson) && (timePanel7.BackColor != Color.Gold))
            {
                timePanel7.BackColor = (timePanel7.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel8_Click(object sender, EventArgs e)
        {
            if ((timePanel8.BackColor != Color.Crimson) && (timePanel8.BackColor != Color.Gold))
            {
                timePanel8.BackColor = (timePanel8.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel9_Click(object sender, EventArgs e)
        {
            if ((timePanel9.BackColor != Color.Crimson) && (timePanel9.BackColor != Color.Gold))
            {
                timePanel9.BackColor = (timePanel9.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel10_Click(object sender, EventArgs e)
        {
            if ((timePanel10.BackColor != Color.Crimson) && (timePanel10.BackColor != Color.Gold))
            {
                timePanel10.BackColor = (timePanel10.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel11_Click(object sender, EventArgs e)
        {
            if ((timePanel11.BackColor != Color.Crimson) && (timePanel11.BackColor != Color.Gold))
            {
                timePanel11.BackColor = (timePanel11.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void timePanel12_Click(object sender, EventArgs e)
        {
            if ((timePanel12.BackColor != Color.Crimson) && (timePanel12.BackColor != Color.Gold))
            {
                timePanel12.BackColor = (timePanel12.BackColor == Color.FromArgb(224, 224, 224) ? Color.DarkCyan : Color.FromArgb(224, 224, 224));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timePanel1_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timePanel2_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timePanel3_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            timePanel4_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timePanel5_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            timePanel6_Click(sender, e);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timePanel7_Click(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timePanel8_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            timePanel9_Click(sender, e);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            timePanel10_Click(sender, e);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            timePanel11_Click(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            timePanel12_Click(sender, e);
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            sqlcon.Open();

            DateTime dt = DateTime.Today;

            int res = DateTime.Compare(dt.Date, monthCalendar.SelectionRange.Start.Date);

            if (res <= 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT Dietician FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlcon);

                string dietician = "";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dietician = reader["Dietician"].ToString();
                    }
                }

                int count = 0;
                int appCount = 0;
                foreach (Panel p in timePanels)
                {
                    if (p.BackColor == Color.DarkCyan)
                    {
                        try
                        {
                            string commString = "INSERT INTO Appointments(DieticianUsername, DieterUsername, AppDate, AppTime, ConfirmState) VALUES" +
                                "(@dieticianUsername,@dieterUsername,@appDate,@appTime,@confirmState)";

                            using (SqlCommand command = new SqlCommand())
                            {
                                command.Connection = sqlcon;
                                command.CommandText = commString;

                                command.Parameters.AddWithValue("@dieticianUsername", dietician);
                                command.Parameters.AddWithValue("@dieterUsername", loginForm.username);
                                command.Parameters.AddWithValue("@appDate", monthCalendar.SelectionRange.Start.Date.ToShortDateString());
                                command.Parameters.AddWithValue("@appTime", times[count]);
                                command.Parameters.Add("@confirmState", SqlDbType.Bit).Value = 0;

                                command.ExecuteNonQuery();
                            }
                            appCount += 1;
                            MessageBox.Show("Your appointment request number " + appCount + " has been sent to your dietician!", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            p.BackColor = Color.Gold;
                        }
                        catch
                        {
                            MessageBox.Show("An appointment error has occurred.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    count += 1;
                }
            }
            else
            {
                MessageBox.Show("Appointment date has passed. Please select valid date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            sqlcon.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            setColors();

        }

        private void setColors()
        {
            foreach (Panel p in timePanels)
            {
                p.BackColor = Color.FromArgb(224, 224, 224);
            }

            colorAllAppointments();

        }

        public void colorAllAppointments()
        {
            sqlcon.Open();

            timePanels.Add(timePanel1); timePanels.Add(timePanel2); timePanels.Add(timePanel3); timePanels.Add(timePanel4);
            timePanels.Add(timePanel5); timePanels.Add(timePanel6); timePanels.Add(timePanel7); timePanels.Add(timePanel8);
            timePanels.Add(timePanel9); timePanels.Add(timePanel10); timePanels.Add(timePanel11); timePanels.Add(timePanel12);
            string query = "SELECT AppTime FROM Appointments WHERE AppDate = '" + monthCalendar.SelectionRange.Start.Date.ToShortDateString() + "' AND DieticianUsername = '" + dieticianUsername + "'";
            int rowCount = 0;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable checkAppTable = new DataTable();

            sda.Fill(checkAppTable);

            rowCount = checkAppTable.Rows.Count;

            if (rowCount != 0)
            {
                setColor(true, Color.Crimson);
                setColor(false, Color.Gold);
            }
            sqlcon.Close();
        }

        private void UserAppointment_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand("SELECT Dietician FROM UserTable WHERE Username = '" + loginForm.username + "'", sqlcon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    dieticianUsername = reader["Dietician"].ToString();
                }
            }
            sqlcon.Close();
            colorAllAppointments();
        }

        private void informationColorCode_Click(object sender, EventArgs e)
        {
            UserColorCode colorCodeForm = new UserColorCode();
            colorCodeForm.Show();
        }

        private void cancelAppButton_Click(object sender, EventArgs e)
        {
            string appDate = "";
            string appTime = "";
            foreach (DataGridViewRow row in viewAppGridView.SelectedRows)
            {
                appDate = row.Cells[0].Value.ToString().Trim();
                appTime = row.Cells[1].Value.ToString().Trim();
            }
            sqlcon.Open();

            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Appointments WHERE AppDate = @appDate And AppTime = @appTime", sqlcon))
                {
                    command.Parameters.AddWithValue("@appDate", appDate);
                    command.Parameters.AddWithValue("@appTime", appTime);
                    command.ExecuteNonQuery();
                }

                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT AppDate, AppTime, ConfirmState FROM Appointments WHERE DieterUsername = '" + loginForm.username + "'", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                viewAppGridView.DataSource = dtbl;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            sqlcon.Close();
        }
    }
}

