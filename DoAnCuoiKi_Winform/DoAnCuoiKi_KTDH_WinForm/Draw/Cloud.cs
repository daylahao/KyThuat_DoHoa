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
        private List<Draw.Point> OffsetPointChild = new List<Point>()
        {
            new Draw.Point(-23,8),
            new Draw.Point(-18,-5),
            new Draw.Point(-8,3),
            new Draw.Point(4,9),
            new Draw.Point(17,3),
        };
        public void Draw(int centerX, int centerY, Color? colorfill = null, Color? colorstroke = null)
        {
            this.name = "Mây";
            ChildShape = new List<ObjectShape>();
            this.center = new Draw.Point(centerX, centerY, colorfill);
            for (int k = 0; k < OffsetPointChild.Count; k++)
            {
                Circle DrawCircle = new Circle();
                DrawCircle.Draw(this.center.X + OffsetPointChild[k].X, this.center.Y + OffsetPointChild[k].Y, radiuschild, colorfill, colorstroke);
                ChildShape.Add(DrawCircle);
            }
        }
        public override List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            int k = 0;
            foreach(ObjectShape Shape in ChildShape)
            {
                Shape.center = new Draw.Point(this.center.X + OffsetPointChild[k].X, this.center.Y + OffsetPointChild[k].Y);
                _listpoint.AddRange(Shape.Showpoint());
                k++;
            }
            SetInfoShape();
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
        public override void Move(Point root, int X, int Y)
        {
            this.center = Tranform2D.Move(root, X, Y);
            foreach(ObjectShape Shape in ChildShape)
            {
                Shape.Move(center, X, Y);
            }

        }
        public override void SetInfoShape()
        {
            Infoshape = new List<DataDetail>();
            Infoshape.Add(new DataDetail() { name = this.name,centerx = this.center.X,centery = this.center.Y});
            base.SetInfoShape();
        }
    }
}
