using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraCharts;
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
    public partial class frmThiThu : DevExpress.XtraEditors.XtraForm
    {
        int slCauHoi = 0;
        int position = 0;
        int prevPosition = 0;
        DataTable dtTracNghiem;
        private BindingSource bds_DSTrinhDo = new BindingSource();// lấy danh sách các trình độ
        Dictionary<int, string> dsDapAn = new Dictionary<int, string>(50);// lưu lại danh sách lựa chọn của người dùng

        public frmThiThu()
        {
            InitializeComponent();
        }

        private void frmBoDe_Load(object sender, EventArgs e)
        {

            
            

        }

        private void btnLayDe_Click(object sender, EventArgs e)
        {
            plNhapLieu.Enabled = true;
            string dscauhoi = "SELECT TOP(10) CAUHOI, NOIDUNG, A,B, C,D,DAP_AN FROM BODE ORDER BY NEWID()";
            dtTracNghiem = Program.ExecDataTable(dscauhoi);
            slCauHoi = dtTracNghiem.Rows.Count;
            this.lvCauHoi.Items.Clear();
            
            int index = 1;
            foreach (DataRow dr in dtTracNghiem.Rows)
            {
                string cauhoi = "Câu " + index.ToString();
                lvCauHoi.Items.Add(cauhoi);
                index++;
            }
        }
        private string GetSelectOption()
        {
            string result = "";
            if (Answer1.Checked)
            {
                result = "A";
            }
            else if (Answer2.Checked)
            {
                result = "B";
            }
            else if (Answer3.Checked)
            {
                result = "C";
            }
            else if (Answer4.Checked)
            {
                result = "D";
            }
            return result;
        }
        private bool LoadPrevSelectedOption()
        {
            string prevselected = dsDapAn[prevPosition];
            if (prevselected.Equals("A"))
            {
                Answer1.Checked = true;
                return true;
            }
            else if (prevselected.Equals("B"))
            {
                Answer2.Checked = true;
                return true;
            }
            else if (prevselected.Equals("C"))
            {
                Answer3.Checked = true;
                return true;
            }
            else if (prevselected.Equals("D"))
            {
                Answer4.Checked = true;
                return true;
            }
            return false;
        }

        private void SaveSelectedOption()
        {
            dsDapAn[position] = GetSelectOption();

        }
        private void lvCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {

            SaveSelectedOption();
            position = lvCauHoi.FocusedItem.Index;
            MessageBox.Show("Position : " + position, "Thông báo", MessageBoxButtons.OK);
            ShowDataQuestion(position);

            // bắt sựkiện prev , next button
            btnCauSau.Enabled = (position < dtTracNghiem.Rows.Count - 1 ? true : false);
            btnCauTrc.Enabled = (position > 0 ? true : false);

            prevPosition = position;
            // reset lại option
            Answer1.Checked = Answer2.Checked = Answer3.Checked = Answer4.Checked = false;

            //bool flag = LoadPrevSelectedOption();// thể hiện lại đáp áp các câu
        }
        private void ShowDataQuestion(int posQuestion)
        {
            CauHoi.Text = "Câu " + (posQuestion + 1).ToString();
            ContentQuestion.Text = dtTracNghiem.Rows[posQuestion]["NOIDUNG"].ToString();
            Answer1.Text = "A." + dtTracNghiem.Rows[posQuestion]["A"].ToString();
            Answer2.Text = "B." + dtTracNghiem.Rows[posQuestion]["B"].ToString();
            Answer3.Text = "C." + dtTracNghiem.Rows[posQuestion]["C"].ToString();
            Answer4.Text = "D." + dtTracNghiem.Rows[posQuestion]["D"].ToString();

        }

        private void btnCauDau_Click(object sender, EventArgs e)
        {
            
        }
    }
}