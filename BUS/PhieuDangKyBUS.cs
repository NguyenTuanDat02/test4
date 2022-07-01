using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhieuDangKyBUS
    {
        static public List<PhieuDangKyDTO> LayDSPhieuDangKy()
        {
            return PhieuDangKyDAO.LayDSPhieuDangKy();
        }
        public static bool ThemPhieuDangKy(PhieuDangKyDTO cv)
        {
            return PhieuDangKyDAO.ThemPhieuDangKy(cv);
        }

        public static PhieuDangKyDTO TimPhieuDangKy(string ma)
        {
            return PhieuDangKyDAO.TimPhieuDangKy(ma);
        }
        public static bool CapNhatPhieuDangKy(PhieuDangKyDTO cv)
        {
            return PhieuDangKyDAO.CapNhatPhieuDangKy(cv);
        }

        public static bool XoaPhieuDangKy(PhieuDangKyDTO cv)
        {
            return PhieuDangKyDAO.XoaPhieuDangKy(cv);
        }

    }
}

