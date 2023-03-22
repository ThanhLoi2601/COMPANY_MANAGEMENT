using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class Customer
    {
        private string id;
        private string name;
        private string idCard;
        private string email;
        private string phone;
        private string address;
        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string IDCard { get { return idCard; } set { idCard = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }

        public Customer() { }
        public Customer(string _id, string _name, string _idCard, string _email, string _phone, string _address)
        {
            this.id = _id;
            this.name = _name;
            this.idCard = _idCard;
            this.email = _email;
            this.phone = _phone;
            this.Address = _address;
        }
        ~Customer() { }
    }
}
