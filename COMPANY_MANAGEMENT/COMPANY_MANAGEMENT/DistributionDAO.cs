using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class DistributionDAO
    {
        DBConn dB = new DBConn();
        JobDAO jbDAO = new JobDAO();
        public void Insert(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("INSERT INTO Distribution(IDJob,IDStaff) values ('{0}','{1}')", IDjob, IDstaff);
                dB.Executive(sqlStr);
        }
        public void Delete(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("DELETE FROM Distribution WHERE IDJob = '{0}' and IDStaff = '{1}' ", IDjob, IDstaff);
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
                 " OR ('{1}' BETWEEN DateStart AND DateEnd)", jb.DateStart.ToString("yyyy-MM-dd"), jb.DateEnd.ToString("yyyy-MM-dd"));
            return dB.LoadList(string.Format("SELECT * FROM Staff WHERE (ID NOT IN (SELECT IDStaff FROM Distribution) " +
                 "OR ID NOT IN ({0}) ) AND Manager_ID = '{1}'", str, IDMan));
        }

        public DataTable LoadListDis(string id)
        {
            return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.StartDate, j.EndDate, pj.Process  FROM Distribution d, Tasks j, ProcessJob pj WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.Project_ID = '{0}';", id));
        }

        public DataTable LoadListTask(string id)
        {
            return dB.LoadList(string.Format("SELECT *FROM Tasks WHERE ID NOT IN (SELECT IDJob FROM Distribution) AND ID like 'TKS%' AND Project_ID = '{0}'", id));
        }
        public bool CheckAssigned(string id)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
            conn.Open();
            string sql = string.Format("SELECT COUNT(*) FROM Distribution WHERE IDJob = '{0}'", id);
            SqlCommand command = new SqlCommand(sql, conn);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
                return true;
            else
                return false;
        }
    }
}
