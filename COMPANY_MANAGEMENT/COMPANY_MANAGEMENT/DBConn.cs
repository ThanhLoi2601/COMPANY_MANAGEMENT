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
    }
}

