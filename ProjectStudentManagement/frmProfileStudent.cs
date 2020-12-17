using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectStudentManagement
{
    public partial class frmProfileStudent : Form
    {
        Student student;
        public frmProfileStudent()
        {
            InitializeComponent();
            student = Student.CreateStudent();
            txtID.Text = student.ID;
            txtFN.Text = student.FirstName;
            txtLN.Text = student.LastName;
            txtPLB.Text = student.PlaceOfBirth;
            dtDOB.Value = student.DateOfBirth;
            switch (student.Gender)
            {
                case SEXUAL.Male:
                    rbMale.Checked = true;
                    break;
                case SEXUAL.Female:
                    rbFemale.Checked = true;
                    break;
                case SEXUAL.Other:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmProfileStudent_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "File hình ảnh | *.jgp;*.png";
            dialog.Title = "Chọn hình ảnh đại diện cho sinh viên";
            var rs = dialog.ShowDialog();
            if(rs == DialogResult.OK)
            {
                var filePath = dialog.FileName;
                picAvatar.ImageLocation = filePath;
            }
        }
    }
}
