using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class TaskDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Task tks)
        {
            string sqlStr = string.Format("INSERT INTO Tasks(ID,Task_Name,StartDate,EndDate,Task_description,Task_status,Project_ID) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                , tks.Id, tks.Name, tks.DateStart.ToString(), tks.DateEnd.ToString(), tks.Description, tks.Status.ToString(), tks.Id_project);
            dB.Executive(sqlStr);
        }

        public void Delete(Task tks)
        {
            string sqlStr = string.Format("DELETE FROM Tasks WHERE ID = '{0}'", tks.Id);
            dB.Executive(sqlStr);
        }

        public void Update(Task tks)
        {
            string sqlStr = string.Format("UPDATE Tasks Set Task_Name = '{0}', Task_description = '{1}', StartDate = '{2}', EndDate = '{3}', Task_status = '{4}'  WHERE ID ='{5}'"
                , tks.Name, tks.Description, tks.DateStart.ToString("yyyy-MM-dd"), tks.DateEnd.ToString("yyyy-MM-dd"), tks.Status.ToString(), tks.Id);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public DataTable LoadList(string id)
        {
            if (id != "")
                return dB.LoadList(string.Format("SELECT ID, Task_Name, StartDate, EndDate, Task_description, Task_status FROM Tasks WHERE ID like 'TKS%' and Project_ID = '{0}'", id));
            else
                return dB.LoadList(string.Format("SELECT ID, Task_Name, StartDate, EndDate, Task_description, Task_status FROM Tasks WHERE ID like 'TKS%'"));
        }

        public DataTable LoadListTaskMan(string idMan)
        {
            return dB.LoadList(string.Format("SELECT t.ID, t.Task_Name, t.Task_description, t.StartDate, t.EndDate, t.Task_status,t.Project_ID, p.Project_Name FROM Tasks t, Distribution d, Projects p WHERE t.ID = d.IDJob and t.Project_ID = p.ID and d.IDStaff = '{0}'",idMan));
        }

        public string Search(string id)
        {
            if (id == "All tasks")
                return null;
            string sqlStr = string.Format("SELECT * FROM Tasks WHERE ID = '{0}';", id);
            return dB.FindNameTask(sqlStr);
        }

        public Task SearchTask(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Tasks WHERE ID = '{0}';", id);
            return dB.FindTask(sqlStr);
        }
    }
}
