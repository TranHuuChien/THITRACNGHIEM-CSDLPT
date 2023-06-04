using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
using System.Windows.Forms.VisualStyles;
using TN_CSDLPT.Subform;
namespace TN_CSDLPT
{
    public partial class frmSinhVien : DevExpress.XtraEditors.XtraForm
    {
        string maLop = "";
        int vitri = 0;
        Stack undo = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        bool kiemtraThemMoi = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSINHVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.LOP' table. You can move, or remove it, as needed.
            DataSet.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.DataSet.LOP);
            // TODO: This line of code loads data into the 'dataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.DataSet.SINHVIEN);

            // TODO: This line of code loads data into the 'dataSet.BAITHI' table. You can move, or remove it, as needed.
            this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bAITHITableAdapter.Fill(this.DataSet.BAITHI);

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;


            if(Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                btnLAMMOI.Enabled = true;
                btnTHOAT.Enabled = true;
                btnTHEM.Enabled = btnXOA.Enabled = btnGHI.Enabled = btnHOANTAC.Enabled = false;
            }
            else if(Program.AuthGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                btnLAMMOI.Enabled = true;
                btnTHOAT.Enabled = true;
                btnTHEM.Enabled = btnXOA.Enabled = btnGHI.Enabled = btnHOANTAC.Enabled = true;
            }
            

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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.DataSet.LOP);
                // TODO: This line of code loads data into the 'dataSet.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.DataSet.SINHVIEN);

                // TODO: This line of code loads data into the 'dataSet.BAITHI' table. You can move, or remove it, as needed.
                this.bAITHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.bAITHITableAdapter.Fill(this.DataSet.BAITHI);
            }
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //lấy vị trí hiện tại của con trỏ để tiến hành undo

            vitri = bdsSINHVIEN.Position;
            //this.panelNhapLieu.Enabled = true;
            kiemtraThemMoi = true;

            // step 2 : nhay xuong cuoi them 1 dong moi
            bdsSINHVIEN.AddNew();
            
            panelNhapLieu.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnGHI.Enabled = true;
            this.btnHOANTAC.Enabled = false;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
            btnCANCEL.Enabled = true;

        }

        

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsSINHVIEN.Count == 0)
            {
                MessageBox.Show("Không tồn tại sinh viên nào", "Thông báo", MessageBoxButtons.OK);
                return;

            }
            if(bdsBAITHI.Count > 0)
            {
                MessageBox.Show("Sinh viên đã tồn tại bài thi không thể xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }


            string caulenhhoantac = "INSERT INTO DBO.SINHVIEN(MASV, HO, TEN ,NGAYSINH, DIACHI, MALOP, PASSWORD)" +
                " VALUES( '" + txtMaSV.Text.Trim() + "','" + txtHO.Text.Trim() + "','" + txtTEN.Text.Trim() + "','" +
                txtNgaySinh.Text.Trim() + "','"+txtDiaChi.Text.Trim()+"','" + txtMaLop.Text.Trim() + "','" + txtPassword.Text.Trim() + "')";
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {
                    vitri = bdsSINHVIEN.Position;
                    bdsSINHVIEN.RemoveCurrent();


                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.DataSet.SINHVIEN);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHOANTAC.Enabled = true;

                    // lưu câu lệnh để hoàn tác
                    panelNhapLieu.Enabled = false;
                    this.btnTHEM.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = false;
                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnTHOAT.Enabled = true;
                    btnCANCEL.Enabled = false;

                    undo.Push(caulenhhoantac);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa MÔN HỌC. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        public bool kiemtradulieu()
        {
            if(txtMaSV.Text == "") {
                MessageBox.Show("Mã sinh viên không được trống", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if (Regex.IsMatch(txtMaSV.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã sinh viên chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }
            if(txtMaSV.Text.Length > 8)
            {
                MessageBox.Show("Mã sinh viên không được quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaSV.Focus();
                return false;
            }

            // kiểm tra họ
            if (txtHO.Text == "")
            {
                MessageBox.Show("Họ không được trống", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (Regex.IsMatch(txtHO.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Họ chỉ có chữ cái và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }
            if (txtHO.Text.Length > 50)
            {
                MessageBox.Show("Họ không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtHO.Focus();
                return false;
            }

            // kiểm tra tên
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Tên không được trống", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (Regex.IsMatch(txtTEN.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Tên chỉ có chữ cái và số ", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }
            if (txtTEN.Text.Length > 10)
            {
                MessageBox.Show("Tên không được quá 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTEN.Focus();
                return false;
            }

            //kiểm tra địa chỉ
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (Regex.IsMatch(txtDiaChi.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ có chữ cái và số và khoẳng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (txtDiaChi.Text.Length > 50)
            {
                MessageBox.Show("Địa chỉ không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            

            //kiểm tra password
            if (txtPassword.Text.Length > 10)
            {
                MessageBox.Show("Địa chỉ không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            return true;

        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool kiemtra = kiemtradulieu();
            if(kiemtra == false)
            {

                return;
            }
            string maSv = txtMaSV.Text.Trim();
            DataRowView drv = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position]);




            /*String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaSinhVien '" + maSv + "' " + "select 'Value' =  @kq";
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
            Program.myReader.Read();*/

            int KETQUA = 0;
            if (KETQUA == 1 && kiemtraThemMoi == true)
            {
                MessageBox.Show("Mã vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                kiemtraThemMoi = false;
                return;

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    btnTHEM.Enabled = btnXOA.Enabled = btnHOANTAC.Enabled = btnLAMMOI.Enabled = true;
                    btnGHI.Enabled = true;
                    
                    string caulenhHoanTac = "";
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ NÚT THÊM
                    if (kiemtraThemMoi == true)
                    {
                        caulenhHoanTac = "delete DBO.SINHVIEN WHERE MASV = '" + txtMaSV.Text.Trim() + "'";
                    }
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                    else
                    {
                        caulenhHoanTac = "update DBO.MONHOC SET " + "TEN = '" + txtTEN.Text.Trim()+ "', HO = '"+txtHO.Text.Trim()
                       +"', NGAYSINH = '"+txtNgaySinh.Text.Trim() + "', DIACHI = '" + txtDiaChi.Text.Trim()
                       +"', MALOP = '" + txtMaLop.Text.Trim() + "', PASSWORD = '"+ txtPassword.Text.Trim() +"'"
                       +"WHERE MAMH = '" + txtMaSV.Text.Trim() + "'";
                    }

                    undo.Push(caulenhHoanTac);
                    this.bdsSINHVIEN.EndEdit();
                    //string insertSinhVien = "INSERT INTO SINHVIEN(MASV, HO, TEN, NGAYSINH, DIACHI, MALOP, PASSWORD) VALUES( "
                    //+ txtMaSV.Text.Trim() + ",'" + txtHO.Text.Trim() + "','" + txtTEN.Text.Trim() + "','"
                    //+ txtNgaySinh.Text.Trim() + "','" + txtDiaChi.Text.Trim() + "','" + txtMaLop.Text.Trim() + "','" + txtPassword.Text.Trim() +  "')";
                    //this.sINHVIENTableAdapter.Update(this.DataSet.SINHVIEN);
                    panelNhapLieu.Enabled = false;
                    this.btnTHEM.Enabled = true;
                    this.btnXOA.Enabled = true;
                    this.btnGHI.Enabled = false;
                    this.btnHOANTAC.Enabled = true;
                    this.btnLAMMOI.Enabled = true;
                    this.btnTHOAT.Enabled = true;
                    btnCANCEL.Enabled = false;

                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                }
                

            }
            kiemtraThemMoi = false;
            btnTHOAT.Enabled = true;
            return;


        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = false;
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnGHI.Enabled = false;
            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = true;
            this.btnTHOAT.Enabled = true;
            btnCANCEL.Enabled = false;


            if (undo.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            bdsSINHVIEN.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();

            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            //Console.WriteLine(caulenhHoanTac + n.ToString());

            this.sINHVIENTableAdapter.Fill(this.DataSet.SINHVIEN);
            return;

        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void sINHVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchSinhVien_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsSP_Lop.Current));
            maLop = drv["MALOP"].ToString().Trim();

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.FillSinhVienTheoLop(this.DataSet.SINHVIEN, maLop);
        }

        private void btnCANCEL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(kiemtraThemMoi == true)
            {
                bdsSINHVIEN.RemoveCurrent();
            }    
            panelNhapLieu.Enabled = false;
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnGHI.Enabled = false;
            this.btnHOANTAC.Enabled = true;
            this.btnLAMMOI.Enabled = true;
            this.btnTHOAT.Enabled = true;
            btnCANCEL.Enabled = false;

        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }
    }
}