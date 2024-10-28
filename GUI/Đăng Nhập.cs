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
    public partial class Đăng_Nhập : Form
    {
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        private void Đăng_Nhập_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng Nhập";
            lblQL.ForeColor = Color.Red;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Đăng_Nhập_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuảnLý ql = new QuảnLý();
            ql.Show();
        }
    }
}
