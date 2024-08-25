namespace PMQuanLyCuaHangThuY
{
    partial class FormMauInHDBH
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
            this.ds_MauInHDBH = new PMQuanLyCuaHangThuY.ds_MauInHDBH();
            this.uspMauInHDBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_MauInHDBHTableAdapter = new PMQuanLyCuaHangThuY.ds_MauInHDBHTableAdapters.usp_MauInHDBHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_MauInHDBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMauInHDBHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspMauInHDBHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_MauInHDBH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1017, 615);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ds_MauInHDBH
            // 
            this.ds_MauInHDBH.DataSetName = "ds_MauInHDBH";
            this.ds_MauInHDBH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspMauInHDBHBindingSource
            // 
            this.uspMauInHDBHBindingSource.DataMember = "usp_MauInHDBH";
            this.uspMauInHDBHBindingSource.DataSource = this.ds_MauInHDBH;
            // 
            // usp_MauInHDBHTableAdapter
            // 
            this.usp_MauInHDBHTableAdapter.ClearBeforeFill = true;
            // 
            // FormMauInHDBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 615);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormMauInHDBH";
            this.Text = "FormMauInHDBH";
            this.Load += new System.EventHandler(this.FormMauInHDBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_MauInHDBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspMauInHDBHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspMauInHDBHBindingSource;
        private ds_MauInHDBH ds_MauInHDBH;
        private ds_MauInHDBHTableAdapters.usp_MauInHDBHTableAdapter usp_MauInHDBHTableAdapter;
    }
}