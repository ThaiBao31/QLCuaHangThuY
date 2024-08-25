namespace PMQuanLyCuaHangThuY.View
{
    partial class FormTonKhoDauKyThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTonKhoDauKyThongTin));
            this.nmTHANHTIEN = new System.Windows.Forms.NumericUpDown();
            this.nmDONGIA = new System.Windows.Forms.NumericUpDown();
            this.cboMAVT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.nmSOLUONG = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmTHANHTIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDONGIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSOLUONG)).BeginInit();
            this.SuspendLayout();
            // 
            // nmTHANHTIEN
            // 
            this.nmTHANHTIEN.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmTHANHTIEN.Location = new System.Drawing.Point(189, 103);
            this.nmTHANHTIEN.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nmTHANHTIEN.Name = "nmTHANHTIEN";
            this.nmTHANHTIEN.Size = new System.Drawing.Size(254, 26);
            this.nmTHANHTIEN.TabIndex = 312;
            // 
            // nmDONGIA
            // 
            this.nmDONGIA.Location = new System.Drawing.Point(189, 79);
            this.nmDONGIA.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nmDONGIA.Name = "nmDONGIA";
            this.nmDONGIA.Size = new System.Drawing.Size(254, 26);
            this.nmDONGIA.TabIndex = 311;
            this.nmDONGIA.Validated += new System.EventHandler(this.nmDONGIA_Validated);
            // 
            // cboMAVT
            // 
            this.cboMAVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMAVT.FormattingEnabled = true;
            this.cboMAVT.Location = new System.Drawing.Point(189, 7);
            this.cboMAVT.Name = "cboMAVT";
            this.cboMAVT.Size = new System.Drawing.Size(254, 26);
            this.cboMAVT.TabIndex = 310;
            this.cboMAVT.SelectedIndexChanged += new System.EventHandler(this.cboMAVT_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(95, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 18);
            this.label7.TabIndex = 305;
            this.label7.Text = "(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 303;
            this.label5.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 302;
            this.label6.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 299;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 298;
            this.label2.Text = "Đơn vị tính";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(189, 31);
            this.txtDVT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.Size = new System.Drawing.Size(255, 26);
            this.txtDVT.TabIndex = 296;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 297;
            this.label1.Text = "Mã vật tư";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(252, 146);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 30);
            this.btnLuu.TabIndex = 293;
            this.btnLuu.Tag = "L116";
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(344, 146);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 30);
            this.btnHuy.TabIndex = 294;
            this.btnHuy.Tag = "L117";
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // nmSOLUONG
            // 
            this.nmSOLUONG.DecimalPlaces = 2;
            this.nmSOLUONG.Location = new System.Drawing.Point(189, 55);
            this.nmSOLUONG.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nmSOLUONG.Name = "nmSOLUONG";
            this.nmSOLUONG.Size = new System.Drawing.Size(254, 26);
            this.nmSOLUONG.TabIndex = 313;
            this.nmSOLUONG.Validated += new System.EventHandler(this.nmSOLUONG_Validated);
            // 
            // FormTonKhoDauKyThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(221)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(469, 179);
            this.Controls.Add(this.nmSOLUONG);
            this.Controls.Add(this.nmTHANHTIEN);
            this.Controls.Add(this.nmDONGIA);
            this.Controls.Add(this.cboMAVT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTonKhoDauKyThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTonKhoDauKyThongTin";
            this.Load += new System.EventHandler(this.FormTonKhoDauKyThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmTHANHTIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDONGIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSOLUONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmTHANHTIEN;
        private System.Windows.Forms.NumericUpDown nmDONGIA;
        private System.Windows.Forms.ComboBox cboMAVT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnLuu;
        internal System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.NumericUpDown nmSOLUONG;
    }
}