using EFNhom3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFNhom3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDanhSachLopHoc_Click(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        void LoadLopHoc()
        {
            var keyword = txtKeyWord.Text;
            AppDBContext db = new AppDBContext();
            var ls = db.LopHocs.Where(e => e.TenLop.Contains(keyword)).
                Select(e => new LopHocViewModel
                {
                    ML = e.MaLop,
                    TL = e.TenLop,
                    PH = e.PhongHoc,
                    SS = e.SinhViens.Count,
                }).ToList();
            gridDanhSach.DataSource = ls;
        }
    }
    class LopHocViewModel
    {
        public string ML { get; set; }
        public string TL { get; set; }
        public string PH { get; set; }
        public int SS { get; set; }
        public string LoaiLop
        {
            get
            {
                return TL.Substring(TL.Count() - 1, 1);
            }
        }

    }
}
