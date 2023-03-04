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
        }
    }
}
