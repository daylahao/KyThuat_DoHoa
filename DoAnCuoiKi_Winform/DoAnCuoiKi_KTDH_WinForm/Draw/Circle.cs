using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Circle:ObjectShape
    {
        public void Draw(int centerx, int centery, int radius, System.Drawing.Color? ColorFill = null,System.Drawing.Color? ColorStroke=null,string type="Nét liền")
        {
            this.center = new Draw.Point(centerx, centery);
            this.radius = radius;
            this.Colorfill = ColorFill;
            this.Colorstroke = ColorStroke;
            this.type = type;
        }
        public override List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            int P0 = 5 / 4 - radius;
            List<int> P = new List<int>();
            int i = 0, currentX = 0, currentY = radius;
            P.Add(P0);
            while (currentX <= radius * System.Math.Sqrt(2) / 2)
            {
                _listpoint.Add(new Point(center.X + currentX, center.Y + currentY,this.Colorstroke));
                _listpoint.Add(new Point(center.X - currentX, center.Y + currentY, this.Colorstroke));
                _listpoint.Add(new Point(center.X + currentX, center.Y - currentY,this.Colorstroke));
                _listpoint.Add(new Point(center.X - currentX, center.Y - currentY,this.Colorstroke));
                _listpoint.Add(new Point(center.X + currentY, center.Y + currentX,this.Colorstroke));
                _listpoint.Add(new Point(center.X - currentY, center.Y + currentX,this.Colorstroke));
                _listpoint.Add(new Point(center.X + currentY, center.Y - currentX,this.Colorstroke));
                _listpoint.Add(new Point(center.X - currentY, center.Y - currentX,this.Colorstroke));
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
            Draw2D Fill = new Draw2D();
            _listpoint = Fill.FillColor(_listpoint, center.X, center.Y, this.Colorfill);
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            center = Tranform2D.Rotate(center, root, angle);
        }
        public override void Scale(Point root, int scaleX = 1,int scaleY = 1)
        {
            scaleY = scaleX;
            center = Tranform2D.Scale(center, root, scaleX, scaleX);
            this.radius = this.radius * scaleX;
        }
    }
}
