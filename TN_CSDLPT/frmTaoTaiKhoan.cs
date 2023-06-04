using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf.Compression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.Class;
using TN_CSDLPT.Subform;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TN_CSDLPT
{
    public partial class frmTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {

        private string txtGiangVien = "";
        //private String taikhoan = "", makhau = "", maGiangVien = "", chucVu = "";


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

            if(txtMatKhau.Text.Trim() != txtXacNhanMatKhau.Text.Trim())
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            return true;
        }


        private void txtMaGiangVien_Validating(object sender, CancelEventArgs e)
        {

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;

            txtXacNhanMatKhau.UseSystemPasswordChar=true;

            var target = new List<RoleClass>(Program.roles);

            this.cmbQuyen.DataSource = target;
            this.cmbQuyen.DisplayMember = "MAQUYEN";
            this.cmbQuyen.ValueMember = "TENQUYEN";


        }

        private void btnChonGiangVien_Click(object sender, EventArgs e)
        {
            ChonGiangVien click = new ChonGiangVien();
            click.ShowDialog();
            txtMaGiangVien.Text = Program.MaGVDaChon;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(KiemTraDuLieuDauVao()== false)
            {
                return;
            }
            // kiểm t
            String truyvan = "DECLARE @kq INT " + "EXEC @kq= sp_danh_sach_username_database '" + txtMaGiangVien.Text.Trim() + "' " + "select 'Value' =  @kq";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int KETQUA = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(KETQUA == 1)
            {
                MessageBox.Show("Mã Nhân Viên đã tồn tại tài khoản", "Warning", MessageBoxButtons.OK);
                return;
            }

            String truyvan1 = "DECLARE @kq INT " + "EXEC @kq= sp_danh_sach_login_server '" + txtMaGiangVien.Text.Trim() + "' " + "select 'Value' =  @kq";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int KETQUA1 = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (KETQUA1 == 1)
            {
                MessageBox.Show("User name để login đã tồn tại", "Warning", MessageBoxButtons.OK);
                return;
            }

            // Tạo tài khoản ở site hiện tại
            string query = "EXEC sp_TaoTaiKhoan '" + txtLoginName.Text.Trim() + "','" + txtMatKhau.Text.Trim() + "','" +
            txtMaGiangVien.Text.Trim() + "','" + cmbQuyen.Text.Trim() + "'";
            int result = Program.ExecSqlNonQuery(query);
            if (result == 0)
            {
                XtraMessageBox.Show("Tạo login thành công!", "Thành công", MessageBoxButtons.OK);
                return;
            }

            //
           
            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}