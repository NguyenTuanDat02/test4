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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            HienThiKhachHangLenDataGrid();
        }
        private void HienThiKhachHangLenDataGrid()
        {
            List<KhachHangDTO> lstKhachHang = KhachHangBUS.LayDSKhachHang();
            dgDSKhachHang.DataSource = lstKhachHang;
            dgDSKhachHang.Columns["Makh"].HeaderText = "Mã Khách Hàng";
            dgDSKhachHang.Columns["Tenkh"].HeaderText = "Tên Khách Hàng";
            dgDSKhachHang.Columns["Diachi"].HeaderText = "Địa Chỉ";
            dgDSKhachHang.Columns["Gioitinh"].HeaderText = "Giới Tính";
            dgDSKhachHang.Columns["Cmnd"].HeaderText = "Chứng Minh Nhân Dân";
            dgDSKhachHang.Columns["Sodt"].HeaderText = "Số Điện Thoại";
            dgDSKhachHang.Columns["Quoctich"].HeaderText = "QuốcTịch";
            dgDSKhachHang.Columns["Makh"].Width = 90;
            dgDSKhachHang.Columns["Tenkh"].Width = 200;
            dgDSKhachHang.Columns["Diachi"].Width = 120;
            dgDSKhachHang.Columns["Gioitinh"].Width = 70;
            dgDSKhachHang.Columns["Cmnd"].Width = 100;
            dgDSKhachHang.Columns["Sodt"].Width = 120;
            dgDSKhachHang.Columns["Quoctich"].Width = 90;
           

        }
    }
}
