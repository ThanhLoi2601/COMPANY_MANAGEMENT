using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace COMPANY_MANAGEMENT
{
    public partial class FDistribution : Form
    {
        string IDReceive;
        JobDAO jobDAO = new JobDAO();
        StaffDAO staDAO = new StaffDAO();
        DistributionDAO disDAO = new DistributionDAO();
        ProcessJobDAO procDAO = new ProcessJobDAO();
        TaskDAO tksDAO = new TaskDAO();
        int count = 0, Overdue = 0, Warning = 0, NotStarted = 0, Inprocess = 0;

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
            this.FormBorderStyle = FormBorderStyle.None;
            Load_Dis_Job();
        }

        private void Load_Dis_Job()
        {
            dGVJob.DataSource = disDAO.LoadListJob(IDReceive);
            dGVDistribution.DataSource = disDAO.LoadListDis(IDReceive);
            LoadCbTask();
            count = 0; Overdue = 0; Warning = 0; NotStarted = 0; Inprocess = 0;
            foreach (DataGridViewRow row in dGVDistribution.Rows)
            {
                if (row.Cells["DateStart"].Value == null) break;
                DateTime rowDateStart = Convert.ToDateTime(row.Cells["DateStart"].Value).Date;
                DateTime rowDateEnd = Convert.ToDateTime(row.Cells["DateEnd"].Value).Date;
                DateTime dtNow = DateTime.Now.Date;
                if (dtNow > rowDateEnd)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    Overdue++;
                }
                else if ((rowDateEnd - dtNow).Days <= 2)
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    Warning++;
                }
                else if (dtNow < rowDateStart)
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                    NotStarted++;
                }
                else Inprocess++;
                row.DefaultCellStyle.ForeColor = Color.Black;
                count++;
            }
            LoadChart();
        }

        private void LoadChart()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("Overdue", Overdue * 100 / count);
            data.Add("Warning", Warning * 100 / count);
            data.Add("NotStarted", NotStarted * 100 / count);
            data.Add("Inprocess", Inprocess * 100 / count);

            chJob.Series.Clear();
            chJob.Series.Add("Overdue");
            chJob.Series["Overdue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in data)
            {
                if (item.Value == 0) continue;
                chJob.Series["Overdue"].Points.AddXY(item.Key, item.Value);
            }
        }

        private void LoadCbTask()
        {
            cbTaskJobList.Items.Clear();
            jobDAO.LoadCbTaskJob(cbTaskJobList, IDReceive);
            cbTaskJobList.Items.Add("All tasks");
            cbTaskDis.Items.Clear();
            jobDAO.LoadCbTaskDis(cbTaskDis, IDReceive);
            cbTaskDis.Items.Add("All tasks");
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
            dGVJob.DataSource = disDAO.LoadListJob(IDReceive);
            if (procDAO.Search(txtIDJob.Text) == null)
            {
                Job jb = jobDAO.Search(txtIDJob.Text);
                procDAO.Insert(jb);
            }
            dGVDistribution.DataSource = disDAO.LoadListDis(IDReceive);
            LoadCbTask();
            foreach (DataGridViewRow row in dGVDistribution.Rows)
            {
                string rowIdJob = Convert.ToString(row.Cells["IDJob"].Value);
                string rowIdStaff = Convert.ToString(row.Cells["IDStaff"].Value);
                if (rowIdJob == txtIDJob.Text && rowIdStaff == txtIDStaff.Text)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    break;
                }
            }
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
            lbProcess.Text = (double.Parse(dGVDistribution.Rows[r].Cells[4].Value.ToString())).ToString();
            prBProc.Value=int.Parse(lbProcess.Text);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                disDAO.Delete(lbIDJob.Text, lbIDStaff.Text);
                Load_Dis_Job();
                LoadCbTask();
                foreach (DataGridViewRow row in dGVJob.Rows)
                {
                    string rowIdJob = Convert.ToString(row.Cells["ID"].Value);
                    if (rowIdJob == lbIDJob.Text)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                    }
                }
            }
        }

        private void combTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameTaskJobList.Text = tksDAO.Search(cbTaskJobList.Text);
            dGVJob.DataSource = disDAO.LoadListJob(cbTaskJobList.Text,IDReceive);
        }

        private void cbTaskDis_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameTaskDis.Text = tksDAO.Search(cbTaskDis.Text);
            dGVDistribution.DataSource = disDAO.LoadListDisCB(cbTaskDis.Text, IDReceive);
        }
        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            Load_Dis_Job();
        }
    }
}
