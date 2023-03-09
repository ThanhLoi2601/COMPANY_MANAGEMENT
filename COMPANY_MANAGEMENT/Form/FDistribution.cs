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
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT
{
    public partial class FDistribution : Form
    {
        JobDAO jobDAO = new JobDAO();
        public FDistribution()
        {
            InitializeComponent();
        }

        private void FDistribution_Load(object sender, EventArgs e)
        {
            dGVJob.DataSource = jobDAO.LoadList();
        }

        private void dGVJob_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVJob.CurrentCell.RowIndex;
            txtIDJob.DataBindings.Clear();
            txtIDJob.Text = dGVJob.Rows[r].Cells[0].Value.ToString();
        }
    }
}
