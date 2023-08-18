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
        public List<Draw.Point> FillColor(List<Point> ListPoint, int X, int Y, Color? ColorFill = null)
        {
            ConvertPoint _convert = new ConvertPoint();
            int picturewidth = View_2D.viewsize.width, pictureheight = View_2D.viewsize.height;
            bool[,] ListCheck = new bool[picturewidth * 2, pictureheight * 2];
            int[] pointcenter = _convert.Doi_Sang_He_Toa_Do_May_Tinh(X, Y);
            int[] pointputpixel;
            X = pointcenter[0]; Y = pointcenter[1];
            foreach (Draw.Point pointpixel in ListPoint)
            {
                int[] a = _convert.Doi_Sang_He_Toa_Do_May_Tinh(pointpixel.X, pointpixel.Y);
                ListCheck[a[0], a[1]] = true;
            }
            while (!ListCheck[X, Y])
            {
                Console.WriteLine(X + " " + Y);
                ListCheck[X, Y] = true;
                pointputpixel = _convert.Doi_Sang_He_Toa_Do_Nguoi_Dung(X, Y);
                ListPoint.Add(new Draw.Point(pointputpixel[0], pointputpixel[1], ColorFill));
                if (Y < pictureheight * 2 && !ListCheck[X, Y + 1])
                    Y++;
                else if ((Y > 0 && !ListCheck[X, Y - 1]) || !ListCheck[X, pointcenter[1] - 1])
                    if (Y >= pointcenter[1])
                        Y = pointcenter[1] - 1;
                    else
                        Y--;
                else
                {
                    X++;
                    Y = pointcenter[1];
                }
            }
            X = pointcenter[0] - 1;
            Y = pointcenter[1];
            while (!ListCheck[X, Y])
            {
                ListCheck[X, Y] = true;
                pointputpixel = _convert.Doi_Sang_He_Toa_Do_Nguoi_Dung(X, Y);
                ListPoint.Add(new Draw.Point(pointputpixel[0], pointputpixel[1], ColorFill));
                if (Y < pictureheight * 2 && !ListCheck[X, Y + 1])
                    Y++;
                else if ((Y > 0 && !ListCheck[X, Y - 1]) || !ListCheck[X, pointcenter[1] - 1])
                    if (Y >= pointcenter[1])
                        Y = pointcenter[1] - 1;
                    else
                        Y--;
                else
                {
                    X--;
                    Y = pointcenter[1];
                }
            }
            return ListPoint;
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
        public List<Draw.Point>Rectangle(int Sx,int Sy,int Ex,int Ey,Color? colorfill = null, string type = "Nét liền")
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
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình chữ nhật", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey, width = Math.Abs(Sx + Ex), height = Math.Abs(Sy + Ey)});
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
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình Tam giác", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey,centerx = (Sx+Ex)/2,centery=(Sy+Ey)/2});
            return PointsDraw;
        }
        private List<Draw.Point> Cricle(int centerX, int centerY, int radius, Color? fillColor=null)
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
            _linepoint=(FillColor(_linepoint, centerX, centerY, fillColor));
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình tròn", centerx = centerX, centery = centerY, R = radius });
            return _linepoint;
        }
        public List<Draw.Point> TreeTriangle(int Sx, int Sy, int Ex, int Ey, int trianglecount = 3)
        {
            if (Math.Abs(Ey + Sy) < 30 && trianglecount>4)
            {
                trianglecount = trianglecount/2;
            }
            List<Draw.Point> ListPoint = new List<Draw.Point>();
            //vẽ hình chữ nhật
            int rectangle_Sx = Sx + (Ex - Sx) / 3,
                rectangle_Sy = Sy,
                rectangle_Ex = Ex - (Ex - Sx) / 3,
                rectangle_Ey = Sy + (Ey - Sy) /5;
            ListPoint.AddRange(Rectangle(rectangle_Sx, rectangle_Sy, rectangle_Ex, rectangle_Ey, System.Drawing.Color.Brown));
            int rangetriangle_Sx = Sx, rangetriangle_Sy = rectangle_Ey, rangetriangle_Ex = Ex, rangetriangle_Ey = Ey;
            for (int i = 0; i < trianglecount; i++)
            {
                int startx = Sx, starty = (Ey - rectangle_Ey) / trianglecount, endx = Ex, endy = 0;
                if (i > 0)
                {
                    endy = (Ey - i * ((Ey + rectangle_Ey) / trianglecount))+ ((Ey + rectangle_Ey) / trianglecount)/2;
                    if (i == trianglecount - 1)
                    {
                        endy = rectangle_Sy + ((Ey + rectangle_Ey) / trianglecount)+ ((Ey + rectangle_Ey) / trianglecount)/2;
                        starty = rectangle_Ey;
                    }else
                    starty = (Ey - (i + 1) * ((Ey + rectangle_Ey) / trianglecount))+((Ey + rectangle_Ey) / trianglecount)/2;
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
                        starty = Ey - (Ey + rectangle_Ey) / trianglecount;
                    }
                }
                ListPoint.AddRange(Triangle(startx, starty, endx, endy, System.Drawing.Color.Green));
            }
            return ListPoint;
        }
        public List<Draw.Point>TreeCricle(int Sx,int Sy,int Ex,int Ey,int criclecount= 3)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            bool flip=false;
            // Tính thân cây
            int rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, bodywidth= (Ex - Sx) / 3;
            rectangle_sx = Sx + bodywidth;
            rectangle_sy = Sy;
            rectangle_ex = Ex - bodywidth;
            rectangle_ey = Ey - bodywidth / 2;
            _listpoint.AddRange(Rectangle(rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, Color.Brown));
            int centerx, centery, radius;
            for (int i = 0; i < criclecount; i++)
            {
                centerx = (Ex + Sx) / 2;
                centery = rectangle_ey-i;
                radius = bodywidth;
                if (i == criclecount / 2)
                {
                    _listpoint.AddRange(Cricle((Ex + Sx) / 2, rectangle_ey, bodywidth, Color.Green));
                }else if (flip)
                {
                    centerx += bodywidth;
                    _listpoint.AddRange(Cricle(centerx, centery-bodywidth, radius, Color.Green));
                    flip = false;
                }
                else
                {
                    centerx -= bodywidth;
                    _listpoint.AddRange(Cricle(centerx, centery-bodywidth, radius, Color.Green));
                    flip = true;
                }
            }
            return _listpoint;
        }
    }
}
