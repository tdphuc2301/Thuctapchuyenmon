using BUS;
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
    public partial class frmThongTin_CaNhan : Form
    {
        BUS_TaiKhoan_NhanVien BUS = new BUS_TaiKhoan_NhanVien();
        DTO_TaiKhoan_NhanVien DTO = new DTO_TaiKhoan_NhanVien();
        public frmThongTin_CaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTin_CaNhan_Load(object sender, EventArgs e)
        {
            DanhSachQuyen();
            DataTable dt = BUS.ThongTinTaiKhoanCaNhan(frmDangNhap.MaTK_NV_Luu);
            txtMaTK_NV.Text = dt.Rows[0]["MaTK_NV"].ToString();
            txtTenTK_NV.Text = dt.Rows[0]["TenTK_NV"].ToString();
            txtSoDienThoai.Text = dt.Rows[0]["SoDienThoai"].ToString();
            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            cboQuyen.SelectedValue = dt.Rows[0]["Quyen"].ToString(); 
        }
        private void DanhSachQuyen()
        {
            DataTable dt = BUS.DanhSachQuyen();
            cboQuyen.DataSource = dt;
            cboQuyen.DisplayMember = "TenQuyen";
            cboQuyen.ValueMember = "MaQuyen";
            cboQuyen.SelectedIndex = 0;
        }
    }
}
