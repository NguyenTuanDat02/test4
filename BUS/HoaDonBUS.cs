using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;



namespace BUS
{
    public class HoaDonBUS
    {
            public static List<HoaDonDTO> LayDSHoaDon()
            {
                return HoaDonDAO.LayDSHoaDon();
            }
            public static bool ThemHoaDon(HoaDonDTO cv)
            {
                return HoaDonDAO.ThemHoaDon(cv);
            }

            public static HoaDonDTO TimHoaDon(string ma)
            {
                return HoaDonDAO.TimHoaDon(ma);
            }
            public static bool CapNhatHoaDon(HoaDonDTO cv)
            {
                return HoaDonDAO.CapNhatHoaDon(cv);
            }

            public static bool XoaHoaDon(HoaDonDTO cv)
            {
                return HoaDonDAO.XoaHoaDon(cv);
            }

        }
    }
