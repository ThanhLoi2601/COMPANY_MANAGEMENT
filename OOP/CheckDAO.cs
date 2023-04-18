using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
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
    }
}
