﻿namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_KhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KhachHang));
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXuatExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dữLiệuĐìnhChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbkLoai = new System.Windows.Forms.ComboBox();
            this.nHOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNhomKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_NhomKH = new PMQuanLyCuaHangThuY.ds_NhomKH();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.nHOMTableAdapter = new PMQuanLyCuaHangThuY.ds_NhomKHTableAdapters.NHOMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhomKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_NhomKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(146, 97);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 22);
            this.txtTen.TabIndex = 455;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 454;
            this.label8.Text = "Tên khách hàng";
            // 
            // dtgvData
            // 
            this.dtgvData.BackgroundColor = System.Drawing.Color.White;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvData.Location = new System.Drawing.Point(3, 18);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.Size = new System.Drawing.Size(961, 449);
            this.dtgvData.TabIndex = 453;
            this.dtgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellContentClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.btnLamMoi.Size = new System.Drawing.Size(101, 24);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.btnXuatExcel.Size = new System.Drawing.Size(111, 24);
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.btnXoa.Size = new System.Drawing.Size(69, 24);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.btnSua.Size = new System.Drawing.Size(68, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.btnThem.Size = new System.Drawing.Size(110, 24);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.Location = new System.Drawing.Point(146, 45);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(187, 22);
            this.txtMa.TabIndex = 458;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 457;
            this.label1.Text = "Mã khách hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(11, 249);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 456;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnXuatExcel,
            this.btnLamMoi,
            this.dữLiệuĐìnhChỉToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 28);
            this.menuStrip1.TabIndex = 452;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dữLiệuĐìnhChỉToolStripMenuItem
            // 
            this.dữLiệuĐìnhChỉToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.delete;
            this.dữLiệuĐìnhChỉToolStripMenuItem.Name = "dữLiệuĐìnhChỉToolStripMenuItem";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.dữLiệuĐìnhChỉToolStripMenuItem.Text = "Dữ liệu đình chỉ";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuĐìnhChỉToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvData);
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(967, 470);
            this.groupBox1.TabIndex = 459;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbkLoai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMa);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox2.Location = new System.Drawing.Point(973, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 449);
            this.groupBox2.TabIndex = 460;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(146, 194);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(187, 22);
            this.txtDiaChi.TabIndex = 464;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 463;
            this.label3.Text = "Địa chỉ";
            // 
            // lbkLoai
            // 
            this.lbkLoai.DataSource = this.nHOMBindingSource;
            this.lbkLoai.DisplayMember = "TENNHOM";
            this.lbkLoai.FormattingEnabled = true;
            this.lbkLoai.Location = new System.Drawing.Point(146, 146);
            this.lbkLoai.Name = "lbkLoai";
            this.lbkLoai.Size = new System.Drawing.Size(187, 24);
            this.lbkLoai.TabIndex = 459;
            this.lbkLoai.ValueMember = "MANHOM";
            this.lbkLoai.SelectedIndexChanged += new System.EventHandler(this.lbkLoai_SelectedIndexChanged);
            // 
            // nHOMBindingSource
            // 
            this.nHOMBindingSource.DataMember = "NHOM";
            this.nHOMBindingSource.DataSource = this.dsNhomKHBindingSource;
            // 
            // dsNhomKHBindingSource
            // 
            this.dsNhomKHBindingSource.DataSource = this.ds_NhomKH;
            this.dsNhomKHBindingSource.Position = 0;
            // 
            // ds_NhomKH
            // 
            this.ds_NhomKH.DataSetName = "ds_NhomKH";
            this.ds_NhomKH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 454;
            this.label2.Text = "Nhóm KH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(3, 529);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(44, 16);
            this.lblTotalRecords.TabIndex = 461;
            this.lblTotalRecords.Text = "label3";
            // 
            // nHOMTableAdapter
            // 
            this.nHOMTableAdapter.ClearBeforeFill = true;
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.lblTotalRecords);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1324, 554);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhomKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_NhomKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.ToolStripMenuItem btnLamMoi;
        private System.Windows.Forms.ToolStripMenuItem btnXuatExcel;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.ComboBox lbkLoai;
        private System.Windows.Forms.BindingSource nHOMBindingSource;
        private System.Windows.Forms.BindingSource dsNhomKHBindingSource;
        private ds_NhomKH ds_NhomKH;
        private ds_NhomKHTableAdapters.NHOMTableAdapter nHOMTableAdapter;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuĐìnhChỉToolStripMenuItem;
    }
}
