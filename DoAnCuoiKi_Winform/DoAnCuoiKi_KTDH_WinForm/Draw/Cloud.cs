using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Cloud: ObjectShape
    {
        private int radiuschild = 8;
        private List<Draw.Point> _listpointcircle;
        public void Draw(int centerX, int centerY, Color? colorfill = null, Color? colorstroke = null)
        {
            ChildShape = new List<ObjectShape>();
            this.center = new Draw.Point(centerX, centerY, colorfill);
            Circle DrawCircle = new Circle();
            DrawCircle.Draw(centerX - 23, centerY + 8, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
            DrawCircle = new Circle();
            DrawCircle.Draw(centerX - 18, centerY - 5, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
            DrawCircle = new Circle();
            DrawCircle.Draw(centerX - 8, centerY + 3, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
            DrawCircle = new Circle();
            DrawCircle.Draw(centerX + 4, centerY + 9, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
            DrawCircle = new Circle();
            DrawCircle.Draw(centerX + 4, centerY - 3, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
            DrawCircle = new Circle();
            DrawCircle.Draw(centerX + 17, centerY + 3, radiuschild, colorfill, colorstroke);
            ChildShape.Add(DrawCircle);
        }
        public override List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            foreach(ObjectShape Shape in ChildShape)
            {
                _listpoint.AddRange(Shape.Showpoint());
            }
            return _listpoint;
        }
        public override void Rotate(Point root, int angle)
        {
            List<ObjectShape> ChildTemp= new List<ObjectShape>();
            this.center = Tranform2D.Rotate(center, root, angle);
            foreach (ObjectShape Shape in ChildShape)
            {
                Shape.Rotate(root,angle);
                ChildTemp.Add(Shape);
            }
            ChildShape = ChildTemp;
        }
    }
}
