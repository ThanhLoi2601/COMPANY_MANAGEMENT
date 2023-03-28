namespace COMPANY_MANAGEMENT
{
    public partial class FLeader : Form
    {
        public FLeader()
        {
            InitializeComponent();
        }

        private void btContract_Click(object sender, EventArgs e)
        {
            FContract contract = new FContract();
            contract.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FProject project = new FProject();
            project.ShowDialog();
        }
    }
}