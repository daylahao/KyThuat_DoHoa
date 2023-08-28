﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using System.Windows.Forms;
using System.Drawing;
namespace DoAnCuoiKi_KTDH_WinForm.view
{
    public class View_Animation
    {
        public PictureBox view { get; set; }
        public Panel panellayer { get; set; }
        public int centerX, centerY;
        public static Size viewsize = new Size();
        public List<Draw.Point> _listpoint;
        public ObjectShape RainBow = new ObjectShape();
        private List<ObjectShape> listtreetriangle;
        private List<ObjectShape> listtreecircle;
        private List<ObjectShape> listcloud;
        private Tranform2D Tranform_2D;
        private List<List<ObjectShape>> ShapePoint;
        public void LoadUIView()
        {
            viewsize.width = view.Width;
            viewsize.height = view.Height;
            centerX = viewsize.width / 2;
            centerY = viewsize.height / 2;
            panellayer.Visible = true;
            ShapePoint = new List<List<ObjectShape>>();
            _listpoint = new List<Draw.Point>();
            view.Paint += SetupDrawView;
            view.Refresh();
        }
        private void SetupDrawView(object sender, PaintEventArgs e)
        {
            Pen grayPen = new Pen(Color.FromArgb(128, Color.Gray));
            Pen xPen = new Pen(Color.Red);
            Pen yPen = new Pen(Color.Red);
            if (MainForm.togglegrid)
            {
                // Vẽ lưới trục x
                for (int x = centerX; x < view.Width; x += MainForm.UnitSize)
                {
                    if (x == centerX) // Kiểm tra nếu là đường trục x đi qua tâm
                    {
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, x, 0, x, view.Height);
                    }
                }
                for (int x = centerX - MainForm.UnitSize; x >= 0; x -= MainForm.UnitSize)
                {
                    if (x == centerX) // Kiểm tra nếu là đường trục x đi qua tâm
                    {
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, x, 0, x, view.Height);
                    }
                }

                // Vẽ lưới trục y
                for (int y = centerY; y < view.Height; y += MainForm.UnitSize)
                {
                    if (y == centerY) // Kiểm tra nếu là đường trục y đi qua tâm
                    {
                        e.Graphics.DrawLine(yPen, 0, y, view.Width, y);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width, y);
                    }
                }
                for (int y = centerY - MainForm.UnitSize; y >= 0; y -= MainForm.UnitSize)
                {
                    if (y == centerY) // Kiểm tra nếu là đường trục y đi qua tâm
                    {
                        e.Graphics.DrawLine(yPen, 0, y, view.Width, y);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width, y);
                    }
                }
            }

            // Vẽ các điểm đã lưu trong danh sách
            using (Brush brush = new SolidBrush(Color.Black))
            {
                MainForm._BoxDetail.DataObject.Clear();
                foreach (List<ObjectShape> ListShape in ShapePoint)
                {
                    foreach(ObjectShape Shape in ListShape)
                        _listpoint.AddRange(Shape.Showpoint());
                }
                foreach (Draw.Point point in _listpoint)
                {
                    int pixelx = centerX + point.X * MainForm.UnitSize - MainForm.UnitSize / 2;
                    int pixely = centerY - point.Y * MainForm.UnitSize - MainForm.UnitSize / 2;
                    if (point.colorvalue != null)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(point.colorvalue.Value), pixelx, pixely, MainForm.UnitSize, MainForm.UnitSize);
                    }
                    else
                        e.Graphics.FillRectangle(brush, pixelx, pixely, MainForm.UnitSize, MainForm.UnitSize);
                }
                MainForm.LoadDetailMenu();
            }
        }
        public void click_putpixel(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)// khang dinh la chuot dc click la chuot trai
            {
                //pointsToDraw.Add(new Point(e.X,e.Y));
                //Tính Toạ độ để hiện lên textbox
                int pixelx = (e.X - centerX) / MainForm.UnitSize;
                int pixely = (centerY - e.Y) / MainForm.UnitSize;
                //Hiện toạ độ lên textbox
                /*                textBoxX.Text = pixelx.ToString();
                                textBoxY.Text = pixely.ToString();*/
                _listpoint.Add(new Draw.Point(pixelx, pixely));
                DataDetail data = new DataDetail();
                data.x = pixelx;
                data.y = pixely;
                view.Refresh();
                MainForm._BoxDetail.DataObject.Clear();
                MainForm._BoxDetail.DataObject.Add(data);
                if (!MainForm.mousedown)
                    MainForm.LoadDetailMenu();
            }

        }
        public void Resetview()
        {
            _listpoint.Clear();
            view.Refresh();
        }
        int steprainbow = 0;
        int rainbowspeed = 10;
        int Windpower = 5;
        bool animationrun = false;
        public void init()
        {

            listtreecircle = new List<ObjectShape>();
            CreateTreeCirle();
            listtreetriangle = new List<ObjectShape>();
            CreateTreeTriangle();
            listcloud = new List<ObjectShape>();
            CreateCloud();
        }
        private void CreateCloud()
        {
            Cloud _cloud = new Cloud();
            _cloud.Draw(200, 30, Color.White, Color.White);
            listcloud.Add(_cloud);
            _cloud = new Cloud();
            _cloud.Draw(100, 20, Color.White, Color.White);
            listcloud.Add(_cloud);
        }
        private void CreateTreeCirle()
        {
            TreeCircle _treecircle = new TreeCircle();
            _treecircle.Draw(5, 0, 20, 20, 3);
            listtreecircle.Add(_treecircle);
            _treecircle = new TreeCircle();
            _treecircle.Draw(-20, 0, -10, 10, 2);
            listtreecircle.Add(_treecircle);
        }
        private void CreateTreeTriangle()
        {
            TreeTriangle _treetriangle = new TreeTriangle();
            _treetriangle.Draw(-3, 0, 3, 20, 3);
            listtreetriangle.Add(_treetriangle);
            _treetriangle = new TreeTriangle();
            _treetriangle.Draw(-15, 0, -5, 20, 1);
            listtreetriangle.Add(_treetriangle);
        }
        int Time = 0;
        public void Update(object sender, EventArgs e)
        {
            ShapePoint.Add(listcloud);
            ShapePoint.Add(listtreetriangle);
            ShapePoint.Add(listtreecircle);
            Time++;
            view.Refresh();
            TreeTriAngle();
            treecirleanimation();
            cloudanimation();
            _listpoint.Clear();
            ShapePoint.Clear();
            if (Time==10)
            {
                Windpower = -Windpower;
                Time = 0;
            }
        }
        int scale = 1;
        int offsetscale = 1;
        public void TreeTriAngle()
        {
            if (Time % 7 == 0)
            {
                scale++;
                if (scale >=3)
                    scale = 0;
                foreach (ObjectShape Shape in listtreetriangle)
                {
                       // Draw.Point a = new Draw.Point((Shape.start.X + Shape.end.X) / 2, Shape.start.Y);
                    Shape.Scale(Shape.start, 1, scale);
                }
            }
        }
        public void treecirleanimation()
        {
                if (Time % 5 == 0)
                {
                    foreach (ObjectShape Shape in listtreecircle)
                    {
                        Draw.Point a = Shape.start;
                        Shape.Rotate(a, Windpower);
                    }
            }
        }
        public void cloudanimation()
        {
            if (Time % 3 == 0)
            {
                foreach(ObjectShape Shape in listcloud)
                {
                    Draw.Point a = Shape.center;
                    Shape.Move(a,-1,0);
                }
            }
        }
    }
}
