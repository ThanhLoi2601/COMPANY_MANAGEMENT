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
    class CompleteJobDAO
    {
        DBConn dB = new DBConn();

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT *FROM CompleteJob"));
        }
    }
}
