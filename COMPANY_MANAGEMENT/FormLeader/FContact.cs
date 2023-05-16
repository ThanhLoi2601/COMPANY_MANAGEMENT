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

namespace COMPANY_MANAGEMENT.FormLeader
{
    public partial class FContact : Form
    {
        ContactDAO contDAO = new ContactDAO();
        string IDReceive;
        string NameReceive;
        public FContact()
        {
            InitializeComponent();
        }

        public FContact(string ID, string Name)
        {
            IDReceive = ID;
            NameReceive = Name;
            InitializeComponent();
        }

        private void FContact_Load(object sender, EventArgs e)
        {
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            txtIDSent.Text = IDReceive;
            txtNameSent.Text = NameReceive; 
            LoadContact();
        }

        private void LoadContact()
        {
            dtGVContact.DataSource = contDAO.LoadListSent(IDReceive);
            HighLight(dtGVContact);
        }

        private void btSent_Click(object sender, EventArgs e)
        {
            if (cbBoxIDRe.Text == "")
            {
                MessageBox.Show("Check back the information!!");
                return; 
            }
            Contact cont = new Contact(txtIDSent.Text, txtNameSent.Text, txtSub.Text,rTxtContent.Text,cbBoxIDRe.Text, DateTime.Now);
            contDAO.Insert(cont);
            LoadContact();
        }

        private void dtGVContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dtGVContact.CurrentCell.RowIndex;
            txtIDSent.DataBindings.Clear();
            txtIDSent.Text = dtGVContact.Rows[r].Cells[0].Value.ToString();
            txtNameSent.DataBindings.Clear();
            txtNameSent.Text = dtGVContact.Rows[r].Cells[1].Value.ToString();
            txtSub.DataBindings.Clear();
            txtSub.Text = dtGVContact.Rows[r].Cells[2].Value.ToString();
            rTxtContent.DataBindings.Clear();
            rTxtContent.Text = dtGVContact.Rows[r].Cells[3].Value.ToString();
            cbBoxIDRe.DataBindings.Clear();
            cbBoxIDRe.Text = dtGVContact.Rows[r].Cells[4].Value.ToString();
        }

        private void btLoadHightLight_Click(object sender, EventArgs e)
        {
            HighLight(dtGVContact);
        }
        private void HighLight(DataGridView dtGV)
        {
            DateTime currentDate = DateTime.Now.Date;

            foreach (DataGridViewRow row in dtGV.Rows)
            {
                if (row.Cells["InfoDate"].Value != null && Convert.ToDateTime(row.Cells["InfoDate"].Value).Date == currentDate)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
