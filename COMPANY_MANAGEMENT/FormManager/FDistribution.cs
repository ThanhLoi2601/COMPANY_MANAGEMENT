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
        ProcessJobDAO procDAO = new ProcessJobDAO();

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
            Load_Dis_Job();
        }

        private void Load_Dis_Job()
        {
            dGVJob.DataSource = disDAO.LoadListJob();
            dGVDistribution.DataSource = disDAO.LoadListDis();
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
            if (procDAO.Search(txtIDJob.Text) == null)
            {
                Job jb = jobDAO.Search(txtIDJob.Text);
                procDAO.Insert(jb);
            }
            dGVDistribution.DataSource = disDAO.LoadListDis();
        }

        private void txtIDJob_TextChanged(object sender, EventArgs e)
        {
            LoadTableStaff();
        }

        private void LoadTableStaff()
        {
            Job jb = jobDAO.Search(txtIDJob.Text);
            dGVStaff.DataSource = disDAO.LoadListStaff(jb, IDReceive);
        }

        private void dGVDistribution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVDistribution.CurrentCell.RowIndex;
            lbIDJob.DataBindings.Clear();
            lbIDJob.Text = dGVDistribution.Rows[r].Cells[0].Value.ToString();
            lbIDStaff.DataBindings.Clear();
            lbIDStaff.Text = dGVDistribution.Rows[r].Cells[1].Value.ToString();
            Job jb = jobDAO.Search(lbIDJob.Text);
            Staff sta = staDAO.Search(lbIDStaff.Text);
            lbNameJob.Text = jb.Name;
            lbNameStaff.Text = sta.Name;
            lbProcess.DataBindings.Clear();
            lbProcess.Text = (double.Parse(dGVDistribution.Rows[r].Cells[4].Value.ToString())*100).ToString();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            disDAO.Delete(lbIDJob.Text,lbIDStaff.Text);
            Load_Dis_Job();
        }
    }
}
