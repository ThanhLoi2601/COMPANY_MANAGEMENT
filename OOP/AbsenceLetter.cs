using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class AbsenceLetter
    {
        private string staffName;
        private string staffID;
        private string reason;
        private DateTime startDate;
        private DateTime endDate;

        public string StaffName { get { return staffName; } set { staffName = value; } }
        public string StaffID { get { return staffID; } set { staffID = value; } }
        public string Reason { get { return reason; } set { reason = value; } }
        public DateTime StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime EndDate { get { return endDate; } set { endDate = value; } }

        public AbsenceLetter()
        { 
        }

        public AbsenceLetter(string staffID, string staffName, string reason, DateTime startDate, DateTime endDate)
        {
            this.staffName = staffID;
            this.staffID = staffName;
            this.reason = reason;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public string toStringAbs()
        {
            return string.Format("'{0}','{1}','{2}','{3}','{4}'", staffID,staffName,reason,startDate,endDate);
        }

        ~AbsenceLetter()
        {
        }
    }
}
