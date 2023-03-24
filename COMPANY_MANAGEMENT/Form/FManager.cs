﻿using COMPANY_MANAGEMENT.OOP;
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
    public partial class FManager : Form
    {
        string IDReceive;
        ManagerDAO manDAO =new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        KPI kpi = new KPI();
        public FManager(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FManager()
        {
            InitializeComponent();
        }
        private void btKPI_Click(object sender, EventArgs e)
        {
            FKPI f = new FKPI(txtID.Text);
            f.ShowDialog();
        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            FSalary f = new FSalary();
            f.ShowDialog();
        }

        private void btDistribution_Click(object sender, EventArgs e)
        {
            FDistribution f = new FDistribution(IDReceive);
            f.ShowDialog();
        }

        private void btAbsenceLetter_Click(object sender, EventArgs e)
        {
            FAbsenceLetter f = new FAbsenceLetter();
            f.ShowDialog();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            FLetterMain f = new FLetterMain();
            f.ShowDialog();
        }

        private void btJob_Click(object sender, EventArgs e)
        {
            FJob f = new FJob(IDReceive);
            f.ShowDialog();
        }
        private void FManager_Load(object sender, EventArgs e)
        {
            this.LoadMyInfo();
            dGVStaff.DataSource = staDAO.LoadList(IDReceive);   
        }

        private void btMyInfo_Click(object sender, EventArgs e)
        {
            this.LoadMyInfo();
        }

        private void LoadMyInfo()
        {
            Manager man = manDAO.Search(IDReceive);
            txtID.Text = man.ID;
            txtName.Text = man.Name;
            dtBirth.Value = man.Birth;
            txtIDCard.Text = man.IDCard;
            txtEmail.Text = man.Email;
            txtAddress.Text = man.Address;
            txtBasicSalary.Text = man.BasicSalary.ToString();
            txtPass.Text = man.Password;
        }

        private void ChangeInfo(Action<Staff> methodChange)
        {
            Staff sta = new Staff(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, IDReceive, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(sta);
            dGVStaff.DataSource = staDAO.LoadList(IDReceive);
        }

        private void ChangeInfo(Action<Manager> methodChange)
        {
            Manager man = new Manager(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(man);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                ChangeInfo(manDAO.Update);
            else
                ChangeInfo(staDAO.Update);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                MessageBox.Show("You're not allowed to add management !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ChangeInfo(staDAO.Insert);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure to delete?", "REMIND",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    ChangeInfo(manDAO.Delete);
                    this.Close();
                }else
                    ChangeInfo(staDAO.Delete);
            }
        }

        private void dGVStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVStaff.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dGVStaff.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dGVStaff.Rows[r].Cells[1].Value.ToString();
            dtBirth.DataBindings.Clear();
            dtBirth.Text = dGVStaff.Rows[r].Cells[2].Value.ToString();
            txtIDCard.DataBindings.Clear();
            txtIDCard.Text = dGVStaff.Rows[r].Cells[3].Value.ToString();
            txtEmail.DataBindings.Clear();
            txtEmail.Text = dGVStaff.Rows[r].Cells[4].Value.ToString();
            txtAddress.DataBindings.Clear();
            txtAddress.Text = dGVStaff.Rows[r].Cells[5].Value.ToString();
            txtBasicSalary.DataBindings.Clear();
            txtBasicSalary.Text = dGVStaff.Rows[r].Cells[7].Value.ToString();
            txtPass.DataBindings.Clear();
            txtPass.Text = dGVStaff.Rows[r].Cells[8].Value.ToString();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtKPI.DataBindings.Clear();
            txtKPI.Text = kpi.CalKPIAvg(txtID.Text).ToString();
        }
    }
}
