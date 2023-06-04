using DevExpress.XtraEditors;
using System;
using System.Collections;
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
    public partial class MonHocForm : DevExpress.XtraEditors.XtraForm
    {

        //String maCoSo = "";
        int vitri = 0;
        Stack undo = new Stack();

        bool kiemtraThemMoi = false;

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public MonHocForm()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void MonHocForm_Load(object sender, EventArgs e)
        {


            DataSet.EnforceConstraints = false;
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.DataSet.MONHOC);

            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DataSet.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DataSet.BODE);

            // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BAITHI' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.DataSet.BAITHI);


            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;


            // Nhóm TRUONG chỉ có thể xem dữ liệu 
            if (Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                labelCoSo.Enabled = true;
                this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnGHI.Enabled = this.btnHOANTAC.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.panelNhapLieu.Enabled = false;
                this.btnTHOAT.Enabled = true;


            }
            // Nhóm COSO có toàn quyền trên 
            else if (Program.AuthGroup == "COSO")
            {
                labelCoSo.Enabled = false;
                cmbCoSo.Enabled = false;
                this.btnTHEM.Enabled = this.btnXOA.Enabled = this.btnGHI.Enabled = this.btnHOANTAC.Enabled = true;
                this.btnLAMMOI.Enabled = true;
                this.panelNhapLieu.Enabled = true;
                this.btnTHOAT.Enabled = true;
            }
            //Nhóm GIANG VIEN và SINHVIEN làm chứ phân quyền csdl hai nhóm này k được truy cập vào cdsl


        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // nếu combobox không có gì kết thúc chương trình luon
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return;
            }


            Program.serverName = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mCoSo)// chọn cơ sở khác với cơ sở lúc đăng nhập
            {
                Program.ServerLogin = Program.remoteLogin;
                Program.ServerPassword= Program.remotePassword;

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
                DataSet.EnforceConstraints = false;
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
                this.mONHOCTableAdapter.Fill(this.DataSet.MONHOC);

                // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DataSet.GIAOVIEN_DANGKY);

                // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
                this.bODETableAdapter.Fill(this.DataSet.BODE);

                // TODO: This line of code loads data into the 'TN_CSDLPTDataSet.BAITHI' table. You can move, or remove it, as needed.
                this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.bAITHITableAdapter.Fill(this.DataSet.BAITHI);
            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //lấy vị trí hiện tại của con trỏ để tiến hành undo

                vitri = bdsMONHOC.Position;
                this.panelNhapLieu.Enabled = true;
                kiemtraThemMoi = true;
               
                
                bdsMONHOC.AddNew();

                panelNhapLieu.Enabled=true;

                btnTHEM.Enabled = false;
                btnXOA.Enabled = false;
                btnGHI.Enabled = true;
                btnSUA.Enabled = false;
                btnCANCEL.Enabled = true;
                btnHOANTAC.Enabled = false;
                btnLAMMOI.Enabled = false;
                btnTHOAT.Enabled = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khoa " + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }


        }
        private bool KiemTraDuLieuDauVao()
        {

            
            // kiểm tra bỏ trống mã môn học
            if (txtMaMonHoc.Text == "")
            {
                MessageBox.Show("Không được để trống mã môn học ", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaMonHoc.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã môn học chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return false;
            }
            if (txtMaMonHoc.Text.Length > 5)
            {
                MessageBox.Show("Mã môn học không được quá 5 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return false;
            }

            // kiểm tra tên môn học
            if (txtTenMonHoc.Text == "")
            {
                MessageBox.Show("Không được để trống tên môn học ", "Thông báo", MessageBoxButtons.OK);
                txtTenMonHoc.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTenMonHoc.Text, @"^[a-zA-Z0-9 ]+$") == false)// kiểm tra bao gồm khoảng trắng
            {
                MessageBox.Show("Tên môn học chỉ có chữ cái và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return false;
            }
            if (txtTenMonHoc.Text.Length > 50)
            {
                MessageBox.Show("Tên môn học không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaMonHoc.Focus();
                return false;
            }
            return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int KETQUA = 0;
            bool kqKiemtra = KiemTraDuLieuDauVao();
            if (kqKiemtra == false)
            {
                return;
            }


            string maMonHoc = txtMaMonHoc.Text.Trim();
            DataRowView drv = ((DataRowView)bdsMONHOC[bdsMONHOC.Position]);
            String tenMonHoc = drv["TENMH"].ToString();



            if(kiemtraThemMoi == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaMonHoc '" + maMonHoc + "' " + "select 'Value' =  @kq";
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
                KETQUA = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();
            }    

            if (KETQUA == 1)
            {
                MessageBox.Show("Mã môn học này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                kiemtraThemMoi = false;
                return;

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    
                    string caulenhHoanTac = "";
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ NÚT THÊM
                    if (kiemtraThemMoi == true)
                    {
                        caulenhHoanTac = "delete DBO.MONHOC WHERE MAMH = '" + txtMaMonHoc.Text.Trim() + "'";
                    }
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                    else
                    {
                        caulenhHoanTac = "update DBO.MONHOC SET " + "TENMH = '" + tenMonHoc + "' WHERE MAMH = '" + maMonHoc + "'";
                    }

                    undo.Push(caulenhHoanTac);
                    this.bdsMONHOC.EndEdit();
                    this.mONHOCTableAdapter.Update(this.DataSet.MONHOC);
                    
                    MessageBox.Show("Ghi thành công",
                     "Thông báo", MessageBoxButtons.OK);
                   
                    panelNhapLieu.Enabled = false;
                    kiemtraThemMoi = false;
                    btnTHEM.Enabled = true;
                    btnXOA.Enabled = true;
                    btnGHI.Enabled = false;
                    btnSUA.Enabled = true;
                    btnCANCEL.Enabled = false;
                    btnHOANTAC.Enabled = true;
                    btnLAMMOI.Enabled = true;
                    btnTHOAT.Enabled = true;

                }


            }
            kiemtraThemMoi = false;
            return;


        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsMONHOC.Count == 0)
            {
                btnXOA.Enabled = false;
            }
            if (bdsBAITHI.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có bài thi", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có bộ đề", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsGIAOVIEN_DANGKI.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã có giáo viên đăng kí ", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            // kiểm tra xem Môn học này có ở cơ sở khác không


            /*
            String strlenh = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaMonHocCSKhac '" + txtMaMonHoc.Text.Trim() + "' " + "select 'Value' =  @kq";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(strlenh);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Thực thi kiểm tra mã Môn học" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (Program.myReader == null)
                return;

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            if(result == 1)
            {
                MessageBox.Show("Môn Học đã được sử dụng ở Cơ Sở khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            */

            string cautruyvanHoanTac =
            "INSERT INTO DBO.MONHOC( MAMH, TENMH)" +
            " VALUES( '" + txtMaMonHoc.Text.Trim() + "','" +
                        txtTenMonHoc.Text.Trim() + "'" + " ) ";

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                string maMonHoc = "";
                try
                {

                    maMonHoc = ((DataRowView)bdsMONHOC[bdsMONHOC.Position])["MAMH"].ToString();// lưu lại
                    bdsMONHOC.RemoveCurrent();


                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.DataSet.MONHOC);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;

                    // lưu câu lệnh để hoàn tác
                    undo.Push(cautruyvanHoanTac);
                    panelNhapLieu.Enabled = false;

                    btnTHEM.Enabled = true;
                    btnXOA.Enabled = true;
                    btnGHI.Enabled = false;
                    btnSUA.Enabled = true;
                    btnCANCEL.Enabled = false;
                    btnHOANTAC.Enabled = true;
                    btnLAMMOI.Enabled = true;
                    btnTHOAT.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa MÔN HỌC. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.DataSet.MONHOC);
                    bdsMONHOC.Position = bdsMONHOC.Find("MAMH", maMonHoc);
                    return;
                }
            }


        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.DataSet.MONHOC);
                //this.gridControlMonHoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void btnHOANTAC_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
                panelNhapLieu.Enabled = false;

                btnTHEM.Enabled = true;
                btnXOA.Enabled = true;
                btnGHI.Enabled = false;
                btnSUA.Enabled = true;
                btnCANCEL.Enabled = false;
                btnHOANTAC.Enabled = true;
                btnLAMMOI.Enabled = true;
                btnTHOAT.Enabled = true;
                
            if (undo.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            bdsMONHOC.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();
            Console.WriteLine(caulenhHoanTac);

            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            this.mONHOCTableAdapter.Fill(this.DataSet.MONHOC);
            return;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // do có chức năng hoàn tác nên không thể cho sửa khóa chính vì để lấy nó làm mốc
            panelNhapLieu.Enabled = true;
            txtMaMonHoc.Enabled = false;

            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnSUA.Enabled = false;
            btnCANCEL.Enabled = true;
            btnHOANTAC.Enabled = false;
            btnLAMMOI.Enabled = false;
            btnTHOAT.Enabled = false;
        }

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = false;
            if(kiemtraThemMoi == true)
            {
                bdsMONHOC.RemoveCurrent();
            }    
            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnGHI.Enabled = false;
            btnSUA.Enabled = true;
            btnCANCEL.Enabled = false;
            btnHOANTAC.Enabled = true;
            btnLAMMOI.Enabled = true;
            btnTHOAT.Enabled = true;
        }
    }
}