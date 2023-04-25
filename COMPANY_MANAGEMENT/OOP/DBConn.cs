using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace COMPANY_MANAGEMENT.OOP
{
    class DBConn
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.con);

        public DataTable LoadList(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public void Executive(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("SUCCESSFUL EXECUTION !!", "ANNOUNCEMENT", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Search(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if ((Int32)cmd.ExecuteScalar() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("FAILED EXECUTION", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public Staff FindStaff(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    string id_man = reader.GetString(6);
                    int bSalary = reader.GetInt32(7);
                    string pass = reader.GetString(8);
                    return new Staff(id, name, birth, id_card, email, address, id_man ,bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Manager FindManager(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    int bSalary = reader.GetInt32(6);
                    string pass = reader.GetString(7);
                    return new Manager(id, name, birth, id_card, email, address, bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Leader FindLeader(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    DateTime birth = reader.GetDateTime(2);
                    string id_card = reader.GetString(3);
                    string email = reader.GetString(4);
                    string address = reader.GetString(5);
                    int bSalary = reader.GetInt32(6);
                    string pass = reader.GetString(7);
                    return new Leader(id, name, birth, id_card, email, address, bSalary, pass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public Job FindJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string name = reader.GetString(1);
                    string content = reader.GetString(2);
                    DateTime datestart = reader.GetDateTime(3);
                    DateTime dateend = reader.GetDateTime(4);
                    int bonus = reader.GetInt32(5);
                    return new Job(id, name, content, datestart, dateend, bonus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public ProcessJob FindProcessJob(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetString(0);
                    string content = reader.GetString(1);
                    double proc = reader.GetDouble(2);
                    return new ProcessJob(id, content, proc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        
        public int Merge(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                Int32 num = (Int32)cmd.ExecuteScalar();
                conn.Close();
                return (int)num;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void ExecutiveWithoutNotice(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
