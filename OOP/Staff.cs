using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class Staff
    {
        private string id;
        private string name;
        private DateTime birth;
        private string id_card;
        private string email;
        private string address;
        private string manager_id;
        private int basic_salary;
        private string password;

        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Birth { get { return birth; } set { birth = value; } }
        public string ID_Card { get { return id_card; } set { id_card = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string ManagerId { get { return manager_id; } set { manager_id = value; } }
        public int BasicSalary { get { return basic_salary; } set { basic_salary = value; } }
        public string Password { get { return password; } set { password = value; } }

        public Staff()
        {
        }
        public Staff(string id, string ten, DateTime birthday, string id_card, string email, string add, string manager_id, int bSalary, string pass)
        {
            this.ID = id;
            this.Name = ten;
            this.Birth = birthday;
            this.ID_Card = id_card;
            this.Email = email;
            this.Address = add;
            this.ManagerId = manager_id;
            this.BasicSalary = bSalary;
            this.Password = pass;
        }

        public Staff(string id, string pass)
        {
            this.ID = id;
            this.Password = pass;
        }
        ~Staff()
        {
        }
    }
}
