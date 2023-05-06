using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {

        private string txtGiangVien = "";
        //private String taikhoan = "", makhau = "", maGiangVien = "", chucVu = "";

        private void button2_Click(object sender, EventArgs e)
        {
           /* bool ketqua = KiemTraDuLieuDauVao();
            if (ketqua == false) return;
            taikhoan = Program.mHoten;
            makhau = txtMatKhau.Text;
            
            */

        }


        private void txtLoginName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGiangVien.Text)) return;

            if (string.IsNullOrWhiteSpace(txtLoginName.Text))
            {
                e.Cancel = true;
                txtLoginName.Focus();
                errorProvider1.SetError(txtLoginName, "Vui lòng điền Login name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLoginName, "");
            }

        }


        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoginName.Text))
                return;
            if(string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                e.Cancel= true;
                txtMatKhau.Focus();
                errorProvider1.SetError(txtMatKhau, "Vui lòng điền mật khẩu");


            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMatKhau, "");
            }

        }

        private void txtXacNhanMatKhau_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                return;
            if (string.IsNullOrWhiteSpace(txtXacNhanMatKhau.Text))
            {
                e.Cancel = true;
                txtXacNhanMatKhau.Focus();
                errorProvider1.SetError(txtXacNhanMatKhau, "Vui lòng điền mật khẩu xác nhận!");
            }
            else if (!txtXacNhanMatKhau.Text.Equals(txtMatKhau.Text))
            {
                e.Cancel = true;
                txtXacNhanMatKhau.Focus();
                errorProvider1.SetError(txtXacNhanMatKhau, "Mật khẩu xác nhận không đúng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtXacNhanMatKhau, "");
            }
        }

        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }


        private bool KiemTraDuLieuDauVao()
        {
            if(txtLoginName.Text =="")
            {
                MessageBox.Show("Thiếu Mã Giảng Viên ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(txtMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            if(txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaGiangVien_Validating(object sender, CancelEventArgs e)
        {

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
            txtXacNhanMatKhau.UseSystemPasswordChar=true;
        }
    }
}