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
            if(rbStaff.Checked==true)
            {
                Staff Sta = new Staff(txtMaDN.Text, txtMK.Text);
                if(StaDAO.Login(Sta)==true)
                {
                    //FStaff f = new FStaff(txtMaDN.Text);
                    //f.ShowDialog();
                }
            }else if(rbManager.Checked==true)
            {
                Manager Man = new Manager(txtMaDN.Text,txtMK.Text);
                if(ManDao.Login(Man)==true)
                {
                    FManager f = new FManager(txtMaDN.Text);
                    f.ShowDialog();
                }
            }else
            {
                Leader Lea = new Leader(txtMaDN.Text, txtMK.Text);
                if (LeaDAO.Login(Lea) == true)
                {
                    //FLeader f = new FLeader(txtMaDN.Text);
                    //f.ShowDialog();
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
    }
}
