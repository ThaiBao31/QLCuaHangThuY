namespace PMQuanLyCuaHangThuY.View
{
    partial class BCCN
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
            this.uspBaoCaoCongNoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsBCCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_BCCN = new PMQuanLyCuaHangThuY.ds_BCCN();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uspBaoCaoCongNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_BaoCaoCongNoTableAdapter = new PMQuanLyCuaHangThuY.ds_BCCNTableAdapters.usp_BaoCaoCongNoTableAdapter();
            this.uspBaoCaoCongNoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usp_BaoCaoCongNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoc = new System.Windows.Forms.Button();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBCCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_BCCN)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_BaoCaoCongNoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uspBaoCaoCongNoBindingSource2
            // 
            this.uspBaoCaoCongNoBindingSource2.DataMember = "usp_BaoCaoCongNo";
            this.uspBaoCaoCongNoBindingSource2.DataSource = this.dsBCCNBindingSource;
            // 
            // dsBCCNBindingSource
            // 
            this.dsBCCNBindingSource.DataSource = this.ds_BCCN;
            this.dsBCCNBindingSource.Position = 0;
            // 
            // ds_BCCN
            // 
            this.ds_BCCN.DataSetName = "ds_BCCN";
            this.ds_BCCN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspBaoCaoCongNoBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BCCongno2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 18);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(877, 380);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // uspBaoCaoCongNoBindingSource
            // 
            this.uspBaoCaoCongNoBindingSource.DataMember = "usp_BaoCaoCongNo";
            this.uspBaoCaoCongNoBindingSource.DataSource = this.dsBCCNBindingSource;
            // 
            // usp_BaoCaoCongNoTableAdapter
            // 
            this.usp_BaoCaoCongNoTableAdapter.ClearBeforeFill = true;
            // 
            // uspBaoCaoCongNoBindingSource1
            // 
            this.uspBaoCaoCongNoBindingSource1.DataMember = "usp_BaoCaoCongNo";
            this.uspBaoCaoCongNoBindingSource1.DataSource = this.ds_BCCN;
            // 
            // usp_BaoCaoCongNoBindingSource
            // 
            this.usp_BaoCaoCongNoBindingSource.DataMember = "usp_BaoCaoCongNo";
            this.usp_BaoCaoCongNoBindingSource.DataSource = this.ds_BCCN;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(619, 13);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(112, 31);
            this.btnLoc.TabIndex = 1;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click_1);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(221, 12);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(115, 22);
            this.dtNgay1.TabIndex = 2;
            // 
            // dtNgay2
            // 
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(397, 12);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(115, 22);
            this.dtNgay2.TabIndex = 2;
            // 
            // BCCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.groupBox1);
            this.Name = "BCCN";
            this.Text = "BCCN";
            this.Load += new System.EventHandler(this.BCCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBCCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_BCCN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspBaoCaoCongNoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_BaoCaoCongNoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource usp_BaoCaoCongNoBindingSource;
        private ds_BCCN ds_BCCN;
        private System.Windows.Forms.BindingSource dsBCCNBindingSource;
        private System.Windows.Forms.BindingSource uspBaoCaoCongNoBindingSource;
        private ds_BCCNTableAdapters.usp_BaoCaoCongNoTableAdapter usp_BaoCaoCongNoTableAdapter;
        private System.Windows.Forms.BindingSource uspBaoCaoCongNoBindingSource1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.BindingSource uspBaoCaoCongNoBindingSource2;
    }
}