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
            this.name = "Cây táng tròn";
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
            SetInfoShape();
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            this.start = Tranform2D.Rotate(start, root, angle); 
            this.end = Tranform2D.Rotate(end, root, angle); 
            if(ChildShape!=null||ChildShape.Count>0)
            foreach(ObjectShape Shape in ChildShape)
            {
                Shape.Rotate(root, angle);
            }
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name, centerx = (this.start.X + this.end.X) / 2, centery = (this.start.Y + this.end.Y) / 2, width = Math.Abs(this.start.X - this.end.X), height = Math.Abs(this.start.Y - this.end.Y) });
            base.SetInfoShape();
        }
    }
}
