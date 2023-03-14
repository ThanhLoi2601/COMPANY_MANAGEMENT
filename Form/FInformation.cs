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
        public FInformation()
        {
            InitializeComponent();
        }

        private void FInformation_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DBStaff;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Staff WHERE ID= @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", textID.Text);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textID.Text = reader["ID"].ToString();
                textName.Text = reader["Name"].ToString();
                dateOfBirth.Value = (DateTime)reader["Birth"];
                textIDcard.Text = reader["ID_Card"].ToString();
                textMail.Text = reader["Email"].ToString();
                textNum.Text = reader["PhoneNumber"].ToString();
                textPlace.Text = reader["Address"].ToString();
                textManID.Text = reader["Manager_ID"].ToString();
                textSalary.Text = reader["Basic_salary"].ToString();
            }
            else
            {
                MessageBox.Show("Không thể load thông tin");
            }

            reader.Close();
            connection.Close();
        }
    }
}

