﻿using DevExpress.XtraEditors;
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
    public partial class frmKhoaAndLop : DevExpress.XtraEditors.XtraForm
    {
        bool kiemtraThemMoi_Khoa = true;
        bool kiemtraThemMoi_Lop = true;

        
        Stack undo_Khoa = new Stack();
        Stack undo_Lop = new Stack();

        string maKhoa = "";

        int vitri = 0;
        public frmKhoaAndLop()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKHOA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmKhoaAndLop_Load(object sender, EventArgs e)
        {

            this.dataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dataSet.LOP);
            // TODO: This line of code loads data into the 'dataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dataSet.KHOA);
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dataSet.GIAOVIEN);

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            if (bdsKHOA.Count > 0)
            {
                btnXOA_KHOA.Enabled = true;
                btnSuaKhoa.Enabled = true;
            }
            else if (bdsKHOA.Count == 0)
            {
                btnXOA_KHOA.Enabled = false;
                btnSuaKhoa.Enabled = false;
            }

            // phân quyền 
            if(Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                panelKhoa.Enabled = false;
                panelLop.Enabled = false;
                btnTHEM_KHOA.Enabled = false;
                btnXOA_KHOA.Enabled = false;
                btnSuaKhoa.Enabled = false;
                btnHOANTAC_KHOA.Enabled = false;
                btnCancelKhoa.Enabled = false;
                btnGHI_KHOA.Enabled = false;

                btnLAMMOI_KHOA.Enabled = true;
                btnTHOAT.Enabled = true;
            }  
            else if(Program.AuthGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
                
            }    
        }

        private void btnTHEM_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // thêm 1 dòng mới
            bdsKHOA.AddNew();

            txtMaCS.Text = "CS" + (Program.mCoSo + 1).ToString();
            panelKhoa.Enabled = true;

            btnTHEM_KHOA.Enabled = false;
            btnXOA_KHOA.Enabled = false;
            btnGHI_KHOA.Enabled = true;
            btnCancelKhoa.Enabled = true;
            btnSuaKhoa.Enabled = false;
            btnHOANTAC_KHOA.Enabled = false;
            btnLAMMOI_KHOA.Enabled = false;
            btnTHOAT.Enabled = false;

            bool kiemtraThemMoi_Khoa = true;// đánh dấu đang thêm mới
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
                this.dataSet.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dataSet.LOP' table. You can move, or remove it, as needed.
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dataSet.LOP);
                // TODO: This line of code loads data into the 'dataSet.KHOA' table. You can move, or remove it, as needed.
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dataSet.KHOA);
                // TODO: This line of code loads data into the 'dataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSet.GIAOVIEN_DANGKY);
                // TODO: This line of code loads data into the 'dataSet.SINHVIEN' table. You can move, or remove it, as needed.
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'dataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dataSet.GIAOVIEN);

            }
        }

        private void btnSuaKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelKhoa.Enabled = true;
            txtMaKhoa.Enabled = false;

            btnTHEM_KHOA.Enabled = false;
            btnXOA_KHOA.Enabled = false;
            btnGHI_KHOA.Enabled = true;
            btnCancelKhoa.Enabled = true;
            btnSuaKhoa.Enabled = false;
            btnHOANTAC_KHOA.Enabled = false;
            btnLAMMOI_KHOA.Enabled = false;
            btnTHOAT.Enabled = false;

            kiemtraThemMoi_Khoa = false;
        }

        private bool KiemTraDuLieuDauVaoKhoa()
        {


            // kiểm tra bỏ trống mã môn học
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Không được để trống mã khoa ", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtMaKhoa.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã khoa chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }*/
            if (txtMaKhoa.Text.Length > 8)
            {
                MessageBox.Show("Mã khoa không được quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }

            // kiểm tra tên môn học
            if (txtTenKhoa.Text == "")
            {
                MessageBox.Show("Không được để trống tên môn khoa ", "Thông báo", MessageBoxButtons.OK);
                txtTenKhoa.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtTenKhoa.Text, @"^[a-zA-Z0-9 ]+$") == false)// kiểm tra bao gồm khoảng trắng
            {
                MessageBox.Show("Tên khoa chỉ có chữ cái và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }*/
            if (txtTenKhoa.Text.Length > 50)
            {
                MessageBox.Show("Tên khoa không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }
            return true;
        }
        private void btnGHI_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int ketquaTrave = 0;
            if (KiemTraDuLieuDauVaoKhoa() == false)
            {
                return;
            }
            if (kiemtraThemMoi_Khoa== true)
            {
                String MaKhoa = txtMaKhoa.Text;
               

                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaKhoa '" + MaKhoa + "' " + "select 'Value' =  @kq";

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

                ketquaTrave = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

            }

            DataRowView drv = ((DataRowView)bdsKHOA[bdsKHOA.Position]);
            String TenKhoa = drv["TENKH"].ToString();


            if (ketquaTrave == 1)
            {
                MessageBox.Show("Mã khoa đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {

                        string strlenhUndo = "";
                        if (kiemtraThemMoi_Khoa == true)
                        {
                            strlenhUndo = "DELETE DBO.KHOA WHERE MAKH ='" + txtMaKhoa.Text.Trim() + "'";

                        }
                        else
                        {
                            strlenhUndo = "UPDATE DBO.KHOA SET TENKH = '" + TenKhoa + "'" + "WHERE MAKH = '" + txtMaKhoa.Text.Trim() + "'";

                        }
                        undo_Khoa.Push(strlenhUndo);
                        this.bdsKHOA.EndEdit();
                        this.kHOATableAdapter.Update(this.dataSet.KHOA);
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                        txtMaKhoa.Enabled = true;
                        panelKhoa.Enabled = false;
                        kiemtraThemMoi_Khoa = false;

                        btnTHEM_KHOA.Enabled = true;
                        btnXOA_KHOA.Enabled = true;
                        btnGHI_KHOA.Enabled = false;
                        btnCancelKhoa.Enabled = false;
                        btnSuaKhoa.Enabled = true;
                        btnHOANTAC_KHOA.Enabled = true;
                        btnLAMMOI_KHOA.Enabled = true;
                        btnTHOAT.Enabled = true;


                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("Tên khoa có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            kiemtraThemMoi_Khoa = false;
            return;
        }

        private void btnXOA_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKHOA.Count == 0)
            {
                MessageBox.Show("Không có khoa nào !", "Thông báo", MessageBoxButtons.OK);
                btnXOA_KHOA.Enabled = false;
                return;
            }

            // XẢY RA LỖI
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì đã tồn tại lớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsGiangVien.Count > 0)
            {
                MessageBox.Show("Không thễ xóa khoa này vì đã tồn tại giáo viên bên trong khoa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            DataRowView drv = (DataRowView)bdsKHOA[bdsKHOA.Position];
            string MaCS = drv["MACS"].ToString();
            string cautruyvanHoanTac =
            "INSERT INTO DBO.KHOA(MAKH, TENKH, MACS)" +
            " VALUES( '" + txtMaKhoa.Text.Trim() + "','" +
                        txtTenKhoa.Text.Trim() + "','"+ MaCS.Trim() + "') ";

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {
                    vitri = bdsKHOA.Position;
                    bdsKHOA.RemoveCurrent();


                    this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHOATableAdapter.Update(this.dataSet.KHOA);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    panelKhoa.Enabled = false;

                    btnTHEM_KHOA.Enabled = true;
                    btnXOA_KHOA.Enabled = true;
                    btnGHI_KHOA.Enabled = false;
                    btnCancelKhoa.Enabled = false;
                    btnSuaKhoa.Enabled = true;
                    btnHOANTAC_KHOA.Enabled = true;
                    btnLAMMOI_KHOA.Enabled = true;
                    btnTHOAT.Enabled = true;
                    // lưu câu lệnh để hoàn tác
                    undo_Khoa.Push(cautruyvanHoanTac);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa KHOA. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

        }

        private void btnHOANTAC_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        
            if(undo_Khoa.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);

                return;
            }

            bdsKHOA.CancelEdit();
            String caulenhHoanTac = undo_Khoa.Pop().ToString();

            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            this.kHOATableAdapter.Fill(this.dataSet.KHOA);

            kiemtraThemMoi_Khoa = false;
            panelKhoa.Enabled = false;

            btnTHEM_KHOA.Enabled = true;
            btnXOA_KHOA.Enabled = true;
            btnGHI_KHOA.Enabled = false;
            btnCancelKhoa.Enabled = false;
            btnSuaKhoa.Enabled = true;
            btnHOANTAC_KHOA.Enabled = true;
            btnLAMMOI_KHOA.Enabled = true;
            btnTHOAT.Enabled = true;
        }

        private void btnLAMMOI_KHOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Fill(this.dataSet.KHOA);
                //this.gridControlMonHoc.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnCancelKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kiemtraThemMoi_Khoa == true)
            {
                bdsKHOA.RemoveCurrent();

            }
            kiemtraThemMoi_Khoa = false;
            txtMaKhoa.Enabled = true;
            panelKhoa.Enabled = false;


            btnTHEM_KHOA.Enabled = true;
            btnXOA_KHOA.Enabled = true;
            btnGHI_KHOA.Enabled = false;
            btnCancelKhoa.Enabled = false;
            btnSuaKhoa.Enabled = true;
            btnHOANTAC_KHOA.Enabled = true;
            btnLAMMOI_KHOA.Enabled = true;
            btnTHOAT.Enabled = true;
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                kHOAGridControl.Enabled = false;
                this.bdsLop.AddNew();
                kiemtraThemMoi_Lop = true;
                panelLop.Enabled = true;

                btnThemLop.Enabled = false;
                btnSuaLop.Enabled = false;
                btnGhiLop.Enabled = true;
                btnCancelLop.Enabled = true;
                btnHoanTacLop.Enabled = false;
                btnXoaLop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm lớp" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private bool KiemtraDuLieu_Lop()
        {
            if (txtMaLop.Text == "")
            {
                MessageBox.Show("Không được để trống mã  lớp", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtMaLop.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã lớp chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKhoa.Focus();
                return false;
            }*/
            if (txtMaKhoa.Text.Length > 15)
            {
                MessageBox.Show("Mã lớp không được quá 15 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return false;
            }

            // kiểm tra tên lớp
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Không được để trống tên lớp ", "Thông báo", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            /*if (Regex.IsMatch(txtTenLop.Text, @"^[a-zA-Z0-9 ]+$") == false)// kiểm tra bao gồm khoảng trắng
            {
                MessageBox.Show("Tên lớp chỉ có chữ cái và số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }*/
            if (txtTenLop.Text.Length > 50)
            {
                MessageBox.Show("Tên lớp không được quá 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }

            return true;

        }
        private void btnGhiLop_Click(object sender, EventArgs e)
        {
            bool kqkiemtra = KiemtraDuLieu_Lop();
            int ketquaTrave = 0;
            if (kqkiemtra == false)
            {
                return;
            }

            //TIẾN HÀNH KIỂM TRA TỒN TẠI SO
            if (kiemtraThemMoi_Lop == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KIEM_TRA_MA_LOP '" + txtMaLop.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                ketquaTrave = int.Parse(Program.myReader.GetValue(0).ToString());

                Program.myReader.Close();
            }
            DataRowView drv = (DataRowView)bdsLop[bdsLop.Position];
            string TenLop = drv["TENLOP"].ToString();

            if (ketquaTrave == 1)
            {
                MessageBox.Show("Mã lớp đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {

                DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {


                        string strlenhUndo = "";
                        if (kiemtraThemMoi_Lop == true)
                        {
                            strlenhUndo = "DELETE DBO.LOP WHERE MAlOP ='" + txtMaLop.Text.Trim() + "'";

                        }
                        else
                        {
                            strlenhUndo = "UPDATE DBO.LOP SET TENLOP = '" + TenLop + "'" + "WHERE MALOP = '" + txtMaLop.Text + "'";

                        }
                        undo_Lop.Push(strlenhUndo);
                        this.bdsLop.EndEdit();

                        this.lOPTableAdapter.Update(this.dataSet.LOP);
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);

                        kiemtraThemMoi_Lop = false;
                        panelLop.Enabled = false;
                        kHOAGridControl.Enabled = true;

                        btnThemLop.Enabled = true;
                        btnSuaLop.Enabled = true;
                        btnGhiLop.Enabled = false;
                        btnCancelLop.Enabled = false;
                        btnHoanTacLop.Enabled = true;
                        btnXoaLop.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsLop.RemoveCurrent();
                        MessageBox.Show("Tên LỚP có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {

            kiemtraThemMoi_Lop = false;
            panelLop.Enabled = true;

            btnThemLop.Enabled = false;
            btnSuaLop.Enabled = false;
            btnGhiLop.Enabled = true;
            btnCancelLop.Enabled = true;
            btnHoanTacLop.Enabled = false;
            btnXoaLop.Enabled = false;
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (bdsLop.Count == 0)
            {
                MessageBox.Show("Không tồn tại lớp nào để xóa!", "Thông báo", MessageBoxButtons.OK);
            }
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã tồn tại sinh viên!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (bdsGiaoVien_DangKi.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã tồn tại giáo viên đăng kí lớp!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            maKhoa = ((DataRowView)bdsKHOA[bdsKHOA.Position])["MAKH"].ToString();

            string cautruyvanHoanTac =
            "INSERT INTO DBO.LOP( MALOP, TENLOP, MAKH)" +
            " VALUES ( '" + txtMaLop.Text.Trim() + "','" +
                        txtTenLop.Text.Trim() + "','" + maKhoa + "') ";

            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {



                    bdsLop.RemoveCurrent();


                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dataSet.LOP);

                    // lưu câu lệnh để hoàn tác
                    undo_Lop.Push(cautruyvanHoanTac);
                    panelLop.Enabled = false;

                    btnThemLop.Enabled = true;
                    btnSuaLop.Enabled = true;
                    btnGhiLop.Enabled = false;
                    btnCancelLop.Enabled = false;
                    btnHoanTacLop.Enabled = true;
                    btnXoaLop.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa KHOA. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnHoanTacLop_Click(object sender, EventArgs e)
        {
            panelLop.Enabled = false;

            btnThemLop.Enabled = true;
            btnSuaLop.Enabled = true;
            btnGhiLop.Enabled = false;
            btnCancelLop.Enabled = false;
            btnHoanTacLop.Enabled = true;
            btnXoaLop.Enabled = true;

            if (undo_Lop.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                btnHoanTacLop.Enabled = false;
                return;
            }

            bdsLop.CancelEdit();
            String caulenhHoanTac = undo_Lop.Pop().ToString();
            Console.WriteLine(caulenhHoanTac);

            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            this.lOPTableAdapter.Fill(this.dataSet.LOP);
            return;
        }

        private void btnCancelLop_Click(object sender, EventArgs e)
        {
            if (kiemtraThemMoi_Lop == true)
            {
                bdsLop.RemoveCurrent();
            }
            kHOAGridControl.Enabled = true;
            kiemtraThemMoi_Lop = false;
            panelLop.Enabled = false;

            btnThemLop.Enabled = true;
            btnSuaLop.Enabled = true;
            btnGhiLop.Enabled = false;
            btnCancelLop.Enabled = false;
            btnHoanTacLop.Enabled = true;
            btnXoaLop.Enabled = true;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (bdsLop.Count > 0)
            {
                btnXoaLop.Enabled = true;
                btnSuaLop.Enabled = true;
            }
            else if (bdsLop.Count == 0)
            {
                btnXoaLop.Enabled = false;
                btnSuaLop.Enabled = false;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}