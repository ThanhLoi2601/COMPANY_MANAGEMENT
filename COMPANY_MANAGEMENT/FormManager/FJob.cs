using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace COMPANY_MANAGEMENT
{
    public partial class FJob : Form
    {
        const string IDjbS = "JOB";
        JobDAO jobDAO =new JobDAO();
        TaskDAO taskDAO = new TaskDAO();
        ManagerDAO manDAO = new ManagerDAO();
        ProcessJobDAO pjDAO =new ProcessJobDAO();
        CompleteJobDAO cmpDAO = new CompleteJobDAO();
        Manager man;
        int count = 0, Overdue = 0, Warning = 0, NotStarted = 0, Inprocess = 0;

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
            dGVJobStaff.DataSource = jobDAO.LoadList(man.ID);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains(IDjbS) == true)
            {
                ChangeInfo(jobDAO.Update);
                foreach (DataGridViewRow row in dGVJobStaff.Rows)
                {
                    string rowId = Convert.ToString(row.Cells["ID"].Value);
                    if (rowId == txtID.Text)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Please fill in information !! ");
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (this.check_Empty() == false && txtID.Text.Contains(IDjbS) == true)
            {
                ChangeInfo(jobDAO.Insert);
                foreach (DataGridViewRow row in dGVJobStaff.Rows)
                {
                    string rowId = Convert.ToString(row.Cells["ID"].Value);
                    if (rowId == txtID.Text)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Please fill in information !! ");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains(IDjbS) == true)
                    ChangeInfo(jobDAO.Delete);
                else
                    MessageBox.Show("Please fill in ID !! ");
            }
        }

        private void FJob_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dGVJobStaff.DataSource = jobDAO.LoadList(man.ID);
            dGVMyProject.DataSource = taskDAO.LoadListTaskMan(man.ID);
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
            txtBonus.Clear();
            if (tabJobStaff.SelectedIndex == 0)
            {
                grInfo.Enabled = true;
                labBonus.Text = "Bonus";
            }
            else
            {
                grInfo.Enabled = false;
                labBonus.Text = "Task_status";
                LoadCBStatus();
            }
        }

        private void LoadCBStatus()
        {
            List<Task.TaskStatus> enum_TaskStatus = new List<Task.TaskStatus>();
            enum_TaskStatus.Add(Task.TaskStatus.Completed);
            enum_TaskStatus.Add(Task.TaskStatus.Cancelled);
            enum_TaskStatus.Add(Task.TaskStatus.NotStarted);
            enum_TaskStatus.Add(Task.TaskStatus.OnHold);
            enum_TaskStatus.Add(Task.TaskStatus.BehindSchedule);
            enum_TaskStatus.Add(Task.TaskStatus.InProgress);
            cbStatus.DataSource = enum_TaskStatus;
        }

        private void UpdateStatus(Task tsk)
        {
            tsk.UpdateStatus((Task.TaskStatus)cbStatus.SelectedItem);
            taskDAO.Update(tsk);
            if ((Task.TaskStatus)cbStatus.SelectedItem == Task.TaskStatus.Completed)
            {
                ProcessJob pj = pjDAO.Search(tsk.Id);
                pjDAO.Detele(pj);
                CompleteJob cmpJob = new CompleteJob(tsk.Id, tsk.Name, DateTime.Now, 0);
                cmpDAO.Insert(cmpJob);
            }
            MessageBox.Show("Đã cập nhật trạng thái công việc thành công");
        }

        private void txtBonus_TextChanged(object sender, EventArgs e)
        {
            if(labBonus.Text == "Task_status")
                cbStatus.Text = txtBonus.Text;
        }

        private void btConf_Click(object sender, EventArgs e)
        {
            Task tsk = taskDAO.SearchTask(txtID.Text);
            UpdateStatus(tsk);
            dGVMyProject.DataSource = taskDAO.LoadListTaskMan(man.ID);
            foreach (DataGridViewRow row in dGVMyProject.Rows)
            {
                if (Convert.ToString(row.Cells["ID"].Value) == txtID.Text)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == dGVMyProject.Columns["Task_status"].Index)
                        {
                            string cellStatus = Convert.ToString(cell.Value);
                            if (cellStatus == cbStatus.Text)
                            {
                                cell.Style.BackColor = Color.Yellow;
                                cell.Style.ForeColor = Color.Black;
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            count = 0; Overdue = 0; Warning = 0; NotStarted = 0; Inprocess = 0;
            foreach (DataGridViewRow row in dGVMyProject.Rows)
            {
                if (row.Cells["StartDate"].Value == null) break;
                DateTime rowDateStart = Convert.ToDateTime(row.Cells["StartDate"].Value).Date;
                DateTime rowDateEnd = Convert.ToDateTime(row.Cells["EndDate"].Value).Date;
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

            chTaskProcess.Series.Clear();
            chTaskProcess.Series.Add("Overdue");
            chTaskProcess.Series["Overdue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in data)
            {
                if (item.Value == 0) continue;
                chTaskProcess.Series["Overdue"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}
