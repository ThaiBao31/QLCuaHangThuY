namespace PMQuanLyCuaHangThuY.View
{
    partial class FormHBTLDinhChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHBTLDinhChi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDataHBTLDinhChi = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietHBTL = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHBTLDinhChi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHBTL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvDataHBTLDinhChi);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu đã đình chỉ";
            // 
            // dtgvDataHBTLDinhChi
            // 
            this.dtgvDataHBTLDinhChi.AllowUserToAddRows = false;
            this.dtgvDataHBTLDinhChi.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataHBTLDinhChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataHBTLDinhChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDataHBTLDinhChi.Location = new System.Drawing.Point(3, 18);
            this.dtgvDataHBTLDinhChi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataHBTLDinhChi.Name = "dtgvDataHBTLDinhChi";
            this.dtgvDataHBTLDinhChi.ReadOnly = true;
            this.dtgvDataHBTLDinhChi.RowHeadersWidth = 51;
            this.dtgvDataHBTLDinhChi.Size = new System.Drawing.Size(871, 218);
            this.dtgvDataHBTLDinhChi.TabIndex = 326;
            this.dtgvDataHBTLDinhChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataHDBHDinhChi_CellContentClick);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(729, 587);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 43);
            this.btnKhoiPhuc.TabIndex = 473;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvChiTietHBTL);
            this.groupBox2.Location = new System.Drawing.Point(3, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 324);
            this.groupBox2.TabIndex = 327;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // dtgvChiTietHBTL
            // 
            this.dtgvChiTietHBTL.AllowUserToAddRows = false;
            this.dtgvChiTietHBTL.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChiTietHBTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHBTL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvChiTietHBTL.Location = new System.Drawing.Point(3, 18);
            this.dtgvChiTietHBTL.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvChiTietHBTL.Name = "dtgvChiTietHBTL";
            this.dtgvChiTietHBTL.ReadOnly = true;
            this.dtgvChiTietHBTL.RowHeadersWidth = 51;
            this.dtgvChiTietHBTL.Size = new System.Drawing.Size(868, 303);
            this.dtgvChiTietHBTL.TabIndex = 326;
            this.dtgvChiTietHBTL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormHBTLDinhChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(874, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHBTLDinhChi";
            this.Text = "FormHBTLDinhChi";
            this.Load += new System.EventHandler(this.FormHBTLDinhChi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHBTLDinhChi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHBTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDataHBTLDinhChi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietHBTL;
    }
}