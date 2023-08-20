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
        int UnitSize = 5;
        public List<Draw.Point> Box(int x, int y, int z, int dai, int rong, int cao)
        {
            _listpoint = new List<Point>();
            ConvertPoint _pointbase = new ConvertPoint();
            int a = x - (z / 2);
            int b = y - (z / 2);
            int cX = (View_3D.viewsize.width / 2) + a;
            int cY = (View_3D.viewsize.height / 2) - b;


            Draw2D drawLine = new Draw2D();
            Color lineColor = Color.Black;
            string lineType = "Nét liền";
            int[] pointcneter = _pointbase.Doi_Sang_He_Toa_Do_Nguoi_Dung(cX, cY);
            _listpoint.AddRange(drawLine.Line(pointcneter[0], pointcneter[1] + cao, pointcneter[0] + dai, pointcneter[1] + cao, lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0], pointcneter[1] + cao, pointcneter[0] + (-rong / 2), pointcneter[1] + cao - (rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0] + dai - (rong / 2), pointcneter[1] + cao - (rong / 2), pointcneter[0] + dai, pointcneter[1] + cao, lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0] + dai - (rong / 2), pointcneter[1] + cao - (rong / 2), pointcneter[0] + (-rong / 2), pointcneter[1] + cao - (rong / 2), lineColor, lineType));

            _listpoint.AddRange(drawLine.Line(pointcneter[0] + (-rong / 2), pointcneter[1] + cao - (rong / 2), pointcneter[0] + (-rong / 2), pointcneter[1] + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0] + dai - (rong / 2), pointcneter[1] + cao - (rong / 2), pointcneter[0] + dai - (rong / 2), pointcneter[1] + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0] + dai, pointcneter[1] + cao, pointcneter[0] + dai, pointcneter[1], lineColor, lineType));

            _listpoint.AddRange(drawLine.Line(pointcneter[0] + (-rong / 2), pointcneter[1] + (-rong / 2), pointcneter[0] + dai - (rong / 2), pointcneter[1] + (-rong / 2), lineColor, lineType));
            _listpoint.AddRange(drawLine.Line(pointcneter[0] + dai - (rong / 2), pointcneter[1] + (-rong / 2), pointcneter[0] + dai, pointcneter[1], lineColor, lineType));

            string linetype1 = "Nét đứt";
            _listpoint.AddRange(drawLine.Line(pointcneter[0], pointcneter[1], pointcneter[0] + (-rong / 2), pointcneter[1] + (-rong / 2), lineColor, linetype1));
            _listpoint.AddRange(drawLine.Line(pointcneter[0], pointcneter[1], pointcneter[0], pointcneter[1] + cao, lineColor, linetype1));
            _listpoint.AddRange(drawLine.Line(pointcneter[0], pointcneter[1], pointcneter[0] + dai, pointcneter[1], lineColor, linetype1));
            return _listpoint;
        }
        public List<Draw.Point> DrawCylinder(int x, int y, int z, int bankinh, int chieucao)
        {
            List<Draw.Point> _listpoint = new List<Point>();
            ConvertPoint _pointbase = new ConvertPoint();
            Draw2D _Draw2D = new Draw2D();
            int x1 = x * UnitSize;
            int y1 = y * UnitSize;
            int z1 = z * UnitSize;
            int a = x1 - (z1 / 2);
            int b = y1 - (z1 / 2);
            int cX = (View_3D.viewsize.width / 2) + a;
            int cY = (View_3D.viewsize.height / 2) - b;
            _listpoint.AddRange(_Draw2D.DrawEllipseMidpoint2(cX, cY, bankinh, bankinh / 2));
            _listpoint.AddRange(_Draw2D.DrawEllipseMidpoint(cX, cY - chieucao * UnitSize, bankinh, bankinh / 2));

            int h = x;
            int w = y;
            int m = z;
            int n = h - (m / 2); ;
            int k = w - (m / 2);
            int cX1 = (View_3D.viewsize.width / 2) + n;
            int cY1 = (View_3D.viewsize.height / 2) - k;
            Color lineColor = Color.Black;
            int[] pointcneter = _pointbase.Doi_Sang_He_Toa_Do_Nguoi_Dung(cX1, cY1);
            _listpoint.AddRange(_Draw2D.Line(pointcneter[0] + bankinh, pointcneter[1], pointcneter[0] + bankinh, pointcneter[1] + chieucao, lineColor));
            _listpoint.AddRange(_Draw2D.Line(pointcneter[0] - bankinh, pointcneter[1], pointcneter[0] - bankinh, pointcneter[1] + chieucao, lineColor));
            return _listpoint;
        }
    }
}
