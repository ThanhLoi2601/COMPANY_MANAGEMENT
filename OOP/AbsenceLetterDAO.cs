using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class AbsenceLetterDAO
    {
        DBConn dB = new DBConn();
        public void UpdateAbsen(AbsenceLetter a)
        {
            string sqlStr = string.Format("INSERT Absence(ID,Name,Reason,StartDate,EndDate) values ('{0}','{1}','{2}','{3}','{4}')", a.StaffID, a.StaffName, a.Reason, a.StartDate.ToString("yyyy-MM-dd"), a.EndDate.ToString("yyyy-MM-dd"));//,a.toStringAbs());
            dB.Executive(sqlStr);
        }
    }
}
