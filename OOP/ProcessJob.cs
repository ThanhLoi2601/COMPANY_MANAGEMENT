using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class ProcessJob
    {
        private string id;
        private string content;
        private int process;
        private int bonus;

        public string Id { get => id; set => id = value; }
        public string Content { get => content; set => content = value; }
        public int Process { get => process; set => process = value; }
        public int Bonus { get => bonus; set => bonus = value; }

        public ProcessJob(string id, string content, int process, int bonus)
        {
            this.id = id;
            this.content = content;
            this.process = process;
            this.bonus = bonus;
        }

        public ProcessJob(string content, int process)
        {
            this.content = content;
            this.process = process;
        }
    }
}
