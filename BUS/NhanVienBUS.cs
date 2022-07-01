using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        static public List<NhanVienDTO> LayDSNhanVien()
        {
            return NhanVienDAO.LayDSNhanVien();
        }
        public static bool ThemNhanVien(NhanVienDTO cv)
        {
            return NhanVienDAO.ThemNhanVien(cv);
        }

        public static NhanVienDTO TimNhanVien(string ma)
        {
            return NhanVienDAO.TimNhanVien(ma);
        }
        public static bool CapNhatNhanVien(NhanVienDTO cv)
        {
            return NhanVienDAO.CapNhatNhanVien(cv);
        }

        public static bool XoaNhanVien(NhanVienDTO cv)
        {
            return NhanVienDAO.XoaNhanVien(cv);
        }

    }
}

