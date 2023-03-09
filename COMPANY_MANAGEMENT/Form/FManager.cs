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
            FAbsenceLetter f = new FAbsenceLetter();
            f.ShowDialog();
        }

        private void btCheckIn_Out_Click(object sender, EventArgs e)
        {
            FCheck f = new FCheck();
            f.ShowDialog();
        }

        private void btLetter_Click(object sender, EventArgs e)
        {
            FLetterMain f = new FLetterMain();
            f.ShowDialog();
        }

        private void btJob_Click(object sender, EventArgs e)
        {
            FJob f = new FJob();
            f.ShowDialog();
        }
        private void FManager_Load(object sender, EventArgs e)
        {
            Manager man = manDAO.Search(txtID.Text);
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
            if (txtID.Text.Contains("MAN"))
            {
                Manager man = new Manager(txtID.Text,txtName.Text,dtBirth.Value,txtIDCard.Text,txtEmail.Text,txtAddress.Text,int.Parse(txtBasicSalary.Text),txtPass.Text);
                manDAO.Update(man);
            }
            else
            {
                //
            }
            
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
            {
                MessageBox.Show("You're not allowed to add management !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure to delete?", "REMIND",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    Manager man = new Manager(txtID.Text, txtName.Text, dtBirth.Value, txtIDCard.Text, txtEmail.Text, txtAddress.Text, int.Parse(txtBasicSalary.Text), txtPass.Text);
                    manDAO.Delete(man);
                    this.Close();
                }else
                {
                    //
                }
            }
        }
    }
}
