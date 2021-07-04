using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHome1 : Form
    {
        public frmHome1()
        {
            InitializeComponent();
        }

        private void tsbDatBan_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmManHinhChinh f = new frmManHinhChinh();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void menudo_uong_Click(object sender, EventArgs e)
        {
           //this.Hide();
            frmDoUong f = new frmDoUong();
            this.Hide();
            f.ShowDialog();

            this.Show(); //
        }

        private void menukhach_hang_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmKhachHang f = new frmKhachHang();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void menuban_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmBan f = new frmBan();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }


        private void menudoanh_thu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmThongKeDoanhThu f = new frmThongKeDoanhThu();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void menu_lich_su_hd_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmLichSuHoaDon f= new frmLichSuHoaDon();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        
        private void menudang_xuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn đăng xuất chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void menutk_nv_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmThongTin_NhanVien f= new frmThongTin_NhanVien();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void menuttcn_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmThongTin_CaNhan f = new frmThongTin_CaNhan();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void frmHome1_Load(object sender, EventArgs e)
        {
            if (frmDangNhap.Quyen_Luu == "NGUOIDUNG")
            {
                menutk_nv.Enabled = false;
                menuban.Enabled = false;
                menudo_uong.Enabled = false;
                menudoanh_thu.Enabled = false;
            }
        }

        private void đóngGópToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdonggop f = new frmdonggop();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmqr f = new frmqr();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }
    }
}
