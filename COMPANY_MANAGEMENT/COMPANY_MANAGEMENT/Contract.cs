using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPANY_MANAGEMENT
{
    class Contract
    {
        private string id;
        private string name;
        private DateTime signingDate;
        private DateTime settlementTerm;
        private DateTime endingDate;
        private int price;
        private string content;
        public string idNV;
        public string idKH;
        public string ID { get { return id; } set { id = value; } }
        public string nameNV { get { return name; } set { name = value; } }
        public DateTime SigningDate { get { return signingDate; } set { signingDate = value; } }
        public DateTime SettlementTerm { get { return settlementTerm; } set { settlementTerm = value; } }
        public DateTime EndingDate { get { return endingDate; } set { endingDate = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Content { get { return content; } set { content = value; } }
        public string IdNV { get { return idNV; } set { idNV = value; } }
        public string IdKH { get { return idKH; } set { idKH = value; } }
        public Contract() {}
        public Contract(string _id, string _name, DateTime _signingDate, DateTime _settlementTerm, DateTime _endingDate, int _price, string _content, string _idNV, string _idKH)
        {
            this.id = _id;
            this.name = _name;
            this.signingDate = _signingDate;
            this.settlementTerm = _settlementTerm;
            this.endingDate = _endingDate;
            this.price = _price;
            this.content = _content;
            this.idNV = _idNV;
            this.idKH = _idKH;
        }
        ~Contract() { }
    }
}
