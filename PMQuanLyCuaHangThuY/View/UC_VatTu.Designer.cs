namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_VatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VatTu));
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
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbkLoai = new System.Windows.Forms.ComboBox();
            this.nHOMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_NhomVt = new PMQuanLyCuaHangThuY.Ds_NhomVt();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaDen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaTu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDvt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nHOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMTableAdapter = new PMQuanLyCuaHangThuY.Ds_NhomVtTableAdapters.NHOMTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_NhomVt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(119, 122);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 22);
            this.txtTen.TabIndex = 448;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 447;
            this.label8.Text = "Tên vật tư";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dtgvData
            // 
            this.dtgvData.BackgroundColor = System.Drawing.Color.White;
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(3, 18);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.Size = new System.Drawing.Size(1215, 354);
            this.dtgvData.TabIndex = 446;
            this.dtgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvData_CellContentClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.btnLamMoi.Size = new System.Drawing.Size(101, 24);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.icons8_excel_48;
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
            this.txtMa.Location = new System.Drawing.Point(119, 60);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(187, 22);
            this.txtMa.TabIndex = 451;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 450;
            this.label1.Text = "Mã vật tư";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(19, 356);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 449;
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
            this.menuStrip1.Size = new System.Drawing.Size(1576, 28);
            this.menuStrip1.TabIndex = 445;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dữLiệuĐìnhChỉToolStripMenuItem
            // 
            this.dữLiệuĐìnhChỉToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dữLiệuĐìnhChỉToolStripMenuItem.Image = global::PMQuanLyCuaHangThuY.Properties.Resources.delete;
            this.dữLiệuĐìnhChỉToolStripMenuItem.Name = "dữLiệuĐìnhChỉToolStripMenuItem";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.dữLiệuĐìnhChỉToolStripMenuItem.Text = "Dữ liệu đình chỉ";
            this.dữLiệuĐìnhChỉToolStripMenuItem.Click += new System.EventHandler(this.dữLiệuĐìnhChỉToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalRecords);
            this.groupBox1.Controls.Add(this.dtgvData);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1218, 412);
            this.groupBox1.TabIndex = 452;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách vật tư";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Location = new System.Drawing.Point(7, 385);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(44, 16);
            this.lblTotalRecords.TabIndex = 447;
            this.lblTotalRecords.Text = "label4";
            this.lblTotalRecords.Click += new System.EventHandler(this.lblTotalRecords_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbkLoai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMa);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtGiaDen);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGiaTu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDvt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(1260, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 391);
            this.groupBox2.TabIndex = 453;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc dữ liệu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbkLoai
            // 
            this.lbkLoai.DataSource = this.nHOMBindingSource1;
            this.lbkLoai.DisplayMember = "TENNHOM";
            this.lbkLoai.FormattingEnabled = true;
            this.lbkLoai.Location = new System.Drawing.Point(118, 215);
            this.lbkLoai.Name = "lbkLoai";
            this.lbkLoai.Size = new System.Drawing.Size(187, 24);
            this.lbkLoai.TabIndex = 453;
            this.lbkLoai.ValueMember = "MANHOM";
            this.lbkLoai.SelectedIndexChanged += new System.EventHandler(this.lbkLoai_SelectedIndexChanged);
            // 
            // nHOMBindingSource1
            // 
            this.nHOMBindingSource1.DataMember = "NHOM";
            this.nHOMBindingSource1.DataSource = this.ds_NhomVt;
            // 
            // ds_NhomVt
            // 
            this.ds_NhomVt.DataSetName = "Ds_NhomVt";
            this.ds_NhomVt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 452;
            this.label5.Text = "Nhóm";
            // 
            // txtGiaDen
            // 
            this.txtGiaDen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaDen.Location = new System.Drawing.Point(119, 307);
            this.txtGiaDen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaDen.Name = "txtGiaDen";
            this.txtGiaDen.Size = new System.Drawing.Size(187, 22);
            this.txtGiaDen.TabIndex = 448;
            this.txtGiaDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiaDen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 447;
            this.label4.Text = "Đến";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGiaTu
            // 
            this.txtGiaTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiaTu.Location = new System.Drawing.Point(119, 265);
            this.txtGiaTu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaTu.Name = "txtGiaTu";
            this.txtGiaTu.Size = new System.Drawing.Size(187, 22);
            this.txtGiaTu.TabIndex = 448;
            this.txtGiaTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiaTu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 265);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 447;
            this.label3.Text = "Đơn giá Từ";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDvt
            // 
            this.txtDvt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDvt.Location = new System.Drawing.Point(119, 171);
            this.txtDvt.Margin = new System.Windows.Forms.Padding(4);
            this.txtDvt.Name = "txtDvt";
            this.txtDvt.Size = new System.Drawing.Size(187, 22);
            this.txtDvt.TabIndex = 448;
            this.txtDvt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 447;
            this.label2.Text = "Đơn vị tính";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nHOMBindingSource
            // 
            this.nHOMBindingSource.DataMember = "NHOM";
            this.nHOMBindingSource.DataSource = this.ds_NhomVt;
            // 
            // nHOMTableAdapter
            // 
            this.nHOMTableAdapter.ClearBeforeFill = true;
            // 
            // UC_VatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_VatTu";
            this.Size = new System.Drawing.Size(1576, 477);
            this.Load += new System.EventHandler(this.UC_VatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_NhomVt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtDvt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.TextBox txtGiaDen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lbkLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource nHOMBindingSource;
        private Ds_NhomVt ds_NhomVt;
        private Ds_NhomVtTableAdapters.NHOMTableAdapter nHOMTableAdapter;
        private System.Windows.Forms.BindingSource nHOMBindingSource1;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuĐìnhChỉToolStripMenuItem;
    }
}
