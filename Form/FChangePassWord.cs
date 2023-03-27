﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace COMPANY_MANAGEMENT
{
    public partial class FChangePassWord : Form
    {
        StaffDAO s = new StaffDAO();
        string ID;
        public FChangePassWord(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void ChangePass()
        {
            Staff man = s.Search(ID);
            Staff a = new Staff(textMaDN.Text, textNewPass.Text);
            string currentPass = textOldPass.Text;
            string newPass = textNewPass.Text;
            string newPassConfirm = textNewPassConfirm.Text;
            string ID_DN = textMaDN.Text;

            if(textMaDN.Text != man.ID)
            {
                MessageBox.Show("Mã đăng nhập không chính xác");
            }    
            else if(textOldPass.Text != man.Password )
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng?");
            }
            else if (newPass != newPassConfirm)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu confirm không chính xác");
                return;
            }
            else
            {
                s.UpdatePass(a);
                MessageBox.Show("Đối mật khẩu thành công");
                this.Close();
            }
            //s.UpdatePass(man);*/
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            this.ChangePass();
        }

        private void FChangePassWord_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
    }
}