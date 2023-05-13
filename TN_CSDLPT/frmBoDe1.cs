using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmBoDe1 : DevExpress.XtraEditors.XtraForm
    {

        bool kiemtraThemMoiCauHoi = false;
        Stack<string> undo = new Stack<string>();
        public frmBoDe1()
        {
            InitializeComponent();
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBoDe.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmBoDe1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.CT_BAITHI' table. You can move, or remove it, as needed.
            this.dataSet.EnforceConstraints = false;
            this.cT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BAITHITableAdapter.Fill(this.dataSet.CT_BAITHI);
            // TODO: This line of code loads data into the 'dataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.FillTheoGiangVien(this.dataSet.BODE, Program.userName);

            cbbTrinhDo.Items.Add("A");
            cbbTrinhDo.Items.Add("B");
            cbbTrinhDo.Items.Add("C");

            cbbDapAn.Items.Add("A");
            cbbDapAn.Items.Add("B");
            cbbDapAn.Items.Add("C");
            cbbDapAn.Items.Add("D");

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            if (Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                
                this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnGHI.Enabled = this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.panelNhapLieu.Enabled = false;
                this.btnTHOAT.Enabled = true;


            }
            // Nhóm COSO có toàn quyền trên 
            else if (Program.AuthGroup == "COSO")
            {
               
                cmbCoSo.Enabled = false;
                this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnGHI.Enabled = this.btnHOANTAC.Enabled = true;
                this.btnLAMMOI.Enabled = true;
                this.panelNhapLieu.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsBoDe.AddNew();
                this.bODEGridControl.Enabled = false;
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
                string SLcauHoi = "SELECT COUNT(CAUHOI) FROM BODE";
 
                    Program.myReader = Program.ExecSqlDataReader(SLcauHoi);
                    if (Program.myReader == null)
                    {
                        return;
                    }
                
                int sl = int.Parse(Program.myReader.GetValue(0).ToString());
                txtCauHoi.Text = string.Concat(sl + 1);

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

            if (txtNoiDung.Text == "")
            {
                MessageBox.Show("Không được để trống nội dụng câu hỏi", "Thông báo", MessageBoxButtons.OK);
                txtNoiDung.Focus();
                return false;
            }

            if (txtA.Text.Length == 0)
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
        private void bODEGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!kiemtra())
            {
                return;
            }
            string caulenhHoanTac = "";

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
                    caulenhHoanTac = "delete DBO.BODE WHERE CAUHOI = " + txtCauHoi.Text.Trim() + "";

                }
                // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                else
                {// câu Llệnh hoàn tác lấy dữ liệu từ các row của tableAdapter
                 // còn lệnh chạy lấy từ textbox bên dưới

                    caulenhHoanTac = "update DBO.BODE SET " + "MAMH = '" + txtMaMH.Text.Trim() + "', TRINHDO = '" + cbbTrinhDo.Text
                   + "', NOIDUNG = '" + txtNoiDung + "', A = '" + txtA + "', B = '" + txtB + "', C = '" + txtC + "', D = '" + txtD + "', DAP_AN ='"
                   + cbbDapAn.SelectedValue.ToString() + "', MAGV ='" + txtMaGV + "' WHERE CAUHOI = " + txtCauHoi;


                }

                undo.Push(caulenhHoanTac);
                this.bdsBoDe.EndEdit();
              
                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                btnTHEM.Enabled = btnXOA.Enabled = btnHOANTAC.Enabled = btnLAMMOI.Enabled = true;
                btnGHI.Enabled = true;
                kiemtraThemMoiCauHoi = false;
            }

        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.FillTheoGiangVien(this.dataSet.BODE, Program.userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsCT_baithi.Count>0)
            {
                MessageBox.Show("Đã tồn tại mã câu hỏi bên trong CHI TIẾT BÀI THI", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string undoCommand = "";
           
                // câu lệnh chuỗi undo này không hiểu tại sao bị lỗi
                undoCommand = "INSERT INTO DBO.BODE(CAUHOI, MAMH, TRINHDO, NOIDUNG, A, B, C, D, DAP_AN, MAGV) VALUES("
                + txtCauHoi.Text.Trim() + ",'" + txtMaMH.Text.Trim() + "','" + cbbTrinhDo.Text + "','"
                + txtNoiDung.Text.Trim() + "','" + txtA.Text.Trim() + "','" + txtB.Text.Trim() + "','" + txtC.Text.Trim() + "','"
                + txtD.Text.Trim() + "','" + cbbDapAn.Text + "','" + txtMaGV.Text.Trim() + "')";

          
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {


                    bdsBoDe.RemoveCurrent();


                    this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bODETableAdapter.Update(this.dataSet.BODE);
                    // lưu câu lệnh để hoàn tác
                    undo.Push(undoCommand);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa câu hỏi. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
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
            bdsBoDe.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();
            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            //Console.WriteLine(caulenhHoanTac + n.ToString());
            try
            {
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.FillTheoGiangVien(this.dataSet.BODE, Program.userName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnGHI.Enabled = true;

            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = true;
            this.btnTHOAT.Enabled = true;
            kiemtraThemMoiCauHoi = false;
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }


            Program.serverName = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoSo)// chọn cơ sở khác với cơ sở lúc đăng nhập
            {
                Program.ServerLogin = Program.remoteLogin;
                Program.ServerPassword = Program.remotePassword;

            }
            else
            {
                Program.ServerLogin = Program.AuthLogin;
                Program.ServerPassword = Program.AuthPassword;

            }

            if (Program.KetNoi() == 0)// lỗi
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.dataSet.EnforceConstraints = false;
                this.cT_BAITHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.cT_BAITHITableAdapter.Fill(this.dataSet.CT_BAITHI);
                // TODO: This line of code loads data into the 'dataSet.BODE' table. You can move, or remove it, as needed.
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.FillTheoGiangVien(this.dataSet.BODE, Program.userName);

            }
        }

        private void txtCauHoi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}