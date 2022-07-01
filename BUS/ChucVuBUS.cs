using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVuBUS
    {
        public static List<ChucVuDTO> LayDSChucVu()
        {
            return ChucVuDAO.LayDSChucVu();
        }
        public static bool ThemChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.ThemChucVu(cv);
        }

        public static ChucVuDTO TimChucVu(string ma)
        {
            return ChucVuDAO.TimChucVu(ma);
        }
        public static bool CapNhatChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.CapNhatChucVu(cv);
        }

        public static bool XoaChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.XoaChucVu(cv);
        }

    }
}
