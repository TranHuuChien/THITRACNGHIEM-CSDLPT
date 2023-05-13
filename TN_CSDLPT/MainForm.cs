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
                this.btn_TaoTaiKhoan.Enabled = true;
                this.btnMONHOC.Enabled = true;
                this.btnKhoa_Lop.Enabled = true;
                this.btnSinhVien.Enabled = true;
                this.btnDANGKI_THI.Enabled = true;
                
            }
            
            else if(Program.AuthGroup == "COSO")
            {
                rib_HeThong.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = true;
                this.btn_TaoTaiKhoan.Enabled = true;
                this.btnMONHOC.Enabled = true;
                this.btnKhoa_Lop.Enabled = true;
                this.btnSinhVien.Enabled = true;
                this.btnBODE.Enabled = false;
                this.btnDANGKI_THI.Enabled = true;
         
            }    

            else if(Program.AuthGroup == "GIANGVIEN")
            {
                btn_TaoTaiKhoan.Enabled = false;

                rib_HeThong.Visible = rib_NghiepVu.Visible = true;
                
                btnTHI.Enabled = true;// vì trong phân quyền yêu cầu GV được thi thử nhưng không ghi điểm
                btnDANGKI_THI.Enabled = false;
                btnBODE.Enabled=true;
            }
            else
            {
                rib_HeThong.Visible = rib_NghiepVu.Visible = true;
                btnTHI.Enabled = true;
            }


            
            


            btn_TaoTaiKhoan.Enabled = btn_DangXuat.Enabled = true;
            btn_DangNhap.Enabled = false;
        }

        public void logout()
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Dispose();// giai phong cac form con  khoi bo nho 
            }
            Program.userName = "";
            Program.AuthHoten = string.Empty;
            Program.AuthGroup = string.Empty;
        }
        private void btn_TaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangNhap));
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
            this.btn_DangNhap.Enabled = true;
            rib_NghiepVu.Visible = rib_BaoCao.Visible = false;
            this.btn_DangXuat.Enabled = this.btn_TaoTaiKhoan.Enabled = false;
            Program.AuthLogin = "";
            Program.AuthHoten = "";
            Program.AuthGroup = "";

            if (Program.AuthGroup.Equals("TRUONG") || Program.AuthGroup.Equals("COSO"))
            {
                btn_TaoTaiKhoan.Enabled = false;
            }

            foreach (Form f in this.MdiChildren)
                f.Dispose();

            MA.Text = "MÃ : " + Program.AuthLogin;
            HOVATEN.Text = "Họ Tên : " + Program.AuthHoten;
            NHOM.Text = "NHÓM : " + Program.AuthGroup;


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
            Form f = this.CheckExists(typeof(frmKHOA_LOP));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmKHOA_LOP frmKHOA_LOp = new frmKHOA_LOP();
               
                //frmKHOA_LOp.MdiParent = this;
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
            Form f = this.CheckExists(typeof(frmBoDe));
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
    }
}