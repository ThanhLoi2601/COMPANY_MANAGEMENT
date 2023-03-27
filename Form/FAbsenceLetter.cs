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
    public partial class FAbsenceLetter : Form
    {
        AbsenceLetterDAO ab = new AbsenceLetterDAO();
        StaffDAO s = new StaffDAO();
        string ID;
        int count = 0;
        int day = 0;
        public FAbsenceLetter(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";

            if (rbRea1.Checked)
            {
                reason = rbRea1.Text;
            }
            else if (rbRea2.Checked)
            {
                reason = rbRea2.Text;
            }
            else if (rbRea3.Checked)
            {
                reason = rbRea3.Text;
            }
            else
            {
                reason = textReason.Text;
            }

            AbsenceLetter lt = new AbsenceLetter(textName.Text, textID.Text, reason, dateStart.Value, dateEnd.Value);
            DateTime d1 = dateStart.Value;
            DateTime d2 = dateEnd.Value;
            int d = DateTime.Compare(dateStart.Value, dateEnd.Value);
            String t = (dateStart.Value - dateEnd.Value).TotalDays.ToString(); ;

            if (textID.Text != ID)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
            }
            else if (d<0)
            {
                MessageBox.Show("Ngày nhập không hợp lệ");
            }
            else if (int.Parse(t) > 3)
            {
                MessageBox.Show("Không được nghỉ phép quá 3 ngày");
            }
            else if (int.Parse(textNghi.Text) > 2)
            {
                MessageBox.Show("Bạn đã nghỉ quá số lần cho phép");
            }
            else
            {
                ab.UpdateAbsen(lt);
                //day += (int)(t.TotalDays);
                count++;
                MessageBox.Show("Gửi đơn xin nghỉ thành công");
                textNghi.Text = count.ToString();
                textNgayNghi.Text = day.ToString();
            }           
            count = int.Parse(textNghi.Text);
            day = int.Parse(textNgayNghi.Text);
        }

        private void rbRea4_CheckedChanged(object sender, EventArgs e)
        {
            textReason.Visible = rbRea4.Checked;
        }

        private void FAbsenceLetter_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            //textNghi.Text = Properties.Settings.Default.textbox2;
            //count = int.Parse(Properties.Settings.Default.textbox2);
        }

        private void FAbsenceLetter_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Properties.Settings.Default.textbox2 = textNghi.Text;
            //Properties.Settings.Default.Save();
        }
    }
}