namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_BCSoCTBH
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
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbkVatTu = new System.Windows.Forms.ComboBox();
            this.ds_VatTu = new PMQuanLyCuaHangThuY.ds_VatTu();
            this.vATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vATTUTableAdapter = new PMQuanLyCuaHangThuY.ds_VatTuTableAdapters.VATTUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_BCSoCTBH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 46);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1015, 486);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtNgay2
            // 
            this.dtNgay2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(394, 10);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(180, 22);
            this.dtNgay2.TabIndex = 482;
            // 
            // dtNgay1
            // 
            this.dtNgay1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(116, 10);
            this.dtNgay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(180, 22);
            this.dtNgay1.TabIndex = 481;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 20, 51, 0, 0);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 478;
            this.label8.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 480;
            this.label1.Text = "Từ ngày";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(900, 8);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 479;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(617, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 501;
            this.label2.Text = "Vật tư";
            // 
            // lbkVatTu
            // 
            this.lbkVatTu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbkVatTu.DataSource = this.vATTUBindingSource;
            this.lbkVatTu.DisplayMember = "MAVT";
            this.lbkVatTu.FormattingEnabled = true;
            this.lbkVatTu.Location = new System.Drawing.Point(689, 10);
            this.lbkVatTu.Name = "lbkVatTu";
            this.lbkVatTu.Size = new System.Drawing.Size(131, 24);
            this.lbkVatTu.TabIndex = 500;
            this.lbkVatTu.ValueMember = "MAVT";
            // 
            // ds_VatTu
            // 
            this.ds_VatTu.DataSetName = "ds_VatTu";
            this.ds_VatTu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // UC_BCSoCTBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbkVatTu);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_BCSoCTBH";
            this.Size = new System.Drawing.Size(1020, 535);
            this.Load += new System.EventHandler(this.UC_BCSoCTBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_VatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vATTUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtNgay2;
        private System.Windows.Forms.DateTimePicker dtNgay1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lbkVatTu;
        private System.Windows.Forms.BindingSource vATTUBindingSource;
        private ds_VatTu ds_VatTu;
        private ds_VatTuTableAdapters.VATTUTableAdapter vATTUTableAdapter;
    }
}
