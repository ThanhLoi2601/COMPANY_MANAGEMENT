using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class KPI
    {
        private int BasicSalary;
        private Job jb = new Job();
        private DateTime dateStart;
        private DateTime dateComplete;

        public Job job { get { return jb; } }

        public KPI()
        {
        }
        public KPI(int BSalary, Job job, DateTime DateComplete)
        {
            this.BasicSalary = BSalary;
            this.jb = job;
            this.dateStart = job.DateStart;
            this.dateComplete = DateComplete;
        }

        ~KPI()
        { }

        public double TimeComplete()
        {
            return this.dateComplete.ToOADate() - this.dateStart.ToOADate();
        }

        public int CalKPI() // KPI của 1 công việc
        {
            return (int)Math.Round((this.jb.Bonus + this.BasicSalary) / this.TimeComplete());
        }
    }
}
