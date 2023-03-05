using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class ManagerDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Manager Man)
        {
            string sqlStr = string.Format("INSERT Manager(ID,Name,Birth,ID_Card,Email,Address,Basic_salary,Password) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');"
                , Man.ID, Man.Name, Man.Birth, Man.ID_Card, Man.Email, Man.Address, Man.BasicSalary, Man.Password);
            dB.ThucThi(sqlStr);
        }

        public void Delete(Manager Man)
        {
            string sqlStr = string.Format("DELETE FROM Manager WHERE ID = '{0}'", Man.ID);
            dB.ThucThi(sqlStr);
        }

        public void Update(Manager Man)
        {
            Delete(Man);
            Insert(Man);
        }

        public bool Login(Manager Man)
        {
            string sqlStr = string.Format("SELECT * FROM Manager WHERE ID = '{0}' and Password = '{1}'", Man.ID, Man.Password);
            sqlStr = string.Format("SELECT COUNT(*) SoUser FROM ({0}) users;", sqlStr);
            return dB.Find(sqlStr);
        }

        public DataTable DanhSach()
        {
            return dB.DanhSach(string.Format("SELECT *FROM Manager"));
        }
    }
}
