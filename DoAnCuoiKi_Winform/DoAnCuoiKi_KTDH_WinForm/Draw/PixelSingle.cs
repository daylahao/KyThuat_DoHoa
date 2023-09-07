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
            this.name = "Điểm";
            this.center = new Draw.Point(sx, sy,ColorPixel);
        }
        public override List<Point> Showpoint()
        {
            SetInfoShape();
            _listpoint = new List<Point>();
            _listpoint.Add(this.center);
            return _listpoint;
        }
        public override void Scale(Point root, int scaleX = 1, int scaleY = 1)
        {
            center = Tranform2D.Scale(center, root, scaleX, scaleY);
        }
        public override void Move(Point root, int X, int Y)
        {
            center = Tranform2D.Move(center, X, Y);
        }
        public override void Rotate(Point root, int angle)
        {
            center = Tranform2D.Rotate(center, root, angle);
        }
        public override void Flip(bool X, bool Y)
        {
            base.Flip(X, Y);
        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name, x = center.X, y = center.Y });
        }
    }
}
