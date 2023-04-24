using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class CompleteJob
    {
        private string id;
        private string content;
        private DateTime comDate;
        int bonus;

        public string Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public DateTime ComDate { get => comDate; set => comDate = value; }
        public int Bonus { get => bonus; set => bonus = value; }

        public CompleteJob(string id, string content, DateTime comDate, int bonus)
        {
            this.id = id;
            this.content = content;
            this.comDate = comDate;
            this.bonus = bonus;
        }
    }
}
