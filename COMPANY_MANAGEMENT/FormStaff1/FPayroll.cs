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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    public partial class FPayroll : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        CompleteJobDAO a = new CompleteJobDAO();
        StaffDAO sta = new StaffDAO();
        DBConn dB = new DBConn();
        string ID;
        public FPayroll(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void FPayroll_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Staff man = sta.Search(ID);
            lbKPI.Text = man.BasicSalary.ToString();
            string[] months = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "All month" };

            foreach (string month in months)
            {
                cbMonth.Items.Add(month);
            }
            cbMonth.Text = DateTime.Now.Month.ToString();
            dataCVHT.DataSource = a.LoadList(ID, "Now");
            LoadSalary();
            dtGVLate.DataSource = LoadLate("Now", ID);
        }

        void LoadSalary31(string month, string IDEmp)
        {
            string query;
            if (month == "All month")
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{0}' ", IDEmp);
            else
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-31'", month, IDEmp);
            Cal_Salary(query);
        }

        void LoadSalary30(string month, string IDEmp)
        {
            string query;
            if (month == "All month")
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{0}' ", IDEmp);
            else
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-30'", month,IDEmp);
            Cal_Salary(query);
        }

        void LoadSalary28(string month,string IDEmp)
        {
            string query;
            if (month == "All month")
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{0}' ", IDEmp);
            else
                query = string.Format("SELECT cj.Bonus FROM Job j, CompleteJob cj, Distribution d WHERE j.ID = cj.IDJob and j.ID = d.IDJob and d.IDStaff = '{1}' and cj.CompleDate >= '2023-{0}-01' AND cj.CompleDate <= '2023-{0}-28'", month,IDEmp);
            Cal_Salary(query);
        }

        private DataTable LoadLate(string month, string IDEmp)
        {
            string query;
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                query = string.Format("SELECT DateCheck,TimeCheckIn,TimeCheckOut FROM SQLCheck WHERE ID = '{0}' ", IDEmp);
            else
                query = string.Format("SELECT DateCheck,TimeCheckIn,TimeCheckOut FROM SQLCheck WHERE ID = '{0}' and MONTH(DateCheck) = {1}", IDEmp,month);
            return dB.LoadList(query);
        }

        private void Cal_Salary(string query)
        {
            try
            {
                int bonus = 0;
                int salary = 0;
                Staff man = sta.Search(ID);
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bonus = bonus + (int)reader["Bonus"];
                            salary = man.BasicSalary + bonus - int.Parse(txtFine.Text);
                            textBonus.Text = bonus.ToString();
                            lbSalary.Text = salary.ToString();
                        }
                    }
                }
                if (bonus == 0) textBonus.Text = bonus.ToString();
                if (salary == 0)
                {
                    salary = man.BasicSalary + bonus - int.Parse(txtFine.Text);
                    lbSalary.Text = salary.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void LoadLate(string month)
        {
            if (month == "All month") return;
            int fine = 0;
            int moneyfine = 0;
            Staff man = sta.Search(ID);
            conn.Open();
            string query = string.Format("SELECT SUM(TimesLate) as Fine from SQLCheck WHERE MONTH(DateCheck) = {0}", month);
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int bonusValue = reader.IsDBNull(reader.GetOrdinal("Fine")) ? 0 : Convert.ToInt32(reader["Fine"]);
                        fine = fine + bonusValue;
                        moneyfine = 500 * fine;
                        txtFine.Text = moneyfine.ToString();
                    }
                }
            }
            conn.Close();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSalary.Text = "0";
            textMonth.Text = cbMonth.SelectedItem.ToString();
            LoadSalary();
            dtGVLate.DataSource = LoadLate(cbMonth.SelectedItem.ToString(), ID);
            if (cbMonth.Text == "All month")
                lbSalary.Text = "";
        }

        private void LoadSalary()
        {
            dataCVHT.DataSource = a.LoadList(ID, cbMonth.Text);
            string selected = cbMonth.Text;
            LoadLate(selected);
            if (selected == "01" || selected == "03" || selected == "05" || selected == "07" || selected == "08"
            || selected == "10" || selected == "12")
            {
                LoadSalary31(selected, ID);
            }
            else if (selected == "04" || selected == "06" || selected == "09" || selected == "11")
            {
                LoadSalary30(selected, ID);
            }
            else
            {
                LoadSalary28(selected,ID);
            }
        }
    }
}
