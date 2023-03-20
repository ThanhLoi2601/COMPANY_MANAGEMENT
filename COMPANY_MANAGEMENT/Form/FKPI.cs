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
            double count = cmpWDAO.CountWork(IDReceive);
            lbNumJob.Text = count.ToString();
            double avg = 0;
            if (count !=0)
                avg = (double)cmpWDAO.SumKPI(IDReceive) / count;
            lbAvgKPI.Text = avg.ToString();
        }

        private void lbAvgKPI_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(lbAvgKPI.Text) <= 5000) lbKPIGrand.Text = "Unachieved";
            else if (int.Parse(lbAvgKPI.Text) < 10000) lbKPIGrand.Text = "Achieve";
            else lbKPIGrand.Text = "Excellence";
        }
    }
}
