namespace PMQuanLyCuaHangThuY
{
    partial class UC_DanhSachVatTu
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_VatTu = new PMQuanLyCuaHangThuY.ds_VatTu();
            this.dsVatTuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new PMQuanLyCuaHangThuY.ds_VatTuTableAdapters.VATTUTableAdapter();
            this.vATTUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVatTuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vATTUBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.VatTu.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1058, 559);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ds_VatTu
            // 
            this.ds_VatTu.DataSetName = "ds_VatTu";
            this.ds_VatTu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsVatTuBindingSource
            // 
            this.dsVatTuBindingSource.DataSource = this.ds_VatTu;
            this.dsVatTuBindingSource.Position = 0;
            // 
            // vATTUBindingSource
            // 
            this.vATTUBindingSource.DataMember = "VATTU";
            this.vATTUBindingSource.DataSource = this.ds_VatTu;
            // 
            // vATTUTableAdapter
            // 
            this.vATTUTableAdapter.ClearBeforeFill = true;
            // 
            // vATTUBindingSource1
            // 
            this.vATTUBindingSource1.DataMember = "VATTU";
            this.vATTUBindingSource1.DataSource = this.dsVatTuBindingSource;
            // 
            // vATTUBindingSource2
            // 
            this.vATTUBindingSource2.DataMember = "VATTU";
            this.vATTUBindingSource2.DataSource = this.ds_VatTu;
            // 
            // vATTUBindingSource3
            // 
            this.vATTUBindingSource3.DataMember = "VATTU";
            this.vATTUBindingSource3.DataSource = this.dsVatTuBindingSource;
            // 
            // vATTUBindingSource4
            // 
            this.vATTUBindingSource4.DataMember = "VATTU";
            this.vATTUBindingSource4.DataSource = this.dsVatTuBindingSource;
            // 
            // UC_DanhSachVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.reportViewer1);
            this.Name = "UC_DanhSachVatTu";
            this.Size = new System.Drawing.Size(1058, 559);
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVatTuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds_VatTu ds_VatTu;
        private System.Windows.Forms.BindingSource dsVatTuBindingSource;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_VatTuTableAdapters.VATTUTableAdapter vATTUTableAdapter;
        private System.Windows.Forms.BindingSource vATTUBindingSource1;
        private System.Windows.Forms.BindingSource vATTUBindingSource2;
        private System.Windows.Forms.BindingSource vATTUBindingSource3;
        private System.Windows.Forms.BindingSource vATTUBindingSource4;
    }
}
