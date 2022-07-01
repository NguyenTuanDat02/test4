using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmchucvu : Form
    {
        public frmchucvu()
        {
            InitializeComponent();
        }

        private void HienThiChucVuLenDataGrid()
        {
            List<ChucVuDTO> lstChucVu = ChucVuBUS.LayDSChucVu();
            dgDSChucVu.DataSource = lstChucVu;
            dgDSChucVu.Columns["Macv"].HeaderText = "Mã Chức Vụ";
            dgDSChucVu.Columns["Tencv"].HeaderText = "tên Chức Vụ";
            dgDSChucVu.Columns["Macv"].Width = 90;
            dgDSChucVu.Columns["Tencv"].Width = 150;


        }

        private void frmchucvu_Load(object sender, EventArgs e)
        {
            HienThiChucVuLenDataGrid();

        }
        private void dgDSChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSChucVu.SelectedRows[0];
            textBox1.Text = r.Cells["Macv"].Value.ToString();
            textBox2.Text = r.Cells["Tencv"].Value.ToString();
        }
     

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã chức vụ có độ dài chuỗi hợp lệ hay không
            if (textBox1.Text.Length > 3)
            {
                MessageBox.Show("Mã chức vụ tối đa 3 ký tự!");
                return;
            }
            // Kiểm tra mã chức vụ có bị trùng không
            if (ChucVuBUS.TimChucVu(textBox1.Text) != null)
            {
                MessageBox.Show("Mã chức vụ đã tồn tại!");
                return;
            }

            ChucVuDTO cv = new ChucVuDTO();
            cv.Macv = textBox1.Text;
            cv.Tencv = textBox2.Text;
            if (ChucVuBUS.ThemChucVu(cv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiChucVuLenDataGrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

    

    private void btnxoa_Click(object sender, EventArgs e)
        {
           // kiểm tra mã có tồn tại
            if (textBox1.Text == "" || ChucVuBUS.TimChucVu(textBox1.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            ChucVuDTO nv = new ChucVuDTO();
            nv.Macv = textBox1.Text;
            nv.Tencv = textBox2.Text;

            if (ChucVuBUS.XoaChucVu(nv) == true)
            {
                HienThiChucVuLenDataGrid();
                MessageBox.Show("Đã xóa Chức Vụ.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
           

        }

        private void btntim_Click(object sender, EventArgs e)
        {
           
            string ma = txttim.Text;
            List<ChucVuDTO> lstcv = ChucVuBUS.TimChucVu(ma);
            if (lstcv == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSChucVu.DataSource = lstcv;
        }

        private void txttim_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           
                // kiểm tra mã có tồn tại
                if (textBox1.Text == "" || ChucVuBUS.TimChucVu(textBox1.Text) == null)
                {
                    MessageBox.Show("Vui lòng chọn mã nhân viên!");
                    return;
                }
                ChucVuDTO cv = new ChucVuDTO();
                cv.Macv = textBox1.Text;
                cv.Tencv = textBox2.Text;
                if (ChucVuBUS.CapNhatChucVu(cv) == true)
                {
                HienThiChucVuLenDataGrid();
                MessageBox.Show("Đã cập nhật thông tin Chức Vụ.");
                }
                else
                {
                    MessageBox.Show("Không cập nhật được.");
                }
            
        }
    }
}
