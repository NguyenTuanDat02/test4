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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiNhanVienLenDataGrid();
        }
        private void HienThiNhanVienLenDataGrid()
        {
            List<NhanVienDTO> lstNhanVien = NhanVienBUS.LayDSNhanVien();
            dgDSNhanVien.DataSource = lstNhanVien;
            dgDSNhanVien.Columns["Manv"].HeaderText = "Mã Nhân Viên";
            dgDSNhanVien.Columns["Tennv"].HeaderText = "Tên Nhân Viên";
            dgDSNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgDSNhanVien.Columns["Macv"].HeaderText = "Mã Chức Vụ";
            dgDSNhanVien.Columns["Diachi"].HeaderText = "Địa Chỉ";
            dgDSNhanVien.Columns["Ngaysinh"].HeaderText = "Ngày Sinh";
            dgDSNhanVien.Columns["Sdt"].HeaderText = "Số Điện Thoại";          
            dgDSNhanVien.Columns["Manv"].Width = 90;
            dgDSNhanVien.Columns["Tennv"].Width = 200;
            dgDSNhanVien.Columns["GioiTinh"].Width = 70;
            dgDSNhanVien.Columns["Macv"].Width = 90;
            dgDSNhanVien.Columns["Diachi"].Width = 100;
            dgDSNhanVien.Columns["Ngaysinh"].Width = 120;
            dgDSNhanVien.Columns["Sdt"].Width = 100;



        }
    }
}
