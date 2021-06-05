using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLMatket
{
    public partial class CategoryForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQurey = "INSERT INTO Category VALUES(" + txtbID.Text + ", '" + txtbName.Text + "', '" + txtbDes.Text + "' )";
                SqlCommand cmd = new SqlCommand(insertQurey,dBCon.GetConnection());
                dBCon.OpenCon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm sản phẩm thành công");
                dBCon.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
