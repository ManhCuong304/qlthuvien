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
    public partial class QuảnLý : Form
    {
        public QuảnLý()
        {
            InitializeComponent();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Quản_Lý_Sách QLS = new Quản_Lý_Sách();
            QLS.Show();
        }

        private void QuảnLý_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýĐọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Đọc_Giả QLDG =  new Quản_Lý_Đọc_Giả();
            QLDG.Show();
        }

        private void quảnLýTácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quản_Lý_Tác_Giả QLTG = new Quản_Lý_Tác_Giả();
            QLTG.Show();
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = menuStrip1.ClientRectangle;

            // Màu sắc và độ dày của viền
            Color borderColor = Color.Black;
            int borderWidth = 2;

            // Vẽ viền cho MenuStrip
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, borderRectangle.Width - 1, borderRectangle.Height - 1);
            }
        }
    }
}
