using System;

namespace COMPANY_MANAGEMENT.OOP
{
    class Contact
    {
        private string idSent;
        private string nameSent;
        private string subject;
        private string content;
        private string idReceive;
        private DateTime infoDate;

        public string IDSent { get { return idSent; } set { idSent = value; } }
        public string NameSent { get { return nameSent; } set { nameSent = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string Content { get { return content; } set { content = value; } }
        public string IDReceive { get { return idReceive; } set { idReceive = value; } }
        public DateTime InfoDate { get { return infoDate; } set { infoDate = value; } }


        public Contact() { }
        public Contact(string idS, string NSent, string sub, string cont, string idRe,DateTime date)
        {
            IDSent = idS;
            NameSent = NSent;
            Subject = sub;
            Content = cont;
            IDReceive = idRe;
            InfoDate = date;
        }

        ~Contact() { }
    }
}
