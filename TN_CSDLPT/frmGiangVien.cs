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
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.dataSet.EnforceConstraints = false;
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'dataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dataSet.KHOA);

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelNhapLieu.Enabled = true;
            kiemtraThemMoi = true;


            bdsGiaoVien.AddNew();

            panelNhapLieu.Enabled = true;

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
            if(txtMaGV.Text.Trim().Length == 0) 
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


            string maMonHoc = txtMaGV.Text.Trim();
            DataRowView drv = ((DataRowView)bdsGiaoVien[bdsGiaoVien.Position]);
            String tenMonHoc = drv["TENGV"].ToString();



            if (kiemtraThemMoi == true)
            {
                String truyvan = "DECLARE @kq INT " + "EXEC @kq= SP_KiemTraMaGiangVien '" + txtMaGV.Text.Trim() + "' " + "select 'Value' =  @kq";
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
                        caulenhHoanTac = "delete DBO.GIANGVIEN WHERE MAGV = '" + txtMaGV.Text.Trim() + "'";
                    }
                    // TRƯỚC KHI NHẤN NÚT GHI LÀ SỬA
                    else
                    {
                        caulenhHoanTac = "update DBO.GIANGVIEN SET " + "TENMH = '" + tenMonHoc + "' WHERE MAMH = '" + maMonHoc + "'";
                    }

                    undo.Push(caulenhHoanTac);
                    this.bdsGiaoVien.EndEdit();
                    this.gIAOVIENTableAdapter.Update(this.dataSet.GIAOVIEN);

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
    }
}