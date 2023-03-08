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
    public partial class FManager : Form
    {
        ManagerDAO manDAO =new ManagerDAO();
        Manager man = new Manager();
        public FManager(string ID)
        {
            InitializeComponent();
            txtID.Text = ID;
        }
        public FManager()
        {
            InitializeComponent();
        }
        private void btKPI_Click(object sender, EventArgs e)
        {
            FKPI f = new FKPI();
            f.ShowDialog();
        }

        private void btSalary_Click(object sender, EventArgs e)
        {
            FSalary f = new FSalary();
            f.ShowDialog();
        }

        private void btDistribution_Click(object sender, EventArgs e)
        {
            FDistribution f = new FDistribution();
            f.ShowDialog();
        }

        private void btAbsenceLetter_Click(object sender, EventArgs e)
        {
            FDonNghi f = new FDonNghi();
            f.ShowDialog();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void FManager_Load(object sender, EventArgs e)
        {
            man = manDAO.Search(txtID.Text);
            txtName.Text = man.Name;
            dtBirth.Value = man.Birth;
            txtIDCard.Text = man.IDCard;
            txtEmail.Text = man.Email;
            txtAddress.Text = man.Address;
            txtBasicSalary.Text = man.BasicSalary.ToString();
            txtPass.Text = man.Password;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            manDAO.Update(man);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            manDAO.Insert(man);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            manDAO.Delete(man);
            this.Close();
        }
    }
}
