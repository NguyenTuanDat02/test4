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
    public class PhongDAO
    {
       
            static SqlConnection con;
            public static List<PhongDTO> LayDSPhong()
            {
                string sTruyVan = "select * from phong";
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                List<PhongDTO> lstPhong = new List<DTO.PhongDTO>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PhongDTO cv = new PhongDTO();
                    cv.Maphong = dt.Rows[i]["maphong"].ToString();
                    cv.Tenphong = dt.Rows[i]["tenphong"].ToString();
                    cv.Tinhtrang = dt.Rows[i]["tinhtrang"].ToString();
                    cv.Maloaiphong = dt.Rows[i]["maloaiphong"].ToString();
                    cv.Giaphong = int.Parse(dt.Rows[i]["giaphong"].ToString());
                    cv.Donvi = dt.Rows[i]["donvi"].ToString();
                    lstPhong.Add(cv);
                }

                DataProvider.DongKetNoi(con);
                return lstPhong;

            }
            public static bool ThemPhong(PhongDTO cv)
            {
                string sTruyVan = string.Format(@"insert into phong values(N'{0}',
                 N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')", cv.Maphong, cv.Tenphong, cv.Tinhtrang, cv.Maloaiphong, cv.Giaphong, cv.Donvi);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static PhongDTO TimPhong(string ma)
            {
                string sTruyVan = string.Format(@"select * from phong where maphong=N'{0}'", ma);
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                // Nếu có chuyển dữ liệu thành kiểu PhongDTO
                PhongDTO cv = new PhongDTO();
                cv.Maphong = dt.Rows[0]["maphong"].ToString();
                cv.Tenphong = dt.Rows[0]["tenphong"].ToString();
                cv.Tinhtrang = dt.Rows[0]["tinhtrang"].ToString();
                cv.Maloaiphong = dt.Rows[0]["maloaiphong"].ToString();
                cv.Giaphong = int.Parse(dt.Rows[0]["giaphong"].ToString());
                cv.Donvi = dt.Rows[0]["donvi"].ToString();
                DataProvider.DongKetNoi(con);
                return cv;
            }
            public static bool CapNhatPhong(PhongDTO cv)
            {
                string sTruyVan = string.Format(@"update phong set tenphong='{0}',tinhtrang='{1}',maloaiphong='{2}',
                giaphong='{3}',donvi='{4}' where maphong=N'{5}'", cv.Maphong, cv.Tenphong, cv.Tinhtrang, cv.Maloaiphong, cv.Giaphong, cv.Donvi);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static bool XoaPhong(PhongDTO cv)
            {
                string sTruyVan = string.Format(@"delete from phong where maphong=N'{0}'", cv.Maphong);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }

        }
    }




