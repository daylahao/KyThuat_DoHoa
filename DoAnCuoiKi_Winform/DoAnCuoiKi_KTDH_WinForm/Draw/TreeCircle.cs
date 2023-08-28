using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class TreeCircle:ObjectShape
    {
        int circlecount = 3;
       public void Draw(int Sx,int Sy,int Ex,int Ey,int circle =3)
        {
            circlecount = circle;
            ChildShape = new List<ObjectShape>();
            circlecount = circle;
            this.start = new Draw.Point(Sx, Sy);
            this.end = new Draw.Point(Ex, Ey);
            Rectangle Rect = new Rectangle();
            bool flip = false;
            // Tính thân cây
            int rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, bodywidth = (Ex - Sx) / 3;
            rectangle_sx = Sx + bodywidth;
            rectangle_sy = Sy;
            rectangle_ex = Ex - bodywidth;
            rectangle_ey = Ey - bodywidth / 2;
            Rect.Draw(rectangle_sx, rectangle_sy, rectangle_ex, rectangle_ey, System.Drawing.Color.Brown);
            ChildShape.Add(Rect);
            int centerx, centery, radius;
            for (int i = 0; i < circlecount; i++)
            {
                Circle Cir = new Circle();
                centerx = (Ex + Sx) / 2;
                centery = rectangle_ey - i;
                radius = bodywidth;
                if (i == circlecount / 2)
                {
                    Cir.Draw((Ex + Sx) / 2, rectangle_ey, bodywidth, System.Drawing.Color.Green);
                    ChildShape.Add(Cir);
                }
                else if (flip)
                {
                    centerx += bodywidth;
                    Cir.Draw(centerx, centery - bodywidth, radius, System.Drawing.Color.Green);
                    ChildShape.Add(Cir);
                    flip = false;
                }
                else
                {
                    centerx -= bodywidth;
                    Cir.Draw(centerx, centery - bodywidth, radius, System.Drawing.Color.Green);
                    ChildShape.Add(Cir);
                    flip = true;
                }
            }
        }
        public override List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            foreach(ObjectShape Shape in ChildShape)
            {
                _listpoint.AddRange(Shape.Showpoint());
            }
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            List<ObjectShape> _temp = new List<ObjectShape>();
            foreach(ObjectShape Shape in ChildShape)
            {
                Shape.Rotate(root, angle);
                _temp.Add(Shape);
            }
            ChildShape = _temp;
        }
    }
}
