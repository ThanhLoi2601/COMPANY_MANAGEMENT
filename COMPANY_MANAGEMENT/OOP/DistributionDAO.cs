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

        public void Delete(string IDjob, string IDstaff)
        {
            string sqlStr = string.Format("DELETE FROM Distribution WHERE IDJob = '{0}' and IDStaff = '{1}' ", IDjob, IDstaff);
            dB.Executive(sqlStr);
        }

        public DataTable LoadListJob()
        {
            return dB.LoadList(string.Format("SELECT j.ID,j.Name,j.Content,j.DateStart,j.DateEnd,j.Bonus,j.IDTasks,t.Task_Name " +
                " FROM Job j, Tasks t WHERE j.ID NOT IN (SELECT IDJob FROM Distribution) AND j.IDTasks = t.ID"));
        }

        public DataTable LoadListJob(string IDTask)
        {
            if (IDTask == "All tasks")
                return LoadListJob();
            return dB.LoadList(string.Format("SELECT j.ID,j.Name,j.Content,j.DateStart,j.DateEnd,j.Bonus,j.IDTasks,t.Task_Name " +
                " FROM Job j, Tasks t WHERE j.ID NOT IN (SELECT IDJob FROM Distribution) AND j.IDTasks = t.ID AND IDTasks = '{0}'", IDTask));
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

        public DataTable LoadListDis()
        {
            return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.DateStart, j.DateEnd, pj.Process, j.IDTasks, t.Task_Name" +
                " FROM Distribution d, Job j, ProcessJob pj, Tasks t WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.IDTasks = t.ID;"));
        }

        public DataTable LoadListDis(string IDTask)
        {
            if (IDTask == "All tasks")
                return LoadListDis();
            return dB.LoadList(string.Format("SELECT d.IDJob , d.IDStaff , j.DateStart, j.DateEnd, pj.Process, j.IDTasks" +
                " FROM Distribution d, Job j, ProcessJob pj WHERE d.IDJob = j.ID and d.IDJob = pj.IDJob and j.IDTasks = '{0}';",IDTask));
        }
    }
}
