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

namespace COMPANY_MANAGEMENT
{
    public partial class FJob : Form
    {
        const string IDjbS = "JOB";
        const string IDjbM = "JOM";
        JobDAO jobDAO =new JobDAO();
        ManagerDAO manDAO = new ManagerDAO();
        Manager man;

        public FJob()
        {
            InitializeComponent();
        }

        public FJob(string ID)
        {
            InitializeComponent();
            man = manDAO.Search(ID);
        }

        private void ChangeInfo(Action<Job> methodChange)
        {
            Job job = new Job(txtID.Text, txtName.Text, rTxtContent.Text, dtDateStart.Value, dtDateEnd.Value, int.Parse(txtBonus.Text),txtIDWork.Text);
            methodChange(job);
            dGVJobStaff.DataSource = jobDAO.LoadList(IDjbS);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains(IDjbS)== true)
                ChangeInfo(jobDAO.Update);
            else
                MessageBox.Show("Please fill in information !! ");
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains(IDjbS) == true)
                ChangeInfo(jobDAO.Insert);
            else
                MessageBox.Show("Please fill in information !! ");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains(IDjbS) == true)
                ChangeInfo(jobDAO.Delete);
            else
                MessageBox.Show("Please fill in ID !! ");
        }

        private void FJob_Load(object sender, EventArgs e)
        {
            dGVJobStaff.DataSource = jobDAO.LoadList(IDjbS);
            //dGVMyProject.DataSource = jobDAO.LoadList(IDjbM);
        }

        private bool check_Empty()
        {
            if (txtName.Text == "" || rTxtContent.Text == "" || txtID.Text == ""
                || txtBonus.Text == "" )
            {
                MessageBox.Show("Please fill in all the information !! ");
                return true;
            }
            return false;
        }

        private void dGV_CellClick(DataGridView dGV)
        {
            int r = dGV.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dGV.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dGV.Rows[r].Cells[1].Value.ToString();
            rTxtContent.DataBindings.Clear();
            rTxtContent.Text = dGV.Rows[r].Cells[2].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = dGV.Rows[r].Cells[3].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = dGV.Rows[r].Cells[4].Value.ToString();
            txtBonus.DataBindings.Clear();
            txtBonus.Text = dGV.Rows[r].Cells[5].Value.ToString();
            txtIDWork.DataBindings.Clear();
            txtIDWork.Text = dGV.Rows[r].Cells[6].Value.ToString();
        }

        private void dGVJobStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(this.dGVJobStaff);
        }

        private void dGVMyProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(this.dGVMyProject);
        }

        private void tabJobStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabJobStaff.SelectedIndex == 0)
                grInfo.Enabled = true;
            else
                grInfo.Enabled = false;
        }

        private void btComp_Click(object sender, EventArgs e)
        {
            //Job jb = jobDAO.Search(txtID.Text);
            //jobDAO.Delete(jb);
            //dGVMyProject.DataSource = jobDAO.LoadList(IDjbM);
        }
    }
}
