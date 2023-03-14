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
    public partial class FChangePassWord : Form
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True";
        public FChangePassWord()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            string ID = textMaDN.Text;
            string currentPassword = textOldPass.Text;
            string newPassword = textNewPass.Text;
            string confirmNewPassword = textNewPassConfirm.Text;

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu confirm không chính xác");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Password FROM Staff WHERE ID = @ID";
                string query1 = "SELECT ID FROM Staff WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ID);
                string currentPasswordInDatabase = (string)command.ExecuteScalar();

                SqlCommand command1 = new SqlCommand(query1, connection);
                command1.Parameters.AddWithValue("@ID", ID);
                string currentIDInDatabase = (string)command1.ExecuteScalar();

                if (currentIDInDatabase != "EMP12345")
                {
                    MessageBox.Show("Mã đăng nhập không đúng");
                    return;
                }

                if (currentPasswordInDatabase != currentPassword)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng");
                    return;
                }

                query = "UPDATE Staff SET Password = @NewPassword WHERE ID = @ID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NewPassword", newPassword);
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Đổi mật khẩu thành công");
            this.Close();
        }
    }
}

