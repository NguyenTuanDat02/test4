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
    public class LoaiPhongDAO
    {
        static SqlConnection con;
        public static List<LoaiPhongDTO> LayDSLoaiPhong()
        {
            string sTruyVan = "select * from loaiphong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LoaiPhongDTO> lstLoaiPhong = new List<DTO.LoaiPhongDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LoaiPhongDTO cv = new LoaiPhongDTO();
                cv.Maloaiphong = dt.Rows[i]["maloaiphong"].ToString();
                cv.Tenloaiphong = dt.Rows[i]["tenloaiphong"].ToString();
                cv.Trangbi= dt.Rows[i]["trangbi"].ToString();
                lstLoaiPhong.Add(cv);

            }
            DataProvider.DongKetNoi(con);
            return lstLoaiPhong;
        }
            public static bool ThemLoaiPhong(LoaiPhongDTO cv)
            {
                string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',
            N'{1}',N'{2}')", cv.Maloaiphong, cv.Tenloaiphong, cv.Trangbi);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static LoaiPhongDTO TimLoaiPhong(string ma)
            {
                string sTruyVan = string.Format(@"select * from loaiphong where maloaiphong=N'{0}'", ma);
                con = DataProvider.MoKetNoi();
                DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                // Nếu có chuyển dữ liệu thành kiểu ChucVuDTO
                LoaiPhongDTO cv = new LoaiPhongDTO();
                cv.Maloaiphong = dt.Rows[0]["maloaiphong"].ToString();
                cv.Tenloaiphong = dt.Rows[0]["tenloaiphong "].ToString();
                cv.Trangbi = dt.Rows[0]["trangbi"].ToString();
                DataProvider.DongKetNoi(con);
                return cv;
            }
            public static bool CapNhatLoaiPhong(LoaiPhongDTO cv)
            {
                string sTruyVan = string.Format(@"update loaiphong set tenloaiphong='{0}',trangbi='{1}'
              where maloaiphong='{2}'", cv.Maloaiphong, cv.Tenloaiphong, cv.Trangbi);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }
            public static bool XoaLoaiPhong(LoaiPhongDTO cv)
            {
                string sTruyVan = string.Format(@"delete from loaiphong where maloaiphong=N'{0}'", cv.Maloaiphong);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
            }

        }
    }


