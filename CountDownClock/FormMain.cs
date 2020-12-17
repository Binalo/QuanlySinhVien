using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownClock
{
    public partial class FormMain : Form
    {
        long remainSeconds = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainSeconds == 0)
            {
                timer1.Stop();
            }
            else
            remainSeconds--;
            showClock(remainSeconds);
        }

        private void numMinutes_ValueChanged(object sender, EventArgs e)
        {
            showStartClock();
        }

        private void numSeconds_ValueChanged(object sender, EventArgs e)
        {
            showStartClock();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if(remainSeconds == 0)
               showStartClock();
            timer1.Start();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            remainSeconds = 0;
            showClock(remainSeconds);
            timer1.Stop();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            showClock(remainSeconds);
        }
        #endregion
        #region Code
        long calRenameSeconds(int minute, int second)
        {
            return minute * 60 + second;

        }
        void showClock(long remainSeconds)
        {
            lblClock.Text = $"{remainSeconds / 60:0#}:{remainSeconds % 60:0#}";
        }
        void showStartClock()
        {
            var minutes = (int)numMinutes.Value;
            var seconds = (int)numSeconds.Value;
            remainSeconds = calRenameSeconds(minutes, seconds);
            showClock(remainSeconds);
        }



        #endregion

        
    }
}
