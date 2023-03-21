using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COMPANY_MANAGEMENT
{
    public partial class FInformation : Form
    {
        StaffDAO s = new StaffDAO();
        string ID;
        public FInformation(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            this.LoadMyInfo();
        }

        private void LoadMyInfo()
        {
            Staff man = s.Search(ID);
            textID.Text = man.ID;
            textName.Text = man.Name;
            dateOfBirth.Value = man.Birth;
            textIDcard.Text = man.ID_Card;
            textMail.Text = man.Email;
            textNum.Text = man.NumPhone;
            textPlace.Text = man.Address;
            textManID.Text = man.ManagerId;
            textSalary.Text = man.BasicSalary.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Staff a = new Staff(textName.Text, dateOfBirth.Value, textIDcard.Text, textMail.Text, textNum.Text, textPlace.Text, ID);
            s.Update(a);
        }
    }
}

