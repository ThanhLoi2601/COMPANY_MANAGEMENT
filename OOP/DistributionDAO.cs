using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    class DistributionDAO
    {
        DBConn dB = new DBConn();
        JobDAO jbDAO = new JobDAO();

        public void LoadListJob(string id)
        {
            string sqlStr = string.Format("SELECT Job.Name FROM Job INNER JOIN Distribution ON Job.ID = Distribution.IDJob WHERE Distribution.IDStaff = '{0}'", id);
            dB.Executive(sqlStr);
        }
    }
}