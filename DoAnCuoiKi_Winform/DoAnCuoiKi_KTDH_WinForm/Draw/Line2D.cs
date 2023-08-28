using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Line2D:ObjectShape
    {
        string _name = "Đường thẳng";
        public void Draw(int Sx, int Sy, int Ex, int Ey, Color? colorstroke = null, string type="Nét liền")
        {
            this.name = _name;
            start = new Draw.Point(Sx, Sy);
            end = new Draw.Point(Ex,Ey);
            Colorstroke = colorstroke;
            this.type = type;
        }
        public void Draw(Draw.Point Start,Draw.Point End, Color? colorstroke = null, string type = "Nét liền")
        {
            this.name = _name;
            start = Start;
            end = End;
            Colorstroke = colorstroke;
            this.type = type;
        }
        public override List<Point> Showpoint()
        {
            SetInfoShape();
            int Ax = this.start.X, Ay = this.start.Y,
                Bx = this.end.X, By = this.end.Y;
            Color? colorfill = null;
                colorfill= this.Colorstroke;
            _listpoint = new List<Point>();
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
                            _listpoint.Add(new Point(x, y, colorfill));
                            break;
                        }
                    case "Nét đứt":
                        {
                            if (i % 3 != 2)
                            {
                                _listpoint.Add(new Point(x, y, colorfill));
                            }
                            break;
                        }
                    case "Nét chấm gạch":
                        {
                            if (i % 5 != 3 && i % 5 != 0)
                            {
                                _listpoint.Add(new Point(x, y, colorfill));
                            }
                            break;
                        }
                    case "Nét 2 chấm gạch":
                        {
                            if (i % 8 != 4 && i % 8 != 6 && i % 8 != 0)
                            {
                                _listpoint.Add(new Point(x, y, colorfill));
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

            return _listpoint;
        }
        public override void Rotate(Draw.Point root,int angle)
        {
            start = Tranform2D.Rotate(start, root, angle);
            end = Tranform2D.Rotate(end, root, angle);

        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            this.start = Tranform2D.Scale(start, root, scaleX, scaleY);
            this.end = Tranform2D.Scale(end, root, scaleX, scaleY);
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name, Sx = this.start.X, Sy = this.end.Y, Ex = this.end.X, Ey = this.end.Y });
        }
    }
}
