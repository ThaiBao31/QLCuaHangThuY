namespace PMQuanLyCuaHangThuY.View
{
    partial class FormDulieuHDBHDinhchi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDulieuHDBHDinhchi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDataHDBHDinhChi = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHDBHDinhChi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvDataHDBHDinhChi);
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu đã đình chỉ";
            // 
            // dtgvDataHDBHDinhChi
            // 
            this.dtgvDataHDBHDinhChi.AllowUserToAddRows = false;
            this.dtgvDataHDBHDinhChi.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataHDBHDinhChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataHDBHDinhChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDataHDBHDinhChi.Location = new System.Drawing.Point(3, 18);
            this.dtgvDataHDBHDinhChi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataHDBHDinhChi.Name = "dtgvDataHDBHDinhChi";
            this.dtgvDataHDBHDinhChi.ReadOnly = true;
            this.dtgvDataHDBHDinhChi.RowHeadersWidth = 51;
            this.dtgvDataHDBHDinhChi.Size = new System.Drawing.Size(924, 245);
            this.dtgvDataHDBHDinhChi.TabIndex = 326;
            this.dtgvDataHDBHDinhChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataHDBHDinhChi_CellContentClick);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(784, 563);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 43);
            this.btnKhoiPhuc.TabIndex = 472;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgvCTHD);
            this.groupBox2.Location = new System.Drawing.Point(2, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 281);
            this.groupBox2.TabIndex = 327;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // dtgvCTHD
            // 
            this.dtgvCTHD.AllowUserToAddRows = false;
            this.dtgvCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvCTHD.Location = new System.Drawing.Point(3, 18);
            this.dtgvCTHD.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvCTHD.Name = "dtgvCTHD";
            this.dtgvCTHD.ReadOnly = true;
            this.dtgvCTHD.RowHeadersWidth = 51;
            this.dtgvCTHD.Size = new System.Drawing.Size(918, 260);
            this.dtgvCTHD.TabIndex = 326;
            this.dtgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCTHD_CellContentClick);
            // 
            // FormDulieuHDBHDinhchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(929, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDulieuHDBHDinhchi";
            this.Text = "FormDulieuHDBHDinhchi";
            this.Load += new System.EventHandler(this.FormDulieuHDBHDinhchi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataHDBHDinhChi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDataHDBHDinhChi;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvCTHD;
    }
}