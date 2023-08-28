using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using System.Windows.Forms;
using System.Drawing;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Detail_Base
    {
        public List<DataDetail> DataObject;
        public void LoadDataDetail(Panel ContainerDetail)
        {
            ContainerDetail.Controls.Clear();
            DataObject.Reverse();
            foreach (DataDetail Data in DataObject)
            {
                FlowLayoutPanel _panel = new FlowLayoutPanel();
                _panel.Dock = DockStyle.Top;
                _panel.AutoSize = true;
                _panel.BackColor = System.Drawing.Color.Gray;
                _panel.Padding = new Padding(3, 3, 3, 3);
                _panel.BorderStyle = BorderStyle.FixedSingle;
                Label pointstartlabel = new Label();
                pointstartlabel.Text = Data.name;
                pointstartlabel.AutoSize = true;
                pointstartlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                _panel.Controls.Add(pointstartlabel);
                if (Data.Sx.HasValue||Data.Sy.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Điểm đầu = { x=" + Data.Sx.ToString() + " y= " + Data.Sy.ToString() + "}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.Ex.HasValue||Data.Ey.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Điểm Cuối = { x=" + Data.Ex.ToString() + " y= " + Data.Ey.ToString() + "}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.R.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Bán kính = {"+ Data.R.ToString()+"}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.centerx.HasValue||Data.centery.HasValue|| Data.X3D.HasValue || Data.Y3D.HasValue || Data.Z3D.HasValue)
                {
                    pointstartlabel = new Label();
                    if (Data.X3D.HasValue || Data.Y3D.HasValue || Data.Z3D.HasValue)
                        pointstartlabel.Text = "Điểm 3D = { X=" + Data.X3D.ToString() + ", Y= " + Data.Y3D.ToString() + ", Z= " + Data.Z3D.ToString() + " }";
                    else
                        pointstartlabel.Text = "Tâm = { X="+Data.centerx.ToString() +"Y= "+Data.centery.ToString() + " }";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.height.HasValue||Data.width.HasValue)
                {
                    pointstartlabel = new Label();
                    if (Data.Rong.HasValue)
                    {
                        pointstartlabel.Text = "Chiều cao= " + Data.height.ToString() + ", dài= " + Data.width.ToString() + ", rộng= " + Data.Rong.ToString() + " }";
                    }
                    else if (Data.width.HasValue)
                    {
                        pointstartlabel.Text = "Chiều cao= " + Data.height.ToString() + ", dài= " + Data.width.ToString() + " }";
                    }
                    else
                    pointstartlabel.Text = "Chiều cao= " + Data.height.ToString() + " }";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.x.HasValue || Data.y.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Điểm { x = " + Data.x.ToString() + "Y= " + Data.y.ToString() + " }";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                ContainerDetail.Controls.Add(_panel);
            }
        }
    }
    public class DataDetail
    {
        public string name { get; set; }
        public int? Sx { get; set; }
        public int? Sy { get; set; }
        public int? Ex { get; set; }
        public int? Ey { get; set; }
        public int? centerx { get; set; }
        public int? centery { get; set; }
        public int? R { get; set; }
        public int? height { get; set; }
        public int? width { get; set; }
        public int? x { get; set; }
        public int? y { get; set; }
        public int? X3D { get; set; }
        public int? Y3D { get; set; }
        public int? Z3D { get; set; }
        public int? Rong { get; set; }
    }
    public partial class ObjectShape
    {
        public List<DataDetail> Infoshape;
        public string name = "Không xác định"; 
        public  Draw.Point center, start, end,point2, point3;
        public  int radius;
        public  Color? Colorfill,Colorstroke;
        public  List<ObjectShape> ChildShape;
        public  List<Draw.Point> _listpoint;
        public string type;
        public virtual List<Point> Showpoint()
        {
            _listpoint = new List<Point>();
            if (ChildShape.Count > 0)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    _listpoint.AddRange(Shape.Showpoint());
                }
            }
            return _listpoint;
        }
        public virtual void Rotate(Draw.Point root, int angle)
        {
            if (ChildShape.Count > 0)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    Shape.Rotate(root, angle);
                }
            }
            return;
        }
        public virtual void Scale(Draw.Point root,int scaleX=1,int scaleY=1) 
        {
            if (ChildShape!=null)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    Shape.Scale(root, scaleX, scaleY);
                }
            }
            return;
        }
        public virtual void Move(Draw.Point root,int X, int Y)
        {
            if (ChildShape.Count > 0)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    Shape.Move(root, X, Y);
                }
            }
            return;
        }
        public virtual void Flip(bool X ,bool Y)
        {
            if(ChildShape!=null &&ChildShape.Count>0)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    Shape.Flip(X, Y);
                }
            }
            return;
        }
        public virtual void SetInfoShape()
        {
            if (ChildShape!=null&&ChildShape.Count>0)
            {
                foreach(ObjectShape Shape in ChildShape)
                {
                    Infoshape.AddRange(Shape.Infoshape);
                }
            }
        }
    }
}
