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
            dataCVHT.DataSource = a.LoadList();
            LoadSalary();
        }

        void LoadSalary()
        {
            int bonus=0;
            int salary=0;
            Staff man = sta.Search(ID);
            conn.Open();
            string query = "SELECT CompleteJob.Bonus FROM Job INNER JOIN CompleteJob ON Job.ID = CompleteJob.IDJob";
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
