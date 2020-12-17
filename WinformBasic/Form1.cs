using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = 0;
                errorProvider1.Clear();
                if (!double.TryParse(txtA.Text,out temp))
                {
                    var mes = $"Vui lòng nhập số a";
                    //MessageBox.Show(mes, "Thông báo lỗi",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Error);
                    errorProvider1.SetError(txtA,mes);
                    txtA.Focus();
                    return;
                }
                if (!double.TryParse(txtB.Text, out temp))
                {
                    var mes = $"Vui lòng nhập số b";
                    //MessageBox.Show(mes, "Thông báo lỗi",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Error);
                    errorProvider1.SetError(txtB,mes);
                    txtB.Focus();
                    return;
                }
                var a = Convert.ToDouble(txtA.Text);
                var b = Convert.ToDouble(txtB.Text);
                //var rs1 = String.Format("{0}+{1}={2}", a, b, a + b);
                var rs = $"{a}+{b}={a + b}";
                MessageBox.Show(rs, "Result",
                    MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                var mes = $"Lỗi rồi bạn ơi. Nhập lại nha";
                MessageBox.Show(mes, "Thông báo lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
