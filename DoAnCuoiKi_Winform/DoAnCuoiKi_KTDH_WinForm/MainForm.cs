using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_KTDH_WinForm.Dialog;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using DoAnCuoiKi_KTDH_WinForm.view;
namespace DoAnCuoiKi_KTDH_WinForm
{
    public partial class MainForm : Form
    {
        public static bool togglegrid = true;
        private int tabindex = 0;
        public static int UnitSize = 5;
        private view.View_2D View2D;
        private view.View_Animation ViewAnimation;
        private view.View_3D View3D;
        public static Detail_Base _BoxDetail;
        public static Panel paneldetail;
        public static Panel panellayer;
        private bool AppStart = true;
        public List<List<Draw.Point>> ListObjectAnimation = new List<List<Draw.Point>>();
        Tranform2D Tranform2D;
        public MainForm()
        {
            InitializeComponent();
            ViewTab.SelectedIndex = tabindex;
            View2D = new View_2D();
            ViewAnimation = new View_Animation();
            ViewAnimation.view = this.viewanim;
            ViewAnimation.panellayer = container_itemlist_bottom;
            ViewAnimation.container_layeritembbody = Container_layeritembody;
            View2D.view = this.ViewPic2D;
            _BoxDetail = new Detail_Base();
            _BoxDetail.DataObject = new List<DataDetail>();
            paneldetail = this.panel_detail;
            panellayer = this.container_itemlist_bottom;
            Tranform2D = new Tranform2D();
            View3D = new View_3D();
            View3D.view = view3D;
            timer1.Tick += new EventHandler(ViewAnimation.Update);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AppStart)
            {
                View2D.CreatListToolBox();
                View3D.CreatListToolBox();
                AppStart = false;
            }
            Changetab();
        }
        private void Changetab()
        {
            group_btn.Controls.Clear();
            Tool_Tranform2D_Container.Hide();
            if (tabindex != ViewTab.SelectedIndex)
            {
                _BoxDetail.DataObject.Clear();
                MainForm.panellayer.Visible = false;
                tabindex = ViewTab.SelectedIndex;
                LoadDetailMenu();
            }
            switch (ViewTab.SelectedIndex)
            {
                case 0: // 2D
                    {
                        View2D.LoadUIView();
                        View2D.LoadMenuToolBox(group_btn);
                        container_menu.Show();
                        Tool_Tranform2D_Container.Show();
                        break;
                    }
                case 1: //3D
                    {
                        View3D.LoadUIView();
                        View3D.LoadMenuToolBox(group_btn);
                        container_menu.Show();
                        break;
                    }
                case 2://Animation
                    {
                        ViewAnimation.LoadUIView();
                        container_menu.Hide();
                        break;
                    }
            }
        }
        private void ViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changetab();
        }
        #region Vẽ 2D
        public static bool mousedown = false;
        private void view2D_MouseDown(object sender, MouseEventArgs e)
        {

            View2D.click_putpixel(sender, e);
        }
        private void ViewPic2D_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mousedown = true;
                View2D.click_putpixel(sender, e);
            }
        }
        private void ViewPic2D_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
            LoadDetailMenu();
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Changetab();
        }
        #endregion
        #region Thanh chi tiết
        public static void LoadDetailMenu()
        {
            _BoxDetail.LoadDataDetail(paneldetail);
        }
        #endregion
        #region MenuHead
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DoAnCuoiKi_KTDH_WinForm.Dialog.InfoDialogForm _infoform = new DoAnCuoiKi_KTDH_WinForm.Dialog.InfoDialogForm())
            {
                _infoform.ShowDialog();
            }
        }
        private void hiệnLướiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (togglegrid == true)
                togglegrid = false;
            else
                togglegrid = true;
            View2D.ResetView();
            View3D.ResetView();
            ViewAnimation.Resetview();
        }

        private void ẩnThanhCôngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (container_menu.Visible)
                container_menu.Hide();
            else
                container_menu.Show();
        }

        private void ẩnThanhChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (containerdetail_right.Visible)
                containerdetail_right.Hide();
            else
                containerdetail_right.Show();
        }

        private void chuyểnSang2DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTab.SelectedIndex = 0;
            Changetab();
        }

        private void chuyểnSang3DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTab.SelectedIndex = 1;
            Changetab();
        }

        private void chuyểnSangAnimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTab.SelectedIndex = 2;
            Changetab();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApproveForm _exitForm = new ApproveForm();
            if (_exitForm.ShowDialog() == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ResetView(object sender, EventArgs e)
        {
            switch (ViewTab.SelectedIndex)
            {
                case 0:
                    {
                        View2D.ResetView();
                        break;
                    }
                case 1:
                    {
                        View3D.ResetView();
                        break;
                    }
                case 2:
                    {
                        ViewAnimation.Resetview();
                        break;
                    }
            }
        }
        #endregion
        #region Load item thanh công cụ
        private void Load_Tool_Box_2D()
        {

        }
        #endregion
        private void resetView2D(object sender, EventArgs e)
        {
            View2D.ResetView();
        }
        int angle = 45;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach(ObjectShape Shapen in View2D.ShapePoint)
                Shapen.Rotate(new Draw.Point(5,5), angle);
            View2D._listpoint.Clear();
            View2D.view.Refresh();
        }


        #region Animtaion
        bool PlayTimer = false;
        private void Click_btnPlayAnimation(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / 30;
            PlayTimer = !PlayTimer;
            if (PlayTimer)
            {
                btn_playtimer.BackgroundImage = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.PauseIcon;
            }
            else
            {
                btn_playtimer.BackgroundImage = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.PlayIcon;
            }
            ViewAnimation.Appstart = true;
            ViewAnimation.init();
            timer1.Enabled = PlayTimer;
        }

        #endregion
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApproveForm _exitForm = new ApproveForm();
            if (_exitForm.ShowDialog() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
       
    }
    public class Size
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    public static class ConvertPoint
    {
        public static int picturewidth = View_2D.viewsize.width, pictureheight = View_2D.viewsize.height;
        public static Draw.Point Doi_Sang_He_Toa_Do_May_Tinh(int X, int Y,Color? Colorpoint =null)
        {
            Draw.Point pointChange = new Draw.Point(0, 0);
            pointChange.X = picturewidth / 2 + X;
            pointChange.Y = pictureheight / 2 - Y;
            return pointChange;
        }
        public static Draw.Point Doi_Sang_He_Toa_Do_May_Tinh(Draw.Point _point)
        {
            Draw.Point pointChange = Doi_Sang_He_Toa_Do_May_Tinh(_point.X, _point.Y, _point.colorvalue);
            return pointChange;
        }
        public static Draw.Point Doi_Sang_He_Toa_Do_Nguoi_Dung(int X, int Y,Color?ColorFill=null)
        {
            Draw.Point pointChange;
            X = (X > picturewidth / 2 )? (X - picturewidth / 2) : -(picturewidth / 2 - X);
            Y = (Y > pictureheight / 2 )? -(Y - pictureheight / 2) : pictureheight / 2 - Y;
            pointChange = new Draw.Point(X, Y, ColorFill);
            return pointChange;
        }

    }

}
