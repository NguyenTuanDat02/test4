using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            HienThiHoaDonLenDataGrid();
        }
        private void HienThiHoaDonLenDataGrid()
        {
            List<HoaDonDTO> lstHoaDon = HoaDonBUS.LayDSHoaDon();
            dgDSHoaDon.DataSource = lstHoaDon;
            dgDSHoaDon.Columns["Mahoadon"].HeaderText = "Mã Hóa Đơn";
            dgDSHoaDon.Columns["Ngaythanhtoan"].HeaderText = "ngày Thanh Toán";
            dgDSHoaDon.Columns["Sotiendattruoc"].HeaderText = "Số Tiền Đặt Trước";
            dgDSHoaDon.Columns["Donvi"].HeaderText = "Đơn Vị";
            dgDSHoaDon.Columns["Mahoadon"].Width = 90;
            dgDSHoaDon.Columns["Ngaythanhtoan"].Width = 150;
            dgDSHoaDon.Columns["Sotiendattruoc"].Width = 90;
            dgDSHoaDon.Columns["Donvi"].Width =60;

        }
    }
}
