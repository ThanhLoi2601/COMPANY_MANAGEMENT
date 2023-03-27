using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class Project
    {
        private string id;
        private string name;
        private DateTime dateStart;
        private DateTime dateEnd;
        private string description;
        private string status;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateEnd { get => dateEnd; set => dateEnd = value; }
        public string Description { get => description; set => description = value; }
        public string Status { get => status; set => status = value; }
        public Project() { }
        public Project(string _id, string _name, DateTime _startDate, DateTime _endDate, string _description, string _status)
        {
            this.id = _id;
            this.name = _name;
            this.dateStart = _startDate;
            this.dateEnd = _endDate;
            this.description = _description;
            this.status = _status;
        }
        ~Project() { }
    }
}
