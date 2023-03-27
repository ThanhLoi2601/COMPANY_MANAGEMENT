using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class ProjectDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Project pro)
        {
            string sqlStr = string.Format("INSERT INTO Projects(ID,Project_Name,StartDate,EndDate,Project_description,Project_status) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , pro.Id, pro.Name, pro.DateStart.ToString(), pro.DateEnd.ToString(), pro.Description, pro.Status);
            dB.Executive(sqlStr);
        }

        public void Delete(Project pro)
        {
            string sqlStr = string.Format("DELETE FROM Projects WHERE ID = '{0}'", pro.Id);
            dB.Executive(sqlStr);
        }

        public void Update(Project pro)
        {
            string sqlStr = string.Format("UPDATE Projects Set Project_Name = '{0}', Project_description = '{1}', DateStart = '{2}', DateEnd = '{3}',  WHERE ID ='{4}'"
                , pro.Name, pro.Description, pro.DateStart.ToString(), pro.DateEnd.ToString(), pro.Id);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM Projects WHERE ID like 'PRO%'"));
        }
    }
}
