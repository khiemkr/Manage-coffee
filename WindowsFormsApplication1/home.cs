using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar2_progressChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int start=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            ProgressBar.Value = start;
            if (ProgressBar.Value==100)
            {
                ProgressBar.Value = 0;
                timer1.Stop();
                Form1 log = new Form1();
                this.Hide();
                log.Show();
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
