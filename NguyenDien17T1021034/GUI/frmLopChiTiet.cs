using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenDien17T1021034.GUI
{
    public partial class frmLopChiTiet : Form
    {
        public frmLopChiTiet()
        {
            InitializeComponent();
            //Thêm lớp học
            this.Text = "Thêm lớp học";
        }
        LopHoc lopHoc;

        public frmLopChiTiet(LopHoc lopHoc)
        {

            InitializeComponent();
            //CHinh sua lop hoc
            this.lopHoc = lopHoc;
            this.Text = "Sua lop hoc";
            txtTenLop.Text = lopHoc.TenLop;
            txtPhongHoc.Text = lopHoc.PhongHoc;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            var tenLop = txtTenLop.Text;
            var phongHoc = txtPhongHoc.Text;
            if (this.lopHoc == null)
            {
                lopHoc = new LopHoc
                {
                    MaLop = Guid.NewGuid().ToString(),
                    TenLop = tenLop,
                    PhongHoc = phongHoc
                };

                var db = new AppDBContext();
                db.LopHocs.Add(lopHoc);
                db.SaveChanges();
                MessageBox.Show("Bạn đã thêm lớp thành công");
                DialogResult = DialogResult.OK;
            }

            else
            {
                var db = new AppDBContext();
                lopHoc = db.LopHocs.Where(t => t.MaLop == lopHoc.MaLop).FirstOrDefault();
                lopHoc.TenLop = tenLop;
                lopHoc.PhongHoc = phongHoc;
                db.SaveChanges();
                MessageBox.Show("Bạn đã sửa lớp thành công");
                DialogResult = DialogResult.OK;
            }
        } 
    }
}
