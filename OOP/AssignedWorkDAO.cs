using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    class AssignedWorkDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList()
        {
            //return dB.LoadList(string.Format("SELECT Job.ID,Job.Name,Job.Content FROM Job INNER JOIN Distribution ON Job.ID = Distribution.IDJob WHERE Distribution.IDStaff = '{0}'",ID));
            return dB.LoadList(string.Format("SELECT ProcessJob.IDJob,ProcessJob.Content,ProcessJob.Bonus FROM ProcessJob"));
        }
    }
}
