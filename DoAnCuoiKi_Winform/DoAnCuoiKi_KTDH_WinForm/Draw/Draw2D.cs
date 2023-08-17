using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Draw2D
    {
        public List<Point> Line(int Ax, int Ay, int Bx, int By, Color? colorfill = null, String type = "Nét liền")
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
    }
}
