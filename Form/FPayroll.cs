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
    public partial class FPayroll : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
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
            int bonus;
            int salary;
            Staff man = sta.Search(ID);
            conn.Open();
            string query = "SELECT CompleteJob.Bonus FROM Job INNER JOIN CompleteJob ON Job.ID = CompleteJob.IDJob";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bonus = (int)reader["Bonus"];
                        salary = man.BasicSalary + bonus;
                        textBonus.Text = bonus.ToString();
                        lbSalary.Text = salary.ToString();
                    }
                }
            }
        }
    }
}
