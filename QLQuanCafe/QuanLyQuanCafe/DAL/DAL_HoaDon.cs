using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDon
    {
        public DataTable Table_No()
        {
            string strSQL = "SELECT MaBan,TenBan FROM Ban  WHERE MaBan NOT IN (SELECT MaBan FROM HoaDon WHERE TrangThai = '0')";
            strSQL = strSQL + "UNION ALL ";
            strSQL = strSQL + "SELECT a.MaBan,TenBan FROM HoaDon a INNER JOIN Ban b ON a.MaBan = b.MaBan ";
            strSQL = strSQL + "WHERE TrangThai = '1' AND a.MaBan NOT IN (SELECT MaBan FROM Ban) ";
            return KetNoiSQL.GetData(strSQL);
        }
        public DataTable Table_Yes()
        {
            string strSQL = "SELECT DISTINCT a.MaBan,TenBan FROM HoaDon a INNER JOIN Ban b ON a.MaBan = b.MaBan WHERE TrangThai = '0'";
            return KetNoiSQL.GetData(strSQL);
        }
        public DataTable HoaDonTheoMa(string MaHD)
        {
            string strSQL = "SELECT * FROM  HoaDon  WHERE MaHD = '" + MaHD + "'";
            return KetNoiSQL.GetData(strSQL);
        }
        public DataTable DanhSachHoaDon(string MaBan)
        {
            string strSQL = "SELECT MaHD,TenDo_Uong,a.DonGia,SoLuong,ThanhTien FROM  HoaDon a LEFT JOIN DoUong b ON a.MaDo_Uong = b.MaDo_Uong WHERE a.MaBan = '" + MaBan + "' AND TrangThai = '0'";
            return KetNoiSQL.GetData(strSQL);
        }
        public void Them(DTO_HoaDon HoaDon)
        {
            string strSQL = "INSERT INTO HoaDon(MaHD,MaBan,MaKH,MaTK_NV,NgayHoaDon,MaDo_Uong,DonGia,SoLuong,ThanhTien,TrangThai)  VALUES ";
            strSQL = strSQL + "('" + HoaDon.MaHD + "', '" + HoaDon.MaBan + "','" + HoaDon.MaKH + "','" + HoaDon.MaTK_NV + "',GETDATE(),'"+HoaDon.MaDo_Uong+"',"+ HoaDon.DonGia +","+ HoaDon.SoLuong +","+ HoaDon.ThanhTien +",'0')";
            KetNoiSQL.ExecuteNonQuery(strSQL);
        }
        public void Sua(DTO_HoaDon HoaDon)
        {
            string strSQL = string.Format(@"UPDATE HoaDon set MaDo_Uong = '" + HoaDon.MaDo_Uong + "',DonGia = " + HoaDon.DonGia + ",SoLuong = " + HoaDon.SoLuong + " where MaHD = '" + HoaDon.MaHD + "'");
            KetNoiSQL.ExecuteNonQuery(strSQL);
        }
        public void Xoa(DTO_HoaDon HoaDon)
        {
            string strSQL = "DELETE HoaDon WHERE MAHD = '"+ HoaDon.MaHD+ "' ";
            KetNoiSQL.ExecuteNonQuery(strSQL);
        }
    }
}
