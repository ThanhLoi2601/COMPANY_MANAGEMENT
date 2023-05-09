using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace COMPANY_MANAGEMENT.OOP
{
    class ProjectDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Project pro)
        {
            string sqlStr = string.Format("INSERT INTO Projects(ID,Project_Name,StartDate,EndDate,Project_description,Project_status) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , pro.Id, pro.Name, pro.DateStart.ToString("yyyy-MM-dd"), pro.DateEnd.ToString("yyyy-MM-dd"), pro.Description, pro.Status);
            dB.Executive(sqlStr);
        }

        public void Delete(Project pro)
        {
            string sqlStr = string.Format("DELETE FROM Projects WHERE ID = '{0}'", pro.Id);
            dB.Executive(sqlStr);
        }

        public void Update(Project pro)
        {
            string sqlStr = string.Format("UPDATE Projects Set Project_Name = '{0}', Project_description = '{1}', StartDate = '{2}', EndDate = '{3}', Project_status = '{4}'  WHERE ID ='{5}'"
                , pro.Name, pro.Description, pro.DateStart.ToString(), pro.DateEnd.ToString(), pro.Status.ToString(), pro.Id);
            dB.Executive(sqlStr);
        }
        public void UpdateWithoutNotice(Project pro)
        {
            string sqlStr = string.Format("UPDATE Projects Set Project_Name = '{0}', Project_description = '{1}', StartDate = '{2}', EndDate = '{3}', Project_status = '{4}'  WHERE ID ='{5}'"
                , pro.Name, pro.Description, pro.DateStart.ToString("yyyy-MM-dd"), pro.DateEnd.ToString("yyyy-MM-dd"), pro.Status.ToString(), pro.Id);
            dB.ExecutiveWithoutNotice(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT * FROM Projects WHERE ID like 'PRO%'"));
        }
        public void AddTask(Project pro)
        {
            pro.GetStatus();
        }
    }
}
