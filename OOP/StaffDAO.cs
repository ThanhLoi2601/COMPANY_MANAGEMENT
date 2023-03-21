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

        public bool Login(Staff sta)
        {
            string sqlStr = string.Format("SELECT COUNT(*) SoUser FROM Staff WHERE ID = '{0}' and Password = '{1}';", sta.ID, sta.Password);
            return dB.Search(sqlStr);
        }

        public void Update(Staff sta)
        {
            string sqlStr = string.Format("UPDATE Staff SET Name = '{0}', Birth ='{1}',ID_CARD ='{2}',Email ='{3}',PhoneNumber ='{4}',Address ='{5}' Where ID ='{6}'"
                                                                            , sta.Name, sta.Birth.ToString("yyyy-MM-dd"), sta.ID_Card, sta.Email, sta.NumPhone, sta.Address, sta.ID);
            dB.Executive(sqlStr);
        }

        public void UpdatePass(Staff sta)
        {
            string sqlStr = string.Format("UPDATE Staff SET Password = '{0}' Where ID ='{1}'", sta.Password, sta.ID);
            dB.Executive(sqlStr);
        }

        public Staff Search(string id)
        {
            string sqlStr = string.Format("SELECT * FROM Staff WHERE ID = '{0}';", id);
            return dB.FindStaff(sqlStr);
        }
    }
}

