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
    public class View_2D
    {
        public PictureBox view { get; set; }
        public int centerX, centerY;
        public static Size viewsize = new Size();
        public List<Draw.Point> _listpoint = new List<Draw.Point>();
        Draw2D _Draw2d;
        public void LoadMenuToolBox(Panel ContainerToolBox)
        {
            ItemBody ItemTool = new ItemBody();
            ItemTool.itemname = "Đường Thẳng";
            ItemTool.thumb = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.LineIcon;
            ItemTool.ButtonClick += new EventHandler(DrawLine);
            ItemTool.Height = 50;
            ItemTool.Dock = DockStyle.Top;
            ContainerToolBox.Controls.Add(ItemTool);
        }
        #region Kích hoạt các hàm vẽ
        protected void DrawLine(object sender, EventArgs e)
        {
            _listpoint.Clear();
            using (Dialog.LineDialogForm _dialog = new Dialog.LineDialogForm())
            {
                if (_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                    _listpoint.AddRange(_Draw2d.Line(_dialog.data.Sx, _dialog.data.Sy, _dialog.data.Ex, _dialog.data.Ey, _dialog.data.colorline, _dialog.data.style));
                    DataDetail Data = new DataDetail();
                    Data.name = "Đường Thẳng";
                    Data.Sx = _dialog.data.Sx;
                    Data.Ex = _dialog.data.Ex;
                    Data.Sy = _dialog.data.Sy;
                    Data.Ey = _dialog.data.Ey;
                    MainForm._BoxDetail.DataObject.Clear();
                    MainForm._BoxDetail.DataObject.Add(Data);
                    MainForm.LoadDetailMenu();

                    view.Refresh();
                }
            }
        }
        protected void DrawCricle(object sender, EventArgs e)
        {

        }
        protected void DrawRectangle(object sender, EventArgs e)
        {

        }
        protected void TreeTriangle(object sender,EventArgs e)
        {

        }
        #endregion
        public void LoadUIView()
        {
            _Draw2d = new Draw2D();
            viewsize.width = view.Width;
            viewsize.height = view.Height;
            centerX = viewsize.width / 2;
            centerY = viewsize.height / 2;
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
                _listpoint.Add(new Draw.Point(pixelx, pixely));
                view.Refresh();
            }

        }
    }
}
