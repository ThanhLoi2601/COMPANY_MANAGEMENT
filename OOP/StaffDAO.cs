using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class StaffDAO
    {
        DBConn dB = new DBConn();
        public bool Login(Staff a)
        {
            string sqlStr = string.Format("SELECT * FROM Staff WHERE ID = '{0}' and Password = '{1}'", a.ID, a.Password);
            return dB.Find(sqlStr);
        }
    }
}

