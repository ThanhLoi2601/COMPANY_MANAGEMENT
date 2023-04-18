using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class Check
    {
        private DateTime checkDate;
        private bool checkIn;
        private bool checkOut;

        public DateTime CheckDate { get => checkDate; set => checkDate = value; }
        public bool CheckIn { get => checkIn; set => checkIn = value; }
        public bool CheckOut { get => checkOut; set => checkOut = value; }

        public Check(DateTime checkDate, bool checkIn, bool checkOut)
        {
            this.checkDate = checkDate;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }
    }
}
