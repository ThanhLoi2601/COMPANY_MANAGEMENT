using COMPANY_MANAGEMENT.OOP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class StaffDAO
    {
        DBConn dB = new DBConn();
        public bool Login(Staff sta)
        {
            string sqlStr = string.Format("SELECT * FROM Staff WHERE ID = '{0}' and Password = '{1}'", sta.ID, sta.Password);
            return dB.Search(sqlStr);
        }

        public void Insert(Staff sta)   
        {
            string sqlStr = string.Format("INSERT Staff(ID,Name,Birth,ID_Card,Email,Address,Manager_ID,Basic_salary,Password) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}');"
                , sta.ID,sta.Name,sta.Birth,sta.ID_Card,sta.Email,sta.Address,sta.ManagerId,sta.BasicSalary,sta.Password);
            dB.Executive(sqlStr);
        }

        public void Delete(Staff sta)
        {
            string sqlStr = string.Format("DELETE FROM Staff WHERE ID = '{0}'", sta.ID);
            dB.Executive(sqlStr);
        }

        public void Update(Staff sta)
        {
            string sqlStr = string.Format("UPDATE Staff SET Name= '{0}', Birth= '{1}', ID_Card= '{2}', Email= '{3}', Address= '{4}', Basic_salary= {5}, Password= '{6}' WHERE ID = '{7}'"
                , sta.Name, sta.Birth.ToString(),sta.ID_Card,sta.Email,sta.Address,sta.BasicSalary.ToString(),sta.Password, sta.ID);
            dB.Executive(sqlStr);
        }

        public DataTable LoadList(string IDMan)
        {
            return dB.LoadList(string.Format("SELECT *FROM Staff WHERE Manager_ID = '{0}'",IDMan));
        }
    }
}

