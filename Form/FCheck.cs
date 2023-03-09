using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT
{
    public partial class FCheck : Form
    {
        //private bool MyCheckboxChecked;
        public FCheck()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void FCheck_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            //Properties.Settings.Default.MyCheckboxChecked = checkBox1.Checked;
            //Properties.Settings.Default.Save();
        }

        public bool CanCheckIn()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 7, 0, 0);
            if (currentTime < checkoutTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanCheckOut()
        {
            DateTime currentTime = DateTime.Now;
            DateTime checkoutTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 8, 0, 0);
            if (currentTime < checkoutTime)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked && CanCheckIn() && checkBox2.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Check in thành công");
            }
            else if (checkBox1.CheckState == CheckState.Checked && !CanCheckIn() && checkBox2.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Check in thành công, bạn tới muộn");
            }
            else if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Bạn chưa check in, vui lòng check in trước");
                checkBox1.Focus();
                //checkBox2.CheckState = CheckState.Unchecked;
            }
            else if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked && CanCheckOut())
            {
                MessageBox.Show("Check out thành công");
            }
            else if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked && !CanCheckIn())
            {
                MessageBox.Show("Check out thất bại,chưa tới giờ check out");
                checkBox2.CheckState = CheckState.Unchecked;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("Vui lòng check");
            }
            else
            {
                MessageBox.Show("Check thành công");
            }
        }
    }
}