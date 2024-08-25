namespace PMQuanLyCuaHangThuY
{
    partial class BaoCaoDoanhSoVtTheoThang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_DoanhSoTheoThang = new PMQuanLyCuaHangThuY.Ds_DoanhSoTheoThang();
            this.dsDoanhSoTheoThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspDoanhThuVatTuTheoThangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_DoanhThuVatTuTheoThangTableAdapter = new PMQuanLyCuaHangThuY.Ds_DoanhSoTheoThangTableAdapters.usp_DoanhThuVatTuTheoThangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_DoanhSoTheoThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhSoTheoThangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspDoanhThuVatTuTheoThangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspDoanhThuVatTuTheoThangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DoanhSoVatTuTheoThang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1012, 630);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ds_DoanhSoTheoThang
            // 
            this.ds_DoanhSoTheoThang.DataSetName = "Ds_DoanhSoTheoThang";
            this.ds_DoanhSoTheoThang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsDoanhSoTheoThangBindingSource
            // 
            this.dsDoanhSoTheoThangBindingSource.DataSource = this.ds_DoanhSoTheoThang;
            this.dsDoanhSoTheoThangBindingSource.Position = 0;
            // 
            // uspDoanhThuVatTuTheoThangBindingSource
            // 
            this.uspDoanhThuVatTuTheoThangBindingSource.DataMember = "usp_DoanhThuVatTuTheoThang";
            this.uspDoanhThuVatTuTheoThangBindingSource.DataSource = this.ds_DoanhSoTheoThang;
            // 
            // usp_DoanhThuVatTuTheoThangTableAdapter
            // 
            this.usp_DoanhThuVatTuTheoThangTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoDoanhSoVtTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 630);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoDoanhSoVtTheoThang";
            this.Text = "BaoCaoDoanhSoVtTheoThang";
            this.Load += new System.EventHandler(this.BaoCaoDoanhSoVtTheoThang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_DoanhSoTheoThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDoanhSoTheoThangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspDoanhThuVatTuTheoThangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspDoanhThuVatTuTheoThangBindingSource;
        private Ds_DoanhSoTheoThang ds_DoanhSoTheoThang;
        private System.Windows.Forms.BindingSource dsDoanhSoTheoThangBindingSource;
        private Ds_DoanhSoTheoThangTableAdapters.usp_DoanhThuVatTuTheoThangTableAdapter usp_DoanhThuVatTuTheoThangTableAdapter;
    }
}