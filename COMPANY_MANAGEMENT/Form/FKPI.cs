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
    public partial class FKPI : Form
    {
        string IDReceive;
        CompleteWorkDAO cmpWDAO = new CompleteWorkDAO();
        KPI kpi = new KPI();
        public FKPI()
        {
            InitializeComponent();
        }

        public FKPI(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }

        private void FKPI_Load(object sender, EventArgs e)
        {
            dGVCompleteWork.DataSource = cmpWDAO.LoadList(IDReceive);
            lbNumJob.Text = cmpWDAO.CountWork(IDReceive).ToString();
            lbAvgKPI.Text = kpi.CalKPIAvg(IDReceive).ToString();
        }

        private void lbAvgKPI_TextChanged(object sender, EventArgs e)
        {
            if (double.Parse(lbAvgKPI.Text) <= 5000) lbKPIGrand.Text = "Unachieved";
            else if (double.Parse(lbAvgKPI.Text) < 10000) lbKPIGrand.Text = "Achieve";
            else lbKPIGrand.Text = "Excellence";
        }
    }
}
