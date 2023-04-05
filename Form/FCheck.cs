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
        public FCheck()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void FCheck_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
            /*checkIN.Checked = Properties.Settings.Default.checkbox;
            checkOUT.Checked = Properties.Settings.Default.checkbox;
            textTienDo.Text = Properties.Settings.Default.textbox;*/
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
            if (checkIN.CheckState == CheckState.Checked && CanCheckIn() && checkOUT.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Check in thành công");
            }
            else if (checkIN.CheckState == CheckState.Checked && !CanCheckIn() && checkOUT.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Check in thành công, bạn tới muộn");
            }
            else if (checkIN.CheckState == CheckState.Unchecked && checkOUT.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Bạn chưa check in, vui lòng check in trước");
                checkOUT.CheckState = CheckState.Unchecked;
            }
            else if (checkIN.CheckState == CheckState.Checked && checkOUT.CheckState == CheckState.Checked && CanCheckOut())
            {
                MessageBox.Show("Check out thành công");
            }
            else if (checkIN.CheckState == CheckState.Checked && checkOUT.CheckState == CheckState.Checked && !CanCheckIn())
            {
                MessageBox.Show("Check out thất bại,chưa tới giờ check out");
                checkOUT.CheckState = CheckState.Unchecked;
            }
            else if (checkIN.CheckState == CheckState.Unchecked && checkOUT.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Vui lòng check");
            }
            else if(dateTimeCheck.Value != DateTime.Today)
            {
                MessageBox.Show("Không thể check khác ngày");
            }    
            else
            {
                MessageBox.Show("Check thành công");
            }
        }

        private void FCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Properties.Settings.Default.checkbox = checkIN.Checked;
            Properties.Settings.Default.checkbox = checkOUT.Checked;
            Properties.Settings.Default.textbox = textTienDo.Text;           
            Properties.Settings.Default.Save();*/
        }

        /*/private void checkIN_CheckedChanged(object sender, EventArgs e)
        {
            if(checkIN.Checked)
            {
                checkIN.CheckState = CheckState.Checked;
            }
            else
            {
                checkIN.CheckState = CheckState.Checked;
            }
        }

        //private void checkOUT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOUT.Checked)
            {
                checkOUT.CheckState = CheckState.Checked;
            }
            else
            {
                checkOUT.CheckState = CheckState.Checked;
            }
        }*/

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