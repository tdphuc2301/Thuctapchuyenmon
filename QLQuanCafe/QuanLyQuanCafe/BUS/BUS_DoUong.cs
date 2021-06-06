﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DoUong
    {
        public DataTable DanhSachDoUong()
        {
            DAL_DoUong DAL = new DAL_DoUong();
            return DAL.DanhSachDoUong();
        }
        public DataTable DanhSachTimKiem(string MaDo_Uong, string TenDo_Uong, decimal DonGia, decimal SoLuongTon, string GhiChu)
        {
            DAL_DoUong DAL = new DAL_DoUong();
            DataTable dtList = DAL.DanhSachTimKiem(MaDo_Uong, TenDo_Uong, DonGia, SoLuongTon, GhiChu);
            return dtList;
        }
        public void Xoa(DTO_DoUong MaDo_Uong)
        {
            DAL_DoUong DAL = new DAL_DoUong();
            DAL.Xoa(MaDo_Uong);
        }
        public void Sua(DTO_DoUong MaDo_Uong)
        {
            DAL_DoUong DAL = new DAL_DoUong();
            DAL.Sua(MaDo_Uong);
        }
        public void Them(DTO_DoUong MaDo_Uong)
        {
            DAL_DoUong DAL = new DAL_DoUong();
            DAL.Them(MaDo_Uong);
        }
        public int KiemTraTrung(string MaTK_NV)
        {
            DAL_DoUong DAL = new DAL_DoUong();
            int i = DAL.KiemTraTrung(MaTK_NV);
            return i;
        }
    }
}
