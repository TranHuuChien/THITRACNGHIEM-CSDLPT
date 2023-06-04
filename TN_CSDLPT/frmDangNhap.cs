using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf.Compression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection conn_publisher = new SqlConnection();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        
        private  Form CheckExist(Type ftype)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim() =="" || txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Tài khoản và Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            /*if (Regex.IsMatch(txtTaiKhoan.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Tài khoản chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtTaiKhoan.Focus();
                return;
            }
            if (Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mat khau chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }*/

            Program.serverName = cbx_CoSo.SelectedValue.ToString();
            Program.AuthServerName = cbx_CoSo.SelectedValue.ToString();


            Program.AuthLogin = txtTaiKhoan.Text.Trim();
            Program.AuthPassword = txtPassword.Text.Trim();

            
            
            if(radioButtonSinhVien.Checked)
            {
                
                // NẾU ĐỂ NHƯ KIA THÌ TA KHÔNG THỂ CHẠY CÂU LỆNH BÊN DƯỚI DO PHÂN QUYỀN CHỈ CÓ 2 TABLE BAITHI , CTBAITHI
                // nên ta phải gán lại để có thể kết nối vào tài khoản ower
                Program.ServerLogin = Program.remoteLogin;
                Program.ServerPassword = Program.remotePassword;

                Program.AuthGroup = "SINHVIEN";

            }
            else
            {
                Program.ServerLogin = Program.AuthLogin;
                Program.ServerPassword = Program.AuthPassword;
            }


            try
            {
                
                if(Program.KetNoi() == 0)
                {
                    return;
                }
            }
            catch(Exception ex) {
                XtraMessageBox.Show(ex.Message, "Không thể kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(radioButtonSinhVien.Checked)
            {
                try
                {
                    string caulenh = "SELECT HO, TEN ,NGAYSINH, DIACHI, MALOP, PASSWORD FROM DBO.SINHVIEN WHERE MASV = '" + Program.AuthLogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(caulenh);
                    if (Program.myReader == null)
                    {
                        MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.myReader.Close();
                        return;
                    }
                    Program.myReader.Read();

                    /*if (Program.myReader.GetString(5) != Program.AuthPassword)
                    {
                        MessageBox.Show("Thông tin mật khẩu sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.myReader.Close();
                        return;
                    }*/

                    Program.userName = txtTaiKhoan.Text;
                    Program.AuthHoten = Program.myReader.GetString(0) + " " + Program.myReader.GetString(1);
                    //Program.AuthGroup = Program.myReader.GetString(2);
                    Program.ServerLogin = Program.SVLogin;
                    Program.ServerPassword = Program.SVPassword;

                    Program.myReader.Close();
                }
                catch(Exception ex )
                {
                    MessageBox.Show("Lỗi khi đăng nhập sinh viên , bạn hãy kiểm tra lại" + ex, "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }

            else
            {
                string statement = "EXEC SP_Lay_Thong_Tin_LOGINNAME_Tu_Login '" + Program.userName + "'";// chạy câu lệnh sp 
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(statement);
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi khi đăng nhập "+ ex.Message , "Thông báo", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    return;
                }
         
            
               

                Program.myReader.Read();
                Program.userName = Program.myReader.GetString(0);
                Program.AuthHoten = Program.myReader.GetString(1);
                Program.AuthGroup = Program.myReader.GetString(2);

                Program.myReader.Close();
                Program.conn.Close();

                if(Program.AuthGroup == "SINHVIEN")
                {
                    MessageBox.Show("Sinh viên đã sử dụng tài khoản sinh viên để đăng nhập vào giảng viên", "Thông báo", MessageBoxButtons.OK);
                    return;
                }    

                //Program.frmChinh.MA.Text = "MÃ = " + Program.userName;
                //Program.frmChinh.HOVATEN.Text = "Họ Tên : " + Program.mHoten;
                //Program.frmChinh.NHOM.Text = "NHÓM : " + Program.mGroup;


            }
            /*Step 3*/
            Program.mCoSo = cbx_CoSo.SelectedIndex;
            

            

            Program.frmChinh.HienThiMenu();


            this.Visible = false;

        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LayDanhSachCoSo(String cmd)// danh sách phân mảnh nganh
        {
            DataTable dt = new DataTable();
            if(conn_publisher.State == ConnectionState.Closed)
            {
                conn_publisher.Open();
            }

            SqlDataAdapter da  = new SqlDataAdapter(cmd,conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();

            Program.bds_DSCS.DataSource = dt;
            cbx_CoSo.DataSource = Program.bds_DSCS;
            cbx_CoSo.DisplayMember = "TENCS";
            cbx_CoSo.ValueMember = "TENSERVER";
            

        }

        private int KetNoiMayChu()// kết nối site chủ để lấy danh sách phân mảnh cơ sở
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try {
                conn_publisher.ConnectionString = Program.connStr_Publisher;
                conn_publisher.Open();
                return 1;
            } 
            catch(Exception ex) 
            {
                MessageBox.Show("Khong ket noi duoc voi may chu"+ex);
                return 0;

            }
        }

        private void ĐăngNhập_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            if (KetNoiMayChu()==0)
            {
                return;
            }
            LayDanhSachCoSo("SELECT * FROM Get_Subscribes");
            cbx_CoSo.SelectedIndex = 0;
            Program.serverName = cbx_CoSo.SelectedValue.ToString();
            txtPassword.UseSystemPasswordChar = true;
          
        }

        private void cbx_CoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cbx_CoSo.SelectedValue.ToString();
                //Program.serverName = cbx_CoSo.SelectedIndex.ToString();
            }
            catch( Exception ex )
            {

                MessageBox.Show(""+ex);
            }
        }
    }
}