using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMatket
{
    public partial class SystemForm : Form
    {
        public SystemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void myCircleProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 4;
            myCircleProgressBar.Value = startPoint;
            if (myCircleProgressBar.Value == 100)
            { 
                myCircleProgressBar.Value = 0;
                timer1.Stop();
                FormLogin loginFrom = new FormLogin();
                this.Hide();
                loginFrom.Show();
            }
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0;
    }
}
