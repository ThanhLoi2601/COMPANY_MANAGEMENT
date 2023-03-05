using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class Manager
    {
        private string iD;
        private string name;
        private DateTime birth;
        private string iD_Card;
        private string email;
        private string address;
        private int basic_salary;
        private string password;

        public string ID { get { return iD; } set { iD = value; }}
        public string Name { get { return name; } set { name = value; } }
        public DateTime Birth { get { return birth; } set { birth = value; } }
        public string ID_Card { get { return iD_Card; } set { iD_Card = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int BasicSalary { get { return basic_salary; } set { basic_salary = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Manager()
        {
        }
        public Manager(string id, string Ten, DateTime birthday, string id_Card, string EMAIL, string add, int bSalary, string pass)
        {
            this.ID = id;
            this.Name = Ten;
            this.Birth = birthday;
            this.ID_Card = id_Card;
            this.Email = EMAIL;
            this.Address = add;
            this.BasicSalary = bSalary;
            this.Password = pass;
        }

        public Manager(string id, string pass)
        {
            this.ID = id;
            this.Password = pass;
        }
        ~Manager()
        {
        }
    }
}
