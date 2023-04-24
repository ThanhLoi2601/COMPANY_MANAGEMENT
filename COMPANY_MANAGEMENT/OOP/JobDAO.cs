using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class JobDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Job job)
        {
            string sqlStr = string.Format("INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , job.ID, job.Name, job.Content,job.DateStart.ToString(),job.DateEnd.ToString(),job.Bonus.ToString());
            dB.Executive(sqlStr);
        }

        public void Delete(Job job)
        {
            string sqlStr = string.Format("DELETE FROM Job WHERE ID = '{0}'", job.ID);
            dB.Executive(sqlStr);
        }

        public void Update(Job job)
        {
            string sqlStr = string.Format("UPDATE Job Set Name = '{0}', Content = '{1}', DateStart = '{2}', DateEnd = '{3}', Bonus = {4} WHERE ID ='{5}'"
                , job.Name,job.Content,job.DateStart.ToString(),job.DateEnd.ToString(),job.Bonus);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string IDhead)
        {
            if (IDhead == "JOB")
                return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID like 'JOB%'"));
            else
                return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID like 'JOM%'"));
        }

    }
}
