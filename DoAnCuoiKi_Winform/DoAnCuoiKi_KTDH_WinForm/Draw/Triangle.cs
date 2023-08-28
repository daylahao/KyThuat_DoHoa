using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Triangle:ObjectShape
    {
        public Draw.Point StarDef, EndDef, P2Def, P3Def;
        public void Draw(int sx,int sy,int ex,int ey, System.Drawing.Color? Colorfill=null,System.Drawing.Color? Colorstroke=null,string type = "Nét liền")
        {
            this.name = "Hình tam giác";
            this.start = new Draw.Point(sx, sy);
            this.end = new Draw.Point(ex, ey);
            this.point2 = new Draw.Point(this.end.X, this.start.Y);
            this.point3 = new Draw.Point((this.end.X + this.start.X) / 2, this.end.Y);
            this.Colorfill = Colorfill;
            this.Colorstroke = Colorstroke;
            this.type = type;
            this.StarDef = start;
            this.EndDef = end;
            this.P2Def = point2;
            this.P3Def = point3;

        }
        public override List<Point> Showpoint()
        {
            List<Draw.Point> PointsDraw = new List<Draw.Point>();
            SetInfoShape();
            Line2D Line = new Line2D();
            Line.Draw(this.start, this.point2, Colorstroke,type);
            PointsDraw.AddRange(Line.Showpoint()); 
            Line.Draw(this.point2,this.point3, Colorstroke,type);
            PointsDraw.AddRange(Line.Showpoint());
            Line.Draw(this.point3, this.start, Colorstroke, type);
            PointsDraw.AddRange(Line.Showpoint());
            if (type == "Nét liền")
            {
                int centerX = (int)((start.X + point2.X + point3.X) / 3);
                int centerY = (int)((start.Y + point2.Y + point3.Y) / 3);
                Draw2D Fill = new Draw2D();
                if (this.end.Y > this.start.Y)
                    PointsDraw = Fill.FillColor(PointsDraw, centerX, centerY, Colorfill);
                else
                    PointsDraw = Fill.FillColor(PointsDraw, centerX, centerY, Colorfill);
            }
            //MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình Tam giác", Sx = Sx, Sy = Sy, Ex = Ex, Ey = Ey, centerx = (Sx + Ex) / 2, centery = (Sy + Ey) / 2 });
            return PointsDraw;
        }
        public override void Rotate(Point root, int angle)
        {
           if(point2!=null && point3 != null)
            {
                start = Tranform2D.Rotate(start, root, angle);
                end = Tranform2D.Rotate(end, root, angle);
                point2 = Tranform2D.Rotate(point2, root, angle);
                point3 = Tranform2D.Rotate(point3, root, angle);
            }
        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            this.start = Tranform2D.Scale(this.StarDef, root, scaleX, scaleY);
            this.end = Tranform2D.Scale(this.EndDef, root, scaleX, scaleY);
            this.point2 = Tranform2D.Scale(this.P2Def, root, scaleX, scaleY);
            this.point3 = Tranform2D.Scale(this.P3Def, root, scaleX, scaleY);
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name, centerx = (this.start.X + this.end.X) / 2, centery = (this.start.Y + this.end.Y) / 2, Sx = start.X, Sy = start.Y,Ex=end.X,Ey = end.Y });
        }
    }
}
