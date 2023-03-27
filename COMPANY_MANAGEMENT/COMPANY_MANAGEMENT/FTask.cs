using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace COMPANY_MANAGEMENT
{
    public partial class FTask : Form
    {
        private string id_Project;
        TaskDAO tksDao = new TaskDAO();
        public FTask(string textBoxValue)
        {
            InitializeComponent();
            this.id_Project = textBoxValue;
        }
        public FTask()
        {
            InitializeComponent();
        }

        private void FTask_Load(object sender, EventArgs e)
        {
            cbbStatus.DataSource = Enum.GetValues(typeof(Task.TaskStatus));
            gvTask.DataSource = tksDao.LoadList(id_Project);
            txtID_Project.Text = this.id_Project; 
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Task tks = new Task(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Task.TaskStatus)cbbStatus.SelectedItem, txtID_Project.Text);
            tksDao.Update(tks);
            gvTask.DataSource = tksDao.LoadList(id_Project);
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtID_Project.Text == "")
            {    
                MessageBox.Show("Please select the project to which you want to add the task!!", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Task tks = new Task(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Task.TaskStatus)cbbStatus.SelectedItem, txtID_Project.Text);
                tksDao.Insert(tks);
                gvTask.DataSource = tksDao.LoadList(id_Project);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?", "REMIND", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Task tks = new Task(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Task.TaskStatus)cbbStatus.SelectedItem, txtID_Project.Text);
                tksDao.Delete(tks);
                gvTask.DataSource = tksDao.LoadList(this.id_Project);
            }    
        }

        private void gvTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
