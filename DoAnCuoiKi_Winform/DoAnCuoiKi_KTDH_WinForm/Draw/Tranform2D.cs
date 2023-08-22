using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_KTDH_WinForm.Draw;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Tranform2D
    {
        public Draw.Point Rotate(Draw.Point _pointrotate,Draw.Point _root, int angle)
        {
            double alpha =angle * (Math.PI / 180);
            double cos = Math.Cos(alpha),
                   sin = Math.Sin(alpha);
            Draw.Point offset = _root;
            int x = _pointrotate.X - offset.X,
                y = _pointrotate.Y - offset.Y;
            _pointrotate.X= (int)Math.Round((x * cos - y * sin) + offset.X);
            _pointrotate.Y = (int)Math.Round((x * sin + y * cos) + offset.Y);
            return _pointrotate;

        }
        public List<Draw.Point> Rotate(List<Draw.Point> _listpoint, Draw.Point _root, int angle)
        {
            List<Draw.Point> _list = new List<Point>();
            foreach (Draw.Point _pointrotate in _listpoint)
            {
                Draw.Point _temp = Rotate(_pointrotate, _root, angle);
                    _list.Add(_temp);
            }
            return _list;
        }
        public Draw.Point Move(Draw.Point _point,int Xstep=0,int Ystep=0)
        {
            _point.Y = _point.Y + Ystep;
            _point.X = _point.X + Xstep;
            return _point;
        }
        public Draw.Point Scale(Draw.Point _point,Draw.Point _root, int scalex = 1, int scaley = 1)
        {
            scalex = (scalex == 0)? 1 : scalex;
            scaley = (scaley == 0) ? 1 : scaley;
            _point.Y = (_point.Y- _root.Y) * scaley;
            _point.X = (_point.X-_root.X)* scalex;
            return _point;
        }
        public List<Draw.Point> Scale(List<Draw.Point> shape, Draw.Point root, int scalex = 1, int scaley = 1)
        {
            List<Draw.Point> scaledShape = new List<Draw.Point>();

            foreach (Draw.Point point in shape)
            {
                Draw.Point scaledPoint = Scale(point, root, scalex, scaley);
                scaledShape.Add(point);
                if (scaledPoint.X == 0 && scaledPoint.Y == 0)
                {
                    scaledShape.Add(scaledPoint);
                }
                else
                {
                    scaledShape.Add(scaledPoint);
                }
            }

            return scaledShape;
        }
    }
}
