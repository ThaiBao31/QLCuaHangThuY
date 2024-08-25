namespace PMQuanLyCuaHangThuY
{
    partial class Soctvt
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspNXTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_SOCTVT = new PMQuanLyCuaHangThuY.ds_SOCTVT();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.usp_NXTTableAdapter = new PMQuanLyCuaHangThuY.ds_SOCTVTTableAdapters.usp_NXTTableAdapter();
            this.lbkVatTu = new System.Windows.Forms.ComboBox();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_VatTu = new PMQuanLyCuaHangThuY.ds_VatTu();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new PMQuanLyCuaHangThuY.ds_VatTuTableAdapters.VATTUTableAdapter();
            this.vATTUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uspNXTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SOCTVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uspNXTBindingSource
            // 
            this.uspNXTBindingSource.DataMember = "usp_NXT";
            this.uspNXTBindingSource.DataSource = this.ds_SOCTVT;
            // 
            // ds_SOCTVT
            // 
            this.ds_SOCTVT.DataSetName = "ds_SOCTVT";
            this.ds_SOCTVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspNXTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_SoChiTietVT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1557, 744);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(373, 12);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(115, 22);
            this.dtNgay1.TabIndex = 3;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 20, 43, 0, 0);
            // 
            // dtNgay2
            // 
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(592, 12);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(135, 22);
            this.dtNgay2.TabIndex = 494;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(797, 10);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 495;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // usp_NXTTableAdapter
            // 
            this.usp_NXTTableAdapter.ClearBeforeFill = true;
            // 
            // lbkVatTu
            // 
            this.lbkVatTu.DataSource = this.vATTUBindingSource1;
            this.lbkVatTu.DisplayMember = "MAVT";
            this.lbkVatTu.FormattingEnabled = true;
            this.lbkVatTu.Location = new System.Drawing.Point(64, 13);
            this.lbkVatTu.Name = "lbkVatTu";
            this.lbkVatTu.Size = new System.Drawing.Size(121, 24);
            this.lbkVatTu.TabIndex = 496;
            this.lbkVatTu.ValueMember = "MAVT";
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
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.ds_VatTu;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // vATTUBindingSource1
            // 
            this.vATTUBindingSource1.DataMember = "VATTU";
            this.vATTUBindingSource1.DataSource = this.ds_VatTu;
            // 
            // Soctvt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 804);
            this.Controls.Add(this.lbkVatTu);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Soctvt";
            this.Text = "Soctvt";
            this.Load += new System.EventHandler(this.Soctvt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspNXTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_SOCTVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.BindingSource uspNXTBindingSource;
        private ds_SOCTVT ds_SOCTVT;
        private System.Windows.Forms.Button btnTim;
        private ds_SOCTVTTableAdapters.usp_NXTTableAdapter usp_NXTTableAdapter;
        private System.Windows.Forms.ComboBox lbkVatTu;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private ds_VatTu ds_VatTu;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_VatTuTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.BindingSource vATTUBindingSource1;
    }
}