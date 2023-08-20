using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class DrawBase
    {
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color? colorvalue { get; set; }
        public Point(int x, int y, Color? color = null)
        {
            X = x;
            Y = y;
            colorvalue = color;
        }
    }
    public class ObjectSharp
    {
        public string name;
        public Draw.Point centerpoint;
        public List<ObjectSharp> childsharp {get;set;}
        public List<Draw.Point> _listpoint { get; set; }
    }
}
