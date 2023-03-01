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
    public partial class FStaff : Form
    {

        public FStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAbsenceLetter f = new FAbsenceLetter();
            f.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FAssignedWork f = new FAssignedWork();  
            f.ShowDialog();
        }
    }
}
