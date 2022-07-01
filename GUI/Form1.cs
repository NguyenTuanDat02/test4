using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }    
         
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string user = txttaikhoan.Text.Trim();
            string password = txtmatkhau.Text.Trim();
            string err = string.Empty;
            if (user == string.Empty)
                err = "bạn vui lòng nhập tài khoản để đăng nhập ";
            if (password == string.Empty)
                err += "\n bạn chưa nhập mặt khẩu ";
            if(err!=string.Empty)
            {
                MessageBox.Show("Lỗi: " + err);
                return;
            }
            if(err == string.Empty)
            {
                MessageBox.Show("đăng nhập thành công");
                this.Hide();
                frmgiaodien frm = new frmgiaodien();
                frm.ShowDialog();

            }    
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có chắc chắn muốn thoát ?", "xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)      
                this.Close();
 
        }
    }
}
