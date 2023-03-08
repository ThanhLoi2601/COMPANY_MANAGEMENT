﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    public class Leader
    {
        private string id;
        private string name;
        DateTime dateOfBirth;
        private string idCard;
        private string email;
        private string address;
        private string basicSalary;
        private string kPI;
        private string password;
        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } set { dateOfBirth = value; } }
        public string IDCard { get { return idCard; } set { idCard = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string BasicSalary { get { return basicSalary; } set { basicSalary = value; } }
        public string KPI { get { return kPI; } set { kPI = value; } }
        public string Password { get { return password; } set { password = value; } }
        
        public Leader() { }
        public Leader(string _id, string _name, DateTime _dateofbirth, string _idcard, string _email, string _address, string _basicsalary, string _kpi, string _password)
        {
            this.id = _id;
            this.name = _name;
            this.dateOfBirth = _dateofbirth;
            this.idCard = _idcard;
            this.email = _email;
            this.address = _address;
            this.basicSalary = _basicsalary; 
            this.kPI = _kpi;
            this.password = _password;
        }
        ~Leader() { }
    }
}
