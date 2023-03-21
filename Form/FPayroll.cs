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
    public partial class FPayroll : Form
    {
        CompleteJobDAO a = new CompleteJobDAO();
        public FPayroll()
        {
            InitializeComponent();
        }

        private void FPayroll_Load(object sender, EventArgs e)
        {
            dataCVHT.DataSource = a.LoadList();
        }
    }
}
