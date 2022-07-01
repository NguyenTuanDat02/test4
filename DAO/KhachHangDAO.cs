using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;
namespace DAO
{
    public class KhachHangDAO
    {
        static SqlConnection con;
        public static List<KhachHangDTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHangDTO> lstKhachHang = new List<DTO.KhachHangDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHangDTO cv = new KhachHangDTO();
                cv.Makh= dt.Rows[i]["makhachhang"].ToString();
                cv.Tenkh = dt.Rows[i]["tenkhachhang"].ToString();
                cv.Diachi= dt.Rows[i]["diachi"].ToString();
                cv.GioiTinh = dt.Rows[i]["gioitinh"].ToString();
                cv.Cmnd = dt.Rows[i]["cmnd"].ToString();
                cv.Sodt = int.Parse(dt.Rows[i]["sdt"].ToString());
                cv.Quoctich = dt.Rows[i]["quoctich"].ToString();
                lstKhachHang.Add(cv);

            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
        public static bool ThemKhachHang(KhachHangDTO cv)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',
            N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", cv.Makh,cv.Tenkh, cv.Diachi,cv.GioiTinh, cv.Cmnd ,cv.Sodt, cv.Quoctich);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static KhachHangDTO TimKhachHang(string ma)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makhachhang=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu ChucVuDTO
            KhachHangDTO cv = new KhachHangDTO();
            cv.Makh = dt.Rows[0]["makhanhhang"].ToString();
            cv.Tenkh = dt.Rows[0]["tenkhachhang"].ToString();
            cv.Diachi = dt.Rows[0]["diachi"].ToString();
            cv.GioiTinh = dt.Rows[0]["gioitinh"].ToString();
            cv.Cmnd = dt.Rows[0]["cmnd"].ToString();
            cv.Sodt = int.Parse(dt.Rows[0]["sdt"].ToString());
            cv.Quoctich = dt.Rows[0]["quoctich"].ToString();
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool CapNhatKhachHang(KhachHangDTO cv)
        {
            string sTruyVan = string.Format(@"update khachhang set tenkhachhang='{0}', diachi='{1}',gioitinh='{2}',
             cmnd='{3}', sdt='{4}',quoctich='{5}' where makhachhang=N'{6}'", cv.Makh, cv.Tenkh, cv.Diachi, cv.GioiTinh, cv.Cmnd, cv.Sodt, cv.Quoctich);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaKhachHang(KhachHangDTO cv)
        {
            string sTruyVan = string.Format(@"delete from khachhang where makhachhang=N'{0}'", cv.Makh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

