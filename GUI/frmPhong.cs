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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            HienThiPhongLenDataGrid();
        }
        private void HienThiPhongLenDataGrid()
        {
            List<PhongDTO> lstPhong = PhongBUS.LayDSPhong();
            dgDSPhong.DataSource = lstPhong;
            dgDSPhong.Columns["Maphong"].HeaderText = "Mã Phòng";
            dgDSPhong.Columns["Tenphong"].HeaderText = "Tên Phòng";
            dgDSPhong.Columns["Maloaiphong"].HeaderText = "Mã Loại Phòng";
            dgDSPhong.Columns["Tinhtrang"].HeaderText = "Tình Trạng";
            dgDSPhong.Columns["Giaphong"].HeaderText = "Giá Phòng";
            dgDSPhong.Columns["Donvi"].HeaderText = "Đơn Vị";
            dgDSPhong.Columns["Maphong"].Width = 90;
            dgDSPhong.Columns["Tenphong"].Width = 150;
            dgDSPhong.Columns["Maloaiphong"].Width = 90;
            dgDSPhong.Columns["Tinhtrang"].Width = 100;
            dgDSPhong.Columns["Giaphong"].Width = 90;
            dgDSPhong.Columns["Donvi"].Width = 60;

        }
    }
}
