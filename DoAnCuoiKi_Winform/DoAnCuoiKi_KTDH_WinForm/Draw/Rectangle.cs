using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Rectangle:ObjectShape
    {
        public void Draw(int Sx,int Sy,int Ex,int Ey,System.Drawing.Color? colorfill=null,System.Drawing.Color? colorstroke =null,string type ="Nét liền")
        {
            this.start = new Draw.Point(Sx, Sy);
            this.end = new Draw.Point(Ex, Ey);
            this.Colorfill = colorfill;
            this.Colorstroke = colorstroke;
            this.type = type;
        }
        public override List<Point> Showpoint()
        {
            int Sx = this.start.X, Sy = this.start.Y, Ex = end.X, Ey = end.Y;
            List<Draw.Point> _listpoint = new List<Point>();
            int x1, y1, x2, y2;
            if (point2 == null || point3 == null){
                point2 = new Draw.Point(Sx,Ey);
                point3 = new Draw.Point(Ex, Sy); 
            }
            Line2D Line = new Line2D();
            Line.Draw(Sx, Sy,point2.X,point2.Y, this.Colorstroke, type);
            _listpoint.AddRange(Line.Showpoint());
            Line.Draw(point2.X,point2.Y, Ex, Ey, this.Colorstroke, type);
            _listpoint.AddRange(Line.Showpoint());
            Line.Draw(Ex, Ey,point3.X,point3.Y, this.Colorstroke, type);
            _listpoint.AddRange(Line.Showpoint());         
            Line.Draw(point3.X, point3.Y, Sx, Sy, this.Colorstroke, type);
            _listpoint.AddRange(Line.Showpoint());
            Draw2D Fill = new Draw2D();
            if (type == "Nét liền")
                _listpoint = Fill.FillColor(_listpoint, (Ex + Sx) / 2, (Ey + Sy) / 2, Colorfill);
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình chữ nhật", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey, width = Math.Abs(Sx + Ex), height = Math.Abs(Sy + Ey) });
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            start=Tranform2D.Rotate(start, root, angle);
            end=Tranform2D.Rotate(end, root, angle);
            point2 = Tranform2D.Rotate(point2, root, angle);
            point3= Tranform2D.Rotate(point3, root, angle);
        }
    }
}
