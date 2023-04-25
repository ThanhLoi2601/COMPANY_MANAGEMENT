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
using COMPANY_MANAGEMENT.OOP;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FCheck : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        string ID;
        CheckDAO c = new CheckDAO();
        StaffDAO s = new StaffDAO();
        ProcessJobDAO j = new ProcessJobDAO();
        CompleteJobDAO cj = new CompleteJobDAO();
        public int latetimes = 0;
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
            LoadCheckState();
        }

        private void FCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Staff man = s.Search(ID);
            if (checkIN.CheckState == CheckState.Checked)
            {
                if(CanCheckIn())
                {
                    Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, latetimes);
                    c.InsertCheck(a);
                }    
                else
                {
                    latetimes++;
                    Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, latetimes);
                    c.InsertCheck(a);
                    MessageBox.Show("Đã cập nhật bảng chấm công thành công");
                }    
            } 
            if(checkOUT.CheckState==CheckState.Checked && CanCheckOut())
            {
                Check a = new Check(man.ID, man.Name, dateTimeCheck.Value, checkIN.Checked, checkOUT.Checked, latetimes);
                c.Updatecheck(a);
                MessageBox.Show("Đã cập nhật bảng chấm công thành công");
            }
        }
  
        public void LoadCongViec()
        {
            Staff man = s.Search(ID);
            string name = "Content";
            conn.Open();
            string query = string.Format("SELECT Content FROM ProcessJob");
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                cbDsCV.Items.Add(row[name].ToString());
            }
            conn.Close();
        }

        void LoadCheckState()
        {
            Staff man = s.Search(ID);
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    
            SqlCommand command = new SqlCommand("SELECT CheckIn, CheckOut FROM SQLCheck WHERE ID = @id AND DateCheck = CONVERT(date, GETDATE())", conn);
            command.Parameters.AddWithValue("@id", man.ID);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                bool bitValue1 = reader.GetBoolean(0);
                bool bitValue2 = reader.GetBoolean(1);
                checkIN.Checked = bitValue1;
                checkOUT.Checked = bitValue2;
            }
            conn.Close();
        }

        private void cbDsCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT Process FROM ProcessJob where Content = '" + cbDsCV.Text + "'";
            SqlCommand objCommand = new SqlCommand(sqlQuery, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            objCommand.ExecuteNonQuery();
            SqlDataReader dr;
            dr = objCommand.ExecuteReader();
            while (dr.Read())
            {
                textTienDo.Text = (string)dr["Process"].ToString();
            }
            conn.Close();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            int Process = int.Parse(textTienDo.Text);
            if (Process < 0 || Process > 100)
            {
                MessageBox.Show("Lỗi cập nhật tiến độ!!");
            }
            else if(Process==100)
            {
                ProcessJob jb = new ProcessJob(cbDsCV.Text, int.Parse(textTienDo.Text));
                j.Detele(jb);
                CompleteJob cjb = new CompleteJob("JOB2346",cbDsCV.Text,DateTime.Today,500000);
                cj.Insert(cjb);
                MessageBox.Show("Đã cập nhật công việc hoàn thành");
            }    
            else
            {
                ProcessJob jb = new ProcessJob(cbDsCV.Text, int.Parse(textTienDo.Text));
                j.Update(jb);
                MessageBox.Show("Cập nhật tiến độ thành công");
            }
        }

        private void checkOUT_CheckedChanged(object sender, EventArgs e)
        {
            if(checkOUT.Checked && !CanCheckOut())
            {
                MessageBox.Show("Chưa tới giờ check out, vui lòng check đúng giờ");
                checkOUT.CheckState = CheckState.Unchecked;
            }    
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
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 19, 0, 0);
            if (currentTime < checkoutTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}