using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using COMPANY_MANAGEMENT.OOP;

namespace COMPANY_MANAGEMENT
{
    class DBConn
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

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
        public void ExecutiveWithoutNotice(string sqlStr)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
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
                MessageBox.Show("FAILED EXECUTION ...\n" + ex, "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("FAILED EXECUTION", "ANNOUNCEMENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
        public Task FindTask(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Task task = new Task();
                    task.Id = reader.GetString(0);
                    task.Name = reader.GetString(1);
                    task.DateStart = reader.GetDateTime(2);
                    task.DateEnd = reader.GetDateTime(3);
                    task.Description = reader.GetString(4);
                    task.Status = (Task.TaskStatus)Enum.Parse(typeof(Task.TaskStatus), reader.GetString(5));
                    task.GetStatus();
                    task.Id_project = reader.GetString(6);
                    return task;
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
    }
}

