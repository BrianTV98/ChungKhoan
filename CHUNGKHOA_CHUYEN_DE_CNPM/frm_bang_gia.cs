using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CHUNGKHOA_CHUYEN_DE_CNPM
{
    public partial class frm_bang_gia : Form
    {
        
        public string m_connect = @"Data Source=DESKTOP-0M1C7IP;Initial Catalog=CHUNGKHOAN;Integrated Security =True;User id=sa;Password=123;";
        SqlConnection con = null;
        public delegate void BangGiaDelegate();
        public event BangGiaDelegate bangGiaDelegate;

        public frm_bang_gia()
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

        private void frm_bang_gia_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.gvBangGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvBangGia.SetBounds(0, 0, this.Size.Width, (int)(this.Size.Height * 0.7));
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
