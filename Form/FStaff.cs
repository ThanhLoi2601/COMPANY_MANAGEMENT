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
        AssignedWorkDAO a = new AssignedWorkDAO();
        string ID;

        public FStaff(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void btCheckInOut_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FCheck f = new FCheck();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void FStaff_Load(object sender, EventArgs e)
        {
            dataStaff.DataSource = a.LoadList();
        }

        private void btLetter_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FAbsenceLetter f = new FAbsenceLetter(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btPayroll_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FPayroll f = new FPayroll();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btInform_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FInformation f = new FInformation(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btChangePass_Click_1(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            FChangePassWord f = new FChangePassWord(ID);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel5.Controls.Add(f);
            panel5.BringToFront();
            f.Show();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            //datastaff.datasource = a.loadlist();
            //panel5.controls.clear();
            //panel5.controls.add(datastaff);
            //controls.add(panel5);
            FStaff f = new FStaff(ID);
            f.ShowDialog();
            this.Close();
        }
    }
}
