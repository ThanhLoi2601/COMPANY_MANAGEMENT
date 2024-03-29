﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT.OOP
{
    class Manager
    {
        private string id;
        private string name;
        private DateTime birth;
        private string idCard;
        private string email;
        private string address;
        private int basicSalary;
        private string password;

        public string ID { get { return id; } set { id = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Name { get { return name; } set { name = value; } }
        public DateTime Birth { get { return birth; } set { birth = value; } }
        public string IDCard { get { return idCard; } set { idCard = value; } }
        public string Email { get { return email; } set{ email = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int BasicSalary { get { return basicSalary; } set { basicSalary = value; } }

        public Manager()
        {
        }
        public Manager(string ID, string Ten, DateTime birthday, string id_Card, string EMAIL, string add, int bSalary, string pass)
        {
            this.id = ID;
            this.name = Ten;
            this.birth = birthday;
            this.idCard = id_Card;
            this.email = EMAIL;
            this.address = add;
            this.basicSalary = bSalary;
            this.password = pass;
        }

        public Manager(string ID, string pass)
        {
            this.id = ID;
            this.password = pass;
        }
        ~Manager()
        {
        }

        public string toStringMan()
        {
            return string.Format("'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", id, name, birth.ToString("yyyy-MM-dd"), idCard, email, address, basicSalary, password); 
        }
        public string toStringInfo()
        {
            return string.Format("ID= '{0}', Name= '{1}', Birth= '{2}', ID_Card= '{3}', Email= '{4}', Address= '{5}', Basic_salary= '{6}', Password= '{7}' "
                , id, name, birth.ToString("yyyy-MM-dd"), idCard, email, address, basicSalary, password);
        }
    }
}
