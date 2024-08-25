namespace PMQuanLyCuaHangThuY.View
{
    partial class DoanhSoNV
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtNgay2 = new System.Windows.Forms.DateTimePicker();
            this.dtNgay1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_DoanhSoBanHangTheoNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1499, 681);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtNgay2
            // 
            this.dtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay2.Location = new System.Drawing.Point(814, 21);
            this.dtNgay2.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay2.Name = "dtNgay2";
            this.dtNgay2.Size = new System.Drawing.Size(135, 22);
            this.dtNgay2.TabIndex = 498;
            this.dtNgay2.ValueChanged += new System.EventHandler(this.dtNgay2_ValueChanged);
            // 
            // dtNgay1
            // 
            this.dtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay1.Location = new System.Drawing.Point(584, 21);
            this.dtNgay1.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgay1.Name = "dtNgay1";
            this.dtNgay1.Size = new System.Drawing.Size(132, 22);
            this.dtNgay1.TabIndex = 497;
            this.dtNgay1.Value = new System.DateTime(2023, 1, 1, 0, 37, 0, 0);
            this.dtNgay1.ValueChanged += new System.EventHandler(this.dtNgay1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(724, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 494;
            this.label8.Text = "Đến ngày";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 496;
            this.label1.Text = "Từ ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(967, 17);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(100, 28);
            this.btnTim.TabIndex = 495;
            this.btnTim.Text = "Lọc";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // DoanhSoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 756);
            this.Controls.Add(this.dtNgay2);
            this.Controls.Add(this.dtNgay1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DoanhSoNV";
            this.Text = "DoanhSoNV";
            this.Load += new System.EventHandler(this.DoanhSoNV_Load);
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
    }
}