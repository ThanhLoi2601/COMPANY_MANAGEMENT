using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class ProcessJob
    {
        private string idJob;
        private string content;
        private double process;

        public string  IDJob { get { return idJob; } set { idJob = value; } }
        public string Content { get { return content; } set { content = value; } }
        public double Process { get { return process; } set { process = value; } }

        public ProcessJob() { }

        public ProcessJob(string idJb, string cont, double proc)
        {
            idJob = idJb;
            content = cont;
            process = proc;
        }

        ~ProcessJob() { }

    }
}
