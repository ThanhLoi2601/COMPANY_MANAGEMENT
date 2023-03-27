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
    public partial class FProject : Form
    {
        ProjectDAO proDao = new ProjectDAO();
        public FProject()
        {
            InitializeComponent();
        }
        private void FProject_Load(object sender, EventArgs e)
        {
            gvProject.DataSource = proDao.LoadList();
        }
        private void btUpdateProject_Click(object sender, EventArgs e)
        {
            Project pro = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, txtStatus.Text);
            proDao.Update(pro);
            gvProject.DataSource = proDao.LoadList();
        }

        private void btInsertProject_Click(object sender, EventArgs e)
        {
            Project pro = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, txtStatus.Text);
            proDao.Insert(pro);
            gvProject.DataSource = proDao.LoadList();
        }

        private void btDeleteProject_Click(object sender, EventArgs e)
        {
            Project sta = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, txtStatus.Text);
            proDao.Delete(sta);
            gvProject.DataSource = proDao.LoadList();
        }
        private void gvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.gvProject.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = gvProject.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = gvProject.Rows[r].Cells[1].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = gvProject.Rows[r].Cells[2].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = gvProject.Rows[r].Cells[3].Value.ToString();
            rtxtContent.DataBindings.Clear();
            rtxtContent.Text = gvProject.Rows[r].Cells[4].Value.ToString();
            txtStatus.DataBindings.Clear();
            txtStatus.Text = gvProject.Rows[r].Cells[5].Value.ToString();
        }

        private void btTask_Click(object sender, EventArgs e)
        {
            FTask ftask = new FTask(txtID.Text);
            ftask.ShowDialog();
        }
    }
}
