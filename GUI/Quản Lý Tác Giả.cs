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
    public partial class Quản_Lý_Tác_Giả : Form
    {
        public Quản_Lý_Tác_Giả()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Quản_Lý_Tác_Giả_Load(object sender, EventArgs e)
        {

        }

        private void Quản_Lý_Tác_Giả_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resul = MessageBox.Show("Bạn có muốn trở về không", "Thông Báo", MessageBoxButtons.YesNo);
            if (resul == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
