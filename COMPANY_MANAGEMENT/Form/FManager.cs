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
        public string IDMan_receive { get { return txtID.Text; } set { txtID.Text = value; } }
        public FManager()
        {
            InitializeComponent();
        }
        private void btKPI_Click(object sender, EventArgs e)
        {
            FKPI f = new FKPI();
            f.ShowDialog();
        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            FSalary f = new FSalary();
            f.ShowDialog();
        }

        private void btDistribution_Click(object sender, EventArgs e)
        {
            FDistribution f = new FDistribution();
            f.ShowDialog();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void btDonNghi_Click(object sender, EventArgs e)
        {
            FDonNghi f = new FDonNghi();
            f.ShowDialog();
        }

        private void FManager_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
