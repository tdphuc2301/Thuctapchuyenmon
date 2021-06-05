
namespace GUI
{
    partial class frmBan_Sua
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.nmso_luong_nguoi = new System.Windows.Forms.NumericUpDown();
            this.txtghi_chu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmso_luong_nguoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(212, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 30);
            this.btnThoat.TabIndex = 40;
            this.btnThoat.Text = "Hủy";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(94, 126);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(112, 30);
            this.btnDangNhap.TabIndex = 39;
            this.btnDangNhap.Text = "Lưu thông tin";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // nmso_luong_nguoi
            // 
            this.nmso_luong_nguoi.Location = new System.Drawing.Point(189, 59);
            this.nmso_luong_nguoi.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmso_luong_nguoi.Name = "nmso_luong_nguoi";
            this.nmso_luong_nguoi.Size = new System.Drawing.Size(142, 20);
            this.nmso_luong_nguoi.TabIndex = 64;
            this.nmso_luong_nguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtghi_chu
            // 
            this.txtghi_chu.Location = new System.Drawing.Point(189, 81);
            this.txtghi_chu.Name = "txtghi_chu";
            this.txtghi_chu.Size = new System.Drawing.Size(141, 20);
            this.txtghi_chu.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Số lượng người";
            // 
            // txtTen_tk
            // 
            this.txtTen_tk.Location = new System.Drawing.Point(190, 36);
            this.txtTen_tk.Name = "txtTen_tk";
            this.txtTen_tk.Size = new System.Drawing.Size(141, 20);
            this.txtTen_tk.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tên bàn";
            // 
            // txtma_tk
            // 
            this.txtma_tk.Location = new System.Drawing.Point(190, 13);
            this.txtma_tk.Name = "txtma_tk";
            this.txtma_tk.Size = new System.Drawing.Size(141, 20);
            this.txtma_tk.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã bàn";
            // 
            // frmBan_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 182);
            this.Controls.Add(this.nmso_luong_nguoi);
            this.Controls.Add(this.txtghi_chu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtma_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "frmBan_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBan_Sua";
            ((System.ComponentModel.ISupportInitialize)(this.nmso_luong_nguoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.NumericUpDown nmso_luong_nguoi;
        private System.Windows.Forms.TextBox txtghi_chu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma_tk;
        private System.Windows.Forms.Label label1;
    }
}