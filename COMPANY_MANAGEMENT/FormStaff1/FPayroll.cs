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
    public partial class FPayroll : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conn);
        CompleteJobDAO a = new CompleteJobDAO();
        StaffDAO sta = new StaffDAO();
        string ID;
        public FPayroll(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void FPayroll_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //dataCVHT.DataSource = a.LoadList();
            Staff man = sta.Search(ID);
            lbKPI.Text = man.BasicSalary.ToString();
            string[] months = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", };

            foreach (string month in months)
            {
                cbMonth.Items.Add(month);
            }
        }

        void LoadSalary31(string month)
        {
             int bonus=0;
            int salary=0;
            Staff man = sta.Search(ID);
            conn.Open();
            string query =string.Format("SELECT CompleteJob.Bonus FROM Job INNER JOIN CompleteJob ON Job.ID = CompleteJob.IDJob WHERE CompleteJob.CompleDate >= '2023-{0}-01' AND CompleteJob.CompleDate < '2023-{0}-31'",month);
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bonus = bonus + (int)reader["Bonus"];
                        salary = man.BasicSalary + bonus;
                        textBonus.Text = bonus.ToString();
                        lbSalary.Text = salary.ToString();
                    }
                }
            }
            conn.Close();
        }

        void LoadSalary30(string month)
        {
            int bonus = 0;
            int salary = 0;
            Staff man = sta.Search(ID);
            conn.Open();
            string query = string.Format("SELECT CompleteJob.Bonus FROM Job INNER JOIN CompleteJob ON Job.ID = CompleteJob.IDJob WHERE CompleteJob.CompleDate >= '2023-{0}-01' AND CompleteJob.CompleDate < '2023-{0}-30'", month);
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bonus = bonus + (int)reader["Bonus"];
                        salary = man.BasicSalary + bonus;
                        textBonus.Text = bonus.ToString();
                        lbSalary.Text = salary.ToString();
                    }
                }
            }
            conn.Close();
        }

        void LoadSalary28(string month)
        {
            int bonus = 0;
            int salary = 0;
            Staff man = sta.Search(ID);
            conn.Open();
            string query = string.Format("SELECT CompleteJob.Bonus FROM Job INNER JOIN CompleteJob ON Job.ID = CompleteJob.IDJob WHERE CompleteJob.CompleDate >= '2023-{0}-01' AND CompleteJob.CompleDate < '2023-{0}-30'", month);
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bonus = bonus + (int)reader["Bonus"];
                        salary = man.BasicSalary + bonus;
                        textBonus.Text = bonus.ToString();
                        lbSalary.Text = salary.ToString();
                    }
                }
            }
            conn.Close();
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            textMonth.Text = cbMonth.SelectedItem.ToString();
            dataCVHT.DataSource = a.LoadList(cbMonth.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = cbMonth.SelectedItem.ToString();
            if (selected == "01" || selected == "03" || selected == "05" || selected == "07" || selected == "08"
            || selected == "10" || selected == "12")
            {
                LoadSalary31(selected);
            }
            else if (selected == "04" || selected == "06" || selected == "09" || selected == "11")
            {
                LoadSalary30(selected);
            }
            else
            {
                LoadSalary28(selected);
            }
        }
    }
}
