﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using COMPANY_MANAGEMENT.OOP;

namespace COMPANY_MANAGEMENT
{
    public partial class FContact : Form
    {
        ContactDAO contDAO = new ContactDAO();
        string IDReceive;
        string NameReceive;
        public FContact()
        {
            InitializeComponent();
        }

        public FContact(string ID, string Name)
        {
            IDReceive = ID;
            NameReceive = Name;
            InitializeComponent();
        }

        private void FContact_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            txtIDSent.Text = IDReceive;
            txtNameSent.Text = NameReceive;
            LoadContact();
        }

        private void LoadContact()
        {
            dtGVSent.DataSource = contDAO.LoadListSent(IDReceive);
            HighLight(dtGVSent);
            dtGVReceive.DataSource = contDAO.LoadListReceive(IDReceive);
            HighLight(dtGVReceive);
        }

        private void HighLight(DataGridView dtGV)
        {
            DateTime currentDate = DateTime.Now.Date;

            foreach (DataGridViewRow row in dtGV.Rows)
            {
                if (row.Cells["InfoDate"].Value != null && Convert.ToDateTime(row.Cells["InfoDate"].Value).Date == currentDate)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void btSent_Click(object sender, EventArgs e)
        {
            if (cbBoxIDRe.Text == "" || IDReceive != txtIDSent.Text)
            {
                MessageBox.Show("Check back the information!!");
                return; 
            }
            Contact cont = new Contact(txtIDSent.Text, txtNameSent.Text, txtSub.Text,rTxtContent.Text,cbBoxIDRe.Text, DateTime.Now);
            contDAO.Insert(cont);
            LoadContact();
        }

        private void dtGVSent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(dtGVSent);
        }

        private void dtGVReceive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dGV_CellClick(dtGVReceive);
        }

        private void dGV_CellClick(DataGridView dGV)
        {
            int r = dGV.CurrentCell.RowIndex;
            txtIDSent.DataBindings.Clear();
            txtIDSent.Text = dGV.Rows[r].Cells[0].Value.ToString();
            txtNameSent.DataBindings.Clear();
            txtNameSent.Text = dGV.Rows[r].Cells[1].Value.ToString();
            txtSub.DataBindings.Clear();
            txtSub.Text = dGV.Rows[r].Cells[2].Value.ToString();
            rTxtContent.DataBindings.Clear();
            rTxtContent.Text = dGV.Rows[r].Cells[3].Value.ToString();
            cbBoxIDRe.DataBindings.Clear();
            cbBoxIDRe.Text = dGV.Rows[r].Cells[4].Value.ToString();
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            LoadContact();
        }
    }
}
