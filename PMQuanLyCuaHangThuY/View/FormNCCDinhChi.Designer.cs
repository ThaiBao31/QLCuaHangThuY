﻿namespace PMQuanLyCuaHangThuY.View
{
    partial class FormNCCDinhChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNCCDinhChi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDataNCCDinhChi = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataNCCDinhChi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtgvDataNCCDinhChi);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 423);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dữ liệu đã đình chỉ";
            // 
            // dtgvDataNCCDinhChi
            // 
            this.dtgvDataNCCDinhChi.AllowUserToAddRows = false;
            this.dtgvDataNCCDinhChi.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDataNCCDinhChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDataNCCDinhChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDataNCCDinhChi.Location = new System.Drawing.Point(3, 18);
            this.dtgvDataNCCDinhChi.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDataNCCDinhChi.Name = "dtgvDataNCCDinhChi";
            this.dtgvDataNCCDinhChi.ReadOnly = true;
            this.dtgvDataNCCDinhChi.RowHeadersWidth = 51;
            this.dtgvDataNCCDinhChi.Size = new System.Drawing.Size(836, 402);
            this.dtgvDataNCCDinhChi.TabIndex = 326;
            this.dtgvDataNCCDinhChi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDataVatTuDinhChi_CellContentClick);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(730, 439);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(133, 43);
            this.btnKhoiPhuc.TabIndex = 475;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // FormNCCDinhChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 485);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNCCDinhChi";
            this.Text = "FormNCCDinhChi";
            this.Load += new System.EventHandler(this.FormNCCDinhChi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDataNCCDinhChi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDataNCCDinhChi;
        private System.Windows.Forms.Button btnKhoiPhuc;
    }
}