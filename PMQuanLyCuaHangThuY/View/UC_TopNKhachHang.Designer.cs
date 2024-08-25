namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_TopNKhachHang
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbkSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PMQuanLyCuaHangThuY.Rp_TopNKhachHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 43);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(766, 459);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lbkSort
            // 
            this.lbkSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkSort.ForeColor = System.Drawing.Color.Navy;
            this.lbkSort.FormattingEnabled = true;
            this.lbkSort.Items.AddRange(new object[] {
            "Cao nhất",
            "Thấp nhất"});
            this.lbkSort.Location = new System.Drawing.Point(317, 6);
            this.lbkSort.Name = "lbkSort";
            this.lbkSort.Size = new System.Drawing.Size(94, 26);
            this.lbkSort.TabIndex = 10;
            this.lbkSort.Text = "Cao nhất";
            this.lbkSort.SelectedIndexChanged += new System.EventHandler(this.lbkSort_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "khách hàng có doanh số";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Top";
            // 
            // txtTopN
            // 
            this.txtTopN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTopN.ForeColor = System.Drawing.Color.Navy;
            this.txtTopN.Location = new System.Drawing.Point(54, 8);
            this.txtTopN.Multiline = true;
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(41, 22);
            this.txtTopN.TabIndex = 7;
            this.txtTopN.Text = "5";
            this.txtTopN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopN.TextChanged += new System.EventHandler(this.txtTopN_TextChanged_1);
            // 
            // UC_TopNKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.lbkSort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTopN);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UC_TopNKhachHang";
            this.Size = new System.Drawing.Size(766, 505);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox lbkSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopN;
    }
}
