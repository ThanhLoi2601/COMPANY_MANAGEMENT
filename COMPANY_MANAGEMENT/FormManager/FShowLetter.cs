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
    public partial class FShowLetter : Form
    {
        AbsenceLetterDAO absenDAO = new AbsenceLetterDAO();
        string IDReceive;

        public FShowLetter(string id)
        {
            InitializeComponent();
            IDReceive = id;
        }

        private void FShowLetter_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            if(IDReceive.Contains("MAN")) 
                dGVStaffLetter.DataSource = absenDAO.LoadAbsenStaff(IDReceive);
            else
                dGVStaffLetter.DataSource = absenDAO.LoadAbsenManager();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
