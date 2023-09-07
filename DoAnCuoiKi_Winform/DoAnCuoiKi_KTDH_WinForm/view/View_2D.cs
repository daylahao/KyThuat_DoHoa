using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DoAnCuoiKi_KTDH_WinForm;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using DoAnCuoiKi_KTDH_WinForm.Dialog;
namespace DoAnCuoiKi_KTDH_WinForm.view
{
    public class ToolBox
    {
        public string name { get; set; }
        public Bitmap thumb { get; set; }
        public EventHandler customFunction { get; set; }
    }
    public class View_2D
    {
        public PictureBox view { get; set; }
        public int centerX, centerY;
        public static Size viewsize = new Size();
        public List<Draw.Point> _listpoint = new List<Draw.Point>();
        Draw2D _Draw2d;
        public List<ObjectShape> ShapePoint = new List<ObjectShape>();
        List<ToolBox> Ds_ToolBox;
        public void ResetView()
        {
            _listpoint.Clear();
            ShapePoint.Clear();
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
            ToolBox toolBox = new ToolBox();
            Ds_ToolBox.Add(new ToolBox() { name = "Đường Thẳng", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.LineIcon, customFunction = new EventHandler(DrawLine) });
            Ds_ToolBox.Add(new ToolBox() { name = "Hình chữ nhật", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.RectangleIcon, customFunction = new EventHandler(DrawRectangle) });
            Ds_ToolBox.Add(new ToolBox() { name = "Cây tam giác", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.TreeTriangleIcon, customFunction = new EventHandler(DrawTreeTriangle) });
            Ds_ToolBox.Add(new ToolBox() { name = "Cây tròn", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.TreeCircleIcon, customFunction = new EventHandler(DrawTreeCircle)});
            Ds_ToolBox.Add(new ToolBox() { name = "Cầu vồng", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.RainbowIcon, customFunction = new EventHandler(DrawRainBow)});
            Ds_ToolBox.Add(new ToolBox() { name = "Đám mây", thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.Cloud, customFunction = new EventHandler(DrawCloud) });
            Ds_ToolBox.Reverse();
        }
        #region Kích hoạt các hàm vẽ
        protected void DrawCloud(object sender, EventArgs e)
        {
            //MessageBox.Show("hello world");
            _listpoint.Clear();
            MainForm._BoxDetail.DataObject.Clear();
            Cloud CloudDraw = new Cloud();
            CloudDraw.Draw(0, 0, Color.Pink, Color.Black);
            ShapePoint.Add(CloudDraw);
            view.Refresh();
        }
        protected void DrawLine(object sender, EventArgs e)
        {
            _listpoint.Clear();
            using (Dialog.LineDialogForm _dialog = new Dialog.LineDialogForm())
            {
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Line2D LineDraw = new Line2D();
                    LineDraw.Draw(_dialog.data.Sx, _dialog.data.Sy, _dialog.data.Ex, _dialog.data.Ey, _dialog.data.colorline, _dialog.data.style);
                    ShapePoint.Add(LineDraw);
                    MainForm.LoadDetailMenu();
                    view.Refresh();
                }
            }
        }
        protected void DrawCircle(object sender, EventArgs e)
        {

        }
        protected void DrawRectangle(object sender, EventArgs e)
        {

            using (Dialog.LineDialogForm _dialog = new Dialog.LineDialogForm())
            {
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Draw.Rectangle Rect = new Draw.Rectangle();
                    Rect.Draw(_dialog.data.Sx, _dialog.data.Sy, _dialog.data.Ex, _dialog.data.Ey, _dialog.data.colorline, Color.Black,_dialog.data.style);
                    ShapePoint.Add(Rect);
                    view.Refresh();
                }
            }
        }
        protected void DrawTreeTriangle(object sender,EventArgs e)
        {
            using (Dialog.TreeTriangleDialogForm _dialog = new Dialog.TreeTriangleDialogForm())
            {
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    TreeTriangle TreeTri = new TreeTriangle();
                    TreeTri.Draw(_dialog.data.Sx, _dialog.data.Sy, _dialog.data.Ex, _dialog.data.Ey, _dialog.data.count);
                    ShapePoint.Add(TreeTri);
                    view.Refresh();
                }
            }
        }
        protected void DrawTreeCircle(object sender,EventArgs e)
        {
            TreeCircle TreeCir = new TreeCircle();
            TreeCir.Draw(0, 0, 20, 40, 3);
            ShapePoint.Add(TreeCir);
            view.Refresh();
        }
        protected void DrawRainBow(object sender,EventArgs e)
        {
            _listpoint.Clear();
            _listpoint.AddRange(_Draw2d.Rainbow());
            //_listpoint.AddRange(_Draw2d.Rainbow(0,0));
            view.Refresh();
        }
        #endregion
        public void LoadUIView()
        {
            _Draw2d = new Draw2D();
            viewsize.width = view.Width;
            viewsize.height = view.Height;
            centerX = viewsize.width / 2;
            centerY = viewsize.height / 2;
            Listtemp = new List<DataDetail>();
            view.Paint += SetupDrawView;
            view.Refresh();
        }
        private void SetupDrawView(object sender, PaintEventArgs e)
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
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height);
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
                        e.Graphics.DrawLine(xPen, x, 0, x, view.Height);
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
                        e.Graphics.DrawLine(yPen, 0, y, view.Width, y);
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
                        e.Graphics.DrawLine(yPen, 0, y, view.Width, y);
                    }
                    else
                    {
                        e.Graphics.DrawLine(grayPen, 0, y, view.Width, y);
                    }
                }
            }

            // Vẽ các điểm đã lưu trong danh sách
            using (Brush brush = new SolidBrush(Color.Black))
            {
                MainForm._BoxDetail.DataObject.Clear();
                foreach (ObjectShape Shape in ShapePoint)
                {
                    _listpoint.AddRange(Shape.Showpoint());
                    MainForm._BoxDetail.DataObject.AddRange(Shape.Infoshape);
                }
                foreach (Draw.Point point in _listpoint)
                {
                    int pixelx = centerX + point.X * MainForm.UnitSize - MainForm.UnitSize/2;
                    int pixely = centerY - point.Y * MainForm.UnitSize - MainForm.UnitSize/2;
                    if (point.colorvalue != null)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(point.colorvalue.Value), pixelx, pixely, MainForm.UnitSize, MainForm.UnitSize);
                    }
                    else
                        e.Graphics.FillRectangle(brush, pixelx, pixely, MainForm.UnitSize, MainForm.UnitSize);
                }
                    MainForm.LoadDetailMenu();
            }
        }
        List<DataDetail> Listtemp;
        int counttest = 0;
        public void click_putpixel(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)// khang dinh la chuot dc click la chuot trai
            {
                    //pointsToDraw.Add(new Point(e.X,e.Y));
                    //Tính Toạ độ để hiện lên textbox
                    int pixelx = (e.X - centerX) / MainForm.UnitSize;
                    int pixely = (centerY - e.Y) / MainForm.UnitSize;
                //Hiện toạ độ lên textbox
                /*                textBoxX.Text = pixelx.ToString();
                                textBoxY.Text = pixely.ToString();*/
                //_listpoint.Add(new Draw.Point(pixelx, pixely));
                    PixelSingle pixelput = new PixelSingle();
                    pixelput.Draw(pixelx, pixely);
                /*                    MainForm._BoxDetail.DataObject.Clear();
                                    MainForm._BoxDetail.DataObject.Add(data);*/
                if (!MainForm.mousedown)
                {
                    ShapePoint.Add(pixelput);
                    view.Refresh();
                }
            }

        }
    }
}
