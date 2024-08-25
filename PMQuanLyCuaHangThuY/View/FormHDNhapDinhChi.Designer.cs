namespace PMQuanLyCuaHangThuY.View
{
    partial class FormHDNhapDinhChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDNhapDinhChi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDataHDNhapDinhChi = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHDNhapDinhChi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvDataHDNhapDinhChi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu đã đình chỉ";
            // 
            // dtgvDataHDNhapDinhChi
            // 
            this.dtgvDataHDNhapDinhChi.AllowUserToAddRows = false;
            this.dtgvDataHDNhapDinhChi.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataHDNhapDinhChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataHDNhapDinhChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDataHDNhapDinhChi.Location = new System.Drawing.Point(3, 18);
            this.dtgvDataHDNhapDinhChi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataHDNhapDinhChi.Name = "dtgvDataHDNhapDinhChi";
            this.dtgvDataHDNhapDinhChi.ReadOnly = true;
            this.dtgvDataHDNhapDinhChi.RowHeadersWidth = 51;
            this.dtgvDataHDNhapDinhChi.Size = new System.Drawing.Size(864, 218);
            this.dtgvDataHDNhapDinhChi.TabIndex = 326;
            this.dtgvDataHDNhapDinhChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataHDNhapDinhChi_CellContentClick);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(729, 557);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 43);
            this.btnKhoiPhuc.TabIndex = 474;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvChiTietNhap);
            this.groupBox2.Location = new System.Drawing.Point(15, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 294);
            this.groupBox2.TabIndex = 327;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // dtgvChiTietNhap
            // 
            this.dtgvChiTietNhap.AllowUserToAddRows = false;
            this.dtgvChiTietNhap.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietNhap.Location = new System.Drawing.Point(3, 18);
            this.dtgvChiTietNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChiTietNhap.Name = "dtgvChiTietNhap";
            this.dtgvChiTietNhap.ReadOnly = true;
            this.dtgvChiTietNhap.RowHeadersWidth = 51;
            this.dtgvChiTietNhap.Size = new System.Drawing.Size(864, 273);
            this.dtgvChiTietNhap.TabIndex = 326;
            this.dtgvChiTietNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChiTietNhap_CellContentClick);
            // 
            // FormHDNhapDinhChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(885, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHDNhapDinhChi";
            this.Text = "FormHDNhapDinhChi";
            this.Load += new System.EventHandler(this.FormHDNhapDinhChi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHDNhapDinhChi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDataHDNhapDinhChi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietNhap;
    }
}