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
        string IDReceive;
        StaffDAO staDAO = new StaffDAO();

        public FStaff(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }

        public FStaff()
        {
            InitializeComponent();
        }

        private void btInform_Click(object sender, EventArgs e)
        {
            FInformation f = new FInformation();
            f.ShowDialog();
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            FChangePassWord f = new FChangePassWord();
            f.ShowDialog();
        }

        private void btAssingedWork_Click(object sender, EventArgs e)
        {
            FAssignedWork f = new FAssignedWork();
            f.ShowDialog();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            FAbsenceLetter f = new FAbsenceLetter(IDReceive);
            f.ShowDialog();
        }

        private void btCheckInOut_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void btPayroll_Click(object sender, EventArgs e)
        {
            FPayroll f = new FPayroll();
            f.ShowDialog();
        }
    }
}
