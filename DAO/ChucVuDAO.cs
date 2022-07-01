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
    public class ChucVuDAO
    {
        static SqlConnection con;
        public static List<ChucVuDTO> LayDSChucVu()
        {
            string sTruyVan = "select * from chucvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVuDTO> lstChucVu = new List<DTO.ChucVuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.Macv= dt.Rows[i]["machucvu"].ToString();
                cv.Tencv = dt.Rows[i]["tenchucvu"].ToString();
                lstChucVu.Add(cv);

            }
            DataProvider.DongKetNoi(con);
            return lstChucVu;
        }
        public static bool ThemChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"insert into chucvu values(N'{0}',
              N'{1}')", cv.Macv, cv.Tencv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
            try
            {
                DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch (Exception ex)
            {
                DataProvider.DongKetNoi(con);
                return false;
            }
        }
        public static ChucVuDTO TimChucVu(string ma)
        {
            string sTruyVan = string.Format(@"select * from chucvu where machucvu=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            // Nếu có chuyển dữ liệu thành kiểu ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.Macv = dt.Rows[0]["machucvu"].ToString();
            cv.Tencv = dt.Rows[0]["tenchucvu"].ToString();
            DataProvider.DongKetNoi(con);
            return cv;
        }
        public static bool CapNhatChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"update chucvu set machucvu=N'{0}'
                where tenchucvu='{1}'", cv.Macv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"delete from chucvu where machucvu=N'{0}'", cv.Macv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

    }
}
