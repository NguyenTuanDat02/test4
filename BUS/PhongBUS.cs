using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhongBUS
    {
        static public List<PhongDTO> LayDSPhong()
        {
            return PhongDAO.LayDSPhong();
        }
        public static bool ThemPhong(PhongDTO cv)
        {
            return PhongDAO.ThemPhong(cv);
        }

        public static PhongDTO TimPhong(string ma)
        {
            return PhongDAO.TimPhong(ma);
        }
        public static bool CapNhatv(PhongDTO cv)
        {
            return PhongDAO.CapNhatPhong(cv);
        }

        public static bool XoaPhong(PhongDTO cv)
        {
            return PhongDAO.XoaPhong(cv);
        }

    }
}

