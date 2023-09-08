using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using System.Drawing;
using DoAnCuoiKi_KTDH_WinForm.view;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Draw3D
    {
        List<Draw.Point> _listpoint;
        public List<Draw.Point> Box(int x, int y, int z, int dai, int rong, int cao)
        {
            _listpoint = new List<Point>();
            int a = x - (z / 2);
            int b = y - (z / 2);
            int cX = (View_2D.viewsize.width / 2) + a;
            int cY = (View_2D.viewsize.height / 2) - b;

            Draw2D drawLine = new Draw2D();
            Color lineColor = Color.Black;
            string lineType = "Nét liền";
            Draw.Point pointcneter = ConvertPoint.Doi_Sang_He_Toa_Do_Nguoi_Dung(cX, cY);
            MainForm._BoxDetail.DataObject.Add(new DataDetail() {name="Hình Hộp", X3D = x, Y3D = y,Z3D = z,height = cao,width = dai,Rong = rong });
            _listpoint.AddRange(drawLine.Line(pointcneter.X, pointcneter.Y + cao, pointcneter.X + dai, pointcneter.Y + cao, lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X, pointcneter.Y + cao, pointcneter.X + (-rong / 2), pointcneter.Y + cao - (rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X + dai - (rong / 2), pointcneter.Y + cao - (rong / 2), pointcneter.X + dai, pointcneter.Y + cao, lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X + dai - (rong / 2), pointcneter.Y + cao - (rong / 2), pointcneter.X + (-rong / 2), pointcneter.Y + cao - (rong / 2), lineColor, lineType));

            _listpoint.AddRange(drawLine.Line(pointcneter.X + (-rong / 2), pointcneter.Y + cao - (rong / 2), pointcneter.X + (-rong / 2), pointcneter.Y + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X + dai - (rong / 2), pointcneter.Y + cao - (rong / 2), pointcneter.X + dai - (rong / 2), pointcneter.Y + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X + dai, pointcneter.Y + cao, pointcneter.X + dai, pointcneter.Y, lineColor, lineType));

            _listpoint.AddRange(drawLine.Line(pointcneter.X + (-rong / 2), pointcneter.Y + (-rong / 2), pointcneter.X + dai - (rong / 2), pointcneter.Y + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter.X + dai - (rong / 2), pointcneter.Y + (-rong / 2), pointcneter.X + dai, pointcneter.Y, lineColor, lineType));

            string linetype1 = "Nét đứt";
            _listpoint.AddRange(drawLine.Line(pointcneter.X, pointcneter.Y, pointcneter.X + (-rong / 2), pointcneter.Y + (-rong / 2), lineColor, linetype1));
            _listpoint.AddRange(drawLine.Line(pointcneter.X, pointcneter.Y, pointcneter.X, pointcneter.Y + cao, lineColor, linetype1));
            _listpoint.AddRange(drawLine.Line(pointcneter.X, pointcneter.Y, pointcneter.X + dai, pointcneter.Y, lineColor, linetype1));
            return _listpoint;
        }
        public List<Draw.Point> DrawCylinder(int x, int y, int z, int bankinh, int chieucao)
        {
            MainForm._BoxDetail.DataObject.Add(new DataDetail() { name = "Hình trụ",X3D=x,Y3D=y,Z3D=z, R = bankinh, height = chieucao });
            List<Draw.Point> _listpoint = new List<Point>();
            Draw2D _Draw2D = new Draw2D();
            int a = x - (z / 2);
            int b = y - (z / 2);
            //int cX = (View_3D.viewsize.width / 2) + a;
            //int cY = (View_3D.viewsize.height / 2) - b;
            int cX = 0 + a;
            int cY = 0 + b;
            _listpoint.AddRange(_Draw2D.DrawEllipseMidpoint2(cX, cY, bankinh, bankinh / 2));
            _listpoint.AddRange(_Draw2D.DrawEllipseMidpoint(cX, cY + chieucao, bankinh, bankinh / 2));

            int h = x;
            int w = y;
            int m = z;
            int n = h - (m / 2); ;
            int k = w - (m / 2);
            int cX1 = (View_2D.viewsize.width / 2) + n;
            int cY1 = (View_2D.viewsize.height / 2) - k;
            Color lineColor = Color.Black;
            Draw.Point pointcneter = ConvertPoint.Doi_Sang_He_Toa_Do_Nguoi_Dung(cX1, cY1);
            _listpoint.AddRange(_Draw2D.Line(pointcneter.X + bankinh, pointcneter.Y, pointcneter.X + bankinh, pointcneter.Y + chieucao, lineColor));
            _listpoint.AddRange(_Draw2D.Line(pointcneter.X - bankinh, pointcneter.Y, pointcneter.X - bankinh, pointcneter.Y + chieucao, lineColor));
            return _listpoint;
        }

    }
}
