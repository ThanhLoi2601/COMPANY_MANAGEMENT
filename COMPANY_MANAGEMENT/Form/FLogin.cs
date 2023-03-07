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
        public FLogin()
        {
            InitializeComponent();
        }

        private void btDNhap_Click(object sender, EventArgs e)
        {
            if(rbStaff.Checked==true)
            {
                //
            }else if(rbManager.Checked==true)
            {
                Manager Man = new Manager(txtMaDN.Text,txtMK.Text);
                if(ManDao.Login(Man)==true)
                {
                    FManager f = new FManager();
                    f.IDMan_receive = txtMaDN.Text;
                    f.ShowDialog();
                }
            }else
            {
                //
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
