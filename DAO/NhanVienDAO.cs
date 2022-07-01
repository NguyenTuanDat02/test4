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
      public class NhanVienDAO
    {
        static SqlConnection con;
        public static List<NhanVienDTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVienDTO> lstNhanVien = new List<DTO.NhanVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVienDTO cv = new NhanVienDTO();
                cv.Manv = dt.Rows[i]["manhanvien"].ToString();
                cv.Tennv = dt.Rows[i]["tennhanvien"].ToString();
                cv.Macv = dt.Rows[i]["machucvu"].ToString();
                cv.Diachi = dt.Rows[i]["diachi"].ToString();
                cv.GioiTinh = dt.Rows[i]["gioitinh"].ToString();
                cv.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                cv.Sdt = int.Parse(dt.Rows[i]["sdt"].ToString());
                lstNhanVien.Add(cv);
            }

            DataProvider.DongKetNoi(con);
            return lstNhanVien;

        }
            public static bool ThemNhanVien(NhanVienDTO cv)
            {
                string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',
                N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", cv.Manv, cv.Tennv, cv.Macv, cv.Diachi, cv.GioiTinh, cv.Ngaysinh, cv.Sdt);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static NhanVienDTO TimNhanVien(string ma)
            {
                string sTruyVan = string.Format(@"select * from nhanvien where manhanvien=N'{0}'", ma);
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                // Nếu có chuyển dữ liệu thành kiểu NhanVienDTO
                 NhanVienDTO cv = new NhanVienDTO();
                cv.Manv = dt.Rows[0]["manhanvien"].ToString();
                cv.Tennv = dt.Rows[0]["tennhanvien"].ToString();
                cv.Macv = dt.Rows[0]["machucvu"].ToString();
                cv.Diachi = dt.Rows[0]["diachi"].ToString();
                cv.GioiTinh = dt.Rows[0]["gioitinh"].ToString();
                cv.Ngaysinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
                cv.Sdt = int.Parse(dt.Rows[0]["sdt"].ToString());
                DataProvider.DongKetNoi(con);
                return cv;
            }
            public static bool CapNhatNhanVien(NhanVienDTO cv)
            {
                string sTruyVan = string.Format(@"update nhanvien set tennhanvien='{0}', machucvu='{1}',diachi='{2}',
                gioitinh='{3}', ngaysinh='{4}',sdt='{5}' where manhanvien=N'{6}'", cv.Manv, cv.Tennv, cv.Macv, cv.Diachi, cv.GioiTinh, cv.Ngaysinh, cv.Sdt);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static bool XoaNhanVien(NhanVienDTO cv)
            {
                string sTruyVan = string.Format(@"delete from nhanvien where manhanvien=N'{0}'", cv.Manv);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }

        }
    }


