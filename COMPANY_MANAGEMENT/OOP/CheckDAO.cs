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

        public void CalcuLates(string month)
        {
            string query = string.Format("SELECT SUM(TimesLate) as TotalLateFROM SQLCheck WHERE MONTH(DateCheck) = {0}", month);
            dB.Executive(query);

        }
        public void InsertCheck(Check a)
        {
            string query = string.Format("INSERT INTO SQLCheck (ID,Name,DateCheck, CheckIn, CheckOut,TimesLate,TimeCheckIn,TimeCheckOut)" +
                                        " VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}')", a.Id, a.Name, a.CheckDate.ToString("yyyy-MM-dd"), a.CheckIn, a.CheckOut, a.TimesLate,
                                                              a.TimeCheckIn.ToString("yyyy-MM-dd HH:mm:ss"), a.TimeCheckOut.ToString("yyyy-MM-dd HH:mm:ss"));
            dB.Executive(query);
        }

        public void Updatecheck(Check a)
        {
            string query = string.Format("UPDATE SQLCheck SET CheckOut ='{0}', TimeCheckOut ='{1}' WHERE ID ='{2}'", a.CheckOut, a.TimeCheckOut.ToString("yyyy-MM-dd HH:mm:ss"), a.Id);
            dB.Executive(query);
        }
        public DataTable LoadCheck()
        {
            string query = string.Format("SELECT * FROM SQLCheck WHERE DateCheck = CONVERT(date, GETDATE())");
            return dB.LoadList(query);
        }

    }
}
