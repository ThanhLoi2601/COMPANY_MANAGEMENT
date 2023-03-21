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
    public partial class FAssignedWork : Form
    {
        AssignedWorkDAO a = new AssignedWorkDAO();
        public FAssignedWork()
        {
            InitializeComponent();
        }

        private void FAssignedWork_Load(object sender, EventArgs e)
        {
            dataCVPC.DataSource = a.LoadList();
        }
    }
}
