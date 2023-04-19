using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPANY_MANAGEMENT.OOP;


namespace COMPANY_MANAGEMENT
{
    public partial class FShowStaffLetter : Form
    {
        AbsenceLetterDAO absenDAO = new AbsenceLetterDAO();

        public FShowStaffLetter()
        {
            InitializeComponent();
        }

        private void FShowStaffLetter_Load(object sender, EventArgs e)
        {
            dGVStaffLetter.DataSource = absenDAO.LoadAbsenStaff();
        }
    }
}
