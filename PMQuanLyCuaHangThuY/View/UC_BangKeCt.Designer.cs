namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_BangKeCt
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
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbkChungTu = new System.Windows.Forms.ComboBox();
            this.dMCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_DMCT = new PMQuanLyCuaHangThuY.ds_DMCT();
            this.label2 = new System.Windows.Forms.Label();
            this.dMCTTableAdapter = new PMQuanLyCuaHangThuY.ds_DMCTTableAdapters.DMCTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dMCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DMCT)).BeginInit();
            this.SuspendLayout();
            // 
            // dtNgay2
            // 
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(392, 30);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(135, 22);
            this.dtNgay2.TabIndex = 502;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(302, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 500;
            this.label8.Text = "Đến ngày";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(862, 22);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 36);
            this.btnTim.TabIndex = 501;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(139, 30);
            this.dtNgay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(132, 22);
            this.dtNgay1.TabIndex = 499;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 0, 37, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 498;
            this.label1.Text = "Từ ngày";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BangKeCt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 76);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1198, 669);
            this.reportViewer1.TabIndex = 503;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lbkChungTu
            // 
            this.lbkChungTu.DataSource = this.dMCTBindingSource;
            this.lbkChungTu.DisplayMember = "MaCt";
            this.lbkChungTu.FormattingEnabled = true;
            this.lbkChungTu.Location = new System.Drawing.Point(683, 28);
            this.lbkChungTu.Name = "lbkChungTu";
            this.lbkChungTu.Size = new System.Drawing.Size(121, 24);
            this.lbkChungTu.TabIndex = 504;
            this.lbkChungTu.ValueMember = "MaCt";
            this.lbkChungTu.SelectedIndexChanged += new System.EventHandler(this.lbkChungTu_SelectedIndexChanged);
            // 
            // dMCTBindingSource
            // 
            this.dMCTBindingSource.DataMember = "DMCT";
            this.dMCTBindingSource.DataSource = this.ds_DMCT;
            // 
            // ds_DMCT
            // 
            this.ds_DMCT.DataSetName = "ds_DMCT";
            this.ds_DMCT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(578, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 500;
            this.label2.Text = "Chứng từ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dMCTTableAdapter
            // 
            this.dMCTTableAdapter.ClearBeforeFill = true;
            // 
            // UC_BangKeCt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.lbkChungTu);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.label1);
            this.Name = "UC_BangKeCt";
            this.Size = new System.Drawing.Size(1198, 745);
            this.Load += new System.EventHandler(this.UC_BangKeCt_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UC_BangKeCt_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dMCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DMCT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox lbkChungTu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource dMCTBindingSource;
        private ds_DMCT ds_DMCT;
        private ds_DMCTTableAdapters.DMCTTableAdapter dMCTTableAdapter;
    }
}
