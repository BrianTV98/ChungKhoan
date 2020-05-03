namespace CHUNGKHOA_CHUYEN_DE_CNPM
{
    partial class frm_dat_lenh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmDatLenh_cb_loai_lenh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmDatLenh_cbMaCK = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frmDatLenh_lbKLMuaToiDa = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.frmDatLenh_lbTLenhDat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.framDatLenh_lbThamChieu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.frmDatLenh_lbSan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.frmDatLenh_lbTran = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.frmDatlenh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.frmDatLenh_btnDatLenh = new System.Windows.Forms.Button();
            this.cb_soluong = new System.Windows.Forms.TextBox();
            this.edit_giaGD = new System.Windows.Forms.TextBox();
            this.panelDatLenh = new System.Windows.Forms.Panel();
            this.gvBangGia = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panelDatLenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // frmDatLenh_cb_loai_lenh
            // 
            this.frmDatLenh_cb_loai_lenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmDatLenh_cb_loai_lenh.FormattingEnabled = true;
            this.frmDatLenh_cb_loai_lenh.Items.AddRange(new object[] {
            "Mua",
            "Bán"});
            this.frmDatLenh_cb_loai_lenh.Location = new System.Drawing.Point(35, 58);
            this.frmDatLenh_cb_loai_lenh.Name = "frmDatLenh_cb_loai_lenh";
            this.frmDatLenh_cb_loai_lenh.Size = new System.Drawing.Size(121, 24);
            this.frmDatLenh_cb_loai_lenh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lệnh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmDatLenh_cbMaCK
            // 
            this.frmDatLenh_cbMaCK.FormattingEnabled = true;
            this.frmDatLenh_cbMaCK.Location = new System.Drawing.Point(182, 58);
            this.frmDatLenh_cbMaCK.Name = "frmDatLenh_cbMaCK";
            this.frmDatLenh_cbMaCK.Size = new System.Drawing.Size(121, 24);
            this.frmDatLenh_cbMaCK.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã CK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmDatLenh_lbKLMuaToiDa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.frmDatLenh_lbTLenhDat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.framDatLenh_lbThamChieu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.frmDatLenh_lbSan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.frmDatLenh_lbTran);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Location = new System.Drawing.Point(16, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1003, 49);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // frmDatLenh_lbKLMuaToiDa
            // 
            this.frmDatLenh_lbKLMuaToiDa.AutoSize = true;
            this.frmDatLenh_lbKLMuaToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDatLenh_lbKLMuaToiDa.ForeColor = System.Drawing.Color.Red;
            this.frmDatLenh_lbKLMuaToiDa.Location = new System.Drawing.Point(934, 18);
            this.frmDatLenh_lbKLMuaToiDa.Name = "frmDatLenh_lbKLMuaToiDa";
            this.frmDatLenh_lbKLMuaToiDa.Size = new System.Drawing.Size(28, 18);
            this.frmDatLenh_lbKLMuaToiDa.TabIndex = 9;
            this.frmDatLenh_lbKLMuaToiDa.Text = "0:0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(825, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "KL mua tối đa: ";
            // 
            // frmDatLenh_lbTLenhDat
            // 
            this.frmDatLenh_lbTLenhDat.AutoSize = true;
            this.frmDatLenh_lbTLenhDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDatLenh_lbTLenhDat.ForeColor = System.Drawing.Color.Red;
            this.frmDatLenh_lbTLenhDat.Location = new System.Drawing.Point(687, 18);
            this.frmDatLenh_lbTLenhDat.Name = "frmDatLenh_lbTLenhDat";
            this.frmDatLenh_lbTLenhDat.Size = new System.Drawing.Size(28, 18);
            this.frmDatLenh_lbTLenhDat.TabIndex = 7;
            this.frmDatLenh_lbTLenhDat.Text = "0:0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(544, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tông giá trị đặt lệnh:";
            // 
            // framDatLenh_lbThamChieu
            // 
            this.framDatLenh_lbThamChieu.AutoSize = true;
            this.framDatLenh_lbThamChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.framDatLenh_lbThamChieu.ForeColor = System.Drawing.Color.Red;
            this.framDatLenh_lbThamChieu.Location = new System.Drawing.Point(381, 18);
            this.framDatLenh_lbThamChieu.Name = "framDatLenh_lbThamChieu";
            this.framDatLenh_lbThamChieu.Size = new System.Drawing.Size(28, 18);
            this.framDatLenh_lbThamChieu.TabIndex = 5;
            this.framDatLenh_lbThamChieu.Text = "0:0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tham chiếu :";
            // 
            // frmDatLenh_lbSan
            // 
            this.frmDatLenh_lbSan.AutoSize = true;
            this.frmDatLenh_lbSan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDatLenh_lbSan.ForeColor = System.Drawing.Color.Red;
            this.frmDatLenh_lbSan.Location = new System.Drawing.Point(148, 18);
            this.frmDatLenh_lbSan.Name = "frmDatLenh_lbSan";
            this.frmDatLenh_lbSan.Size = new System.Drawing.Size(28, 18);
            this.frmDatLenh_lbSan.TabIndex = 3;
            this.frmDatLenh_lbSan.Text = "0:0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sàn: ";
            // 
            // frmDatLenh_lbTran
            // 
            this.frmDatLenh_lbTran.AutoSize = true;
            this.frmDatLenh_lbTran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDatLenh_lbTran.ForeColor = System.Drawing.Color.Red;
            this.frmDatLenh_lbTran.Location = new System.Drawing.Point(59, 18);
            this.frmDatLenh_lbTran.Name = "frmDatLenh_lbTran";
            this.frmDatLenh_lbTran.Size = new System.Drawing.Size(28, 18);
            this.frmDatLenh_lbTran.TabIndex = 1;
            this.frmDatLenh_lbTran.Text = "0:0";
            this.frmDatLenh_lbTran.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(17, 18);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(46, 18);
            this.lb.TabIndex = 0;
            this.lb.Text = "Trần :";
            // 
            // frmDatlenh
            // 
            this.frmDatlenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.frmDatlenh.FormattingEnabled = true;
            this.frmDatlenh.Items.AddRange(new object[] {
            "LO"});
            this.frmDatlenh.Location = new System.Drawing.Point(498, 60);
            this.frmDatlenh.Name = "frmDatlenh";
            this.frmDatlenh.Size = new System.Drawing.Size(121, 24);
            this.frmDatlenh.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(495, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Loại Lệnh";
            // 
            // frmDatLenh_btnDatLenh
            // 
            this.frmDatLenh_btnDatLenh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.frmDatLenh_btnDatLenh.Font = new System.Drawing.Font("VNI 06 Springtime", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmDatLenh_btnDatLenh.ForeColor = System.Drawing.Color.White;
            this.frmDatLenh_btnDatLenh.Location = new System.Drawing.Point(1100, 44);
            this.frmDatLenh_btnDatLenh.Name = "frmDatLenh_btnDatLenh";
            this.frmDatLenh_btnDatLenh.Size = new System.Drawing.Size(108, 36);
            this.frmDatLenh_btnDatLenh.TabIndex = 16;
            this.frmDatLenh_btnDatLenh.Text = "ĐẶT LỆNH";
            this.frmDatLenh_btnDatLenh.UseVisualStyleBackColor = false;
            this.frmDatLenh_btnDatLenh.Click += new System.EventHandler(this.frmDatLenh_btnDatLenh_Click);
            // 
            // cb_soluong
            // 
            this.cb_soluong.Location = new System.Drawing.Point(323, 58);
            this.cb_soluong.Name = "cb_soluong";
            this.cb_soluong.Size = new System.Drawing.Size(121, 22);
            this.cb_soluong.TabIndex = 18;
            // 
            // edit_giaGD
            // 
            this.edit_giaGD.Location = new System.Drawing.Point(667, 62);
            this.edit_giaGD.Name = "edit_giaGD";
            this.edit_giaGD.Size = new System.Drawing.Size(121, 22);
            this.edit_giaGD.TabIndex = 19;
            // 
            // panelDatLenh
            // 
            this.panelDatLenh.Controls.Add(this.label3);
            this.panelDatLenh.Controls.Add(this.edit_giaGD);
            this.panelDatLenh.Controls.Add(this.frmDatLenh_cb_loai_lenh);
            this.panelDatLenh.Controls.Add(this.cb_soluong);
            this.panelDatLenh.Controls.Add(this.label1);
            this.panelDatLenh.Controls.Add(this.frmDatLenh_btnDatLenh);
            this.panelDatLenh.Controls.Add(this.frmDatLenh_cbMaCK);
            this.panelDatLenh.Controls.Add(this.label11);
            this.panelDatLenh.Controls.Add(this.label2);
            this.panelDatLenh.Controls.Add(this.frmDatlenh);
            this.panelDatLenh.Controls.Add(this.label4);
            this.panelDatLenh.Controls.Add(this.groupBox1);
            this.panelDatLenh.Location = new System.Drawing.Point(12, 628);
            this.panelDatLenh.Name = "panelDatLenh";
            this.panelDatLenh.Size = new System.Drawing.Size(1463, 150);
            this.panelDatLenh.TabIndex = 20;
            // 
            // gvBangGia
            // 
            this.gvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangGia.Location = new System.Drawing.Point(12, 12);
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.RowTemplate.Height = 24;
            this.gvBangGia.Size = new System.Drawing.Size(1116, 597);
            this.gvBangGia.TabIndex = 21;
            // 
            // frm_dat_lenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1507, 790);
            this.Controls.Add(this.gvBangGia);
            this.Controls.Add(this.panelDatLenh);
            this.Name = "frm_dat_lenh";
            this.Text = "Đặt lệnh";
            this.Load += new System.EventHandler(this.frm_dat_lenh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDatLenh.ResumeLayout(false);
            this.panelDatLenh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox frmDatLenh_cb_loai_lenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox frmDatLenh_cbMaCK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label frmDatLenh_lbTran;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label frmDatLenh_lbKLMuaToiDa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label frmDatLenh_lbTLenhDat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label framDatLenh_lbThamChieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label frmDatLenh_lbSan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox frmDatlenh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button frmDatLenh_btnDatLenh;
        private System.Windows.Forms.TextBox cb_soluong;
        private System.Windows.Forms.TextBox edit_giaGD;
        private System.Windows.Forms.Panel panelDatLenh;
        private System.Windows.Forms.DataGridView gvBangGia;
    }
}

