using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class DistributionDAO
    {
        DBConn dB = new DBConn();
        JobDAO jbDAO = new JobDAO();
        public void Insert(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("INSERT INTO Distribution(IDJob,IDStaff) values ('{0}','{1}')", IDjob,IDstaff);
            dB.Executive(sqlStr);
        }
        public DataTable LoadListJob()
        {
            return dB.LoadList(string.Format("SELECT *FROM Job WHERE ID NOT IN (SELECT IDJob FROM Distribution) AND ID like 'JOB%'"));
        }

        public DataTable LoadListStaff(Job jb, string IDMan)
        {
            string str = string.Format("SELECT IDStaff FROM Distribution INNER JOIN Job ON IDJob = ID " +
                 "WHERE (DateStart BETWEEN '{0}' AND '{1}')" +
                 " OR (DateEnd BETWEEN '{0}' AND '{1}')" +
                 " OR ('{0}' BETWEEN DateStart AND DateEnd)" +
                 " OR ('{1}' BETWEEN DateStart AND DateEnd)", jb.DateStart.ToString(), jb.DateEnd.ToString());
            return dB.LoadList(string.Format("SELECT * FROM Staff WHERE (ID NOT IN (SELECT IDStaff FROM Distribution) " +
                 "OR ID NOT IN ({0}) ) AND Manager_ID = '{1}'", str, IDMan));
        }
    }
}
