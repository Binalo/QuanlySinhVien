using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDien17T1021034.GUI
{
    public partial class frmSinhVienChiTiet : Form
    {
        SinhVien sinhVien;
        LopHoc lopHoc;
        public frmSinhVienChiTiet()
        {
            InitializeComponent();
            this.Text = "Them Sinh Vien";
            //DataTable dtDataFromDB = GetDataFromDatabaseinDataTable();
            var db = new AppDBContext();
            var ls = db.LopHocs.OrderBy(t => t.MaLop).ToList();
            cbTenlop.DataSource = ls;
            cbTenlop.DisplayMember = "TenLop";
            cbTenlop.ValueMember = "MaLop";
        }
        public frmSinhVienChiTiet(SinhVien sv)
        {
            InitializeComponent();
            this.sinhVien = sv;
            this.Text = "Sửa Sinh Viên";
            txtMaSV.Text = sv.MaSinhVien;
            txtHo.Text = sv.Ho;
            txtTen.Text = sv.Ten;
            dtNgaySinh.Text = sv.NgaySinh.ToString();
            cbGioitinh.SelectedItem = sinhVien.GioiTinh;
            txtQuequan.Text = sv.QueQuan;
            // Combobox Malop
            //var db = new AppDBContext();
            //var ls = db.LopHocs.OrderBy(t => t.MaLop).ToList();
            //cbTenlop.DataSource = ls;
            //cbTenlop.DisplayMember = "TenLop";
            //cbTenlop.ValueMember = "MaLop";
            var tam = this.sinhVien.MaLop;
            var DB = new AppDBContext();
            var lop = DB.LopHocs.Where(t => t.MaLop == tam).FirstOrDefault();
            cbTenlop.Text = lop.TenLop;
        }
        

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (this.sinhVien == null)
            {
                 sinhVien = new SinhVien
                {
                    MaSinhVien = txtMaSV.Text,
                    Ho = txtHo.Text,
                    Ten = txtTen.Text,
                    NgaySinh = dtNgaySinh.Value,
                    QueQuan = txtQuequan.Text,
                    GioiTinh = cbGioitinh.SelectedItem.ToString(),
                    MaLop = cbTenlop.SelectedValue.ToString()
                };
                var db = new AppDBContext();
                var obj = db.SinhViens.Where(t => t.MaSinhVien == sinhVien.MaSinhVien).
               FirstOrDefault();
                if (obj == null)
                {
                    db.SinhViens.Add(sinhVien);
                    db.SaveChanges();
                    MessageBox.Show("Bạn đã thêm sinh viên thành công");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Mã SV bị trùng, vui lòng nhập lại !!");
                }
                }
            else
            {
                var db = new AppDBContext();
                sinhVien = db.SinhViens.Where(t => t.MaSinhVien == sinhVien.MaSinhVien).FirstOrDefault();
                sinhVien.Ho = txtHo.Text;
                sinhVien.Ten = txtTen.Text;
                sinhVien.GioiTinh = cbGioitinh.SelectedItem.ToString();
                sinhVien.NgaySinh = dtNgaySinh.Value;
                sinhVien.QueQuan = txtQuequan.Text;
                sinhVien.MaSinhVien = txtMaSV.Text;
                sinhVien.MaLop = cbTenlop.SelectedValue.ToString();
                db.SaveChanges();
                MessageBox.Show("Ban da sửa sinh vien thanh cong");
                DialogResult = DialogResult.OK;
            }

        }

        private void cbMalop_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        public DataTable GetDataFromDatabaseinDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                // database Connection String  
                string connectionString = "Server =.; database = QLSVNhom3; Integrated Security = true";
                using (SqlConnection sqlCon = new System.Data.SqlClient.SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    using (SqlDataAdapter SqlDa = new SqlDataAdapter("Select MaLop from LopHoc", sqlCon))
                    {
                        SqlDa.Fill(dt);
                    }
                    sqlCon.Close();
                }
                return dt;



            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
