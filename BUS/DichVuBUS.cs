using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DichVuBUS
    {
        public static List<DichVuDTO> LayDSDichVu()
        {
            return DichVuDAO.LayDSDichVu();
        }
        public static bool ThemDichVu(DichVuDTO cv)
        {
            return DichVuDAO.ThemDichVu(cv);
        }

        public static DichVuDTO TimDichVu(string ma)
        {
            return DichVuDAO.TimDichVu(ma);
        }
        public static bool CapNhatDichVu(DichVuDTO cv)
        {
            return DichVuDAO.CapNhatDichVu(cv);
        }

        public static bool XoaDichVu(DichVuDTO cv)
        {
            return DichVuDAO.XoaDichVu(cv);
        }

    }
}
