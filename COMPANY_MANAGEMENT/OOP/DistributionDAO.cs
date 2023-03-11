using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class DistributionDAO
    {
        DBConn dB = new DBConn();
        public void Insert(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("INSERT INTO Distribution(IDJob,IDStaff) values ('{0}','{1}')", IDjob,IDstaff);
            dB.Executive(sqlStr);
        }
        public DataTable LoadListJob()
        {
            return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID NOT IN (SELECT IDJob FROM Distribution)"));
        }
    }
}
