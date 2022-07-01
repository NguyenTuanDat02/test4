using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiPhongBUS
    {
        public static List<LoaiPhongDTO> LayDSLoaiPhong()
        {
            return LoaiPhongDAO.LayDSLoaiPhong();
        }
        public static bool ThemLoaiPhong(LoaiPhongDTO cv)
        {
            return LoaiPhongDAO.ThemLoaiPhong(cv);
        }

        public static LoaiPhongDTO TimLoaiPhong(string ma)
        {
            return LoaiPhongDAO.TimLoaiPhong(ma);
        }
        public static bool CapNhatLoaiPhong(LoaiPhongDTO cv)
        {
            return LoaiPhongDAO.CapNhatLoaiPhong(cv);
        }

        public static bool XoaLoaiPhong(LoaiPhongDTO cv)
        {
            return LoaiPhongDAO.XoaLoaiPhong(cv);
        }

    }
}
