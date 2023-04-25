using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class CheckDAO
    {
        DBConn dB = new DBConn();
        public void InsertCheck(Check a)
        {
            string query = string.Format("INSERT INTO SQLCheck (ID,Name,DateCheck, CheckIn, CheckOut,TimesLate)" +
                                        " VALUES ('{0}','{1}','{2}','{3}','{4}',{5})", a.Id,a.Name,a.CheckDate.ToString("yyyy-MM-dd"),a.CheckIn,a.CheckOut,a.TimesLate);
            dB.Executive(query);
        }

        public void Updatecheck(Check a)
        {
            string query = string.Format("UPDATE SQLCheck SET CheckOut ='{0}' WHERE ID ='{1}'", a.CheckOut, a.Id);
            dB.Executive(query);
        }
        public DataTable LoadCheck()
        {
            string query = string.Format("SELECT * FROM SQLCheck WHERE DateCheck= CONVERT(date, GETDATE())");
            return dB.LoadList(query);
        }

    }
}
