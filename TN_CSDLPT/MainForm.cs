using DevExpress.Pdf.Native;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.Subform;

namespace TN_CSDLPT
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MaLogin_ListItemClick(object sender, ListItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btn_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form f = this.CheckExists(typeof(frmDangNhap));
            if(f!= null)
            {
                f.Activate();
            }
            else
            {
                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.MdiParent = this;
                dangnhap.Show();
            }
        }

        public void HienThiMenu()
        {
            MA.Text = "MÃ : " + Program.userName;// để có thể hiện thị mã giảng viên hoặc mã sinh viên
            HOVATEN.Text = "Họ Tên : " + Program.AuthHoten;
            NHOM.Text = "NHÓM : " + Program.AuthGroup;

            //Phân quyền

           

            if(Program.AuthGroup == "TRUONG")
            {
                rib_HeThong.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = true;
                btn_TaoTaiKhoan.Enabled = true;
                btnChangePassword.Enabled = true;

                btnMONHOC.Enabled = true;
                btnKhoa_Lop.Enabled = true;
                btnSinhVien.Enabled = true;
                btnDANGKI_THI.Enabled = true;
                btnGiangVien.Enabled = true;
                btnBODE.Enabled = true;

                btnXemDiem.Enabled = true;
                btnDSDK.Enabled = true;

                btnXemLaiBaiThi.Enabled = false;
                btnTHI.Enabled = false;
            }
            
            else if(Program.AuthGroup == "COSO")
            {
                rib_HeThong.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = true;

                btn_TaoTaiKhoan.Enabled = true;
                btnChangePassword.Enabled = true;

                btnMONHOC.Enabled = true;
                btnKhoa_Lop.Enabled = true;
                btnSinhVien.Enabled = true;
                btnDANGKI_THI.Enabled = true;
                btnGiangVien.Enabled = true;
                btnBODE.Enabled = true;

                btnXemDiem.Enabled = true;
                btnDSDK.Enabled = true;

                btnXemLaiBaiThi.Enabled = false;
                btnTHI.Enabled = false;

            }    

            else if(Program.AuthGroup == "GIANGVIEN")
            {

                rib_HeThong.Visible = rib_NghiepVu.Visible = true;
                btn_TaoTaiKhoan.Enabled = false;
                btnChangePassword.Enabled = true;

                btnMONHOC.Enabled = false;
                btnKhoa_Lop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnDANGKI_THI.Enabled = true;
                btnGiangVien.Enabled = false;
                btnBODE.Enabled = true;
                btnTHI.Enabled = true;


                btnXemDiem.Enabled = false;
                btnDSDK.Enabled = false;
                btnXemLaiBaiThi.Enabled = false;


            }
            else 
            {
                
                rib_HeThong.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = true;

                btn_TaoTaiKhoan.Enabled = false;
                btnChangePassword.Enabled = true;

                btnMONHOC.Enabled = false;
                btnKhoa_Lop.Enabled = false;
                btnSinhVien.Enabled = false;
                btnDANGKI_THI.Enabled = false;
                btnGiangVien.Enabled = false;
                btnBODE.Enabled = false;
                btnTHI.Enabled = true;


                btnXemDiem.Enabled = false;
                btnDSDK.Enabled = false;
                btnXemLaiBaiThi.Enabled = true;
            }


            btn_DangXuat.Enabled = true;
            btn_DangNhap.Enabled = false;
        }

        public void logout()
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Dispose();// giai phong cac form con  khoi bo nho 
            }
            btn_DangNhap.Enabled = true;
            rib_NghiepVu.Visible = rib_BaoCao.Visible = false;
            btn_DangXuat.Enabled = btn_TaoTaiKhoan.Enabled = false;
            btnChangePassword.Enabled = false;
            Program.AuthLogin = "";
            Program.AuthHoten = "";
            Program.AuthGroup = "";


            foreach (Form f in this.MdiChildren)
                f.Dispose();

            MA.Text = "MÃ : " + Program.AuthLogin;
            HOVATEN.Text = "Họ Tên : " + Program.AuthHoten;
            NHOM.Text = "NHÓM : " + Program.AuthGroup;
        }
        private void btn_TaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmTaoTaiKhoan taoTaiKhoan = new frmTaoTaiKhoan();
                taoTaiKhoan.MdiParent = this;
                taoTaiKhoan.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();
        }
        /*private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }*/
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if(Program.AuthGroup == "TRUONG" || Program.AuthGroup =="COSO")
            {
                btn_TaoTaiKhoan.Enabled = true;
            }
            else
            {
                btn_TaoTaiKhoan.Enabled = false;
            }
        }

        

       

        private void btnMONHOC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(MonHocForm));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                MonHocForm formMH = new MonHocForm();
                formMH.MdiParent = this;
                formMH.Show();
            }
        }

        private void btnSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(MonHocForm));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmSinhVien formSV= new frmSinhVien();
                formSV.MdiParent = this;
                formSV.Show();
            }
        }

        private void btnKhoa_Lop_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmKhoaAndLop));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKhoaAndLop frmKHOA_LOp = new frmKhoaAndLop();
               
                frmKHOA_LOp.MdiParent = this;
                frmKHOA_LOp.Show();
            }
        }

        private void btnTHI_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmEXAM));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmEXAM formTHI = new frmEXAM();
                formTHI.MdiParent = this;
                formTHI.Show();
            }
        }

        private void btnBODE_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmThiThu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmBoDe1 formbode = new frmBoDe1();
                formbode.MdiParent = this;
                formbode.Show();
            }
        }

        private void btnDANGKI_THI_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangKiTHI));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                
                frmDangKiTHI dangkiTHI = new frmDangKiTHI();
                dangkiTHI.MdiParent = this;
                dangkiTHI.Show();
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnGiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmGiangVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {

                frmGiangVien gv = new frmGiangVien();
                gv.MdiParent = this;
                gv.Show();
            }
        }

        private void btnXemLaiBai_ItemClick(object sender, ItemClickEventArgs e)
        {
           frmThiThu baithi = new frmThiThu();
            baithi.MdiParent = this;
            baithi.Show();
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword();
            changePassword.MdiParent = this;
            changePassword.Show();
        }

        private void btnXemLaiBaiThi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrptXemLaiBaiThi checkIn = new FrptXemLaiBaiThi();
            checkIn.MdiParent = this;
            checkIn.Show();
        }

        private void btnXemDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrptXemDiemLop report = new FrptXemDiemLop();
            report.MdiParent = this;
            report.Show();

        }

        private void btnDSDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrptDanhSachDangKiTHI report = new FrptDanhSachDangKiTHI();
            report.MdiParent = this;
            report.Show();
        }
    }
}