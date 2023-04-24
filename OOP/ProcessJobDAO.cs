using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{

    class ProcessJobDAO
    {
        DBConn dB = new DBConn();
        public void Update(ProcessJob a)
        {
            string sqlStr = string.Format("UPDATE ProcessJob SET Process = {0} Where Content ='{1}'", a.Process,a.Content);
            dB.Executive(sqlStr);
        }

        public void Detele(ProcessJob a)
        {
            string sqlStr = string.Format("Delete FROM ProcessJob Where Content = '{0}'" ,  a.Content);
            dB.Executive(sqlStr);
        }
    }
}
