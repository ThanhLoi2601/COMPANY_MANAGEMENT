using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class ContactDAO
    {
        DBConn dB = new DBConn();
        public void Insert(Contact cont)
        {
            string sqlStr = string.Format("INSERT INTO Contact(IDSent,NameSent,Subject,Content,IdReceive,InfoDate) values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                , cont.IDSent, cont.NameSent, cont.Subject, cont.Content, cont.IDReceive, cont.InfoDate.ToString());
            dB.Executive(sqlStr);
        }

        public DataTable LoadList()
        {
            return dB.LoadList(string.Format("SELECT * FROM Contact"));
        }
    }
}
