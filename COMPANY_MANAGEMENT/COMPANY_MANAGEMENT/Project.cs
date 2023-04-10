using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace COMPANY_MANAGEMENT
{
    class Project
    {
        private string id;
        private string name;
        private DateTime dateStart;
        private DateTime dateEnd;
        private string description;
        private List<Task> tasks;
        public enum ProjectStatus
        {
            NotStarted,
            InProgress,
            OnHold,
            Completed,
            BehindSchedule,
            Cancelled
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        public string Description { get => description; set => description = value; }
        public ProjectStatus Status { get; set; }
        public List<Task> Tasks { get => tasks; set => tasks = value; }

        public Project() { }
        public Project(string _id, string _name, DateTime _startDate, DateTime _endDate, string _description, ProjectStatus _status)
        {
            this.id = _id;
            this.name = _name;
            this.dateStart = _startDate;
            this.dateEnd = _endDate;
            this.description = _description;
            this.Status = _status;
            Tasks = new List<Task>();
        }
        ~Project() { }
        public void UpdateStatus(ProjectStatus newStatus)
        {
            this.Status = newStatus;
        }
        public string ToStringTaskStatus(ProjectStatus status)
        {
            return status.ToString();
        }
        public ProjectStatus GetStatus()
        {
            if (Tasks == null || Tasks.Count == 0)
            {
                return ProjectStatus.NotStarted;
            }

            bool allTasksCompleted = Tasks.All(t => t.Status == Task.TaskStatus.Completed);

            if (allTasksCompleted)
            {
                return ProjectStatus.Completed;
            }

            bool anyTaskInProgress = Tasks.Any(t => t.Status == Task.TaskStatus.InProgress);

            if (anyTaskInProgress)
            {
                return ProjectStatus.InProgress;
            }

            bool anyTaskOnHold = Tasks.Any(t => t.Status == Task.TaskStatus.OnHold);

            if (anyTaskOnHold)
            {
                return ProjectStatus.OnHold;
            }

            if (dateEnd < DateTime.Now)
            {
                return ProjectStatus.BehindSchedule;
            }
            return ProjectStatus.InProgress;
        }
        public List<Task> GetListTasks(string id_project)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            conn.Open();
            string sql = String.Format("SELECT * FROM Tasks WHERE Project_ID = '{0}'", id_project);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Task> tasks = new List<Task>();
            while (reader.Read())
            {
                Task task = new Task();
                task.Id = reader.GetString(0);
                task.Name = reader.GetString(1);
                task.DateStart = reader.GetDateTime(2);
                task.DateEnd = reader.GetDateTime(3);
                task.Description = reader.GetString(4);
                task.Status = (Task.TaskStatus)Enum.Parse(typeof(Task.TaskStatus), reader.GetString(5));
                task.Id_project = reader.GetString(6);
                tasks.Add(task);
            }
            reader.Close();
            return tasks;
        }
    }
}
