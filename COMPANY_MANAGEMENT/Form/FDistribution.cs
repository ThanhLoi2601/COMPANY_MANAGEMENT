using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT
{
    public partial class FDistribution : Form
    {
        string IDReceive;
        JobDAO jobDAO = new JobDAO();
        StaffDAO staDAO = new StaffDAO();
        DistributionDAO disDAO = new DistributionDAO();

        public FDistribution(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FDistribution()
        {
            InitializeComponent();
        }

        private void FDistribution_Load(object sender, EventArgs e)
        {
            dGVJob.DataSource = disDAO.LoadListJob();
            dGVStaff.DataSource = staDAO.LoadList(IDReceive);
        }

        private void dGVJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVJob.CurrentCell.RowIndex;
            txtIDJob.DataBindings.Clear();
            txtIDJob.Text = dGVJob.Rows[r].Cells[0].Value.ToString();
        }

        private void dGVStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVStaff.CurrentCell.RowIndex;
            txtIDStaff.DataBindings.Clear();
            txtIDStaff.Text = dGVStaff.Rows[r].Cells[0].Value.ToString();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            disDAO.Insert(txtIDJob.Text, txtIDStaff.Text);
            dGVJob.DataSource = disDAO.LoadListJob();
        }
    }
}
