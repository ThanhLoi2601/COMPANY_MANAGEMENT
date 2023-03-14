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
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Absence (ID, Name, Reason, StartDate, EndDate) VALUES (@ID, @Name, @Reason, @StartDate, @EndDate)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", textID.Text);
            command.Parameters.AddWithValue("@Name", textName.Text);
            command.Parameters.AddWithValue("@Reason", rbRea1.Checked ? rbRea1.Text : rbRea2.Text);
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
