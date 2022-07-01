using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class PhieuDangKyDAO
    {
        static SqlConnection con;
        public static List<PhieuDangKyDTO> LayDSPhieuDangKy()
        {
            string sTruyVan = "select * from phieudanggky";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhieuDangKyDTO> lstPhieuDangKy = new List<DTO.PhieuDangKyDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhieuDangKyDTO cv = new PhieuDangKyDTO();
                cv.Maphieudangky = dt.Rows[i]["maphieudangky"].ToString();
                cv.Makh = dt.Rows[i]["makhachhang"].ToString();
                cv.Manv = dt.Rows[i]["manhanvien"].ToString();
                cv.Maphong = dt.Rows[i]["maphong"].ToString();
                cv.Ngaylap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                cv.Ngaydi = DateTime.Parse(dt.Rows[i]["ngaydi"].ToString());
                cv.Tratruoc = int.Parse(dt.Rows[i]["tratruoc"].ToString());
                cv.Maphieudichvu = dt.Rows[i]["maphieudichvu"].ToString();
                lstPhieuDangKy.Add(cv);
            }

            DataProvider.DongKetNoi(con);
            return lstPhieuDangKy;

        }
        public static bool ThemPhieuDangKy(PhieuDangKyDTO cv)
        {
            string sTruyVan = string.Format(@"insert into phieudanggky values(N'{0}',
            N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')", cv.Maphieudangky, cv.Makh, cv.Manv, cv.Maphong, cv.Ngaylap, cv.Ngaydi, cv.Tratruoc, cv.Maphieudichvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static PhieuDangKyDTO TimPhieuDangKy(string ma)
        {
            string sTruyVan = string.Format(@"select * from phieudanggky where maphieudangky=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu phieudangkyDTO
            PhieuDangKyDTO cv = new PhieuDangKyDTO();
            cv.Maphieudangky = dt.Rows[0]["maphieudangky"].ToString();
            cv.Makh = dt.Rows[0]["makhachhang"].ToString();
            cv.Manv = dt.Rows[0]["manhanvien"].ToString();
            cv.Maphong = dt.Rows[0]["maphong"].ToString();
            cv.Ngaylap = DateTime.Parse(dt.Rows[0]["ngaylap"].ToString());
            cv.Ngaydi = DateTime.Parse(dt.Rows[0]["ngaydi"].ToString());
            cv.Tratruoc = int.Parse(dt.Rows[0]["tratruoc"].ToString());
            cv.Maphieudichvu = dt.Rows[0]["maphieudichvu"].ToString();
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool CapNhatPhieuDangKy(PhieuDangKyDTO cv)
        {
            string sTruyVan = string.Format(@"update phieudanggky set makhachhang='{0}',manhanvien='{1}',maphong='{2}',
               ngaylap='{3}', ngaydi='{4}',tratruoc='{5}',maphieudichvu='{6}' where maphieudangky=N'{7}'", cv.Maphieudangky, cv.Makh, cv.Manv, cv.Maphong, cv.Ngaylap, cv.Ngaydi, cv.Tratruoc, cv.Maphieudichvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaPhieuDangKy(PhieuDangKyDTO cv)
        {
            string sTruyVan = string.Format(@"delete from phieudanggky where maphieudangky=N'{0}'", cv.Maphieudangky);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

