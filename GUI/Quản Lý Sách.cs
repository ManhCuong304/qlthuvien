using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class Quản_Lý_Sách : Form
    {
        public Quản_Lý_Sách()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Black;
            Rectangle borderRectangle = groupBox2.ClientRectangle;
            borderRectangle.X += 1;
            borderRectangle.Y += 8; // Khoảng cách cho tiêu đề
            borderRectangle.Width -= 2;
            borderRectangle.Height -= 10;


            // Vẽ viền với màu tùy chỉnh
            e.Graphics.DrawRectangle(new Pen(borderColor, 2), borderRectangle);

            // Vẽ lại text của GroupBox
            
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Green;

            // Đặt độ dày của viền
            int borderWidth = 2;

            // Lấy kích thước của Button
            Rectangle borderRectangle = button1.ClientRectangle;
            borderRectangle.Inflate(-borderWidth, -borderWidth);

            // Vẽ viền với màu tùy chỉnh
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, borderRectangle);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Green;

            // Đặt độ dày của viền
            int borderWidth = 2;

            // Lấy kích thước của Button
            Rectangle borderRectangle = button2.ClientRectangle;
            borderRectangle.Inflate(-borderWidth, -borderWidth);

            // Vẽ viền với màu tùy chỉnh
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, borderRectangle);
            }
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Green;

            // Đặt độ dày của viền
            int borderWidth = 2;

            // Lấy kích thước của Button
            Rectangle borderRectangle = button3.ClientRectangle;
            borderRectangle.Inflate(-borderWidth, -borderWidth);

            // Vẽ viền với màu tùy chỉnh
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, borderRectangle);
            }
        }

        private void Quản_Lý_Sách_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Roboto", 13, FontStyle.Regular);




        }
    }
}
