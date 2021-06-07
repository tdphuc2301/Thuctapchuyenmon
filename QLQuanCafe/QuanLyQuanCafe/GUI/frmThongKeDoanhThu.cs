using BUS;
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
    public partial class frmThongKeDoanhThu : Form
    {
        BUS_ThongKe BUS_TK = new BUS_ThongKe();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            grdDoanhThu.AllowUserToAddRows = false;
            grdDoanhThu.DataSource = BUS_TK.ThongKeDoanhThu(dateTimePicker1.Value, dateTimePicker2.Value);
            grdDoanhThu.Columns[0].HeaderText = "Tổng tiền";
            grdDoanhThu.Columns[1].HeaderText = "Ngày hóa đơn";
            grdDoanhThu.Columns[2].HeaderText = "Bàn";
            grdDoanhThu.Columns[0].Width = 150;
            grdDoanhThu.Columns[1].Width = 150;
            grdDoanhThu.Columns[2].Width = 150;

            if (grdDoanhThu.Rows.Count == 0)
            {
                lblTongTien.Text = "0 VND";
                lblTongTien.ForeColor = SystemColors.HotTrack;
                return;
            }
            int tien = grdDoanhThu.Rows.Count;
            decimal thanhtien = 0;
            for (int i = 0; i < tien; i++)
            {
                thanhtien += decimal.Parse(grdDoanhThu.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            lblTongTien.Text = thanhtien.ToString("#,###") + " VND";
            if (lblTongTien.Text == " VND")
            {
                lblTongTien.Text = "0 VND";
            }
        }
    }
}
