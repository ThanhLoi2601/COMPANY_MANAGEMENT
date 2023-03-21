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
    public partial class FAbsenceLetter : Form
    {
        AbsenceLetterDAO ab = new AbsenceLetterDAO();
        StaffDAO s = new StaffDAO();
        string ID;
        public FAbsenceLetter(string id)
        {
            InitializeComponent();
            this.ID = id;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string reason = "";

            if (rbRea1.Checked)
            {
                reason = rbRea1.Text;
            }
            else if (rbRea2.Checked)
            {
                reason = rbRea2.Text;
            }
            else if (rbRea3.Checked)
            {
                reason = rbRea3.Text;
            }
            else
            {
                reason = textReason.Text;
            }

            AbsenceLetter lt = new AbsenceLetter(textID.Text, textName.Text, reason, dateStart.Value, dateEnd.Value);

            if (textID.Text != ID)
            {
                MessageBox.Show("Mã nhân viên không hợp lệ");
            }
            else
            {
                ab.UpdateAbsen(lt);
                MessageBox.Show("Gửi đơn xin nghỉ thành công");
                this.Close();
            }
        }

        private void rbRea4_CheckedChanged(object sender, EventArgs e)
        {
            textReason.Visible = rbRea4.Checked;
        }
    }
}
