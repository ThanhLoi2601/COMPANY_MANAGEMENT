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
    public partial class FLeader : Form
    {
        string IDReceive;

        public FLeader()
        {
            InitializeComponent();
        }

        public FLeader(string ID)
        {
            InitializeComponent();
            IDReceive = ID;
        }
    }
}