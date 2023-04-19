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
    public partial class FLetterMain : Form
    {
        string IDReceive;
        public FLetterMain(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(rbCreate.Checked == true )
            {
                FAbsenceLetter f = new FAbsenceLetter(IDReceive);
                f.ShowDialog();
            }
            else
            {
                FShowStaffLetter f = new FShowStaffLetter();
                f.ShowDialog();
            }
        }
    }
}
