using DevExpress.XtraEditors;
using System;
using System.Collections;
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
    public partial class frmGiangVien : DevExpress.XtraEditors.XtraForm
    {
        bool kiemtraThemMoi = false;
        Stack undo = new Stack();
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
         
            this.DataSet.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'dataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DataSet.KHOA);
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DataSet.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.DataSet.BODE);
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            
            

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = true;
            kiemtraThemMoi = true;
            gcGiaoVien.Enabled = false;


            bdsGiaoVien.AddNew();

            pc1.Enabled = true;

            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnGHI.Enabled = true;
            btnSUA.Enabled = false;
            btnCANCEL.Enabled = true;
            btnHOANTAC.Enabled = false;
            btnLAMMOI.Enabled = false;
            btnTHOAT.Enabled = false;
        }

        private bool KiemTraDuLieuDauVao()
        {
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không đc để trống mã giảng viên", "Thông báo", MessageBoxButtons.OK);

                return false;
            }

            if (txtHo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không đc để trống họ", "Thông báo", MessageBoxButtons.OK);

                return false;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không đc để trống tên", "Thông báo", MessageBoxButtons.OK);

                return false;
            }
            if (txtDiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không đc để trống địa chỉ", "Thông báo", MessageBoxButtons.OK);

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


            DataRowView drv = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position]);
            string maGiangVien = drv["MAGV"].ToString().Trim();
            string TEN = drv["TEN"].ToString().Trim();
            string HO = drv["HO"].ToString().Trim();
            string DIACHI = drv["DIACHI"].ToString().Trim();



            if (kiemtraThemMoi == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KIEM_TRA_MA_GIANG_VIEN '" + txtMaGV.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                MessageBox.Show("Mã giảng viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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
                        caulenhHoanTac = "delete DBO.GIAOVIEN WHERE MAGV = '" + maGiangVien + "'";
                    }
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                    else
                    {
                        caulenhHoanTac = "update DBO.GIAOVIEN SET " + "TEN = '" + TEN +"',HO = '" + HO 
                        +"',DIACHI ='"+ DIACHI + "' WHERE MAGV = '" + maGiangVien + "'";
                    }

                    undo.Push(caulenhHoanTac);
                    this.bdsGiaoVien.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.DataSet.GIAOVIEN);

                    MessageBox.Show("Ghi thành công",
                     "Thông báo", MessageBoxButtons.OK);

                    panelNhapLieu.Enabled = false;
                    gcGiaoVien.Enabled = true;
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
            if (bdsGiaoVien.Count == 0)
            {
                btnXOA.Enabled = false;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên vì đã có bộ đề", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(bdsGiaoVien_DangKi.Count > 0)
            {
                MessageBox.Show("Không thể xóa giảng viên vì đã có Giao Viên Đăng Kí", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            DataRowView drv = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position]);
            string MAGV = drv["MAGV"].ToString().Trim();
            string TEN = drv["TEN"].ToString().Trim();
            string HO = drv["HO"].ToString().Trim();
            string DIACHI = drv["DIACHI"].ToString().Trim();
            string MAKH = drv["MAKH"].ToString().Trim();
            string hoantac =
            "INSERT INTO DBO.GIAOVIEN(MAGV, HO, TEN, DIACHI,MAKH)" +
            " VALUES( '" + MAGV + "','" + HO + "','" + TEN +"','" + DIACHI + "','" + MAKH + "')";

            if (dr == DialogResult.OK)
            {
                string MaGV = "";
                try
                {

                    MaGV = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position])["MAGV"].ToString();// lưu lại
                    bdsGiaoVien.RemoveCurrent();


                    this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIAOVIENTableAdapter.Update(this.DataSet.GIAOVIEN);
                    MessageBox.Show("Xóa thành công giáo viên", "Thông báo", MessageBoxButtons.OK);

                    // lưu câu lệnh để hoàn tác
                    undo.Push(hoantac);
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
                    MessageBox.Show("Lỗi xóa giảng viên Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    
                    return;
                }
            }

        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = true;
            gcGiaoVien.Enabled = false;
            kiemtraThemMoi = false;

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
            if (kiemtraThemMoi == true)
            {
                bdsGiaoVien.RemoveCurrent();
            }
            gcGiaoVien.Enabled = true;
            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnGHI.Enabled = false;
            btnSUA.Enabled = true;
            btnCANCEL.Enabled = false;
            btnHOANTAC.Enabled = true;
            btnLAMMOI.Enabled = true;
            btnTHOAT.Enabled = true;
        }

        private void btnHOANTAC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (undo.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục dữ liệu ", "Thông báo", MessageBoxButtons.OK);
                btnHOANTAC.Enabled = false;
                return;
            }

            bdsGiaoVien.CancelEdit();
            String caulenhHoanTac = undo.Pop().ToString();
            Console.WriteLine(caulenhHoanTac);

            int n = Program.ExecSqlNonQuery(caulenhHoanTac);
            this.gIAOVIENTableAdapter.Fill(this.DataSet.GIAOVIEN);

            panelNhapLieu.Enabled = false;

            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnGHI.Enabled = false;
            btnSUA.Enabled = true;
            btnCANCEL.Enabled = false;
            btnHOANTAC.Enabled = true;
            btnLAMMOI.Enabled = true;
            btnTHOAT.Enabled = true;


            return;
        }

        private void kHOAGridControl_Click(object sender, EventArgs e)
        {
            if(bdsGiaoVien.Count == 0)
            {
                btnXOA.Enabled = false;
                btnSUA.Enabled = false;
            }
            else
            {
                btnXOA.Enabled = true;
                btnSUA.Enabled = true;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}