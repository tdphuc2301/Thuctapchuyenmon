using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan_NhanVien
    {
        public DataTable DangNhapChuongTrinh(string MaTK_NV, string MatKhau, string Quyen)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            return DAL.DangNhapChuongTrinh(MaTK_NV, MatKhau, Quyen);
        }
        public DataTable DanhSachQuyen()
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            return DAL.DanhSachQuyen();
        }
        public DataTable DanhSachTaiKhoan_NhanVien()
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            return DAL.DanhSachTaiKhoan_NhanVien();
        }
        public DataTable LayMatKhau(string MaTK_NV)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            return DAL.LayMatKhau(MaTK_NV);
        }
        public DataTable DanhSachTimKiem(string MaTK_NV, string TenTK_NV, string SoDienThoai, string DiaChi)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            DataTable dtList = DAL.DanhSachTimKiem(MaTK_NV, TenTK_NV, SoDienThoai, DiaChi);
            return dtList;
        }
        public void Xoa(DTO_TaiKhoan_NhanVien MaTK_NV)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            DAL.Xoa(MaTK_NV);
        }
        public void Sua(DTO_TaiKhoan_NhanVien MaTK_NV)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            DAL.Sua(MaTK_NV);
        }
        public void Them(DTO_TaiKhoan_NhanVien MaTK_NV)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            DAL.Them(MaTK_NV);
        }
        public int KiemTraTrung(string MaTK_NV)
        {
            DAL_TaiKhoan_NhanVien DAL = new DAL_TaiKhoan_NhanVien();
            int i = DAL.KiemTraTrung(MaTK_NV);
            return i;
        }
    }
}
