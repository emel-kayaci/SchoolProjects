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
    public partial class DieticianAppointment : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DietDanisanDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public DieticianAppointment()
        {
            InitializeComponent();
        }

        private void registeredAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            refreshGridView(true, registeredGridView);
            sqlcon.Close();
            registeredPanel.Show();
            pendingPanel.Hide();

        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshGridView(false, pendingGridView);
            pendingPanel.Show();
        }

        private void DieticianAppointment_Load(object sender, EventArgs e)
        {
            sqlcon.Open();
            refreshGridView(false, pendingGridView);
            sqlcon.Close();
        }

        private void refreshGridView(bool confirmState, DataGridView gridView)
        {
            string query = "SELECT ut.FirstName, ut.LastName, ut.Phone, ut.Mail, app.AppDate, app.AppTime, app.ConfirmState FROM UserTable ut INNER JOIN Appointments app ON ut.Username = app.DieterUsername WHERE app.DieticianUsername= '" + loginForm.username + "' AND app.ConfirmState = '" + confirmState + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable unregApp = new DataTable();
            sda.Fill(unregApp);
            gridView.DataSource = unregApp;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            List<string> primaryKeys = getPrimaryKeys(pendingGridView);
            sqlcon.Open();
            try
            {
                string commString = "UPDATE Appointments SET ConfirmState = @confirmState WHERE DieterUsername = '" + primaryKeys[0] + "' AND AppDate = '" + primaryKeys[1] + "' AND AppTime = '" + primaryKeys[2] + "'";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlcon;
                    cmd.CommandText = commString;
                    cmd.Parameters.AddWithValue("@confirmState", true);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Appointment confirmed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshGridView(false, pendingGridView);
            }
            catch
            {
                MessageBox.Show("A confirmation error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlcon.Close();
        }

        private List<string> getPrimaryKeys(DataGridView gridView)
        {
            List<string> primaryKeys = new List<string>();
            string dieterMail = "";
            string appDate = "";
            string appTime = "";
            foreach (DataGridViewRow row in gridView.SelectedRows)
            {
                dieterMail = row.Cells[3].Value.ToString().Trim();
                appDate = row.Cells[4].Value.ToString().Trim();
                appTime = row.Cells[5].Value.ToString().Trim();
            }

            sqlcon.Open();
            SqlCommand command = new SqlCommand("SELECT Username FROM UserTable WHERE Mail = '" + dieterMail + "'", sqlcon);

            string username = "";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    username = reader["Username"].ToString();
                }
            }
            primaryKeys.Add(username);
            primaryKeys.Add(appDate);
            primaryKeys.Add(appTime);

            sqlcon.Close();
            return primaryKeys;
        }

        private void cancelBtn1_Click(object sender, EventArgs e)
        {
            cancelAppointment(pendingGridView);
            refreshGridView(false, pendingGridView);
        }

        private void cancelAppointment(DataGridView gridView)
        {
            List<string> primaryKeys = getPrimaryKeys(gridView);

            if (MessageBox.Show("Are you sure you want to cancel this appointment?", "Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlcon.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand("DELETE FROM Appointments WHERE DieterUsername = @username AND AppDate = @appDate AND AppTime = @appTime", sqlcon))
                    {
                        command.Parameters.AddWithValue("@username", primaryKeys[0]);
                        command.Parameters.AddWithValue("@appDate", primaryKeys[1]);
                        command.Parameters.AddWithValue("@appTime", primaryKeys[2]);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("The appointment cancelled!", "Cancel Success", MessageBoxButtons.OK);
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Cancel error has occured!", ex.Message));
                }
                sqlcon.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cancelAppointment(registeredGridView);
            refreshGridView(true, registeredGridView);
        }

        private void returnToPending_Click(object sender, EventArgs e)
        {
            List<string> primaryKeys = getPrimaryKeys(registeredGridView);
            sqlcon.Open();
            try
            {
                string commString = "UPDATE Appointments SET ConfirmState = @confirmState WHERE DieterUsername = '" + primaryKeys[0] + "' AND AppDate = '" + primaryKeys[1] + "' AND AppTime = '" + primaryKeys[2] + "'";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = sqlcon;
                    cmd.CommandText = commString;
                    cmd.Parameters.AddWithValue("@confirmState", false);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Appointment returned to pending.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshGridView(true, registeredGridView);
            }
            catch
            {
                MessageBox.Show("A confirmation error has occured.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sqlcon.Close();
        }
    }
}
