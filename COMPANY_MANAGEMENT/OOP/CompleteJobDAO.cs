using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.OOP
{
    class CompleteJobDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM CompleteJob"));
        }

        public void Insert(CompleteJob job)
        {
            string sqlStr=string.Format("Insert INTO CompleteJob VALUES ('{0}','{1}','{2}','{3}')"
                                                                            , job.Id, job.Content,job.ComDate.ToString("yyyy-MM-dd"), job.Bonus);
            dB.Executive(sqlStr);
        }
    }
}
