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
    public partial class FCheck : Form
    {
        string ID;
        public FCheck(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void FCheck_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
            LoadCongViec();
            
        }

        private void FCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        public bool CanCheckIn()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 0, 0);
            if (currentTime < checkoutTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanCheckOut()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
            if (currentTime < checkoutTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True");
            connection.Open();
            string query = "INSERT INTO SQLCheck (DateCheck, CheckIn, CheckOut) VALUES (@NgayCheck, @TrangThaiCheckIn, @TrangThaiCheckOut)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NgayCheck", dateTimeCheck.Value);
            command.Parameters.AddWithValue("@TrangThaiCheckIn", checkIN.Checked);
            command.Parameters.AddWithValue("@TrangThaiCheckOut", checkOUT.Checked);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Dữ liệu đã được cập nhật thành công!");
            }
        }

        private void FCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
  
        public void LoadCongViec()
        {
            string ID = "Content";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True");
            connection.Open();
            string query = "SELECT Job.Content FROM Job INNER JOIN Distribution ON Job.ID = Distribution.IDJob WHERE Distribution.IDStaff = 'EMP12345'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                cbDsCV.Items.Add(row[ID].ToString());
            }
        }
    }
}