using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaiTapKTDH
{
    public partial class Form1 : Form
    {
        private const int ScalePixel = 5; // Đơn vị scale

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                pictureBox.MouseClick += PictureBox_MouseClick;
                pictureBox.KeyDown += PictureBox_KeyDown;
                pictureBox.Paint += PictureBox_Paint;
                pictureBox.Focus();
        }
        private void PictureBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxX.Text, out int x) && int.TryParse(textBoxY.Text, out int y))
                {
                    DrawPixel(x,y);
                }
                else
                {
                    MessageBox.Show("Invalid coordinates!");
                }
            }
        }

        private void DrawPixel(int x, int y)
        {
            using (Graphics g = pictureBox.CreateGraphics())
            {
                Brush brush = Brushes.Black;
                g.FillRectangle(brush, x * ScalePixel,y * ScalePixel, ScalePixel, ScalePixel);
            }
                
            labelCoordinates.Text = $"({x}, {y})";
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Vẽ các line để tạo hệ tọa độ
            using (Pen pen = new Pen(Color.Black))
            {
                // Vẽ trục x
                e.Graphics.DrawLine(pen, 0, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height / 2);
                // Vẽ trục y
                e.Graphics.DrawLine(pen, pictureBox.Width / 2, 0, pictureBox.Width / 2, pictureBox.Height);
            }
        }
        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / ScalePixel; // Tính tọa độ x theo đơn vị scale
            int y = e.Y / ScalePixel; // Tính tọa độ y theo đơn vị scale
            DrawPixel(x, y);
        }

        private void Btn_EnterDrawing_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x) && int.TryParse(textBoxY.Text, out int y))
            {
                DrawPixel(x, y);
            }
            else
            {
                MessageBox.Show("Invalid coordinates!");
            }
        }
    }
}
