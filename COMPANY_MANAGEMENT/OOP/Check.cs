using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class Check
    {
        private string id;
        private string name;
        private DateTime checkDate;
        private bool checkIn;
        private bool checkOut;
        private int timesLate;
        private DateTime timeCheckIn;
        private DateTime timeCheckOut;

        public DateTime CheckDate { get => checkDate; set => checkDate = value; }
        public bool CheckIn { get => checkIn; set => checkIn = value; }
        public bool CheckOut { get => checkOut; set => checkOut = value; }
        public int TimesLate { get => timesLate; set => timesLate = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime TimeCheckIn { get => timeCheckIn; set => timeCheckIn = value; }
        public DateTime TimeCheckOut { get => timeCheckOut; set => timeCheckOut = value; }

        public Check(string Id, string Name, DateTime checkDate, bool checkIn, bool checkOut, int Timeslate, DateTime timein, DateTime timeout)
        {
            this.id = Id;
            this.name = Name;
            this.checkDate = checkDate;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.timesLate = Timeslate;
            this.timeCheckIn = timein;
            this.timeCheckOut = timeout;
        }
    }
}
