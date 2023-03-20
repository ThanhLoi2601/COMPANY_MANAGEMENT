using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class CompleteWorkDAO
    {
        DBConn dB = new DBConn();

        public void Insert(KPI kpi, string ID)
        {
            string sqlStr = string.Format("INSERT INTO CompleteWork(IDUser,IDJob,KPI) values ('{0}','{1}','{2}')"
                , ID, kpi.job.ID, kpi.CalKPI());
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string IDUser)
        {
            return dB.LoadList(string.Format("SELECT *FROM CompleteWork WHERE IDUser = '{0}';",IDUser));
        }

        public int CountWork(string IDUser)
        {
            return dB.Merge(string.Format("SELECT COUNT(IDJob) FROM CompleteWork WHERE IDUser = '{0}';", IDUser));
        }

        public int SumKPI(string IDUser)
        {
            return dB.Merge(string.Format("SELECT SUM(KPI) FROM CompleteWork WHERE IDUser = '{0}';", IDUser));
        }

    }
}
