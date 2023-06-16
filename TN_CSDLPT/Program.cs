using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using TN_CSDLPT.Class;

namespace TN_CSDLPT
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connStr_Publisher = "Data Source = DESKTOP-E2I98S5\\MAYCHU; Initial Catalog =TN_CSDLPT; Integrated Security = True";
        
        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String userName = "";//User name đăng nhập vào DataBase thống nhất sử dụng mã giảng viên 
        public static String ServerLogin = "";//Login Name để đăng nhập vào Server
        public static String ServerPassword = "";

        //cho phép người dùng hỗ trợ kết nối từ xa
        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "1234";


        //Tài khoản login name của Sinh viên 
        public static string SVLogin = "SV";
        public static string SVPassword = "1234";



        /*public static String loginCurrent = "";
        public static String passwordCurrent = "";
        public static String mGroup = "";
        public static String mHoten = "";
        */

        //Lưu thông tin đăng nhập vào có thể là sinh viên 
        public static string AuthUserID = string.Empty;
        public static string AuthLogin = string.Empty;
        public static string AuthPassword = string.Empty;
        public static string AuthGroup = string.Empty;
        public static string AuthHoten = string.Empty;
        public static string AuthServerName = string.Empty;


        public static int mCoSo = 0;// lưu thông tin của server đăng nhập 

        public static MainForm frmChinh;

        //biến dùng để lưu chứa danh sách các phân mảnh
        public static BindingSource bds_DSCS = new BindingSource();

        // lưu mã lớp ở subform
        public static string MaLopDuocChon = "";
        //lưu mã môn học được chọn ở subform
        public static string MaMonDaChon = "";

        //
        public static string MaGVDaChon = "";

        // lưu danh sách các nhóm quyền
        public static List<RoleClass> roles = new List<RoleClass> {
                new RoleClass("TRUONG", "Nhóm Trường"),
                new RoleClass("COSO", "Nhóm Cơ Sở"),
                new RoleClass("GIANGVIEN", "Nhóm Giảng Viên")
        };

        //public static MainForm main = new MainForm();
       
        public static int id_baithi = 0;
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.ServerLogin + ";password=" + Program.ServerPassword;
                Program.conn.ConnectionString = connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = System.Data.CommandType.Text;
            if(Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                myreader = sqlcmd.ExecuteReader();
                
                return myreader;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message, "Thông báo", MessageBoxButtons.OK);
                Program.conn.Close();
                return null;
            }

        }

        public static DataTable ExecDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) {
                Program.conn.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static  int ExecSqlNonQuery(string strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType =CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                //Console.WriteLine(strlenh);
                XtraMessageBox.Show(ex.Message, "Lỗi EXECSQLNONQUERY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return ex.State;
            }
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ĐăngNhập());

            frmChinh = new MainForm();
            Application.Run(frmChinh);

        }
    }
}
