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
        public string m_connect = Program.rootSeverName;
        SqlConnection con = null;
        public delegate void BangGiaDelegate();
        public event BangGiaDelegate bangGiaDelegate;

        public frm_dat_lenh()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);
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
                MessageBox.Show("Loi ko chay dc sp " + ex, "Lỗi Phần Mềm", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
            }
            if (kq == -1)
            {
                MessageBox.Show("Loi"," Loi ket noi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Program.conn.Close();
        }

        private void frm_dat_lenh_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.gvBangGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvBangGia.SetBounds(0, 0, this.Size.Width, (int)(this.Size.Height * 0.7));
            panelDatLenh.SetBounds(0, (int)(this.Size.Height * 0.7), this.Size.Width, (int)(this.Size.Height * 0.3));
            bangGiaDelegate += new BangGiaDelegate(startDependency);//tab
            //load data vao datagrid
            LoadData();
        }


        public void startDependency()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                BangGiaDelegate dd = new BangGiaDelegate(startDependency);
                i.BeginInvoke(dd, null);
                return;
            }
            LoadData();

        }

        //Ham load data
        void LoadData()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT   MACP, MG2, MK2, MG1, MK1, GKHOP, KLKHOP, BG1, BK1, BG2, BK2  from dbo.GIATRUCTUYEN", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            gvBangGia.DataSource = dt;

            gvBangGia.Columns[0].HeaderText = "Mã cổ phiếu";
            gvBangGia.Columns[1].HeaderText = "Giá mua 2";
            gvBangGia.Columns[2].HeaderText = "KL mua 2";
            gvBangGia.Columns[3].HeaderText = "Giá mua 1";
            gvBangGia.Columns[4].HeaderText = "KL mua 1";
            gvBangGia.Columns[5].HeaderText = "Giá khớp";
            gvBangGia.Columns[6].HeaderText = "KL khớp";
            gvBangGia.Columns[7].HeaderText = "Giá bán 1";
            gvBangGia.Columns[8].HeaderText = "KL bán 1";
            gvBangGia.Columns[9].HeaderText = "Giá bán 2";
            gvBangGia.Columns[10].HeaderText = "KL bán 2";

            gvBangGia.EnableHeadersVisualStyles = false;
            gvBangGia.Columns[1].HeaderCell.Style.BackColor = Color.LightBlue;
            gvBangGia.Columns[2].HeaderCell.Style.BackColor = Color.LightBlue;
            gvBangGia.Columns[3].HeaderCell.Style.BackColor = Color.LightBlue;
            gvBangGia.Columns[4].HeaderCell.Style.BackColor = Color.LightBlue;
            gvBangGia.Columns[5].HeaderCell.Style.BackColor = Color.LightGreen;
            gvBangGia.Columns[6].HeaderCell.Style.BackColor = Color.LightGreen;
            gvBangGia.Columns[7].HeaderCell.Style.BackColor = Color.PaleVioletRed;
            gvBangGia.Columns[8].HeaderCell.Style.BackColor = Color.PaleVioletRed;
            gvBangGia.Columns[9].HeaderCell.Style.BackColor = Color.PaleVioletRed;
            gvBangGia.Columns[10].HeaderCell.Style.BackColor = Color.PaleVioletRed;

        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (bangGiaDelegate != null)
            {
                bangGiaDelegate();
            }
        }
    }
}
