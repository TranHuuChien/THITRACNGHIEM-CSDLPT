using DevExpress.XtraEditors;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using TN_CSDLPT.Subform;
using TN_CSDLPT.Class;

namespace TN_CSDLPT
{
    public partial class frmEXAM : DevExpress.XtraEditors.XtraForm
    {
        int iPhut;
        int iGiay;
        Timer timer;
        bool isSinhVien = false;
        int position = 0;// lưu lại vị trí các row bên trong datatable
        int index = 1;// tạo danh sách list câu hỏi tăng dần
        int slCauHoi = 0;
        string Malop = "";
        int prevPosition = 0;// lưu lại vị trí trước của row
        Dictionary<int, string> dsDapAn = new Dictionary<int, string>(50);// lưu lại danh sách lựa chọn của người dùng

        DataTable dtTracNghiem;
        public frmEXAM()
        {
            InitializeComponent();
        }

        private void frmEXAM_Load(object sender, EventArgs e)
        {
            string truyvan = "SELECT MALOP, TENLOP FROM LOP WHERE MALOP = (SELECT MALOP FROM SINHVIEN WHERE MASV ='" + Program.AuthLogin + "')";

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
            Malop = Program.myReader.GetValue(0).ToString();
            string TenLop = Program.myReader.GetValue(1).ToString();
            lbMaLop.Text = "MÃ LỚP : " + Malop; 
            lbHoTen.Text = "HỌ VÀ TÊN : " + Program.AuthHoten;
            lbTenLop.Text = "TÊN LỚP : " + TenLop;



            List<LanThi> lanthis = new List<LanThi> {
                new LanThi("1", "Lần 1"),
                new LanThi("2", "Lần 2"),
                
             };
            cbbLanThi.DataSource = lanthis;
            cbbLanThi.DisplayMember = "SOLAN";
            cbbLanThi.ValueMember = "TENLAN";
           

            Program.myReader.Close();
            string dsmohoc = "SELECT MAMH, TENMH FROM MONHOC WHERE MAMH IN (SELECT MAMH FROM GIAOVIEN_DANGKY) ";
            DataTable dt =  Program.ExecDataTable(dsmohoc);
            
            //while(Program.myReader.Read())
            //{
            //    string tenmonhoc = Program.myReader.GetString(0);
            //    cbbMonHoc.Items.Add(tenmonhoc);
            //}
            cbbMonHoc.DataSource = dt;
            cbbMonHoc.DisplayMember = "TENMH";
            cbbMonHoc.ValueMember = "MAMH";
            cbbMonHoc.SelectedIndex = 0;
            Program.myReader.Close();
        }

        public void LoadCAUHOI()
        {

        }

        private void HienThiPhutGio()
        {
            string sPhut = "";
            string sGiay = "";
            if(iPhut < 10)
            {
                sPhut = "0" + iPhut.ToString();
            }
            else
            {
                sPhut = iPhut.ToString();
            }

            if(iGiay < 10)
            {
                sGiay ="0" +  iGiay.ToString();
            }
            else
            {
                sGiay = iGiay.ToString();
            }

            this.txtThoiGian.Text = sPhut + ":" + iGiay;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            
            timer.Interval = 1000; //1s
            timer.Start();

        }
        private void btnLayDeThi_Click(object sender, EventArgs e)
        {

            //string dscauhoi = "EXEC SP_LAY_CAU_HOI_NGAU_NHIEN_CHUAN 'TH04','001', 'AVCB',1";
            string dscauhoi = "select top(10)CAUHOI, NOIDUNG, A,B, C,D,DAP_AN from BODE";
            dtTracNghiem = Program.ExecDataTable(dscauhoi);
            slCauHoi = dtTracNghiem.Rows.Count;
            this.listCauHoi.Items.Clear();
            Program.MaMonDaChon = cbbMonHoc.SelectedValue.ToString();
            foreach(DataRow dr in dtTracNghiem.Rows)
            {
                string cauhoi = "Câu " + index.ToString();
                listCauHoi.Items.Add(cauhoi);
                dsDapAn[index] = "";
                index++;
            }
            listCauHoi.SelectedIndex = 0;
            Program.myReader.Close();
            position = 0;
            ShowDataQuestion(position);
            pcHienThiChiTietCauHoi.Enabled = true;

            iGiay = 0;
            iPhut = 20;
            HienThiPhutGio();
        }

        private string GetSelectOption()
        {
            string result = "";
            if(Answer1.Checked)
            {
                result = "A";
            }
            else if(Answer2.Checked)
            {
                result = "B";
            }
            else if(Answer3.Checked)
            {
                result = "C";
            }
            else if(Answer4.Checked)
            {
                result = "D";
            }
            return result;
        }

