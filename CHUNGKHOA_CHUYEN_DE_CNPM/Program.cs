using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOA_CHUYEN_DE_CNPM
{
    static class Program
    {
        public static String rootSeverName = "Data Source=HIEU;Initial Catalog=CHUNGKHOAN;Persist Security Info=True;User ID=sa;Password=123";

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
               
                Program.conn.ConnectionString = Program.rootSeverName;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password :(.\n " + Program.connstr, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int execStoreProcedureWithReturnValue(SqlCommand sqlcmd)
        {
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlParameter retval = sqlcmd.Parameters.Add("@return_value", SqlDbType.Int);
            retval.Direction = ParameterDirection.ReturnValue;
            try { sqlcmd.ExecuteNonQuery(); }
            catch (Exception) { }
            string tmp = sqlcmd.Parameters["@return_value"].Value.ToString();
            if (tmp == null)
            {
                MessageBox.Show("Lỗi lập trình! Sp hoặc đối số của sp có vấn đề!");
            }
            return int.Parse(tmp);

        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;


            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_dat_lenh());
        }
    }
}
