﻿using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class DistributionLD : Form
    {
        string proid = "";
        ProjectDAO proDAO = new ProjectDAO();
        TaskDAO tksDAO = new TaskDAO();
        ManagerDAO manDAO = new ManagerDAO();
        DistributionDAO disDAO = new DistributionDAO();
        ProcessJobDAO procDAO = new ProcessJobDAO();
        int count = 0, Overdue = 0, Warning = 0, NotStarted = 0, Inprocess = 0;

        public DistributionLD()
        {
            InitializeComponent();
        }

        private void DistributionLD_Load(object sender, EventArgs e)
        {
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            Load_All_DGV();
        }

        private void Load_All_DGV()
        {
            dgvProject.DataSource = proDAO.LoadList();
            dgvListManager.DataSource = manDAO.LoadList();
            dgvTask.DataSource = disDAO.LoadListTask(proid);
            dgvDistribution.DataSource = disDAO.LoadListDisTask("All");
        }

        private void dgvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvProject.CurrentCell.RowIndex;
            proid = dgvProject.Rows[r].Cells[0].Value.ToString();
            dgvTask.DataSource = disDAO.LoadListTask(proid);
            dgvDistribution.DataSource = disDAO.LoadListDisTask(proid);
            grBTasks.Text = "List Tasks of " + proid;
        }

        private void dgvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvTask.CurrentCell.RowIndex;
            txtIDTask.DataBindings.Clear();
            txtIDTask.Text = dgvTask.Rows[r].Cells[0].Value.ToString();
            txtTaskName.DataBindings.Clear();
            txtTaskName.Text = dgvTask.Rows[r].Cells[1].Value.ToString();
        }

        private void dgvListManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListManager.CurrentCell.RowIndex;
            txtIDManager.DataBindings.Clear();
            txtIDManager.Text = dgvListManager.Rows[r].Cells[0].Value.ToString();
            txtManagerName.DataBindings.Clear();
            txtManagerName.Text = dgvListManager.Rows[r].Cells[1].Value.ToString();
        }

        private void btInsertLd_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxEmpty())
            {
                MessageBox.Show("Please fill in the assignment information !!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(disDAO.CheckAssigned(txtIDTask.Text))
            {
                MessageBox.Show("Task has been assigned, please choose another task to assign !!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                disDAO.Insert(txtIDTask.Text, txtIDManager.Text);
                dgvTask.DataSource = disDAO.LoadListTask(proid);
                if (procDAO.Search(txtIDTask.Text) == null)
                {
                    Task t = tksDAO.SearchTask(txtIDTask.Text);
                    procDAO.Insert(t);
                }
                dgvDistribution.DataSource = disDAO.LoadListDisTask(proid);
                foreach (DataGridViewRow row in dgvDistribution.Rows)
                {
                    string rowId = Convert.ToString(row.Cells["IDJob"].Value);
                    if (rowId == txtIDTask.Text)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                        break;
                    }
                }
            }    
        }

        private void dgvDistribution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvDistribution.CurrentCell.RowIndex;
            Task t = tksDAO.SearchTask(dgvDistribution.Rows[r].Cells[0].Value.ToString());
            txtIDTask.Clear();
            txtIDTask.Text = t.Id;
            txtTaskName.Clear();
            txtTaskName.Text = t.Name;
            Manager man = manDAO.Search(dgvDistribution.Rows[r].Cells[1].Value.ToString());
            txtIDManager.Clear();
            txtIDManager.Text = man.ID;
            txtManagerName.Clear();
            txtManagerName.Text = man.Name;
        }

        private void btDeleteLd_Click(object sender, EventArgs e)
        {
            disDAO.Delete(txtIDTask.Text, txtIDManager.Text);
            Load_All_DGV();
        }
        
        private bool CheckTextBoxEmpty()
        {
            foreach (Control control in grbListDistribution.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    return true;
                } 
            }
            return false;
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            count = 0; Overdue = 0; Warning = 0; NotStarted = 0; Inprocess = 0;
            foreach (DataGridViewRow row in dgvDistribution.Rows)
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
            if (count == 0) count = 1;
            Dictionary<string, int> data = new Dictionary<string, int>();
            data.Add("Overdue", Overdue * 100 / count);
            data.Add("Warning", Warning * 100 / count);
            data.Add("NotStarted", NotStarted * 100 / count);
            data.Add("Inprocess", Inprocess * 100 / count);

            chDis.Series.Clear();
            chDis.Series.Add("Overdue");
            chDis.Series["Overdue"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var item in data)
            {
                if (item.Value == 0) continue;
                chDis.Series["Overdue"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}
