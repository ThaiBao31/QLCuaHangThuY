namespace PMQuanLyCuaHangThuY
{
    partial class UC_SOCTVT
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_VatTu = new PMQuanLyCuaHangThuY.ds_VatTu();
            this.vATTUTableAdapter = new PMQuanLyCuaHangThuY.ds_VatTuTableAdapters.VATTUTableAdapter();
            this.lbkVatTu = new System.Windows.Forms.ComboBox();
            this.vATTUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_SoChiTietVT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1569, 704);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(100, 28);
            this.dtNgay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(132, 22);
            this.dtNgay1.TabIndex = 494;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 0, 37, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 493;
            this.label1.Text = "Từ ngày";
            // 
            // dtNgay2
            // 
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(353, 28);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(135, 22);
            this.dtNgay2.TabIndex = 497;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(263, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 495;
            this.label8.Text = "Đến ngày";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(823, 20);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(89, 36);
            this.btnTim.TabIndex = 496;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.ds_VatTu;
            // 
            // ds_VatTu
            // 
            this.ds_VatTu.DataSetName = "ds_VatTu";
            this.ds_VatTu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // lbkVatTu
            // 
            this.lbkVatTu.DataSource = this.vATTUBindingSource2;
            this.lbkVatTu.DisplayMember = "MAVT";
            this.lbkVatTu.FormattingEnabled = true;
            this.lbkVatTu.Location = new System.Drawing.Point(632, 28);
            this.lbkVatTu.Name = "lbkVatTu";
            this.lbkVatTu.Size = new System.Drawing.Size(131, 24);
            this.lbkVatTu.TabIndex = 498;
            this.lbkVatTu.ValueMember = "MAVT";
            this.lbkVatTu.SelectedIndexChanged += new System.EventHandler(this.lbkVatTu_SelectedIndexChanged);
            // 
            // vATTUBindingSource1
            // 
            this.vATTUBindingSource1.DataMember = "VATTU";
            this.vATTUBindingSource1.DataSource = this.ds_VatTu;
            // 
            // vATTUBindingSource2
            // 
            this.vATTUBindingSource2.DataMember = "VATTU";
            this.vATTUBindingSource2.DataSource = this.ds_VatTu;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 499;
            this.label2.Text = "Vật tư";
            // 
            // UC_SOCTVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbkVatTu);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UC_SOCTVT";
            this.Size = new System.Drawing.Size(1569, 781);
            this.Load += new System.EventHandler(this.UC_SOCTVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_VatTu ds_VatTu;
        private ds_VatTuTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.ComboBox lbkVatTu;
        private System.Windows.Forms.BindingSource vATTUBindingSource1;
        private System.Windows.Forms.BindingSource vATTUBindingSource2;
        private System.Windows.Forms.Label label2;
    }
}
