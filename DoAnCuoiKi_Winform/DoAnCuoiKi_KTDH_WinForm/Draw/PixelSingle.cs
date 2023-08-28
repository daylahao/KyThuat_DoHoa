using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class PixelSingle:ObjectShape
    {
        public void Draw(int sx,int sy,System.Drawing.Color? ColorPixel=null)
        {
            this.center = new Draw.Point(sx, sy);
        }
        public override List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            _listpoint.Add(this.center);
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            this.center = Tranform2D.Rotate(this.center, root, angle);
        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            center = Tranform2D.Scale(center, root,scaleX,scaleY);
        }
    }
}
