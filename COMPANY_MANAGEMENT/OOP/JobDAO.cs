using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class JobDAO
    {
        DBConn dB = new DBConn();

        public void Insert(Job job)
        {
            string sqlStr = string.Format("INSERT INTO Job(ID,Name,Content,DateStart,DateEnd,Bonus,IDTasks) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , job.ID, job.Name, job.Content,job.DateStart.ToString("yyyy-MM-dd"),job.DateEnd.ToString("yyyy-MM-dd"),job.Bonus.ToString(),job.IDTask);
            dB.Executive(sqlStr);
        }

        public void Delete(Job job)
        {
            string sqlStr = string.Format("DELETE FROM Job WHERE ID = '{0}'", job.ID);
            dB.Executive(sqlStr);
        }

        public void Update(Job job)
        {
            string sqlStr = string.Format("UPDATE Job Set Name = '{0}', Content = '{1}', DateStart = '{2}', DateEnd = '{3}', Bonus = {4}, IDTasks= '{5}' WHERE ID ='{6}'"
                , job.Name,job.Content,job.DateStart.ToString("yyyy-MM-dd"),job.DateEnd.ToString("yyyy-MM-dd"),job.Bonus,job.IDTask,job.ID);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string IDhead)
        {
            if (IDhead == "JOB")
                return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID like 'JOB%'"));
            else
            {
                // return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID like 'TKS%'"));
                return null;
            }
        }

        public Job Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Job WHERE ID = '{0}';", id);
            return dB.FindJob(sqlStr);
        }

        public void LoadCbTaskJob(ComboBox cb)// SELECT DISTINCT j.IDTasks FROM Job j INNER JOIN Distribution d ON j.IDTask = d.IDJob
        {
            string sqlStr = string.Format("SELECT DISTINCT IDTasks FROM Job WHERE ID NOT IN (SELECT IDJob FROM Distribution)");
            dB.LoadCbJobTask(sqlStr,cb);
        }
        public void LoadCbTaskDis(ComboBox cb)
        {
            string sqlStr = string.Format("SELECT DISTINCT j.IDTasks FROM Job j INNER JOIN Distribution d ON j.ID = d.IDJob");
            dB.LoadCbJobTask(sqlStr, cb);
        }

    }
}
