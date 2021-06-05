using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTin_NhanVien : Form
    {
        public frmThongTin_NhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTin_NhanVien_Sua frm =new frmThongTin_NhanVien_Sua();
            frm.ShowDialog();
        }
    }
}
