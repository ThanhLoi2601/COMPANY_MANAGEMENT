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
        JobDAO jobDAO =new JobDAO();
        public FJob()
        {
            InitializeComponent();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains("JOB")== true)
            {
                Job job = new Job(txtID.Text,txtName.Text,rTxtContent.Text,dtDateStart.Value,dtDateEnd.Value,int.Parse(txtBunus.Text));
                jobDAO.Update(job);
                dGVJobStaff.DataSource = jobDAO.LoadList("JOB");
            }
            else
            {
                MessageBox.Show("Please fill in information !! ");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains("JOB") == true)
            {
                Job job = new Job(txtID.Text, txtName.Text, rTxtContent.Text, dtDateStart.Value, dtDateEnd.Value, int.Parse(txtBunus.Text));
                jobDAO.Insert(job);
                dGVJobStaff.DataSource = jobDAO.LoadList("JOB");
            }
            else
            {
                MessageBox.Show("Please fill in information !! ");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("JOB") == true)
            {
                Job job = new Job(txtID.Text, txtName.Text, rTxtContent.Text, dtDateStart.Value, dtDateEnd.Value, int.Parse(txtBunus.Text));
                jobDAO.Delete(job);
                dGVJobStaff.DataSource = jobDAO.LoadList("JOB");
            }else
            {
                MessageBox.Show("Please fill in ID !! ");
            }
        }

        private void FJob_Load(object sender, EventArgs e)
        {
            dGVJobStaff.DataSource = jobDAO.LoadList("JOB");
            dGVMyJob.DataSource = jobDAO.LoadList("JOM");
        }

        private bool check_Empty()
        {
            if (txtName.Text == "" || rTxtContent.Text == "" || txtID.Text == ""
                || txtBunus.Text == "" )
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
            txtBunus.DataBindings.Clear();
            txtBunus.Text = dGV.Rows[r].Cells[5].Value.ToString();
        }

        private void dGVJobStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(this.dGVJobStaff);
        }

        private void dGVMyJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(this.dGVMyJob);
        }

        private void tabJobStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabJobStaff.SelectedIndex == 0)
                grInfo.Enabled = true;
            else
                grInfo.Enabled = false;
        }
    }
}
