namespace PMQuanLyCuaHangThuY
{
    partial class TopNVatTu
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
            this.txtTopN = new System.Windows.Forms.TextBox();
            this.lbkSort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportViewer1.Location = new System.Drawing.Point(1, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(935, 552);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // txtTopN
            // 
            this.txtTopN.Location = new System.Drawing.Point(505, 12);
            this.txtTopN.Multiline = true;
            this.txtTopN.Name = "txtTopN";
            this.txtTopN.Size = new System.Drawing.Size(100, 22);
            this.txtTopN.TabIndex = 1;
            this.txtTopN.Text = "5";
            this.txtTopN.TextChanged += new System.EventHandler(this.txtTopN_TextChanged_1);
            // 
            // lbkSort
            // 
            this.lbkSort.FormattingEnabled = true;
            this.lbkSort.Items.AddRange(new object[] {
            "Cao nhất",
            "Thấp nhất"});
            this.lbkSort.Location = new System.Drawing.Point(737, 12);
            this.lbkSort.Name = "lbkSort";
            this.lbkSort.Size = new System.Drawing.Size(121, 24);
            this.lbkSort.TabIndex = 2;
            this.lbkSort.Text = "Cao nhất";
            this.lbkSort.SelectedIndexChanged += new System.EventHandler(this.lbkSort_SelectedIndexChanged_1);
            // 
            // TopNVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 594);
            this.Controls.Add(this.lbkSort);
            this.Controls.Add(this.txtTopN);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TopNVatTu";
            this.Text = "TopNVatTu";
            this.Load += new System.EventHandler(this.TopNVatTu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtTopN;
        private System.Windows.Forms.ComboBox lbkSort;
    }
}