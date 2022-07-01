using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
    
    public static List<KhachHangDTO> LayDSKhachHang()
    {
        return KhachHangDAO.LayDSKhachHang();
    }
    public static bool ThemKhachHang(KhachHangDTO cv)
    {
        return KhachHangDAO.ThemKhachHang(cv);
    }

    public static KhachHangDTO TimKhachHang(string ma)
    {
        return KhachHangDAO.TimKhachHang(ma);
    }
    public static bool CapNhatKhachHang(KhachHangDTO cv)
    {
        return KhachHangDAO.CapNhatKhachHang(cv);
    }

    public static bool XoaKhachHang(KhachHangDTO cv)
    {
        return KhachHangDAO.XoaKhachHang(cv);
    }

}
    }
