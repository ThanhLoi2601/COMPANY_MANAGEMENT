using COMPANY_MANAGEMENT.OOP;
using COMPANY_MANAGEMENT.FormStaff1;
using COMPANY_MANAGEMENT.FormLeader;
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
    public partial class FLogin : Form
    {
        ManagerDAO ManDao = new ManagerDAO();
        StaffDAO StaDAO = new StaffDAO();
        LeaderDAO LeaDAO = new LeaderDAO();

        public FLogin()
        {
            InitializeComponent();
        }

        private void btDNhap_Click(object sender, EventArgs e)
        {
            if (rbStaff.Checked == true)
            {
                Staff Sta = new Staff(txtMaDN.Text, txtMK.Text);
                if (StaDAO.Login(Sta) == true)
                {
                    FStaff f = new FStaff(txtMaDN.Text);
                    f.ShowDialog();
                }
            }
            else if (rbManager.Checked == true)
            {
                Manager Man = new Manager(txtMaDN.Text, txtMK.Text);
                if (ManDao.Login(Man) == true)
                {
                    FManager f = new FManager(txtMaDN.Text);
                    f.ShowDialog();
                }
            }
            else
            {
                Leader Lea = new Leader(txtMaDN.Text, txtMK.Text);
                if (LeaDAO.Login(Lea) == true)
                {
                    FLeader f = new FLeader(txtMaDN.Text);
                    f.ShowDialog();
                }
            }
        }

        private void cbHienMK_TextChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
                txtMK.UseSystemPasswordChar = false;
            else
                txtMK.UseSystemPasswordChar = true;
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
                txtMK.UseSystemPasswordChar = false;
            else
                txtMK.UseSystemPasswordChar = true;
        }

        private void txtMaDN_Click(object sender, EventArgs e)
        {
            txtMaDN.SelectAll();
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            txtMK.SelectAll();
        }

        private void txtMaDN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaDN.ForeColor = Color.Black;
            }
            catch { }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtMK.ForeColor = Color.Black;
            }
            catch { }
        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtMaDN_Enter(object sender, EventArgs e)
        {
            if (txtMaDN.Text == "")
            {
                txtMaDN.Text = "Enter username";
                txtMaDN.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtMaDN_Leave(object sender, EventArgs e)
        {
            if (txtMaDN.Text == "")
            {
                txtMaDN.Text = "Enter username";
                txtMaDN.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Enter password";
                txtMK.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Enter password";
                txtMaDN.ForeColor = SystemColors.GrayText;
            }
        }
    }
}