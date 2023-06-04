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
using TN_CSDLPT.Subform;

namespace TN_CSDLPT
{
    public partial class frmDangKiTHI : DevExpress.XtraEditors.XtraForm
    {
        
        bool kiemtraTHEM = false;
        Stack undo = new Stack();
        public frmDangKiTHI()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGIAOVIEN_DANGKI.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmDangKiTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.dataSet.EnforceConstraints = false;
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSet.GIAOVIEN_DANGKY);

            cmbCoSo.DataSource = Program.bds_DSCS;
            cmbCoSo.DisplayMember = "TENCS";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mCoSo;

            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            cbbTrinhDo.DataSource = list;
            cbbTrinhDo.SelectedIndex = 0;

            if(Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
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
                dataSet.EnforceConstraints = false;
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSet.GIAOVIEN_DANGKY);
            }
        }

       


        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void LayDSTrinhDo(string cmd)
        {
            DataTable dt = new DataTable();
            dt = Program.ExecDataTable(cmd);
            //cmbTrinhDo.DataSource = dt;
            //cmbTrinhDo.DisplayMember = "TENTRINHDO";
            //cmbTrinhDo.ValueMember = "TRINHDO";

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bdsGIAOVIEN_DANGKI.AddNew();
                kiemtraTHEM = true;
                pcNhapLieu.Enabled = true;

                btnTHEM.Enabled = false;
                btnXOA.Enabled = false;
                btnGHI.Enabled = true;
                btnCancel.Enabled = true;
                btnTHOAT.Enabled = false;
                btnHoanTac.Enabled = false;
                btnSua.Enabled = false;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm " + ex.Message,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private bool KiemTraDuLieu()
        {
            if (txtMaGV.Text.Length == 0)
            {
                MessageBox.Show("Mã Giảng Viên không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (txtMaMH.Text.Length == 0)
            {
                MessageBox.Show("Mã Môn Học không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMaLop.Text.Length == 0)
            {
                MessageBox.Show("Mã Lớp không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }


            if (dateNgayThi.Text.Length == 0)
            {
                MessageBox.Show("Ngay thi không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (spinLAN.Text.Length == 0)
            {
                MessageBox.Show("Só lần thi không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            //kiểm tra  lần thi 1 hoặc 2
            if (int.Parse(spinLAN.Text) < 1 || int.Parse(spinLAN.Text) > 2)
            {
                MessageBox.Show("Só lần thi chỉ có thể là 1 hoặc là 2 !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            // số câu thi
            if (txtSoCauTHI.Text.Length == 0)
            {
                MessageBox.Show("Số câu thi không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if(int.Parse(txtSoCauTHI.Text) <= 10 || int.Parse(txtSoCauTHI.Text) >= 100)
            {
                MessageBox.Show("Số câu thi nằm trong khoảng 10 đến 100 câu  !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    
            if (Regex.IsMatch(txtSoCauTHI.Text, @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số câu thi chỉ só thể là số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            //Thời gian thi
            if (Regex.IsMatch(txtThoiGian.Text, @"^[0-9 ]+$") == false)
            {
                MessageBox.Show("Thời gian THI chỉ só thể là số!", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtThoiGian.Text.Length == 0)
            {
                MessageBox.Show("Thời Gian THI không được để trống !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (int.Parse(txtThoiGian.Text) < 15 || int.Parse(txtThoiGian.Text) > 60)
            {
                MessageBox.Show("Thời gian THI nằm trong khoảng 15 đến 60 câu  !", "Thông báo", MessageBoxButtons.OK);
                return false;
            }


            return true;
        }
        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string hoantac = "";
            if(KiemTraDuLieu() == false)
            {
                return;
            }

            //kiểm tra xem có bị trùng đăng kí thi


            // kiểm tra số câu thi có bị thiếu trong bộ đề không
            //string truyvan = "SELECT COUNT(CAUHOI) FROM BODE WHERE MAGV = '" + txtMaGV.Text + "'";
            //try
            //{
            //    Program.myReader = Program.ExecSqlDataReader(truyvan);
            //    if (Program.myReader == null)
            //    {
            //        return;
            //    }

            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Thực thi database thất bại " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;

            //}
            //int socauhoi = int.Parse(Program.myReader.GetValue(0).ToString());
            //if(socauhoi < int.Parse(txtSoCauTHI.Text))
            //{
            //    string socauthieu = string.Concat(int.Parse(txtSoCauTHI.Text) - socauhoi);
            //    MessageBox.Show("Số câu thi yêu cầu vượt quá số câu hỏi trong bộ đề, thiếu " + socauthieu, "THÔNG BÁO", MessageBoxButtons.OK);
            //    return;
            //}    

            DataRowView drv = (DataRowView)bdsGIAOVIEN_DANGKI[bdsGIAOVIEN_DANGKI.Position];
            string trinhdo = drv["TRINHDO"].ToString();
            string ngaythi = drv["NGAYTHI"].ToString();
            string solan = drv["LAN"].ToString();
            string socauthi = drv["SOCAUTHI"].ToString();
            string thoigian = drv["THOIGIAN"].ToString();

            DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                // Trước khi nhấn nút ghi là thêm
                if(kiemtraTHEM == true)
                {
                    hoantac = "delete from GIAOVIEN_DANGKY WHERE MAGV = '" + txtMaGV.Text.Trim() + "' AND MALOP = '" + txtMaLop.Text.Trim() + "' AND MAMH = '" + txtMaMH.Text.Trim() + "'" ;
                }
                //trước khi nhấn nút ghi là sửa
                else
                {
                    
                    hoantac = "UPDATE GIAOVIEN_DANGKY SET TRINHDO = '" + trinhdo + "', NGAYTHI = '" + ngaythi
                    + "', LAN = '" + solan + "', SOCAUTHI = '" + socauthi + "', THOIGIAN = '" + thoigian + "'";
                }

                undo.Push(hoantac);
                this.bdsGIAOVIEN_DANGKI.EndEdit();
                this.gIAOVIEN_DANGKYTableAdapter.Update(this.dataSet.GIAOVIEN_DANGKY);

                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                btnTHEM.Enabled = true;
                btnXOA.Enabled = true;
                btnGHI.Enabled = false;
                btnCancel.Enabled = false;
                btnTHOAT.Enabled = true;
                btnHoanTac.Enabled = true;
                btnSua.Enabled = true;

                kiemtraTHEM = false;
                pcNhapLieu.Enabled = false;
            }
            

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(bdsGIAOVIEN_DANGKI.Count == 0)
            {
                MessageBox.Show("Không tồn tại sinh viên nào", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string caulenhhoantac = "";
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {

                try
                {
                    
                    bdsGIAOVIEN_DANGKI.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dataSet.GIAOVIEN_DANGKY);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    // lưu câu lệnh để hoàn tác
                    undo.Push(caulenhhoantac);
                    btnTHEM.Enabled = true;
                    btnXOA.Enabled = true;
                    btnGHI.Enabled = false;
                    btnCancel.Enabled = false;
                    btnTHOAT.Enabled = false;
                    btnHoanTac.Enabled = true;
                    btnSua.Enabled = true;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa MÔN HỌC. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }


        }

        private void btnCHON_GIANG_VIEN_Click(object sender, EventArgs e)
        {
            ChonGiangVien clickGV = new ChonGiangVien();
            clickGV.ShowDialog();

            txtMaGV.Text = Program.MaGVDaChon;
        }

        private void btnCHON_MON_HOC_Click(object sender, EventArgs e)
        {
            ChonMonHoc clickMonHoc = new ChonMonHoc();
            clickMonHoc.ShowDialog();
            txtMaMH.Text = Program.MaMonDaChon;
        }

        private void btnCHON_LOP_Click(object sender, EventArgs e)
        {
            frmChonLop clickLop = new frmChonLop();
            clickLop.ShowDialog();
            txtMaLop.Text = Program.MaLopDuocChon;
        }

        

        private void cmbTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pcNhapLieu.Enabled = true;
            kiemtraTHEM = false;
            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnCancel.Enabled = true;
            btnTHOAT.Enabled = false;
            btnHoanTac.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pcNhapLieu.Enabled = false;
            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnGHI.Enabled = false;
            btnCancel.Enabled = false;
            btnTHOAT.Enabled = false;
            btnHoanTac.Enabled = true;
            btnSua.Enabled = true;
            if (kiemtraTHEM == true)
            {
                bdsGIAOVIEN_DANGKI.RemoveCurrent();
            }
           
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undo.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                
                return;
            }
            bdsGIAOVIEN_DANGKI.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();
            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            //Console.WriteLine(caulenhHoanTac + n.ToString());
            try
            {
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo làm mới", MessageBoxButtons.OK);
            }
        }

        private void tHOIGIANLabel_Click(object sender, EventArgs e)
        {

        }
    }
}