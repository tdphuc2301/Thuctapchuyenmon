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
    public class BUS_HoaDon
    {
        public DataTable Table_No()
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            return DAL.Table_No();
        }
        public DataTable Table_Yes()
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            return DAL.Table_Yes();
        }
        public DataTable DanhSachHoaDon(string MaBan)
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            return DAL.DanhSachHoaDon(MaBan);
        }
        public DataTable HoaDonTheoMa(string MaHD)
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            return DAL.HoaDonTheoMa(MaHD);
        }
        public void Them(DTO_HoaDon MaHD)
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            DAL.Them(MaHD);
        }
        public void Sua(DTO_HoaDon MaHD)
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            DAL.Sua(MaHD);
        }
        public void Xoa(DTO_HoaDon MaHD)
        {
            DAL_HoaDon DAL = new DAL_HoaDon();
            DAL.Xoa(MaHD);
        }
    }
}
