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
            if (this.check_Empty() == false)
            {
                Job job = new Job(txtID.Text,txtName.Text,rTxtContent.Text,dtDateStart.Value,dtDateEnd.Value,int.Parse(txtBunus.Text));
                jobDAO.Update(job);
                dGVJobStaff.DataSource = jobDAO.LoadList();
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false)
            {
                Job job = new Job(txtID.Text, txtName.Text, rTxtContent.Text, dtDateStart.Value, dtDateEnd.Value, int.Parse(txtBunus.Text));
                jobDAO.Insert(job);
                dGVJobStaff.DataSource = jobDAO.LoadList();
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                Job job = new Job(txtID.Text, txtName.Text, rTxtContent.Text, dtDateStart.Value, dtDateEnd.Value, int.Parse(txtBunus.Text));
                jobDAO.Delete(job);
                dGVJobStaff.DataSource = jobDAO.LoadList();
            }else
            {
                MessageBox.Show("Please fill in ID !! ");
            }
        }

        private void FJob_Load(object sender, EventArgs e)
        {
            dGVJobStaff.DataSource = jobDAO.LoadList();
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

        private void dGVJobStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVJobStaff.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dGVJobStaff.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dGVJobStaff.Rows[r].Cells[1].Value.ToString();
            rTxtContent.DataBindings.Clear();
            rTxtContent.Text = dGVJobStaff.Rows[r].Cells[2].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = dGVJobStaff.Rows[r].Cells[3].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = dGVJobStaff.Rows[r].Cells[4].Value.ToString();
            txtBunus.DataBindings.Clear();
            txtBunus.Text = dGVJobStaff.Rows[r].Cells[5].Value.ToString();
        }
    }
}
