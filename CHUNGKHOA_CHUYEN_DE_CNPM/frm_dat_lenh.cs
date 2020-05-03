using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHUNGKHOA_CHUYEN_DE_CNPM
{
    public partial class frm_dat_lenh : Form
    {
        public frm_dat_lenh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmDatLenh_btnDatLenh_Click(object sender, EventArgs e)
        {
            int kq = -1;
            String macp = frmDatLenh_cbMaCK.Text.ToString().Trim();
            String ngay = DateTime.Now.ToString();
            String loaiGD = (frmDatLenh_cb_loai_lenh.Text.ToString().Trim()=="Mua"? "M":"B");
            int soluongGD = int.Parse( cb_soluong.Text.ToString());
            String giaGD = edit_giaGD.Text.ToString();
            Program.conn.ConnectionString = Program.rootSeverName;
            int kn = Program.KetNoi();
            if (kn == 0)
            {
                MessageBox.Show("Lỗi kết nối! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SqlCommand sqlCommand = new SqlCommand("SP_KHOPLENH_LO", Program.conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@macp", macp);
            sqlCommand.Parameters.AddWithValue("@Ngay", ngay);
            sqlCommand.Parameters.AddWithValue("@LoaiGD", loaiGD);
            sqlCommand.Parameters.AddWithValue("@soluongMB", soluongGD);
            sqlCommand.Parameters.AddWithValue("@giadatMB", giaGD);

            MessageBox.Show(Program.conn.ToString(), " Loi ket noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(Program.conn);
            Console.WriteLine(sqlCommand.CommandText);

            try
            {
                 kq = Program.execStoreProcedureWithReturnValue(sqlCommand);
                if(kq!=-1)
                MessageBox.Show("Thanh cong", " Thanh Cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kiểm tra được số câu hỏi có trong hệ thống " + ex, "Lỗi Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            if (kq == -1)
            {
                MessageBox.Show("Loi"," Loi ket noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Program.conn.Close();
        }
    }
}
