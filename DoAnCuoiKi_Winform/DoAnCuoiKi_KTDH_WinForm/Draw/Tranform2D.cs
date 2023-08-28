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
        public static double CustomRound(double value, int decimals, double roundThreshold)
        {
            double factor = Math.Pow(10, decimals);
            double roundedValue = Math.Round(value * factor);

            if (Math.Abs(roundedValue / factor - value) >= roundThreshold)
            {
                roundedValue = Math.Sign(value) * Math.Ceiling(Math.Abs(value) * factor);
            }

            return roundedValue / factor;
        }
        //public Draw.Point Rotate(Draw.Point _pointrotate,Draw.Point _root, double angle)
        //{
        //    double alpha = (angle * Math.PI / 180);
        //    double cos = Math.Cos(alpha),
        //           sin = Math.Sin(alpha);
        //    Draw.Point offset = _root;
        //   int x = _pointrotate.X - offset.X,
        //        y = _pointrotate.Y - offset.Y;
        //    Console.WriteLine(((x * cos - y * sin) + offset.X).ToString() + "Y = " + ((x * sin + y * cos) + offset.Y).ToString());
        //    _pointrotate.X= (int)(Math.Round((x* cos - y * sin)) +offset.X);
        //    _pointrotate.Y = (int)(CustomRound((x * sin + y * cos),0,0.5)+offset.Y);
        //    Console.WriteLine("Da chuyen ="+_pointrotate.X + " " + _pointrotate.Y);

        //    return _pointrotate;
        //}       
        public static Draw.Point  Rotate(Draw.Point _pointrotate,Draw.Point _root, double angle)
        {
            double alpha = (angle * Math.PI/ 180);
            double cos = Math.Cos(alpha),
                   sin = Math.Sin(alpha);
            int x = _pointrotate.X- _root.X,
                y = _pointrotate.Y- _root.Y;
            double xNewDouble = (x * cos - y * sin),
                yNewDouble = (x * sin + y * cos);
            int xNew = 0;
            int yNew = 0;
            xNew = (int)Math.Round(xNewDouble+ _root.X);
            yNew = (int)Math.Round(yNewDouble+ _root.Y);
            _pointrotate = new Draw.Point(xNew, yNew);
            return _pointrotate = new Draw.Point(_pointrotate.X, _pointrotate.Y, _pointrotate.colorvalue);
        }
        public static List<Draw.Point> Rotate(List<Draw.Point> _listpoint, Draw.Point _root, double angle)
        {
            List<Draw.Point> _list = new List<Point>();
            
            foreach(Draw.Point _temp in _listpoint) { 
                _list.Add(Rotate(_temp, _root, angle));
            }
            return _list;
        }
        public static Draw.Point Move(Draw.Point _point,int Xstep=0,int Ystep=0)
        {
            _point.Y = _point.Y + Ystep;
            _point.X = _point.X + Xstep;
            return _point;
        }
        public static Draw.Point Scale(Draw.Point _point,Draw.Point _root, int scalex = 1, int scaley = 1)
        {
            scalex = (scalex == 0)? 1 : scalex;
            scaley = (scaley == 0) ? 1 : scaley;
            _point.Y = (_point.Y- _root.Y) * scaley;
            _point.X = (_point.X-_root.X)* scalex;
            return _point;
        }
        public static  List<Draw.Point> Scale(List<Draw.Point> shape, Draw.Point root, int scalex = 1, int scaley = 1)
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
