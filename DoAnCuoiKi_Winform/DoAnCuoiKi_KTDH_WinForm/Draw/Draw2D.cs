using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DoAnCuoiKi_KTDH_WinForm.view;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{

    public class Draw2D
    {
        List<Draw.Point> _listfill;
        static bool[,] ListCheck;
        static int picturewidth,pictureheight;
        /*    public static List<Draw.Point> FillColor(List<Point> ListPoint, int X, int Y, Color? ColorFill = null)
        {
            int picturewidth = View_2D.viewsize.width, pictureheight = View_2D.viewsize.height;
            bool[,] ListCheck = new bool[picturewidth * 2, pictureheight * 2];
            Draw.Point pointcenter = ConvertPoint.Doi_Sang_He_Toa_Do_May_Tinh(X, Y);
            Draw.Point pointputpixel;
            X = pointcenter.X; Y = pointcenter.Y;

            foreach (Draw.Point pointpixel in ListPoint)
            {
                Draw.Point a = ConvertPoint.Doi_Sang_He_Toa_Do_May_Tinh(pointpixel.X, pointpixel.Y);
                ListCheck[a.X, a.Y] = true;
            }

            while (X <=picturewidth && !(ListCheck[X, Y]))
            {
                ListCheck[X, Y] = true;
                pointputpixel = ConvertPoint.Doi_Sang_He_Toa_Do_Nguoi_Dung(X, Y);
                ListPoint.Add(new Draw.Point(pointputpixel.X, pointputpixel.Y, ColorFill));

                if (Y > 0|| !ListCheck[X, Y + 1])
                {
                    if (Y < pictureheight&&!ListCheck[X, Y + 1])
                        Y++;
                    else if ((!ListCheck[X, Y - 1]) || !ListCheck[X, pointcenter.Y - 1])
                    {
                        if (Y >= pointcenter.Y)
                            Y = pointcenter.Y - 1;
                        else
                            Y--;
                    }
                    else
                    {
                        X++;
                        Y = pointcenter.Y;
                    }
                }
            }

            X = pointcenter.X - 1;
            Y = pointcenter.Y;

            while (X >= 0 && !ListCheck[X, Y])
            {
                ListCheck[X, Y] = true;
                pointputpixel = ConvertPoint.Doi_Sang_He_Toa_Do_Nguoi_Dung(X, Y);
                ListPoint.Add(new Draw.Point(pointputpixel.X, pointputpixel.Y, ColorFill));

                if (Y < pictureheight && !ListCheck[X, Y + 1])
                    Y++;
                else if ((Y > 0 && !ListCheck[X, Y - 1]) || !ListCheck[X, pointcenter.Y - 1])
                {
                    if (Y >= pointcenter.Y)
                        Y = pointcenter.Y - 1;
                    else
                        Y--;
                }
                else
                {
                    X--;
                        Y = pointcenter.Y;
                }
            }

            return ListPoint;
        }*/
        public List<Draw.Point> FillColor(List<Point> ListPoint,int X,int Y,Color?ColorFill = null)
        {
            picturewidth = View_2D.viewsize.width; pictureheight = View_2D.viewsize.height;
            ListCheck = new bool[picturewidth * 2, pictureheight * 2];
            _listfill = ListPoint;
            foreach (Draw.Point pointpixel in ListPoint)
            {
                Draw.Point a = ConvertPoint.Doi_Sang_He_Toa_Do_May_Tinh(pointpixel.X, pointpixel.Y);
                ListCheck[a.X, a.Y] = true;
            }
            Draw.Point PointFill = ConvertPoint.Doi_Sang_He_Toa_Do_May_Tinh(X,Y);
            FloodFill(PointFill.X, PointFill.Y, ColorFill);
            return _listfill;
        }
        private void FloodFill(int x, int y, Color? ColorFill = null)
        {
            // Kiểm tra xem điểm (x,y) có nằm trong hình ảnh không
            if (x <=0 || x >= picturewidth || y <=0 || y >= pictureheight)
                return;
            if (ListCheck[x, y])
                return;
            else
            {

                // Kiểm tra xem điểm (x,y) có phải là màu cũ không
                // Tô màu mới cho điểm (x,y)
                ListCheck[x, y] = true;
                int xpoint=x, ypoint=y;
                _listfill.Add(ConvertPoint.Doi_Sang_He_Toa_Do_Nguoi_Dung(xpoint, ypoint, ColorFill));
                if (!ListCheck[x + 1, y])
                    FloodFill(x + 1, y, ColorFill);
                if (!ListCheck[x - 1, y])
                    FloodFill(x - 1, y, ColorFill);
                if (!ListCheck[x, y + 1])
                    FloodFill(x, y + 1, ColorFill);
                if (!ListCheck[x, y - 1])
                    FloodFill(x, y - 1, ColorFill);
            }
            return;
        }
        public List<Draw.Point> Line(int Ax, int Ay, int Bx, int By, Color? colorfill = null, String type = "Nét liền")
        {
            List<Draw.Point> linePoints = new List<Draw.Point>();

            int dx = Math.Abs(Bx - Ax);
            int dy = Math.Abs(By - Ay);
            int sx = (Ax < Bx) ? 1 : -1;
            int sy = (Ay < By) ? 1 : -1;
            int p = dx - dy;

            int x = Ax, y = Ay, i = 0;
            while (true)
            {
                switch (type)
                {
                    case "Nét liền":
                        {
                            linePoints.Add(new Point(x, y, colorfill));
                            break;
                        }
                    case "Nét đứt":
                        {
                            if (i % 3 != 2)
                            {
                                linePoints.Add(new Point(x, y, colorfill));
                            }
                            break;
                        }
                    case "Nét chấm gạch":
                        {
                            if (i % 5 != 3 && i % 5 != 0)
                            {
                                linePoints.Add(new Point(x, y, colorfill));
                            }
                            break;
                        }
                    case "Nét 2 chấm gạch":
                        {
                            if (i % 8 != 4 && i % 8 != 6 && i % 8 != 0)
                            {
                                linePoints.Add(new Point(x, y, colorfill));
                            }
                            break;
                        }
                }
                i++;
                if (x == Bx && y == By)
                    break;

                int p2 = 2 * p;
                if (p2 > -dy)
                {
                    p -= dy;
                    x += sx;
                }
                if (p2 < dx)
                {
                    p += dx;
                    y += sy;
                }
            }

            return linePoints;
        }
        public List<Draw.Point> Rectangle(int Sx, int Sy, int Ex, int Ey, Color? colorfill = null, string type = "Nét liền")
        {
            List<Draw.Point> _listpoint = new List<Point>();
            int x1, y1, x2, y2;
            x1 = Sx;
            y1 = Ey;
            x2 = Ex;
            y2 = Sy;
            _listpoint.AddRange(Line(Sx, Sy, x1, y1, Color.Black));
            _listpoint.AddRange(Line(x1, y1, Ex, Ey, Color.Black));
            _listpoint.AddRange(Line(Ex, Ey, x2, y2, Color.Black));
            _listpoint.AddRange(Line(x2, y2, Sx, Sy, Color.Black));
            if (type == "Nét liền")
                _listpoint = FillColor(_listpoint, (Ex + Sx) / 2, (Ey + Sy) / 2, colorfill);
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình chữ nhật", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey, width = Math.Abs(Sx + Ex), height = Math.Abs(Sy + Ey) });
            return _listpoint;
        }
        public List<Draw.Point> Triangle(int Sx, int Sy, int Ex, int Ey, Color? colorfill = null, string type = "Nét liền")
        {
            List<Draw.Point> PointsDraw = new List<Draw.Point>();
            int Ax, Ay, Bx, By;
            Ax = Ex;
            Ay = Sy;
            Bx = (Ex + Sx) / 2;
            By = Ey;
            PointsDraw.AddRange(Line(Sx, Sy, Ax, Ay));
            PointsDraw.AddRange(Line(Sx, Sy, Bx, By));
            PointsDraw.AddRange(Line(Bx, By, Ex, Sy));
            if (type == "Nét liền")
            {
                if (Ey > Sy)
                    PointsDraw = FillColor(PointsDraw, (Ex + Sx) / 2, Sy + 1, colorfill);
                else
                    PointsDraw = FillColor(PointsDraw, (Ex + Sx) / 2, Sy - 1, colorfill);
            }
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình Tam giác", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey, centerx = (Sx + Ex) / 2, centery = (Sy + Ey) / 2 });
            return PointsDraw;
        }
        private List<Draw.Point> Circle(int centerX, int centerY, int radius, Color? fillColor = null)
        {
            int P0 = 5 / 4 - radius;
            List<int> P = new List<int>();
            List<Draw.Point> _linepoint = new List<Draw.Point>();
            int i = 0, currentX = 0, currentY = radius;
            P.Add(P0);
            while (currentX <= radius * System.Math.Sqrt(2) / 2)
            {
                _linepoint.Add(new Point(centerX + currentX, centerY + currentY));
                _linepoint.Add(new Point(centerX - currentX, centerY + currentY));
                _linepoint.Add(new Point(centerX + currentX, centerY - currentY));
                _linepoint.Add(new Point(centerX - currentX, centerY - currentY));
                _linepoint.Add(new Point(centerX + currentY, centerY + currentX));
                _linepoint.Add(new Point(centerX - currentY, centerY + currentX));
                _linepoint.Add(new Point(centerX + currentY, centerY - currentX));
                _linepoint.Add(new Point(centerX - currentY, centerY - currentX));
                currentX++;
                int CurrentP;
                if (P[i] < 0)
                {
                    CurrentP = P[i] + 2 * currentX + 3;
                }
                else
                {
                    CurrentP = P[i] + 2 * currentX - 2 * currentY + 5;
                    currentY = currentY - 1;
                }
                P.Add(CurrentP);
                i++;
            }
            _linepoint.Add(new Point(centerX - radius + 1, centerY));
            _linepoint = (FillColor(_linepoint, centerX, centerY, fillColor));
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình tròn", centerx = centerX, centery = centerY, R = radius });
            return _linepoint;
        }
        public List<Draw.Point> TreeTriangle(int Sx, int Sy, int Ex, int Ey, int trianglecount = 3)
        {
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Cây tam giác", centerx = (Ex+Sx)/2, centery = Sy, width = Math.Abs(Sx) + Math.Abs(Ex), height = Math.Abs(Ey)+ Math.Abs(Sy) });
            if (Math.Abs(Ey + Sy) % 10 > 1 && Math.Abs(Ey + Sy) % 10 < trianglecount)
                trianglecount = Math.Abs(Ey + Sy) % 10;
            List<Draw.Point> ListPoint = new List<Draw.Point>();
            List<Draw.Point> Listtriangle = new List<Point>();
            //vẽ hình chữ nhật
            int rectangle_Sx = Sx + (Ex - Sx) / 3,
                rectangle_Sy = Sy,
                rectangle_Ex = Ex - (Ex - Sx) / 3,
                rectangle_Ey = Sy + (Ey - Sy) / 5;
            ListPoint.AddRange(Rectangle(rectangle_Sx, rectangle_Sy, rectangle_Ex, rectangle_Ey, System.Drawing.Color.Brown));
            int rangetriangle_Sx = Sx, rangetriangle_Sy = rectangle_Ey, rangetriangle_Ex = Ex, rangetriangle_Ey = Ey;
            for (int i = 0; i < trianglecount; i++)
            {
                int startx = Sx, starty = (Ey - rectangle_Ey) / trianglecount, endx = Ex, endy = 0;
                int offset = ((Ey + rectangle_Ey) / trianglecount) / 2;
                if (i > 0)
                {
                    endy = (Ey - i * (Ey + rectangle_Ey) / trianglecount);
                    if (i >= trianglecount - 2)
                    {
                        if (endy < starty)
                        {
                            continue;
                        }
                        starty = rectangle_Ey - rectangle_Ey / 2;
                    }
                    else
                        starty = (Ey - (i + 1) * ((Ey + rectangle_Ey) / trianglecount) - offset);
                }
                else if (i < 1)
                {
                    endy = Ey;
                    if (trianglecount == 1)
                    {
                        starty = rectangle_Ey;
                    }
                    else
                    {
                        starty = Ey - (Ey + rectangle_Ey) / trianglecount - offset;
                    }
                }
                Listtriangle.AddRange(Triangle(startx, starty, endx, endy, System.Drawing.Color.Green));
            }
            Listtriangle.Reverse();
            ListPoint.AddRange(Listtriangle);
            return ListPoint;
        }
        public List<Draw.Point> TreeCircle(int Sx, int Sy, int Ex, int Ey, int Circlecount = 3)
        {
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Cây táng tròn", centerx = (Ex + Sx) / 2, centery = Sy, width = Math.Abs(Sx) + Math.Abs(Ex), height = Math.Abs(Ey) + Math.Abs(Sy) });
            List<Draw.Point> _listpoint = new List<Point>();
            bool flip = false;
            // Tính thân cây
            int rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, bodywidth = (Ex - Sx) / 3;
            rectangle_sx = Sx + bodywidth;
            rectangle_sy = Sy;
            rectangle_ex = Ex - bodywidth;
            rectangle_ey = Ey - bodywidth / 2;
            _listpoint.AddRange(Rectangle(rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, Color.Brown));
            int centerx, centery, radius;
            for (int i = 0; i < Circlecount; i++)
            {
                centerx = (Ex + Sx) / 2;
                centery = rectangle_ey - i;
                radius = bodywidth;
                if (i == Circlecount / 2)
                {
                    _listpoint.AddRange(Circle((Ex + Sx) / 2, rectangle_ey, bodywidth, Color.Green));
                }
                else if (flip)
                {
                    centerx += bodywidth;
                    _listpoint.AddRange(Circle(centerx, centery - bodywidth, radius, Color.Green));
                    flip = false;
                }
                else
                {
                    centerx -= bodywidth;
                    _listpoint.AddRange(Circle(centerx, centery - bodywidth, radius, Color.Green));
                    flip = true;
                }
            }
            return _listpoint;
        }
        public List<Draw.Point> DrawEllipseMidpoint(int centerX, int centerY, int radiusX, int radiusY)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            int a = radiusX;
            int b = radiusY;

            int aSquared = a * a;
            int bSquared = b * b;

            int twoASquared = 2 * aSquared;
            int twoBSquared = 2 * bSquared;

            int x = 0;
            int y = b;
            int p = 0;

            // Vẽ bán kính ban đầu trong góc đầu tiên của hình ellipse (0, b)
            _listpoint.AddRange(DrawEllipsePoints(centerX, centerY, x, y));

            // Vùng 1: (0, b) đến (a^2 / sqrt(a^2 + b^2), b / sqrt(a^2 + b^2))
            p = Convert.ToInt32(bSquared - (aSquared * b) + (0.25 * aSquared));
            while (twoBSquared * x < twoASquared * y)
            {
                x++;
                if (p < 0)
                    p += twoBSquared * x + bSquared;
                else
                {
                    y--;
                    p += twoBSquared * x - twoASquared * y + bSquared;
                }
                _listpoint.AddRange(DrawEllipsePoints(centerX, centerY, x, y));
            }

            // Vùng 2: (a^2 / sqrt(a^2 + b^2), b / sqrt(a^2 + b^2)) đến (a, 0)
            p = Convert.ToInt32(bSquared * (x + 0.5) * (x + 0.5) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared);
            while (y > 0)
            {
                y--;
                if (p > 0)
                    p += -twoASquared * y + aSquared;
                else
                {
                    x++;
                    p += twoBSquared * x - twoASquared * y + aSquared;
                }
                _listpoint.AddRange(DrawEllipsePoints(centerX, centerY, x, y));
            }
            return _listpoint;

        }
        public List<Draw.Point> DrawEllipseMidpoint2(int centerX, int centerY, int radiusX, int radiusY)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            int a = radiusX;
            int b = radiusY;
            int aSquared = a * a;
            int bSquared = b * b;

            int twoASquared = 2 * aSquared;
            int twoBSquared = 2 * bSquared;

            int x = 0;
            int y = b;
            int p = 0;
            int i = 0;

            // Vẽ bán kính ban đầu trong góc đầu tiên của hình ellipse (0, b)
            //DrawEllipsePoints2(g, centerX, centerY, x, y, i);
            _listpoint.Add(new Draw.Point(centerX - x, centerY - y));
            // Vùng 1: (0, b) đến (a^2 / sqrt(a^2 + b^2), b / sqrt(a^2 + b^2))
            p = Convert.ToInt32(bSquared - (aSquared * b) + (0.25 * aSquared));
            while (twoBSquared * x < twoASquared * y)
            {
                x++;
                if (p < 0)
                    p += twoBSquared * x + bSquared;
                else
                {
                    y--;
                    p += twoBSquared * x - twoASquared * y + bSquared;
                }
                _listpoint.AddRange(DrawEllipsePoints2(centerX, centerY, x, y, i));
                i++;
            }

            // Vùng 2: (a^2 / sqrt(a^2 + b^2), b / sqrt(a^2 + b^2)) đến (a, 0)
            p = Convert.ToInt32(bSquared * (x + 0.5) * (x + 0.5) + aSquared * (y - 1) * (y - 1) - aSquared * bSquared);
            while (y > 0)
            {
                y--;
                if (p > 0)
                    p += -twoASquared * y + aSquared;
                else
                {
                    x++;
                    p += twoBSquared * x - twoASquared * y + aSquared;
                }
                _listpoint.AddRange(DrawEllipsePoints2(centerX, centerY, x, y, i));
                i++;
            }
            return _listpoint;
        }
        public List<Draw.Point> DrawEllipsePoints(int centerX, int centerY, int x, int y)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            // Vẽ 4 điểm đối xứng của hình ellipse dựa vào giá trị x, y và tâm (centerX, centerY)
            _listpoint.Add(new Draw.Point(centerX + x, centerY + y)); // Quận 1: (x, y)
            _listpoint.Add(new Draw.Point(centerX - x, centerY + y)); // Quận 2: (-x, y)
            _listpoint.Add(new Draw.Point(centerX + x, centerY - y)); // Quận 3: (x, -y)
            _listpoint.Add(new Draw.Point(centerX - x, centerY - y)); // Quận 4: (-x, -y)
            return _listpoint;
        }
        public List<Draw.Point> DrawEllipsePoints2(int centerX, int centerY, int x, int y, int i)
        {
            List<Draw.Point> _lispoint = new List<Point>();
            // Vẽ 4 điểm đối xứng của hình ellipse dựa vào giá trị x, y và tâm (centerX, centerY)
            if (i % 4 < 2)
            {
                _lispoint.Add(new Draw.Point(centerX + x, centerY + y));// Quận 1: (x, y)
                _lispoint.Add(new Draw.Point(centerX - x, centerY + y));// Quận 2: (-x, y)
            }
            _lispoint.Add(new Draw.Point(centerX + x, centerY - y));// Quận 3: (x, -y)
            _lispoint.Add(new Draw.Point(centerX - x, centerY - y));// Quận 4: (-x, -y)
            return _lispoint;
        }

        public List<Draw.Point> Rainbow()
        {
            int centerX = 0;
            int centerY = 0;
            List<Draw.Point> _rListPoint = new List<Point>();
            Stack<Point> _Stack = new Stack<Point>();
            Queue<Point> _Queue = new Queue<Point>();
            Stack<Point> _Stack2 = new Stack<Point>();
            Queue<Point> _Queue2 = new Queue<Point>();
            Stack<Point> _Stack3 = new Stack<Point>();
            Queue<Point> _Queue3 = new Queue<Point>();
            Stack<Point> _Stack4 = new Stack<Point>();
            Queue<Point> _Queue4 = new Queue<Point>();
            Stack<Point> _Stack5 = new Stack<Point>();
            Queue<Point> _Queue5 = new Queue<Point>();
            Stack<Point> _Stack6 = new Stack<Point>();
            Queue<Point> _Queue6 = new Queue<Point>();
            Stack<Point> _Stack7 = new Stack<Point>();
            Queue<Point> _Queue7 = new Queue<Point>();

            DrawRainbow(centerX, centerY, 60, 45, _Stack, _Queue);
            DrawRainbow(centerX, centerY, 59, 44, _Stack2, _Queue2);
            DrawRainbow(centerX, centerY, 58, 43, _Stack3, _Queue3);
            DrawRainbow(centerX, centerY, 57, 42, _Stack4, _Queue4);
            DrawRainbow(centerX, centerY, 56, 41, _Stack5, _Queue5);
            DrawRainbow(centerX, centerY, 55, 40, _Stack6, _Queue6);
            DrawRainbow(centerX, centerY, 54, 39, _Stack7, _Queue7);

            while (_Stack.Count > 0)
            {
                // Lấy điểm ra khỏi stack
                Point point = _Stack.Pop();
                _rListPoint.Add(new Point(point.X, point.Y, Color.Red));
                if (_Stack2.Count > 0)
                {
                    Point point2 = _Stack2.Pop();
                    _rListPoint.Add(new Point(point2.X, point2.Y, Color.Orange));
                }
                if (_Stack3.Count > 0)
                {
                    Point point3 = _Stack3.Pop();
                    _rListPoint.Add(new Point(point3.X, point3.Y, Color.Yellow));
                }
                if (_Stack4.Count > 0)
                {
                    Point point4 = _Stack4.Pop();
                    _rListPoint.Add(new Point(point4.X, point4.Y, Color.Green));
                }
                if (_Stack5.Count > 0)
                {
                    Point point5 = _Stack5.Pop();
                    _rListPoint.Add(new Point(point5.X, point5.Y, Color.Teal));
                }
                if (_Stack6.Count > 0)
                {
                    Point point6 = _Stack6.Pop();
                    _rListPoint.Add(new Point(point6.X, point6.Y, Color.Blue));
                }
                if (_Stack7.Count > 0)
                {
                    Point point7 = _Stack7.Pop();
                    _rListPoint.Add(new Point(point7.X, point7.Y, Color.Violet));
                }
            }
            while (_Queue.Count > 0)
            {
                // Lấy điểm ra khỏi queue
                Point point1 = _Queue.Dequeue();
                _rListPoint.Add(new Point(point1.X, point1.Y, Color.Red));
                if (_Queue2.Count > 0)
                {
                    Point point2 = _Queue2.Dequeue();
                    _rListPoint.Add(new Point(point2.X, point2.Y, Color.Orange));
                }
                if (_Queue3.Count > 0)
                {
                    Point point3 = _Queue3.Dequeue();
                    _rListPoint.Add(new Point(point3.X, point3.Y, Color.Yellow));
                }
                if (_Queue4.Count > 0)
                {
                    Point point4 = _Queue4.Dequeue();
                    _rListPoint.Add(new Point(point4.X, point4.Y, Color.Green));
                }
                if (_Queue5.Count > 0)
                {
                    Point point5 = _Queue5.Dequeue();
                    _rListPoint.Add(new Point(point5.X, point5.Y, Color.Teal));
                }
                if (_Queue6.Count > 0)
                {
                    Point point6 = _Queue6.Dequeue();
                    _rListPoint.Add(new Point(point6.X, point6.Y, Color.Blue));
                }
                if (_Queue7.Count > 0)
                {
                    Point point7 = _Queue7.Dequeue();
                    _rListPoint.Add(new Point(point7.X, point7.Y, Color.Violet));
                }
            }
            return _rListPoint;
        }

        private void DrawRainbow(int centerX, int centerY, int radiusX, int radiusY, Stack<Point> pointsStack, Queue<Point> pointsQueue)
        {
            int a = radiusX;
            int b = radiusY;
            int x = 0;
            int y = b;
            int p = 0;
            int i = 0;

            pointsQueue.Enqueue(new Point(centerX + x, centerY + y));

            p = Convert.ToInt32(b * b - (a * a * b) + (0.25 * a * a));
            while (2 * b * b * x < 2 * a * a * y)
            {
                x++;
                if (p < 0)
                    p += 2 * b * b * x + b * b;
                else
                {
                    y--;
                    p += 2 * b * b * x - 2 * a * a * y + b * b;
                }
                pointsQueue.Enqueue(new Point(centerX + x, centerY + y));
                pointsStack.Push(new Point(centerX - x, centerY + y));
                i++;
            }
            p = Convert.ToInt32(b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b);
            while (y > 0)
            {
                y--;
                if (p > 0)
                    p += -(2 * a * a) * y + a * a;
                else
                {
                    x++;
                    p += (2 * b * b) * x - (2 * a * a) * y + a * a;
                }
                pointsQueue.Enqueue(new Point(centerX + x, centerY + y));
                pointsStack.Push(new Point(centerX - x, centerY + y));
                i++;
            }
        }
        public List<Draw.Point> DrawCloud(int centerX, int centerY, Color? colorfill = null)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            _listpoint.AddRange(Circle(-23, 8, 8, Color.White));
            _listpoint.AddRange(Circle(-18, -5, 8, Color.White));
            _listpoint.AddRange(Circle(-8, 3, 9, Color.White));
            _listpoint.AddRange(Circle(4, 9, 8, Color.White));
            _listpoint.AddRange(Circle(4, -3, 9, Color.White));
            _listpoint.AddRange(Circle(17, 3, 8, Color.White));

            return _listpoint;
        }
    }
}
