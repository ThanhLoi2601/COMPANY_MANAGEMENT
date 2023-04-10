using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
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
                , tks.Name, tks.Description, tks.DateStart.ToString(), tks.DateEnd.ToString(), tks.Status.ToString(), tks.Id);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public DataTable LoadList(string id)
        {
            if (id != "")
                return dB.LoadList(string.Format("SELECT * FROM Tasks WHERE ID like 'TKS%' and Project_ID = '{0}'", id));
            else
                return dB.LoadList(string.Format("SELECT * FROM Tasks WHERE ID like 'TKS%'"));
        }
    }
}
