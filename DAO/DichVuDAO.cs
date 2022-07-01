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
    public class DichVuDAO
    {
        static SqlConnection con;
        public static List<DichVuDTO> LayDSDichVu()
        {
            string sTruyVan = "select * from dichvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DichVuDTO> lstDichVu = new List<DTO.DichVuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DichVuDTO cv = new DichVuDTO();
                cv.Maphieudichvu = dt.Rows[i]["maphieudichvu"].ToString();
                cv.Maphieudangky = dt.Rows[i]["maphieudangky"].ToString();
                cv.Tendichvu = dt.Rows[i]["tendichvu"].ToString();
                cv.Giadichvu = int.Parse(dt.Rows[i]["giadichvu"].ToString());
                lstDichVu.Add(cv);

            }
            DataProvider.DongKetNoi(con);
            return lstDichVu;
        }
        public static bool ThemDichVu(DichVuDTO cv)
        {
            string sTruyVan = string.Format(@"insert into dichvu values(N'{0}',
            N'{1}',N'{2}',N'{3}')", cv.Maphieudichvu, cv.Maphieudangky, cv.Tendichvu, cv.Giadichvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static DichVuDTO TimDichVu(string ma)
        {
            string sTruyVan = string.Format(@"select * from dichvu where maphieudichvu=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu ChucVuDTO
            DichVuDTO cv = new DichVuDTO();
            cv.Maphieudichvu = dt.Rows[0]["maphieudichvu"].ToString();
            cv.Maphieudangky = dt.Rows[0]["maphieudangky"].ToString();
            cv.Tendichvu = dt.Rows[0]["tendichvu"].ToString();
            cv.Giadichvu = int.Parse(dt.Rows[0]["giadichvu"].ToString());
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool CapNhatDichVu(DichVuDTO cv)
        {
            string sTruyVan = string.Format(@"update dichvu set maphieudangky='{0}', tendichvu='{1}',
               ,giadichvu='{2}' where maphieudichvu = N'{3}'", cv.Maphieudichvu, cv.Maphieudangky, cv.Tendichvu, cv.Giadichvu); 
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaDichVu(DichVuDTO cv)
        {
            string sTruyVan = string.Format(@"delete from dichvu where maphieudichvu=N'{0}'", cv.Maphieudichvu);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}

