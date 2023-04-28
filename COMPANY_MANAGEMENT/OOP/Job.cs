using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class Job
    {
        private string id;
        private string name;
        private string content;
        private DateTime dateStart;
        private DateTime dateEnd;
        private int bonus;
        private string idTask;

        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Content { get { return content; } set { content = value; } }
        public DateTime DateStart { get { return dateStart; } set { dateStart = value; } }
        public DateTime DateEnd { get { return dateEnd; } set { dateEnd = value; } }
        public int Bonus { get { return bonus; } set { bonus = value; } }
        public string IDTask { get { return idTask; } set { idTask = value; } }

        public Job()
        {
        }

        public Job(string ID, string NAME, string CONTENT, DateTime DATESTART, DateTime DATEEND, int BONUS, string IDTASK)
        {
            this.id = ID;
            this.name = NAME;
            this.content = CONTENT;
            this.dateStart = DATESTART;
            this.dateEnd = DATEEND;
            this.bonus = BONUS;
            this.idTask = IDTASK;
        }

        ~Job()
        {
        }
    }
}
