using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKe
    {
        public DataTable XemLaiHoaDon(DateTime ngay1, DateTime ngay2, string MaBan)
        {
            string strSQL = "SELECT NgayHoaDon,TenBan,TenKH,TenDo_Uong,a.DonGia,a.SoLuong,ThanhTien ";
            strSQL += "FROM HoaDon a LEFT JOIN Ban b ON a.MaBan = b.MaBan ";
            strSQL += "LEFT JOIN KhachHang c ON a.MaKH = c.MaKH ";
            strSQL += "LEFT JOIN DoUong d ON a.MaDo_Uong = d.MaDo_Uong ";
            strSQL += " WHERE CONVERT(DATETIME, NgayHoaDon,103) BETWEEN CONVERT(DATETIME, '" + ngay1 + "',103) AND CONVERT(DATETIME, '" + ngay2 + "',103) AND a.MaBan ='" + MaBan + "' AND TrangThai = '1'";
            return KetNoiSQL.GetData(strSQL);
        }
        public DataTable ThongKeDoanhThu(DateTime ngay1, DateTime ngay2)
        {
            string strSQL = "SELECT SUM(ThanhTien) AS ThanhTien,NgayHoaDon,TenBan FROM HoaDon a LEFT JOIN Ban b ON a.MaBan = b.MaBan WHERE CONVERT(DATETIME, NgayHoaDon,103) BETWEEN CONVERT(DATETIME, '" + ngay1 + "',103) AND CONVERT(DATETIME, '" + ngay2 + "',103) AND TrangThai = '1' GROUP BY NgayHoaDon,TenBan ";
            return KetNoiSQL.GetData(strSQL);
        }
    }
}
