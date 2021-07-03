using BUS;
using DAL;
using DTO;
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
    public partial class frmManHinhChinh : Form
    {
        BUS_KhachHang BUS_KH = new BUS_KhachHang();
        BUS_HoaDon BUS_HD = new BUS_HoaDon();
        DTO_HoaDon DTO_HD = new DTO_HoaDon();
        public static bool luu = true;
        public static string MaDo_Uong_DonGia = "";
        public static string MaHD_Luu = "";
        public static string MaBan_Luu = "";
        public static string MaKH_Luu = "";
        public static string MaDo_Uong_Luu = "";
        public static string MaTK_NV_Luu = "";
        public static decimal DonGia_Luu;
        public static decimal SoLuong_Luu;
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        //private void menutk_nv_Click(object sender, EventArgs e)
        //{
         
        //    frmThongTin_NhanVien frm = new frmThongTin_NhanVien();
        //    frm.ShowDialog();
        //}

        //private void menuttcn_Click(object sender, EventArgs e)
        //{
            
        //    frmThongTin_CaNhan frm = new frmThongTin_CaNhan();
        //    frm.ShowDialog();
        //}

        //private void menudo_uong_Click(object sender, EventArgs e)
        //{
            
        //    frmDoUong frm = new frmDoUong();
        //    frm.ShowDialog();
        //}

        //private void menukhach_hang_Click(object sender, EventArgs e)
        //{

        //    frmKhachHang frm = new frmKhachHang();
        //    frm.ShowDialog();
        //}

        //private void menuban_Click(object sender, EventArgs e)
        //{
        //    frmBan frm = new frmBan();
        //    frm.ShowDialog();
        //}

        //private void menudoanh_thu_Click(object sender, EventArgs e)
        //{
        //    frmThongKeDoanhThu frm = new frmThongKeDoanhThu();
        //    frm.ShowDialog();
        //}

        //private void menu_lich_su_hd_Click(object sender, EventArgs e)
        //{
        //    frmLichSuHoaDon frm = new frmLichSuHoaDon();
        //    frm.ShowDialog();
        //}

        //private void menudang_xuat_Click(object sender, EventArgs e)
        //{
        //    DialogResult dr = MessageBox.Show("Bạn có chắc chắn đăng xuất chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dr == DialogResult.Yes)
        //    {
        //        this.Close();
        //    }
        //    else
        //        return;
        //}

        private void frmManHinhChinh_Load(object sender, EventArgs e)
        {
            //if (frmDangNhap.Quyen_Luu == "NGUOIDUNG")
            //{
            //    menutk_nv.Enabled = false;
            //    menuban.Enabled = false;
            //    menudo_uong.Enabled = false;
            //    menudoanh_thu.Enabled = false;
            //}
            btnBanDaChon.Text = "";
            txtMaTK_NV.Text = frmDangNhap.MaTK_NV_Luu;
            DanhSachKhachHang();
            DanhSachBan();
            DanhSachHoaDon(btnBanDaChon.Text);
            MaKH_Luu = cboMaKH.SelectedValue.ToString();
        }
        public void Tien()
        {
            if (grdHoaDon.Rows.Count == 0)
            {
                lblTongTien.Text = "0 VNĐ";
                return;
            }
            int tien = grdHoaDon.Rows.Count;
            decimal thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += decimal.Parse(grdHoaDon.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            lblTongTien.Text = thanhtien.ToString("#,###") + "VNĐ";
            if (lblTongTien.Text == " VNĐ")
            {
                lblTongTien.Text = "0 VNĐ";
            }
        }
        private void DanhSachHoaDon(string MaBan)
        {
            grdHoaDon.AllowUserToAddRows = false;
            grdHoaDon.DataSource = BUS_HD.DanhSachHoaDon(MaBan);
            grdHoaDon.Columns[0].HeaderText = "";
            grdHoaDon.Columns[1].HeaderText = "Tên món";
            grdHoaDon.Columns[2].HeaderText = "Đơn giá";
            grdHoaDon.Columns[3].HeaderText = "Số lượng";
            grdHoaDon.Columns[4].HeaderText = "Thành Tiền";
            grdHoaDon.Columns[0].Width = -10;
            grdHoaDon.Columns[1].Width = 100;
            grdHoaDon.Columns[2].Width = 110;
            grdHoaDon.Columns[3].Width = 80;
            grdHoaDon.Columns[4].Width = 100;

        }
        public void DanhSachBan()
        {
            DataTable dtBan = new DataTable();
            listViewBan.Items.Clear();
            dtBan = BUS_HD.Table_No();
            for (int i = 0; i < dtBan.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dtBan.Rows[i]["TenBan"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dtBan.Rows[i][0].ToString());
                item.ImageIndex = 0;
                item.SubItems.Add(subItem);
                listViewBan.Items.Add(item);
            }
            dtBan = BUS_HD.Table_Yes();
            for (int i = 0; i < dtBan.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dtBan.Rows[i]["TenBan"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dtBan.Rows[i][0].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                listViewBan.Items.Add(item);
            }
        }
        private void DanhSachKhachHang()
        {
            DataTable dt = BUS_KH.DanhSachKhachHang();
            cboMaKH.DataSource = dt;
            cboMaKH.DisplayMember = "TenKH";
            cboMaKH.ValueMember = "MaKH";
            cboMaKH.SelectedIndex = 0;
        }
       

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(btnBanDaChon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn để gọi món", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            luu = true;
            MaKH_Luu = cboMaKH.SelectedValue.ToString();
            frmHoaDon_Sua frm = new frmHoaDon_Sua(this.grdHoaDon);
            frm.Text = "Hóa đơn mới";
            frm.ShowDialog();
            DanhSachBan();
            Tien();
        }

        private void listViewBan_Click(object sender, EventArgs e)
        {
            string MaBan = listViewBan.SelectedItems[0].SubItems[0].Text;
            btnBanDaChon.Text = MaBan;
            MaBan_Luu = listViewBan.SelectedItems[0].SubItems[1].Text;
            DanhSachHoaDon(MaBan_Luu);
            Tien();
        }

        private void grdHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void grdHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdHoaDon.Rows[e.RowIndex];
                DataTable dtHoaDon = BUS_HD.HoaDonTheoMa(row.Cells[0].Value.ToString());
                cboMaKH.SelectedValue = dtHoaDon.Rows[0]["MaKH"].ToString();
            }
        }

        private void cboMaDo_Uong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnBanDaChon.Text = "";
            txtMaTK_NV.Text = frmDangNhap.MaTK_NV_Luu;
            DanhSachKhachHang();
            DanhSachBan();
            DanhSachHoaDon(btnBanDaChon.Text);
            MaKH_Luu = cboMaKH.SelectedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdHoaDon.Rows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = this.grdHoaDon.Rows[grdHoaDon.CurrentCell.RowIndex];
            luu = false;
            frmHoaDon_Sua frm = new frmHoaDon_Sua(this.grdHoaDon);
            MaHD_Luu = row.Cells[0].Value.ToString();
            MaDo_Uong_Luu = row.Cells[1].Value.ToString();
            DonGia_Luu = decimal.Parse(row.Cells[2].Value.ToString() + "");
            SoLuong_Luu = decimal.Parse(row.Cells[3].Value.ToString() + "");
            frm.Text = "Sửa món";
            frm.ShowDialog();
            DanhSachBan();
            Tien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grdHoaDon.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Có chắc xóa món này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO_HD.MaHD = grdHoaDon.Rows[grdHoaDon.CurrentCell.RowIndex].Cells[0].Value.ToString();
                BUS_HD.Xoa(DTO_HD);
                MessageBox.Show("Xóa xong ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                DanhSachHoaDon(btnBanDaChon.Text);
                DanhSachBan();
                Tien();
            }
            else
                return;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (grdHoaDon.Rows.Count == 0)
            {
                return;
            }
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Tính tiền cho bàn " + btnBanDaChon.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("Tổng tiền là " + lblTongTien.Text, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Tien();
                    string s = "UPDATE HoaDon SET TrangThai = '1' WHERE MaBan = '"+MaBan_Luu+"'";
                    KetNoiSQL.ExecuteNonQuery(s);
                    DanhSachBan();
                    DanhSachHoaDon(MaBan_Luu);
                    Tien();
                }
                else
                {
                    return;
                }
            }
            catch { MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome1 home = new frmHome1();
            home.ShowDialog();
            
        }
    }
}
