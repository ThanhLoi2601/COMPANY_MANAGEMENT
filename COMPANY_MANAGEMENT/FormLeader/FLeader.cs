using COMPANY_MANAGEMENT.OOP;
using System;
using System.Drawing;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class FLeader : Form
    {
        string IDReceive;
        string NameReceive;
        ManagerDAO manDAO = new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        LeaderDAO ledDAO = new LeaderDAO();
        Thread th;
        public FLeader(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FLeader()
        {
            InitializeComponent();
        }

        private void btUpdateLd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
            {
                Manager man = new Manager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                manDAO.Update(man);
            }
            else
            {
                Staff sta = new Staff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                staDAO.Update(sta);
            }
            dgvLoad();
        }

        private void btInsertLd_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Contains("MAN"))
            {
                if (txtIDManager.Text != "")
                {
                    MessageBox.Show("If you add a manager, please do not fill in the text ID  !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Manager man = new Manager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Insert(man);
                }
            }
            else if(txtID.Text.Contains("EMP"))
            {
                Staff sta = new Staff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                staDAO.Insert(sta);
            }
            else
            {
                foreach (Control ctrl in grbInformationLd.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox txtBox = (TextBox)ctrl;
                        if (string.IsNullOrEmpty(txtBox.Text))
                        {
                            MessageBox.Show("Please enter full information !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (!txtID.Text.Contains("MAN") || !txtID.Text.Contains("EMP"))
                {
                    MessageBox.Show("You must enter the correct employee ID !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvLoad();
        }

        private void btDeleteLd_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txtID.Text.Contains("MAN"))
                {
                    Manager man = new Manager(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Delete(man);
                }
                else
                {
                    Staff sta = new Staff(txtID.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    staDAO.Delete(sta);
                }
                dgvLoad();
            }
        }

        private void dgvListManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListManager.CurrentCell.RowIndex;
            txtIDManager.Clear();
            txtID.DataBindings.Clear();
            txtID.Text = dgvListManager.Rows[r].Cells[0].Value.ToString();
            txtNameLd.DataBindings.Clear();
            txtNameLd.Text = dgvListManager.Rows[r].Cells[1].Value.ToString();
            dtpkDateOfBirthLd.DataBindings.Clear();
            dtpkDateOfBirthLd.Text = dgvListManager.Rows[r].Cells[2].Value.ToString();
            txtIDCardLd.DataBindings.Clear();
            txtIDCardLd.Text = dgvListManager.Rows[r].Cells[3].Value.ToString();
            txtEmailLd.DataBindings.Clear();
            txtEmailLd.Text = dgvListManager.Rows[r].Cells[4].Value.ToString();
            txtAddressLd.DataBindings.Clear();
            txtAddressLd.Text = dgvListManager.Rows[r].Cells[5].Value.ToString();
            txtBasicSalaryLd.DataBindings.Clear();
            txtBasicSalaryLd.Text = dgvListManager.Rows[r].Cells[6].Value.ToString();
            txtPasswordLd.DataBindings.Clear();
            txtPasswordLd.Text = dgvListManager.Rows[r].Cells[7].Value.ToString();
            dgvListStaff.DataSource = staDAO.LoadList(txtID.Text);
            grBStaff.Text = "List Staff managed by " + txtID.Text;
        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListStaff.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = dgvListStaff.Rows[r].Cells[0].Value.ToString();
            txtNameLd.DataBindings.Clear();
            txtNameLd.Text = dgvListStaff.Rows[r].Cells[1].Value.ToString();
            dtpkDateOfBirthLd.DataBindings.Clear();
            dtpkDateOfBirthLd.Text = dgvListStaff.Rows[r].Cells[2].Value.ToString();
            txtIDCardLd.DataBindings.Clear();
            txtIDCardLd.Text = dgvListStaff.Rows[r].Cells[3].Value.ToString();
            txtEmailLd.DataBindings.Clear();
            txtEmailLd.Text = dgvListStaff.Rows[r].Cells[4].Value.ToString();
            txtAddressLd.DataBindings.Clear();
            txtAddressLd.Text = dgvListStaff.Rows[r].Cells[5].Value.ToString();
            txtIDManager.DataBindings.Clear();
            txtIDManager.Text = dgvListStaff.Rows[r].Cells[6].Value.ToString();
            txtBasicSalaryLd.DataBindings.Clear();
            txtBasicSalaryLd.Text = dgvListStaff.Rows[r].Cells[7].Value.ToString();
            txtPasswordLd.DataBindings.Clear();
            txtPasswordLd.Text = dgvListStaff.Rows[r].Cells[8].Value.ToString();
        }

        private void FLeader_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            dgvLoad();
            NameReceive = txtNameLd.Text;
        }
        private void dgvLoad()
        { 
            dgvListManager.DataSource = manDAO.LoadList();
            dgvListStaff.DataSource = staDAO.LoadList();
            LoadMyInfo();
        }
        private void LoadMyInfo()
        {
            Leader led = ledDAO.Search(IDReceive);
            txtID.Text = led.ID;
            txtNameLd.Text = led.Name;
            dtpkDateOfBirthLd.Value = led.DateOfBirth;
            txtIDCardLd.Text = led.IDCard;
            txtEmailLd.Text = led.Email;
            txtAddressLd.Text = led.Address;    
            txtBasicSalaryLd.Text = led.BasicSalary.ToString();
            txtPasswordLd.Text = led.Password;
        }

        private void btMyInfor_Click(object sender, EventArgs e)
        {
            LoadMyInfo();
        }

        private void btProject_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FProject f = new FProject();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
            panel3.BringToFront();
            f.Show();
        }

        private void btContact_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FContact f = new FContact(IDReceive,Name);
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
            panel3.BringToFront();
            f.Show();
        }

        private void OpenNewHome()
        {
            Application.Run(new FLeader(IDReceive));
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenNewHome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btDistributionLd_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            DistributionLD f = new DistributionLD();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel3.Controls.Add(f);
            panel3.BringToFront();
            f.Show();
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