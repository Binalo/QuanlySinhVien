using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NguyenDien17T1021034;
using NguyenDien17T1021034.GUI;

namespace NguyenDien17T1021034
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            gridLopHoc.AutoGenerateColumns = false;
            gridSV.AutoGenerateColumns = false;
            LoadLopHoc();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        void LoadLopHoc()
        {
            var db = new AppDBContext();
            var ls = db.LopHocs.ToList();
            bdsLopHoc.DataSource = ls;
            gridLopHoc.DataSource = bdsLopHoc;
        }
        void LoadSV()
        {
            var db = new AppDBContext();
            var ls = db.SinhViens.ToList();
            bdsSinhVien.DataSource = ls;
            gridSV.DataSource = bdsSinhVien;
        }

        private void bdsLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var lopDangchon = bdsLopHoc.Current as LopHoc;
            if(lopDangchon != null)
            {
                LoadSinhVien(lopDangchon.MaLop);
            }
        }
        public void LoadSinhVien(string maLop)
        {
            var db = new AppDBContext();
            var lsSV = db.SinhViens.Where(e => e.MaLop == maLop).ToList();
            gridSV.DataSource = lsSV;
        }
        LopHoc lopHoc;
        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmLopChiTiet();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadLopHoc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as LopHoc;
            if (lopDangChon != null)
            {
                var f = new frmLopChiTiet(lopDangChon);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    LoadLopHoc();
                }
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            var f = new frmSinhVienChiTiet();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadSV();
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            var svDangchon = bdsSinhVien.Current as SinhVien;
            if (svDangchon != null)
            {
                var f = new frmSinhVienChiTiet(svDangchon);
              
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadSV();
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var lopDangChon = bdsLopHoc.Current as LopHoc;
            if (lopDangChon != null)
            {
                var rs = MessageBox.Show(
                    "Bạn có muốn xóa Lớp này không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    var db = new AppDBContext();
                    var lop = db.LopHocs.Where(t => t.MaLop == lopDangChon.MaLop).FirstOrDefault();
                    if (lop != null)
                    {
                        db.LopHocs.Remove(lop);
                        db.SaveChanges();
                        LoadLopHoc();
                    }
                }
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            var sinhVienDangChon = bdsSinhVien.Current as SinhVien;
            if (sinhVienDangChon != null)
            {
                var rs = MessageBox.Show(
                    "Bạn có muốn xóa Sinh Viên này không?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    //Xóa lớp đang chọn
                    var db = new AppDBContext();
                    var sinhvien = db.SinhViens.Where(t => t.MaSinhVien == sinhVienDangChon.MaSinhVien).FirstOrDefault();
                    if (sinhvien != null)
                    {
                        db.SinhViens.Remove(sinhvien);
                        db.SaveChanges();
                        LoadSV();
                    }
                }

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadSV();
        }
    }
}
