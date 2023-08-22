using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using System.Windows.Forms;
using DoAnCuoiKi_KTDH_WinForm.Dialog;
namespace DoAnCuoiKi_KTDH_WinForm.view
{
    public class View_3D
    {
        public class ToolBox
        {
            public string name { get; set; }
            public Bitmap thumb { get; set; }
            public EventHandler customFunction { get; set; }
        }
        public PictureBox view { get; set; }
        public int centerX, centerY;
        public static Size viewsize = new Size();
        public List<Draw.Point> _listpoint = new List<Draw.Point>();
        Draw3D _Draw3d;
        List<ToolBox> Ds_ToolBox;
        public void LoadUIView()
        {
            _Draw3d = new Draw3D();
            viewsize.width = view.Width;
            viewsize.height = view.Height;
            centerX = viewsize.width / 2;
            centerY = viewsize.height / 2;
            view.Paint += SetupDrawView;
            view.Refresh();
        }
        public void ResetView()
        {
            _listpoint.Clear();
            MainForm._BoxDetail.DataObject.Clear();
            view.Refresh();
            MainForm.LoadDetailMenu();
        }
        public void LoadMenuToolBox(Panel ContainerToolBox)
        {
            //Drawline Button
            
            foreach (ToolBox tool in Ds_ToolBox)
            {
                ItemBody ItemTool = new ItemBody();
                ItemTool.itemname = tool.name;
                ItemTool.thumb = tool.thumb;
                ItemTool.ButtonClick += tool.customFunction;
                ItemTool.Height = 50;
                ItemTool.Dock = DockStyle.Top;
                ContainerToolBox.Controls.Add(ItemTool);
            }
        }
        public void CreatListToolBox()
        {
            Ds_ToolBox = new List<ToolBox>();
            Ds_ToolBox = new List<ToolBox>();
            ToolBox toolBox = new ToolBox();
            Ds_ToolBox.Add(new ToolBox() { name = "Hình Hộp", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.BoxIcon, customFunction = new EventHandler(DrawBox3D)});
            Ds_ToolBox.Add(new ToolBox() { name = "Hình Trụ", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.CylineIcon, customFunction = new EventHandler(DrawCycline3D) });
            Ds_ToolBox.Reverse();
        }
        protected void DrawBox3D(object sender, EventArgs e)
        {
            _listpoint.Clear();
            using (Dialog.DialogForm3Dcs _dialog = new Dialog.DialogForm3Dcs())
            {
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MainForm._BoxDetail.DataObject.Clear();
                    _listpoint.AddRange(_Draw3d.Box(_dialog.Data.x, _dialog.Data.y, _dialog.Data.z, _dialog.Data.width,_dialog.Data.rong, _dialog.Data.height));
                    MainForm.LoadDetailMenu();
                    view.Refresh();
                }
            }
        }
        protected void DrawCycline3D(object sender, EventArgs e)
        {
            _listpoint.Clear();
            using (Dialog.DialogForm3Dcs _dialog = new Dialog.DialogForm3Dcs())
            {
               _dialog.Cylinder = true;
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MainForm._BoxDetail.DataObject.Clear();
                    _listpoint.AddRange(_Draw3d.DrawCylinder(_dialog.Data.x, _dialog.Data.y, _dialog.Data.z,_dialog.Data.radius, _dialog.Data.height));
                    MainForm.LoadDetailMenu();
                    view.Refresh();
                }
            }
        }

        public void SetupDrawView(object sender, PaintEventArgs e)
        {
            Pen grayPen = new Pen(Color.FromArgb(128, Color.Gray));
            Pen xPen = new Pen(Color.Red);
            Pen yPen = new Pen(Color.Red);
            if (MainForm.togglegrid)
            {
                // Vẽ lưới trục x
                for (int x = centerX; x < view.Width; x += MainForm.UnitSize)
                {
                    if (x == centerX) // Kiểm tra nếu là đường trục x đi qua tâm
                    {
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height/2);
                        e.Graphics.DrawLine(grayPen, x, view.Height / 2, x, view.Height);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, x, 0, x, view.Height);
                    }
                }
                for (int x = centerX - MainForm.UnitSize; x >= 0; x -= MainForm.UnitSize)
                {
                    if (x == centerX) // Kiểm tra nếu là đường trục x đi qua tâm
                    {
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height/2);
                        e.Graphics.DrawLine(grayPen, x, view.Height / 2, x, view.Height);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, x, 0, x, view.Height);
                    }
                }

                // Vẽ lưới trục y
                for (int y = centerY; y < view.Height; y += MainForm.UnitSize)
                {
                    if (y == centerY) // Kiểm tra nếu là đường trục y đi qua tâm
                    {
                        e.Graphics.DrawLine(yPen, view.Width/2, y, view.Width, y);
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width/2, y);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width, y);
                    }
                }
                for (int y = centerY - MainForm.UnitSize; y >= 0; y -= MainForm.UnitSize)
                {
                    if (y == centerY) // Kiểm tra nếu là đường trục y đi qua tâm
                    {
                        e.Graphics.DrawLine(yPen, view.Width/2, y, view.Width, y);
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width / 2, y);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width, y);
                    }
                }
            }
            if (MainForm.togglegrid)
            {
                float Sz = (float)Math.Tan(45 * Math.PI / 180) * (view.Height / 2);
                e.Graphics.DrawLine(yPen, view.Width / 2 - Sz, view.Height, view.Width / 2, view.Height / 2); // Trục z
            }
            // Vẽ các điểm đã lưu trong danh sách
            using (Brush brush = new SolidBrush(Color.Black))
            {
                foreach (Draw.Point point in _listpoint)
                {
                    int pixelx = centerX + point.X * MainForm.UnitSize;
                    int pixely = centerY - point.Y * MainForm.UnitSize;
                    if (point.colorvalue != null)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(point.colorvalue.Value), pixelx - MainForm.UnitSize / 2, pixely - MainForm.UnitSize / 2, MainForm.UnitSize, MainForm.UnitSize);
                    }
                    else
                        e.Graphics.FillRectangle(brush, pixelx - MainForm.UnitSize / 2, pixely - MainForm.UnitSize / 2, MainForm.UnitSize, MainForm.UnitSize);
                }
            }
        }
    }
}
