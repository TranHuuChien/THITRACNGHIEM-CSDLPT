using DevExpress.CodeParser;
using DevExpress.DataProcessing.InMemoryDataProcessor;
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

            if (Program.AuthGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;
                pcNhapLieu.Enabled = false;

                btnTHEM.Enabled = false;
                btnXOA.Enabled = false;
                btnGHI.Enabled = false;
                btnCancel.Enabled = false;
                btnTHOAT.Enabled = true;
                btnHoanTac.Enabled = false;
                btnSua.Enabled = false;


            }
            // Nhóm COSO có toàn quyền trên 
            else if (Program.AuthGroup == "COSO")
            {
                cmbCoSo.Enabled = false;
               
            }
            pcNhapLieu.Enabled = false;
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
                gcGiaoVien_DangKi.Enabled = false;

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
            if(int.Parse(txtSoCauTHI.Text.Trim()) <= 10 || int.Parse(txtSoCauTHI.Text.Trim()) >= 100)
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


            if(kiemtraTHEM == true)
            {
                //kiểm tra xem có bị trùng đăng kí thi
                string truyvankt = "DECLARE @kq int EXEC @kq = SP_KIEM_TRA_DANG_KI_THI '" + txtMaLop.Text.Trim() + "','"
                + txtMaMH.Text.Trim() + "'," + spinLAN.Text.Trim() + "  SELECT @kq";

                Program.myReader = Program.ExecSqlDataReader(truyvankt);
                Program.myReader.Read();
                int KQ_ktdk = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();
                // nếu kết quả kiểm tra là 0 thì oke
                if (KQ_ktdk == 1)
                {
                    MessageBox.Show("Đã tồn tại đăng kí thi, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

            }

            // kiểm tra số câu thi có bị thiếu trong bộ đề không
            //string truyvan1 = "EXEC SP_KIEM_TRA_DU_CAU_THI 'TH04', 'A','CSDL',50";
            string truyvan = "EXEC SP_KIEM_TRA_DU_CAU_THI '" + txtMaLop.Text + "','" + cbbTrinhDo.Text + "','" + txtMaMH.Text + "'," + txtSoCauTHI.Text;
            try
            {
                Program.myReader = Program.ExecSqlDataReader(truyvan);
               if (Program.myReader == null)
               {
                   return;
               }

            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Close();
           
            DataRowView drv = (DataRowView)bdsGIAOVIEN_DANGKI[bdsGIAOVIEN_DANGKI.Position];
            string MAGV = drv["MAGV"].ToString().Trim();
            string MAMH = drv["MAMH"].ToString().Trim();
            string MALOP = drv["MALOP"].ToString().Trim();
            string TRINHDO = drv["TRINHDO"].ToString().Trim();
            string NGAYTHI = drv["NGAYTHI"].ToString().Trim();
            string LAN = drv["LAN"].ToString().Trim();
            string SOCAUTHI = drv["SOCAUTHI"].ToString().Trim();
            string THOIGIAN = drv["THOIGIAN"].ToString().Trim();

            DialogResult dr = MessageBox.Show("Bạn có chắc ghi dữ liệu vào cơ sở dữ liệu ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                // Trước khi nhấn nút ghi là thêm
                if(kiemtraTHEM == true)
                {
                    hoantac = "delete FROM GIAOVIEN_DANGKY WHERE LAN = "+ LAN + " AND MALOP = '" + MALOP + "' AND MAMH = '" + MAMH + "'" ;
                }
                //trước khi nhấn nút ghi là sửa
                else
                {
                    
                    hoantac = "UPDATE GIAOVIEN_DANGKY SET TRINHDO = '" + TRINHDO + "', NGAYTHI = '" + NGAYTHI
                    + "', MAGV = '" + MAGV + "', SOCAUTHI = " + SOCAUTHI + ", THOIGIAN = " + THOIGIAN + 
                    " WHERE LAN = "+ LAN + " AND MALOP = '" + MALOP + "' AND MAMH = '" + MAMH + "'" ;
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
                txtMaGV.Enabled = true;
                txtMaMH.Enabled = true;
                txtMaLop.Enabled = true;
                pcNhapLieu.Enabled = false;
                gcGiaoVien_DangKi.Enabled = true;
            }
            

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv = (DataRowView)bdsGIAOVIEN_DANGKI[bdsGIAOVIEN_DANGKI.Position];
            string MAGV = drv["MAGV"].ToString().Trim();
            string MAMH = drv["MAMH"].ToString().Trim();
            string MALOP = drv["MALOP"].ToString().Trim();
            string TRINHDO = drv["TRINHDO"].ToString().Trim();
            string NGAYTHI = drv["NGAYTHI"].ToString().Trim();
            string LAN = drv["LAN"].ToString().Trim();
            string SOCAUTHI = drv["SOCAUTHI"].ToString().Trim();
            string THOIGIAN = drv["THOIGIAN"].ToString().Trim();

            if (bdsGIAOVIEN_DANGKI.Count == 0)
            {
                MessageBox.Show("Không tồn tại sinh viên nào", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // kiểm tra đăng kí thi đã có bài thi hay nói cách khác là đa
            string KTXOA = "DECLARE @KQ INT EXEC @KQ =  SP_KIEM_TRA_DANG_KI_THI_DA_THI_CHUA '"+ MALOP +"','"+ MAMH +"'," + LAN +"  SELECT @KQ";
            try
            {
                Program.myReader = Program.ExecSqlDataReader(KTXOA);
                if (Program.myReader == null)
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.myReader.Read();
            int KQ = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if(KQ == 1)
            {
                MessageBox.Show("Đăng kí thi đã được thi rồi ,vui lòng không được xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }    

           

            string caulenhhoantac = "INSERT INTO GIAOVIEN_DANGKY(MAGV,MAMH,MALOP,TRINHDO,NGAYTHI,LAN, SOCAUTHI, THOIGIAN) VALUES('" +
            MAGV + "','" + MAMH + "','" + MALOP + "','" + TRINHDO + "','"+ NGAYTHI + "'," +
            LAN + "," + SOCAUTHI + "," + THOIGIAN + ")";
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
            gcGiaoVien_DangKi.Enabled = false;

            txtMaGV.Enabled = false; 
            txtMaMH.Enabled = false;
            txtMaLop.Enabled = false;

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
            
            txtMaGV.Enabled = true;
            txtMaMH.Enabled = true;
            txtMaLop.Enabled = true;
            pcNhapLieu.Enabled = false;
            gcGiaoVien_DangKi.Enabled = true;

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
            try
            {
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(dataSet.GIAOVIEN_DANGKY);
            }
            catch(Exception ex)
            {

            }
            //Console.WriteLine(caulenhHoanTac + n.ToString());
           
        }

        private void tHOIGIANLabel_Click(object sender, EventArgs e)
        {

        }
    }
}