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
using System.Threading;

namespace COMPANY_MANAGEMENT
{
    public partial class FManager : Form
    {
        string IDReceive;
        ManagerDAO manDAO =new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        Thread th;
        public FManager(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FManager()
        {
            InitializeComponent();
        }
 
        private void FManager_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.LoadMyInfo();
            dGVBasic.DataSource = staDAO.LoadList(IDReceive);   
        }

        private void LoadMyInfo()
        {
            Manager man = manDAO.Search(IDReceive);
            txtID.Text = man.ID;
            txtName.Text = man.Name;
            dtBirth.Value = man.Birth;
            txtIDCard.Text = man.IDCard;
            txtEmail.Text = man.Email;
            txtAddress.Text = man.Address;
            txtBasicSalary.Text = man.BasicSalary.ToString();
            txtPass.Text = man.Password;
        }

        private void ChangeInfo(Action<Staff> methodChange)
        {
            Staff sta = new Staff(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, IDReceive, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(sta);
            dGVBasic.DataSource = staDAO.LoadList(IDReceive);
        }

        private void ChangeInfo(Action<Manager> methodChange)
        {
            Manager man = new Manager(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtBasicSalary.Text), txtPass.Text);
            methodChange(man);
        }

        private void dGVBasic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dGVBasic.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dGVBasic.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = dGVBasic.Rows[r].Cells[1].Value.ToString();
            dtBirth.DataBindings.Clear();
            dtBirth.Text = dGVBasic.Rows[r].Cells[2].Value.ToString();
            txtIDCard.DataBindings.Clear();
            txtIDCard.Text = dGVBasic.Rows[r].Cells[3].Value.ToString();
            txtEmail.DataBindings.Clear();
            txtEmail.Text = dGVBasic.Rows[r].Cells[4].Value.ToString();
            txtAddress.DataBindings.Clear();
            txtAddress.Text = dGVBasic.Rows[r].Cells[5].Value.ToString();
            txtBasicSalary.DataBindings.Clear();
            txtBasicSalary.Text = dGVBasic.Rows[r].Cells[7].Value.ToString();
            txtPass.DataBindings.Clear();
            txtPass.Text = dGVBasic.Rows[r].Cells[8].Value.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                ChangeInfo(manDAO.Update);
            else
                ChangeInfo(staDAO.Update);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
                MessageBox.Show("You're not allowed to add management !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                ChangeInfo(staDAO.Insert);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    ChangeInfo(manDAO.Delete);
                    this.Close();
                }
                else
                    ChangeInfo(staDAO.Delete);
            }
        }

        private void btDistribution_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FDistribution f = new FDistribution(IDReceive);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FSalary f = new FSalary(IDReceive);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }

        private void btMyInfo_Click(object sender, EventArgs e)
        {
            this.LoadMyInfo();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FCheck f = new FCheck();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }

        private void btJob_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            FJob f = new FJob(IDReceive);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            Manager man = manDAO.Search(IDReceive);
            panel2.Controls.Clear();
            FLetterMain f = new FLetterMain(IDReceive,man.Name);
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }

        private void btContact_Click(object sender, EventArgs e)
        {
            Manager man = manDAO.Search(IDReceive);
            panel2.Controls.Clear();
            FContact f = new FContact(man.ID, man.Name);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel2.Controls.Add(f);
            panel2.BringToFront();
            f.Show();
        }


        private void OpenNewHome()
        {
            Application.Run(new FManager(IDReceive));
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
