using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COMPANY_MANAGEMENT
{
    public partial class FAbsenceLetter : Form
    {
        public FAbsenceLetter()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";

            if (rbRea1.Checked)
            {
                reason = rbRea1.Text;
            }
            else if (rbRea2.Checked)
            {
                reason = rbRea2.Text;
            }
            else if (rbRea3.Checked)
            {
                reason = rbRea3.Text;
            }
            else
            {
                reason = textReason.Text;
            }

            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Absence (ID, Name, Reason, StartDate, EndDate) VALUES (@ID, @Name, @Reason, @StartDate, @EndDate)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", textID.Text);
            command.Parameters.AddWithValue("@Name", textName.Text);
            command.Parameters.AddWithValue("@Reason", reason);
            command.Parameters.AddWithValue("@StartDate", dateStart.Value);
            command.Parameters.AddWithValue("@EndDate", dateEnd.Value);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Gửi thư xin nghỉ thành công");
            this.Close();
        }
    }
}
