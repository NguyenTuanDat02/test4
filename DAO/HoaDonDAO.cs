using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class HoaDonDAO
    {
        static SqlConnection con;
        public static List<HoaDonDTO> LayDSHoaDon()
        {
            string sTruyVan = "select * from hoadon";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDonDTO> lstHoaDon = new List<DTO.HoaDonDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonDTO cv = new HoaDonDTO();
                cv.Mahoadon = dt.Rows[i]["mahoadon"].ToString();
                cv.Ngaythanhtoan = DateTime.Parse(dt.Rows[i]["ngaythanhtoan"].ToString());
                cv.Sotiendattruoc = int.Parse(dt.Rows[i]["sotiendattruoc"].ToString());
                cv.Donvi = dt.Rows[i]["donvi"].ToString();
                cv.Manhanvien = dt.Rows[i]["manhanvien"].ToString();
                lstHoaDon.Add(cv);

            }
            DataProvider.DongKetNoi(con);
            return lstHoaDon;
        }
        public static bool ThemHoaDon(HoaDonDTO cv)
        {
            string sTruyVan = string.Format(@"insert into hoadon values(N'{0}',
              N'{1}',N'{2}',N'{3}',N'{4}')", cv.Mahoadon,cv.Ngaythanhtoan,cv.Sotiendattruoc,cv.Donvi, cv.Manhanvien,cv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static HoaDonDTO TimHoaDon(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadon where machucvu=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu HoaDonDTO
            HoaDonDTO cv = new HoaDonDTO();
            cv.Mahoadon = dt.Rows[0]["mahoadon"].ToString();
            cv.Ngaythanhtoan = DateTime.Parse(dt.Rows[0]["ngaythanhtoan"].ToString());
            cv.Sotiendattruoc = int.Parse(dt.Rows[0]["sotientratruoc"].ToString());
            cv.Donvi = dt.Rows[0]["donvi"].ToString();
            cv.Manhanvien = dt.Rows[0]["manhanvien"].ToString();
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool CapNhatHoaDon(HoaDonDTO cv)
        {
            string sTruyVan = string.Format(@"update hoadon set ngaythanhtoan='{0}',sotiendattruoc='{1},donvi=N'{2}',
             manhanvien=N'{3}' where mahoadon=N'{4}' ", cv.Mahoadon, cv.Ngaythanhtoan, cv.Sotiendattruoc, cv.Donvi, cv.Manhanvien, cv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHoaDon(HoaDonDTO cv)
        {
            string sTruyVan = string.Format(@"delete from hoadon where mahoadon=N'{0}'", cv.Mahoadon);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

    