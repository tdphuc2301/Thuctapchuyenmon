﻿
namespace GUI
{
    partial class frmDoUong_Sua
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
            this.nmso_luong_ton = new System.Windows.Forms.NumericUpDown();
            this.nmdon_gia = new System.Windows.Forms.NumericUpDown();
            this.txtghi_chu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen_do_uong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma_do_uong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmso_luong_ton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdon_gia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(212, 137);
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
            this.btnDangNhap.Location = new System.Drawing.Point(94, 137);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(112, 30);
            this.btnDangNhap.TabIndex = 39;
            this.btnDangNhap.Text = "Lưu thông tin";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // nmso_luong_ton
            // 
            this.nmso_luong_ton.Location = new System.Drawing.Point(180, 79);
            this.nmso_luong_ton.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmso_luong_ton.Name = "nmso_luong_ton";
            this.nmso_luong_ton.Size = new System.Drawing.Size(142, 20);
            this.nmso_luong_ton.TabIndex = 51;
            this.nmso_luong_ton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmdon_gia
            // 
            this.nmdon_gia.Location = new System.Drawing.Point(180, 57);
            this.nmdon_gia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmdon_gia.Name = "nmdon_gia";
            this.nmdon_gia.Size = new System.Drawing.Size(142, 20);
            this.nmdon_gia.TabIndex = 50;
            this.nmdon_gia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtghi_chu
            // 
            this.txtghi_chu.Location = new System.Drawing.Point(180, 101);
            this.txtghi_chu.Name = "txtghi_chu";
            this.txtghi_chu.Size = new System.Drawing.Size(141, 20);
            this.txtghi_chu.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng tồn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đơn giá";
            // 
            // txtTen_do_uong
            // 
            this.txtTen_do_uong.Location = new System.Drawing.Point(180, 35);
            this.txtTen_do_uong.Name = "txtTen_do_uong";
            this.txtTen_do_uong.Size = new System.Drawing.Size(141, 20);
            this.txtTen_do_uong.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên đồ uống";
            // 
            // txtma_do_uong
            // 
            this.txtma_do_uong.Location = new System.Drawing.Point(180, 12);
            this.txtma_do_uong.Name = "txtma_do_uong";
            this.txtma_do_uong.Size = new System.Drawing.Size(141, 20);
            this.txtma_do_uong.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã đồ uống";
            // 
            // frmDoUong_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 172);
            this.Controls.Add(this.nmso_luong_ton);
            this.Controls.Add(this.nmdon_gia);
            this.Controls.Add(this.txtghi_chu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen_do_uong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtma_do_uong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "frmDoUong_Sua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoUong_Sua";
            ((System.ComponentModel.ISupportInitialize)(this.nmso_luong_ton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmdon_gia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.NumericUpDown nmso_luong_ton;
        private System.Windows.Forms.NumericUpDown nmdon_gia;
        private System.Windows.Forms.TextBox txtghi_chu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen_do_uong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma_do_uong;
        private System.Windows.Forms.Label label1;
    }
}