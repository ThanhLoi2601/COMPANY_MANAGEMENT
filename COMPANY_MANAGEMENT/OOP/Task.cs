using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace COMPANY_MANAGEMENT.OOP
{
    class Task
    {
        private string id;
        private string name;
        private DateTime dateStart;
        private DateTime dateEnd;
        private string description;
        private string id_project;
        public enum TaskStatus
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
        public TaskStatus Status { get; set; }
        public string Id_project { get => id_project; set => id_project = value; }

        public Task() { }

        public Task(string _id, string _name, DateTime _startDate, DateTime _endDate, string _description, TaskStatus _status, string _id_project)
        {
            this.id = _id;
            this.name = _name;
            this.dateStart = _startDate;
            this.dateEnd = _endDate;
            this.description = _description;
            this.Status = _status;
            this.id_project = _id_project;
        }
        ~Task() { }
        public void UpdateStatus(TaskStatus newStatus)
        {
            this.Status = newStatus;
        }
        public void GetStatus()
        {
            if (Status == TaskStatus.NotStarted)
            {
                DateTime today = DateTime.Today;
                if (today > DateEnd)
                {
                    UpdateStatus(Task.TaskStatus.BehindSchedule);
                }
                else if (today >= DateStart && today <= DateEnd)
                {
                    if (today > DateEnd)
                    {
                        UpdateStatus(Task.TaskStatus.BehindSchedule);
                    }
                    else
                    {
                        UpdateStatus(Task.TaskStatus.InProgress);
                    }
                }
                else
                {
                    UpdateStatus(Task.TaskStatus.NotStarted);
                }
            }
        }
        public string ToStringTaskStatus(TaskStatus status)
        {
            return status.ToString();
        }
    }
}
