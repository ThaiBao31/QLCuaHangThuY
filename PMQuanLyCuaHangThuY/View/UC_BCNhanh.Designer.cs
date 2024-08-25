namespace PMQuanLyCuaHangThuY.View
{
    partial class UC_BCNhanh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uC_TopNVatTu1 = new PMQuanLyCuaHangThuY.UC_TopNVatTu();
            this.uC_TopNKhachHang1 = new PMQuanLyCuaHangThuY.View.UC_TopNKhachHang();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1485, 24);
            this.menuStrip1.TabIndex = 418;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uC_TopNVatTu1
            // 
            this.uC_TopNVatTu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.uC_TopNVatTu1.Location = new System.Drawing.Point(0, 69);
            this.uC_TopNVatTu1.Name = "uC_TopNVatTu1";
            this.uC_TopNVatTu1.Size = new System.Drawing.Size(747, 461);
            this.uC_TopNVatTu1.TabIndex = 419;
            this.uC_TopNVatTu1.Load += new System.EventHandler(this.uC_TopNVatTu1_Load);
            // 
            // uC_TopNKhachHang1
            // 
            this.uC_TopNKhachHang1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.uC_TopNKhachHang1.Location = new System.Drawing.Point(766, 69);
            this.uC_TopNKhachHang1.Name = "uC_TopNKhachHang1";
            this.uC_TopNKhachHang1.Size = new System.Drawing.Size(709, 461);
            this.uC_TopNKhachHang1.TabIndex = 420;
            // 
            // UC_BCNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.uC_TopNKhachHang1);
            this.Controls.Add(this.uC_TopNVatTu1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UC_BCNhanh";
            this.Size = new System.Drawing.Size(1485, 541);
            this.Load += new System.EventHandler(this.UC_BCNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private UC_TopNVatTu uC_TopNVatTu1;
        private UC_TopNKhachHang uC_TopNKhachHang1;
    }
}
