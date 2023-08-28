using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Rectangle:ObjectShape
    {
        public Draw.Point StartDef, EndDef, P2Def, P3Def;
        public void Draw(int Sx,int Sy,int Ex,int Ey,System.Drawing.Color? colorfill=null,System.Drawing.Color? colorstroke =null,string type ="Nét liền")
        {
            this.name = "Hình đa giác ";
            this.start = new Draw.Point(Sx, Sy);
            this.end = new Draw.Point(Ex, Ey);
            this.Colorfill = colorfill;
            this.Colorstroke = colorstroke;
            this.type = type;
            this.StartDef = this.start;
            this.EndDef = this.end;
            point2 = new Draw.Point(this.start.X, this.end.Y);
            point3 = new Draw.Point(this.end.X, this.start.Y);
            this.P2Def = this.point2;
            this.P3Def = this.point3;
        }
        public override List<Point> Showpoint()
        {
            SetInfoShape();
            int Sx = this.start.X, Sy = this.start.Y, Ex = end.X, Ey = end.Y;
            List<Draw.Point> _listpoint = new List<Point>();
            int x1, y1, x2, y2;
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
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            start=Tranform2D.Rotate(start, root, angle);
            end=Tranform2D.Rotate(end, root, angle);
            point2 = Tranform2D.Rotate(point2, root, angle);
            point3= Tranform2D.Rotate(point3, root, angle);
        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            this.start = Tranform2D.Scale(StartDef, root, scaleX,scaleY);
            this.end = Tranform2D.Scale(EndDef, root, scaleX,scaleY);
            this.point2 = Tranform2D.Scale(P2Def, root, scaleX, scaleY);
            this.point3 = Tranform2D.Scale(P3Def, root, scaleX,scaleY);
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name, centerx = (this.start.X + this.end.X) / 2, centery = (this.start.Y + this.end.Y) / 2, width = Math.Abs(this.start.X - this.end.X), height = Math.Abs(this.end.Y - this.start.Y) });
        }
    }
}
