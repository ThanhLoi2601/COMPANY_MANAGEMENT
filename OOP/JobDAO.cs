using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class JobDAO
    {
        DBConn dB = new DBConn();
        public Job Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Job WHERE ID = '{0}';", id);
            return dB.FindJob(sqlStr);
        }
    }
}