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
        string ID;

        public FStaff(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btInform_Click(object sender, EventArgs e)
        {
            FInformation f = new FInformation(ID);
            f.ShowDialog();
        }

        private void btChangePass_Click(object sender, EventArgs e)
        {
            FChangePassWord f = new FChangePassWord(ID);
            f.ShowDialog();
        }

        private void btAssingedWork_Click(object sender, EventArgs e)
        {
            FAssignedWork f = new FAssignedWork();
            f.ShowDialog();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            FAbsenceLetter f = new FAbsenceLetter(ID);
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
