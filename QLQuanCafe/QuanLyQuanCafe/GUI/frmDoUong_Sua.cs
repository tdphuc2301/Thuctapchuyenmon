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
    public partial class frmDoUong_Sua : Form
    {
        protected DataGridView gridView;
        BUS_DoUong BUS = new BUS_DoUong();
        DTO_DoUong DTO = new DTO_DoUong();
        public frmDoUong_Sua(DataGridView dtgridView)
        {
            InitializeComponent();
            gridView = dtgridView;
        }

        private void frmDoUong_Sua_Load(object sender, EventArgs e)
        {
            if (frmDoUong.luu == false)
            {
                txtMaDo_Uong.Text = frmDoUong.MaDo_Uong;
                txtTenDo_Uong.Text = frmDoUong.TenDo_Uong;
                nmDonGia.Value = frmDoUong.DonGia;
                nmSoLuongTon.Value = frmDoUong.SoLuongTon;
                txtGhiChu.Text = frmDoUong.GhiChu;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDo_Uong.Text == "")
            {
                MessageBox.Show("Mã đồ uống không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaDo_Uong.Focus();
                return;
            }
            if (txtTenDo_Uong.Text == "")
            {
                MessageBox.Show("Tên đồ uống không được trống", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDo_Uong.Focus();
                return;
            }
            if (frmDoUong.luu == true)
            {
                if (KiemTraTrung(txtMaDo_Uong.Text) == 1)
                {
                    MessageBox.Show("Không lưu được, Đồ uống này đã tồn tại trong cơ sở dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DTO.MaDo_Uong = txtMaDo_Uong.Text;
                DTO.TenDo_Uong = txtTenDo_Uong.Text;
                DTO.DonGia = nmDonGia.Value;
                DTO.SoLuongTon = nmSoLuongTon.Value;
                DTO.GhiChu = txtGhiChu.Text;

                BUS.Them(DTO);
                MessageBox.Show("Thêm xong ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                gridView.DataSource = BUS.DanhSachDoUong();
                this.Close();
            }
            else if (frmDoUong.luu == false)
            {
                if (KiemTraTrung(txtMaDo_Uong.Text) == 1 && txtMaDo_Uong.Text != frmDoUong.MaDo_Uong)
                {
                    MessageBox.Show("Không lưu được, Tài khoản này đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DTO.MaDo_Uong_Sua = frmDoUong.MaDo_Uong;
                DTO.MaDo_Uong = txtMaDo_Uong.Text;
                DTO.TenDo_Uong = txtTenDo_Uong.Text;
                DTO.DonGia = nmDonGia.Value;
                DTO.SoLuongTon = nmSoLuongTon.Value;
                DTO.GhiChu = txtGhiChu.Text;

                BUS.Sua(DTO);
                MessageBox.Show("Sửa xong ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                gridView.DataSource = BUS.DanhSachDoUong();
                this.Close();
            }
        }
        private int KiemTraTrung(string MaDo_Uong)
        {
            if (BUS.KiemTraTrung(MaDo_Uong) == 1)
                return 0;
            return 1;
        }

        private void txtMaDo_Uong_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmSoLuongTon_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
