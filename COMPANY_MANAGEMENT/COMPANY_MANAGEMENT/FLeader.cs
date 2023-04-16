using COMPANY_MANAGEMENT.OOP;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT
{
    public partial class FLeader : Form
    {
        string IDReceive;
        ManagerDAO manDAO = new ManagerDAO();
        StaffDAO staDAO = new StaffDAO();
        public FLeader(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
        public FLeader()
        {
            InitializeComponent();
        }

        private void btContract_Click(object sender, EventArgs e)
        {
            FContact cont = new FContact();
            cont.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProject project = new FProject();
            project.ShowDialog();
        }

        private void btUpdateLd_Click(object sender, EventArgs e)
        {
            if (txtIDLd.Text.Contains("MAN"))
            {
                Manager man = new Manager(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                manDAO.Update(man);
            }
            else
            {
                Staff sta = new Staff(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                staDAO.Update(sta);
            }
            dgvLoad();
        }

        private void btInsertLd_Click(object sender, EventArgs e)
        {
            if (txtIDLd.Text.Contains("MAN"))
            {
                if (txtIDManager.Text != "")
                {
                    MessageBox.Show("If you add a manager, please do not fill in the text ID  !!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Manager man = new Manager(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Insert(man);
                }
            }
            else if(txtIDLd.Text.Contains("EMP"))
            {
                Staff sta = new Staff(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
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
                if (!txtIDLd.Text.Contains("MAN") || !txtIDLd.Text.Contains("EMP"))
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
                if (txtIDLd.Text.Contains("MAN"))
                {
                    Manager man = new Manager(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    manDAO.Delete(man);
                }
                else
                {
                    Staff sta = new Staff(txtIDLd.Text, txtNameLd.Text, dtpkDateOfBirthLd.Value, txtIDCardLd.Text, txtEmailLd.Text, txtAddressLd.Text, IDReceive, int.Parse(txtBasicSalaryLd.Text), txtPasswordLd.Text);
                    staDAO.Delete(sta);
                }
                dgvLoad();
            }
        }

        private void dgvListManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListManager.CurrentCell.RowIndex;
            txtIDManager.Clear();
            txtIDLd.DataBindings.Clear();
            txtIDLd.Text = dgvListManager.Rows[r].Cells[0].Value.ToString();
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
            IDReceive = dgvListManager.Rows[r].Cells[0].Value.ToString();
            dgvListStaff.DataSource = staDAO.LoadList(IDReceive);
        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgvListStaff.CurrentCell.RowIndex;
            txtIDLd.DataBindings.Clear();
            txtIDLd.Text = dgvListStaff.Rows[r].Cells[0].Value.ToString();
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
            IDReceive = dgvListStaff.Rows[r].Cells[0].Value.ToString();
        }

        private void FLeader_Load(object sender, EventArgs e)
        {
            dgvLoad();
        }
        private void dgvLoad()
        { 
            dgvListManager.DataSource = manDAO.LoadList();
            dgvListStaff.DataSource = staDAO.LoadList();
        }
    }
}