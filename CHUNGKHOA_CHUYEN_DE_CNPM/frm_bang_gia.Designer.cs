namespace CHUNGKHOA_CHUYEN_DE_CNPM
{
    partial class frm_bang_gia
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
            this.gvBangGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBangGia
            // 
            this.gvBangGia.AllowUserToAddRows = false;
            this.gvBangGia.AllowUserToDeleteRows = false;
            this.gvBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBangGia.Location = new System.Drawing.Point(2, -2);
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.ReadOnly = true;
            this.gvBangGia.RowHeadersWidth = 82;
            this.gvBangGia.RowTemplate.Height = 33;
            this.gvBangGia.Size = new System.Drawing.Size(2315, 1402);
            this.gvBangGia.TabIndex = 0;
            // 
            // frm_bang_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2274, 1412);
            this.Controls.Add(this.gvBangGia);
            this.Name = "frm_bang_gia";
            this.Text = "Bảng giá trực tuyến";
            this.Load += new System.EventHandler(this.frm_bang_gia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvBangGia;
    }
}