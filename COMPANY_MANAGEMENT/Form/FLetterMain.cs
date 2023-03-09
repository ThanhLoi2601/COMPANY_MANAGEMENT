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
        public FLetterMain()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(rbCreate.Checked == true )
            {
                FAbsenceLetter f = new FAbsenceLetter();
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
