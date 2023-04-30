using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class CompleteJobDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM CompleteJob"));
        }

        public void Insert(CompleteJob job)
        {
            string sqlStr=string.Format("Insert INTO CompleteJob VALUES ('{0}','{1}','{2}','{3}')"
                                                                            , job.Id, job.Content,job.ComDate.ToString("yyyy-MM-dd"), job.Bonus);
            dB.Executive(sqlStr);
        }
        public DataTable LoadList(string month)
        {
            return dB.LoadList(string.Format("SELECT * FROM CompleteJob WHERE MONTH(CompleDate) = {0} ", month));
        }
        public DataTable LoadListTask(string IDEmp, string month)
        {
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if(month == "All month")
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate  FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}'", IDEmp));
            else
                return dB.LoadList(string.Format("SELECT cj.IDJob, cj.Content, cj.CompleDate  FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}' and MONTH(CompleDate) = {1}", IDEmp, month));
        }
        public string SumTaskCmp(string IDEmp, string month)
        {
            if (month == "Now")
                month = DateTime.Now.Month.ToString();
            if (month == "All month")
                return dB.Merge(string.Format("SELECT COUNT(*) FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}'", IDEmp)).ToString();
            else
                return dB.Merge(string.Format("SELECT COUNT(*) FROM CompleteJob cj INNER JOIN Distribution d ON cj.IDJob = d.IDJob WHERE d.IDStaff = '{0}' and MONTH(CompleDate) = {1}", IDEmp, month)).ToString();
        }
    }
}
