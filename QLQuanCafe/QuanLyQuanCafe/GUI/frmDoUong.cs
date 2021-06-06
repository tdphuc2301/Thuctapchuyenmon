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
    public partial class frmDoUong : Form
    {
        BUS_DoUong BUS = new BUS_DoUong();
        DTO_DoUong DTO = new DTO_DoUong();
        public static bool luu = true;
        public static string MaDo_Uong = "";
        public static string TenDo_Uong = "";
        public static decimal DonGia ;
        public static decimal SoLuongTon ;
        public static string GhiChu = "";
        public frmDoUong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luu = true;
            frmDoUong_Sua frm = new frmDoUong_Sua(this.grdDoUong);
            frm.Text = "Thêm đồ uống";
            frm.ShowDialog();
        }

        private void frmDoUong_Load(object sender, EventArgs e)
        {
            DanhSachDoUong();
        }
        private void DanhSachDoUong()
        {
            grdDoUong.AllowUserToAddRows = false;
            grdDoUong.DataSource = BUS.DanhSachDoUong();
            grdDoUong.Columns[0].HeaderText = "Mã đồ uống";
            grdDoUong.Columns[1].HeaderText = "Tên đồ uống";
            grdDoUong.Columns[2].HeaderText = "Đơn giá";
            grdDoUong.Columns[3].HeaderText = "Số lượng tồn";
            grdDoUong.Columns[4].HeaderText = "Ghi chú";
            grdDoUong.Columns[0].Width = 100;
            grdDoUong.Columns[1].Width = 150;
            grdDoUong.Columns[2].Width = 100;
            grdDoUong.Columns[3].Width = 100;
            grdDoUong.Columns[4].Width = 150;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.grdDoUong.Rows[grdDoUong.CurrentCell.RowIndex];
            luu = false;
            frmDoUong_Sua frm = new frmDoUong_Sua(this.grdDoUong);
            MaDo_Uong = row.Cells[0].Value.ToString();
            TenDo_Uong = row.Cells[1].Value.ToString();
            DonGia = decimal.Parse(row.Cells[2].Value.ToString() + "");
            SoLuongTon = decimal.Parse(row.Cells[3].Value.ToString() + "");
            GhiChu = row.Cells[4].Value.ToString();
            frm.Text = "Sửa đồ uống";
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grdDoUong.Rows.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa dòng dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DTO.MaDo_Uong = grdDoUong.Rows[grdDoUong.CurrentCell.RowIndex].Cells[0].Value.ToString();
                BUS.Xoa(DTO);
                MessageBox.Show("Đã xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                grdDoUong.DataSource = BUS.DanhSachDoUong();
            }
            else
                return;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < grdDoUong.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = grdDoUong.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < grdDoUong.Rows.Count; i++)
            {
                for (int j = 0; j < grdDoUong.Columns.Count; j++)
                {
                    if (grdDoUong.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = grdDoUong.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = "";
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            grdDoUong.DataSource = BUS.DanhSachDoUong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt = BUS.DanhSachTimKiem(txtMaDo_Uong.Text, txtTenDo_Uong.Text, nmDonGia.Value, nmSoLuongTon.Value, txtGhiChu.Text);
            grdDoUong.DataSource = dt;
        }

        private void grdDoUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdDoUong.Rows[e.RowIndex];
                txtMaDo_Uong.Text = row.Cells[0].Value.ToString();
                txtTenDo_Uong.Text = row.Cells[1].Value.ToString();
                nmDonGia.Text = row.Cells[2].Value.ToString();
                nmSoLuongTon.Text = row.Cells[3].Value.ToString();
                txtGhiChu.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaDo_Uong.Text = "";
            txtTenDo_Uong.Text = "";
            nmDonGia.Value = 0;
            nmSoLuongTon.Value = 0;
            txtGhiChu.Text = "";
        }
    }
}
