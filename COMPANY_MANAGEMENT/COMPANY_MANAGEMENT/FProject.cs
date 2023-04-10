using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    public partial class FProject : Form
    {
        ProjectDAO proDao = new ProjectDAO();
        public FProject()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            conn.Open();
            string sql = "SELECT * FROM Projects WHERE ID like 'PRO%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Tạo đối tượng Project và gán giá trị từ các trường trong bảng Projects
                Project project = new Project();
                project.Id = reader.GetString(0);
                project.Name = reader.GetString(1);
                project.DateStart = reader.GetDateTime(2);
                project.DateEnd = reader.GetDateTime(3);
                project.Description = reader.GetString(4);
                project.Status = (Project.ProjectStatus)Enum.Parse(typeof(Project.ProjectStatus), reader.GetString(5));
                project.Tasks = project.GetListTasks(project.Id);
                project.Status = project.GetStatus();
                proDao.UpdateWithoutNotice(project);
            }

        }
        private void FProject_Load(object sender, EventArgs e)
        {
            cbbStatus.DataSource = Enum.GetValues(typeof(Project.ProjectStatus));
            Project pro = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Project.ProjectStatus)cbbStatus.SelectedItem);
            gvProject.DataSource = proDao.LoadList();
        }
        private void btUpdateProject_Click(object sender, EventArgs e)
        {
            Project pro = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Project.ProjectStatus)cbbStatus.SelectedItem);
            proDao.Update(pro);
            gvProject.DataSource = proDao.LoadList();
        }

        private void btInsertProject_Click(object sender, EventArgs e)
        {
            Project pro = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Project.ProjectStatus)cbbStatus.SelectedItem);
            proDao.Insert(pro);
            gvProject.DataSource = proDao.LoadList();
        }

        private void btDeleteProject_Click(object sender, EventArgs e)
        {
            Project sta = new Project(txtID.Text, txtName.Text, dtDateStart.Value, dtDateEnd.Value, rtxtContent.Text, (Project.ProjectStatus)cbbStatus.SelectedItem);
            proDao.Delete(sta);
            gvProject.DataSource = proDao.LoadList();
        }
        private void gvProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.gvProject.CurrentCell.RowIndex;
            txtID.DataBindings.Clear();
            txtID.Text = gvProject.Rows[r].Cells[0].Value.ToString();
            txtName.DataBindings.Clear();
            txtName.Text = gvProject.Rows[r].Cells[1].Value.ToString();
            dtDateStart.DataBindings.Clear();
            dtDateStart.Text = gvProject.Rows[r].Cells[2].Value.ToString();
            dtDateEnd.DataBindings.Clear();
            dtDateEnd.Text = gvProject.Rows[r].Cells[3].Value.ToString();
            rtxtContent.DataBindings.Clear();
            rtxtContent.Text = gvProject.Rows[r].Cells[4].Value.ToString();
            cbbStatus.DataBindings.Clear();
            cbbStatus.Text = gvProject.Rows[r].Cells[5].Value.ToString();
        }

        private void btTask_Click(object sender, EventArgs e)
        {
            FTask ftask = new FTask(txtID.Text);
            ftask.ShowDialog();
        }
    }
}
