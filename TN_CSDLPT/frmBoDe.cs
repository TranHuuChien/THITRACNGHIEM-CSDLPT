using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
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
using TN_CSDLPT.Subform;

namespace TN_CSDLPT
{
    public partial class frmBoDe : DevExpress.XtraEditors.XtraForm
    {
        bool kiemtraThemMoiCauHoi = false;
        Stack<string> undo = new Stack<string>();

        private BindingSource bds_DSTrinhDo = new BindingSource();// lấy danh sách các trình độ
        public frmBoDe()
        {
            InitializeComponent();
        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {

            
            // TODO: This line of code loads data into the 'dataSet.SP_LAYDANHSACH_ALL_BODE' table. You can move, or remove it, as needed.

            this.dataSet.EnforceConstraints = false;


            //PHÂN QUYỀN GIẢNG VIÊN
            //string commandGiangVien = "SELECT CAUHOI,MAMH, TRINHDO, NOIDUNG, A, B,C,D,DAP_AN, MAGV FROM DBO.BODE WHERE MAGV ='" + Program.userName + "'";
            this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Fill(this.dataSet.SP_LAYDANHSACH_THEO_GIANG_VIEN, Program.userName);

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");

            cbbDapAn.Items.Add("A");
            cbbDapAn.Items.Add("B");
            cbbDapAn.Items.Add("C");
            cbbDapAn.Items.Add("D");

        }

        /*private void LayDSTrinhDo(string cmd)
        {
            DataTable dt = new DataTable();
            dt = Program.ExecDataTable(cmd);
            cmbTrinhDo.DataSource = dt;
            cmbTrinhDo.DisplayMember = "TENTRINHDO";
            cmbTrinhDo.ValueMember = "TRINHDO";

        }*/

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsSP_LAY_DS_THEO_MAGV.AddNew();
                this.sP_LAYDANHSACH_THEO_GIANG_VIENGridControl.Enabled = false;
                kiemtraThemMoiCauHoi = true;

                btnTHEM.Enabled = false;
                btnGHI.Enabled = true;
                btnXOA.Enabled = false;
                btnTHOAT.Enabled = true;
                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = false;
                //LayDSTrinhDo("SELECT TENTRINHDO = 'TRINH DO  ' + TRINHDO, TRINHDO FROM DBO.BODE GROUP BY TRINHDO");
                txtMaGV.Text = Program.userName;
                txtMaGV.Enabled = false;
                //txtTrinhDo.Visible = false;
                //cmbTrinhDo.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private bool kiemtra()
        {
            if (txtCauHoi.Text == "")
            {
                MessageBox.Show("Không được để trống Mã câu hỏi ", "Thông báo", MessageBoxButtons.OK);
                txtCauHoi.Focus();
                return false;
            }
            if (Regex.IsMatch(txtCauHoi.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã câu hỏi chỉ có số", "Thông báo", MessageBoxButtons.OK);
                txtCauHoi.Focus();
                return false;
            }
            // Mã môn học cho phép chọn nên không cần kiểm tra điều kiện vào
            
            if(txtNoiDung.Text == "")
            {
                MessageBox.Show("Không được để trống nội dụng câu hỏi", "Thông báo", MessageBoxButtons.OK); 
                txtNoiDung.Focus();
                return false;
            }    
            
            if(txtA.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống phương án A", "Thông báo", MessageBoxButtons.OK);
                txtA.Focus();
                return false;
            }
            if (txtB.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống phương án B", "Thông báo", MessageBoxButtons.OK);
                txtB.Focus();
                return false;
            }
            if (txtC.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống phương án C", "Thông báo", MessageBoxButtons.OK);
                txtC.Focus();
                return false;
            }
            if (txtD.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống phương án D", "Thông báo", MessageBoxButtons.OK);
                txtD.Focus();
                return false;
            }
            

            return true;
        }
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string caulenhHoanTac = "";
            if (!kiemtra())
            {
                return;
            }
            //select TOP 2 * from DBO.BODE ORDER BY CAUHOI DESC

            //INSERT INTO DBO.BODE(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) VALUES(231, 'MMTCB',
            //'A', 'Khám phá thế giới', 'nai', 'hươu', 'mểm', 'dê', 'A', 'TH123')

            //Muốn cho KHÓA CHÍNH CAUHOI tự động tăng lên 1 sau mỗi lần insert để không cần phải kiểm tra trùng
            DataRowView drv = ((DataRowView)bdsSP_LAY_DS_THEO_MAGV[bdsSP_LAY_DS_THEO_MAGV.Position]);
            // vì gridcontrol mình sử dụng sp thể thể hiện số liệu không thể thực hiện như table đc nên phải tiến hành reload nhiều lần
            string cauhoi = drv["CAUHOI"].ToString();
            string trinhDo = drv["TRINHDO"].ToString();

            string MaMonHoc = drv["MAMH"].ToString();
            string noidung = drv["NOIDUNG"].ToString();
            string A = drv["A"].ToString();
            string B = drv["B"].ToString();
            string C = drv["C"].ToString();
            string D = drv["D"].ToString();
            string dapAn = drv["DAP_AN"].ToString();
            string maGiangVien = drv["MAGV"].ToString();


            string caulenh = "";

            String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTra_CauHoi_ADD " + txtCauHoi.Text + "select 'Value' =  @kq";
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
            if (KETQUA == 1 && kiemtraThemMoiCauHoi == true)
            {
                MessageBox.Show("Đã tồn tại mã câu hỏi bên trong BỘ ĐỀ", "Thông báo", MessageBoxButtons.OK);
                return;
            }    
            Program.myReader.Close();
            DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                

                // TRƯỚC KHI NHẤN NÚT GHI LÀ NÚT THÊM
                if (kiemtraThemMoiCauHoi == true)
                    {
                        caulenhHoanTac = "delete DBO.BODE WHERE CAUHOI = " + txtCauHoi.Text.Trim()+ "";
                        caulenh = "INSERT INTO DBO.BODE(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) VALUES("
                        + txtCauHoi.Text.Trim() + ",'" + txtMaMH.Text.Trim() + "','" + cbbTrinhDo.Text + "','"
                        + txtNoiDung.Text.Trim() + "','" + txtA.Text.Trim() + "','" + txtB.Text.Trim() + "','" + txtC.Text.Trim() + "','"
                        + txtD.Text.Trim() + "','" + cbbDapAn.Text + "','" + txtMaGV.Text.Trim() + "')";
                       
                }
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                else
                    {// câu Llệnh hoàn tác lấy dữ liệu từ các row của tableAdapter
                    // còn lệnh chạy lấy từ textbox bên dưới

                     caulenh = "update DBO.BODE SET " + "MAMH = '" + txtMaMH.Text +"', TRINHDO = '"+ trinhDo 
                     +"', NOIDUNG = '"+ txtNoiDung.Text+"', A = '" + txtA.Text +"', B = '" + txtB.Text +"', C = '"+ txtC.Text + "', D = '" + txtD.Text + "', DAP_AN ='"
                     +cbbDapAn.Text +"', MAGV ='" + txtMaGV.Text.Trim() +"' WHERE CAUHOI = " + txtCauHoi.Text.Trim();
                     
                      caulenhHoanTac = "update DBO.BODE SET " + "MAMH = '" + txtMaMH.Text.Trim() + "', TRINHDO = '" + cbbTrinhDo.Text
                     + "', NOIDUNG = '" + txtNoiDung + "', A = '" + txtA + "', B = '" + txtB + "', C = '" + txtC + "', D = '" + txtD + "', DAP_AN ='"
                     + cbbDapAn.SelectedValue.ToString() + "', MAGV ='" + txtMaGV + "' WHERE CAUHOI = " + txtCauHoi;


                }

                undo.Push(caulenhHoanTac);
                this.bdsSP_LAY_DS_THEO_MAGV.EndEdit();


            



                if(Program.ExecSqlNonQuery(caulenh) == 0)
                   MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                btnTHEM.Enabled = btnXOA.Enabled = btnHOANTAC.Enabled = btnLAMMOI.Enabled = true;
                btnGHI.Enabled = true;

                sP_LAYDANHSACH_THEO_GIANG_VIENGridControl.Enabled = true;

                try
                {
                    this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Fill(this.dataSet.SP_LAYDANHSACH_THEO_GIANG_VIEN, Program.userName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
                }
                kiemtraThemMoiCauHoi = false;
             }
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Fill(this.dataSet.SP_LAYDANHSACH_THEO_GIANG_VIEN, Program.userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.Close();
        }

        private void btnCHON_GV_Click(object sender, EventArgs e)
        {
            ChonMonHoc monhoc = new ChonMonHoc();
            monhoc.ShowDialog();
            txtMaMH.Text = Program.MaMonDaChon;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //kiem tra xem câu hỏi này đã nằm trong chi tiết bài thi nào hay chưa


            
            /*DataRowView drv = ((DataRowView)bdsSP_LAY_DS_THEO_MAGV[bdsSP_LAY_DS_THEO_MAGV.Position]);
            string cauhoi = drv["CAUHOI"].ToString();
            string trinhDo = drv["TRINHDO"].ToString();

            string MaMonHoc = drv["MAMH"].ToString();
            string noidung = drv["NOIDUNG"].ToString();
            string A = drv["A"].ToString();
            string B = drv["B"].ToString();
            string C = drv["C"].ToString();
            string D = drv["D"].ToString();
            string dapAn = drv["DAP_AN"].ToString();
            string maGiangVien = drv["MAGV"].ToString();*/

            String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTra_CAUHOI_CT_BAITHI" + txtCauHoi.Text + "select 'Value' =  @kq";
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
            if (KETQUA == 1)
            {
                MessageBox.Show("Đã tồn tại mã câu hỏi bên trong CHI TIẾT BÀI THI", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Program.myReader.Close();
            string undoCommand = "";
            try
            {

                // câu lệnh chuỗi undo này không hiểu tại sao bị lỗi
                undoCommand = "INSERT INTO DBO.BODE(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) VALUES("
                + txtCauHoi.Text.Trim() + ",'" + txtMaMH.Text.Trim() + "','" + cbbTrinhDo.Text + "','"
                + txtNoiDung.Text.Trim() + "','" + txtA.Text.Trim() + "','" + txtB.Text.Trim() + "','" + txtC.Text.Trim() + "','"
                + txtD.Text.Trim() + "','" + cbbDapAn.Text + "','" + txtMaGV.Text.Trim() + "')";

                /*undoCommand = "INSERT INTO DBO.BODE(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) VALUES("
                + cauhoi + ",'" +  MaMonHoc + "','" + trinhDo + "','"
                + noidung + "','" + A + "','" + B+ "','" + C + "','"
                + D + "','" + dapAn + "','" + maGiangVien+ "')";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa cauhoi "+ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                try
                {

                    
                    bdsSP_LAY_DS_THEO_MAGV.RemoveCurrent();
                    

                    this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    //this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Update(this.DataSet.SINHVIEN);
                    string deleteCommand = "delete DBO.BODE WHERE CAUHOI = " + txtCauHoi + "";
                    int kq = Program.ExecSqlNonQuery(deleteCommand);
                    if(kq ==0)
                    {
                        MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                        this.btnHOANTAC.Enabled = true;
                    }
                    else
                    {
                        return;
                    }
                    // lưu câu lệnh để hoàn tác
                    undo.Push(undoCommand);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa MÔN HỌC. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = true;
            this.btnTHOAT.Enabled = true;
            if (undo.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }
            bdsSP_LAY_DS_THEO_MAGV.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();
            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            //Console.WriteLine(caulenhHoanTac + n.ToString());
            try
            {
                this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAYDANHSACH_THEO_GIANG_VIENTableAdapter.Fill(this.dataSet.SP_LAYDANHSACH_THEO_GIANG_VIEN, Program.userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }

            return;
        }
    }
}