        private bool LoadPrevSelectedOption()
        {
            string prevselected = dsDapAn[prevPosition];
            if( prevselected.Equals("A")) 
            {
                Answer1.Checked = true;
                return true;
            }
            else if( prevselected.Equals("B"))
            {
                Answer2.Checked = true;
                return true;
            }
            else if(prevselected.Equals("C"))
            {
                Answer3.Checked = true;
                return true;
            }
            else if(prevselected.Equals("D"))
            {
                Answer4.Checked = true;
                return true;
            }
            return false;
        }

       
        private void SaveSelectedOption()
        {
            
            if(position == dtTracNghiem.Rows.Count - 1)
            {
                dsDapAn[position] = GetSelectOption();
                
            }    
            else
            {
                dsDapAn[prevPosition] = GetSelectOption();
            }
            
        }

        void ChangeColorQuestion()
        {
            foreach (ListViewItem item in listCauHoi.Items)
            {
                if(item.Selected)
                {
                    item.BackColor = Color.Green;
                }
            }
        }
        private void listCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            SaveSelectedOption();
            if (this.listCauHoi.SelectedIndex < 0) return;

            position = int.Parse(this.listCauHoi.SelectedIndex.ToString());

            // bắt sựkiện prev , next button
            btnCauSau.Enabled = (position < dtTracNghiem.Rows.Count - 1 ? true : false);
            btnCauTrc.Enabled = (position > 0 ? true : false);

            ShowDataQuestion(position);
            prevPosition = position;

            
            // reset lại option
            Answer1.Checked = Answer2.Checked = Answer3.Checked = Answer4.Checked = false;

            bool flag =  LoadPrevSelectedOption();// thể hiện lại đáp áp các câu
            //if(flag== true)
            //{
            //    listCauHoi.Items[prevPosition].BackColor = Color.Blue;
            //}    
            

        }

        private void ShowDataQuestion(int posQuestion)
        {
            Cauhoi.Text = "Câu " + (posQuestion+1).ToString();
            ContentQuestion.Text = dtTracNghiem.Rows[posQuestion]["NOIDUNG"].ToString();
            Answer1.Text ="A."  + dtTracNghiem.Rows[posQuestion]["A"].ToString();
            Answer2.Text ="B."+ dtTracNghiem.Rows[posQuestion]["B"].ToString();
            Answer3.Text ="C."+dtTracNghiem.Rows[posQuestion]["C"].ToString();
            Answer4.Text ="D."+ dtTracNghiem.Rows[posQuestion]["D"].ToString();

        }

        private void cbbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbMonHoc.SelectedValue.ToString(), "Thông báo", MessageBoxButtons.OK);
            return;
        }

        private void btnCauDau_Click(object sender, EventArgs e)
        {
            listCauHoi.SelectedIndex = 0;
        }

        private void btnCauTrc_Click(object sender, EventArgs e)
        {
            if(position > 0)
            {
                listCauHoi.SelectedIndex = position - 1;
            }
        }

        private void btnCauSau_Click(object sender, EventArgs e)
        {
            
             if(position < dtTracNghiem.Rows.Count - 1)    
                listCauHoi.SelectedIndex = position + 1;
            
        }

        private void btnCauCuoi_Click(object sender, EventArgs e)
        {
            
            listCauHoi.SelectedIndex = dtTracNghiem.Rows.Count - 1;
        }


        private bool Check()
        {
            int i = 0;
            foreach (DataRow dr in dtTracNghiem.Rows)
            {
                if (dsDapAn[i]=="")
                {
                    return false;
                }    
                i++;
            }
            return true;
        }
        private void btnFinshTest_Click(object sender, EventArgs e)
        {
            if(!Check()) 
            {
                MessageBox.Show("Còn để trống câu hỏi ", "thông báo", MessageBoxButtons.OK);
                return;
            }
            //string truyvan = "exec SP_TAO_BAITHI 'AT2','001', 'AVCB',1";
            String truyvan = "exec SP_TAO_BAITHI '" + Malop.Trim() + "','" + Program.AuthLogin + "','" + cbbMonHoc.SelectedValue.ToString() + "'," + cbbLanThi.SelectedValue.ToString();
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
            string id_baithi = Program.myReader.GetValue(0).ToString();
            Program.myReader.Close();


            int correctAnswer = 0;
            string selectedOption = "";
            
            int i = 0;
            foreach(DataRow dr in dtTracNghiem.Rows)
            {
                string dapan = dr["DAP_AN"].ToString();
                string cauhoi = dr["CAUHOI"].ToString();
                selectedOption = dsDapAn[i];
                if (dapan.Equals(selectedOption))
                    correctAnswer++;
                string query = "INSERT INTO CT_BAITHI(ID_BAITHI,CAUHOI, STT,DACHON) VALUES("+id_baithi+","+cauhoi+","+i+",'"+selectedOption+"')";
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(query);
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
                Program.myReader.Close();

                i++;
            }
            float mark =(float)( correctAnswer*10)/ dtTracNghiem.Rows.Count;
            MessageBox.Show("Số câu đúng : "+ correctAnswer+"Điểm : " + mark, "Thông báo", MessageBoxButtons.OK);
            
        }
        
    }
}