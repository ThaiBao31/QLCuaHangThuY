namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_HDBH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HDBH));
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvDataHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnThem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSua = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuĐìnhChỉToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvDataCTHD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbkKhachHang = new System.Windows.Forms.ComboBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_DmKhachHang = new PMQuanLyCuaHangThuY.ds_DmKhachHang();
            this.kHACHHANGTableAdapter = new PMQuanLyCuaHangThuY.ds_DmKhachHangTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DmKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 635);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 468;
            this.label8.Text = "Đến ngày";
            // 
            // dtgvDataHD
            // 
            this.dtgvDataHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDataHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataHD.Location = new System.Drawing.Point(4, 66);
            this.dtgvDataHD.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataHD.Name = "dtgvDataHD";
            this.dtgvDataHD.RowHeadersWidth = 51;
            this.dtgvDataHD.Size = new System.Drawing.Size(998, 255);
            this.dtgvDataHD.TabIndex = 467;
            this.dtgvDataHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataHD_CellClick);
            this.dtgvDataHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataHD_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 635);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 471;
            this.label1.Text = "Từ ngày";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(861, 632);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 470;
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
            this.thanhToánToolStripMenuItem,
            this.xuấtExcelToolStripMenuItem,
            this.làmMớiToolStripMenuItem,
            this.dữLiệuĐìnhChỉToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 28);
            this.menuStrip1.TabIndex = 466;
            this.menuStrip1.Text = "menuStrip1";
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
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.btnSua.Size = new System.Drawing.Size(68, 24);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.money;
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("làmMớiToolStripMenuItem.Image")));
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // dữLiệuĐìnhChỉToolStripMenuItem
            // 
            this.dữLiệuĐìnhChỉToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.delete;
            this.dữLiệuĐìnhChỉToolStripMenuItem.Name = "dữLiệuĐìnhChỉToolStripMenuItem";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.dữLiệuĐìnhChỉToolStripMenuItem.Text = "Dữ liệu đình chỉ";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuĐìnhChỉToolStripMenuItem_Click);
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.printer;
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // xuấtExcelToolStripMenuItem
            // 
            this.xuấtExcelToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.icons8_excel_48;
            this.xuấtExcelToolStripMenuItem.Name = "xuấtExcelToolStripMenuItem";
            this.xuấtExcelToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.xuấtExcelToolStripMenuItem.Text = "Xuất Excel";
            this.xuấtExcelToolStripMenuItem.Click += new System.EventHandler(this.xuấtExcelToolStripMenuItem_Click);
            // 
            // dtgvDataCTHD
            // 
            this.dtgvDataCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDataCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataCTHD.Location = new System.Drawing.Point(4, 360);
            this.dtgvDataCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataCTHD.Name = "dtgvDataCTHD";
            this.dtgvDataCTHD.RowHeadersWidth = 51;
            this.dtgvDataCTHD.Size = new System.Drawing.Size(998, 246);
            this.dtgvDataCTHD.TabIndex = 473;
            this.dtgvDataCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataCTHD_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 474;
            this.label2.Text = "Danh sách hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 475;
            this.label3.Text = "Chi tiết";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(83, 634);
            this.dtNgay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(180, 22);
            this.dtNgay1.TabIndex = 476;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtNgay1.ValueChanged += new System.EventHandler(this.dtNgay1_ValueChanged);
            // 
            // dtNgay2
            // 
            this.dtNgay2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(362, 634);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(180, 22);
            this.dtNgay2.TabIndex = 477;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 635);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 478;
            this.label4.Text = "Khách hàng";
            // 
            // lbkKhachHang
            // 
            this.lbkKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbkKhachHang.DataSource = this.kHACHHANGBindingSource;
            this.lbkKhachHang.DisplayMember = "TENKH";
            this.lbkKhachHang.FormattingEnabled = true;
            this.lbkKhachHang.Location = new System.Drawing.Point(668, 635);
            this.lbkKhachHang.Name = "lbkKhachHang";
            this.lbkKhachHang.Size = new System.Drawing.Size(166, 24);
            this.lbkKhachHang.TabIndex = 479;
            this.lbkKhachHang.ValueMember = "MAKH";
            this.lbkKhachHang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.ds_DmKhachHang;
            // 
            // ds_DmKhachHang
            // 
            this.ds_DmKhachHang.DataSetName = "ds_DmKhachHang";
            this.ds_DmKhachHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // UC_HDBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.lbkKhachHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvDataCTHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvDataHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_HDBH";
            this.Size = new System.Drawing.Size(1006, 675);
            this.Load += new System.EventHandler(this.UC_HDBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DmKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvDataHD;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
        private System.Windows.Forms.ToolStripMenuItem btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dtgvDataCTHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuĐìnhChỉToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lbkKhachHang;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private ds_DmKhachHang ds_DmKhachHang;
        private ds_DmKhachHangTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem xuấtExcelToolStripMenuItem;
    }
}
