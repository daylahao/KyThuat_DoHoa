﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class TreeTriangle:ObjectShape
    {
        public int trianglecount=1;
        public Draw.Point enddefault;
        public void Draw(int sx, int sy, int ex, int ey, int triangle = 3)
        {
            this.name = "Cây táng tam giác";
            trianglecount = triangle;
            if (Math.Abs(ey + sy) % 10 > 1 && Math.Abs(ey + sy) % 10 < trianglecount)
                trianglecount = Math.Abs(ey + sy) % 10;
            ChildShape = new List<ObjectShape>();
            this.start = new Draw.Point(sx, sy);
            this.end = new Draw.Point(ex, ey);
            enddefault = this.end;
            //Tạo hình chữ nhật làm thân cây
            Rectangle Rect = new Rectangle();
            Draw.Point Rectstart = new Draw.Point(this.start.X + (this.end.X - this.start.X) / 3,this.start.Y);
            Draw.Point Rectend = new Draw.Point(this.end.X - (this.end.X - this.start.X) / 3,this.start.Y+(this.end.Y-this.start.Y)/5);
            Rect.Draw(Rectstart.X, Rectstart.Y, Rectend.X, Rectend.Y, System.Drawing.Color.Brown);
            ChildShape.Add(Rect);
            //Tạo táng cây
            for (int i = 0; i < trianglecount; i++)
            {
                int startx = start.X, starty = (end.Y - Rectend.Y) / trianglecount, endx = end.X, endy = 0;
                int offset = ((end.Y + Rectstart.Y) / trianglecount) / 2;
                if (i > 0)
                {
                    endy = (end.Y - i * (end.Y + Rectend.Y) / trianglecount);
                    if (i >= trianglecount - 2)
                    {
                        if (endy < starty)
                        {
                            continue;
                        }
                        starty = Rectend.Y - Rectend.Y / 2;
                    }
                    else
                        starty = (end.Y - (i + 1) * ((end.Y + Rectend.Y) / trianglecount) - offset);
                }
                else if (i < 1)
                {
                    endy = end.Y;
                    if (trianglecount == 1)
                    {
                        starty = Rectend.Y;
                    }
                    else
                    {
                        starty = end.Y - (end.Y + Rectend.Y) / trianglecount - offset;
                    }
                }
                Triangle Tri = new Triangle();
                Tri.Draw(startx,starty,endx,endy,System.Drawing.Color.Green);
                ChildShape.Add(Tri);
            }
        }
        public override List<Point> Showpoint()
        {
            if(_listpoint==null)
            _listpoint = new List<Point>();
            else
            {
                _listpoint.Clear();
            }
            foreach(ObjectShape Shape in ChildShape)
            {
                _listpoint.AddRange(Shape.Showpoint());
            }
            SetInfoShape();
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            List<ObjectShape> Temp = new List<ObjectShape>();
            this.start = Tranform2D.Rotate(start, root, angle);
            this.end = Tranform2D.Rotate(end, root, angle);
            foreach (ObjectShape Shape in ChildShape)
            {
                Shape.Rotate(root,angle);
                Temp.Add(Shape);
            }
            ChildShape = Temp;
        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            foreach(ObjectShape Shape in ChildShape)
            {
                Shape.Scale(root, scaleX, scaleY);
            }
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() {name = this.name,centerx = (this.start.X+this.end.X)/2,centery = (this.start.Y+this.end.Y)/2,width=Math.Abs(this.start.X-this.end.X),height=Math.Abs(this.start.Y-this.end.Y)});
            base.SetInfoShape();
        }
    }
}
