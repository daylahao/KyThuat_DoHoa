﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public static Detail_Base _BoxDetail;
        public static Panel paneldetail;
        public static Panel panellayer;
        private bool AppStart = true;
        public List<List<Draw.Point>> ListObjectAnimation = new List<List<Draw.Point>>();
        public MainForm()
        {
            InitializeComponent();
            ViewTab.SelectedIndex = tabindex;
            View2D = new View_2D();
            ViewAnimation = new View_Animation();
            ViewAnimation.view = this.viewanim;
            ViewAnimation.panellayer = container_itemlist_bottom;
            View2D.view = this.ViewPic2D;
            _BoxDetail = new Detail_Base();
            _BoxDetail.DataObject = new List<DataDetail>();
            paneldetail = this.panel_detail;
            panellayer = this.container_itemlist_bottom;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AppStart)
            {
                View2D.CreatListToolBox();
                AppStart = false;
            }
            Changetab();
        }
        private void Changetab()
        {
            if (tabindex != ViewTab.SelectedIndex)
            {
                group_btn.Controls.Clear();
                _BoxDetail.DataObject.Clear();
                MainForm.panellayer.Visible = false;
                LoadDetailMenu();
                tabindex = ViewTab.SelectedIndex;
            }
            switch (ViewTab.SelectedIndex)
            {
                case 0: // 2D
                    {
                        View2D.LoadUIView();
                        View2D.LoadMenuToolBox(group_btn);
                        break;
                    }
                case 1: //3D
                    {
                        break;
                    }
                case 2://Animation
                    {
                        ViewAnimation.LoadUIView();
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
        #endregion
        #region Load item thanh công cụ
        private void Load_Tool_Box_2D()
        {

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void resetView2D(object sender, EventArgs e)
        {
            View2D.ResetView();
        }
    }
    public class Size
    {
        public int width { get; set; }
        public int height { get; set; }
    }
    public class ConvertPoint
    {
        int picturewidth = View_2D.viewsize.width, pictureheight = View_2D.viewsize.height;
        public int[] Doi_Sang_He_Toa_Do_May_Tinh(int X, int Y)
        {
            int[] pointChange;
            X = picturewidth / 2 + X;
            Y = pictureheight / 2 - Y;
            pointChange = new int[] { X, Y };
            return pointChange;
        }
        public int[] Doi_Sang_He_Toa_Do_Nguoi_Dung(int X, int Y)
        {
            int[] pointChange;
            X = X > picturewidth / 2 ? (X - picturewidth / 2) : -(picturewidth / 2 - X);
            Y = Y > pictureheight / 2 ? -(Y - pictureheight / 2) : pictureheight / 2 - Y;
            pointChange = new int[] { X, Y };
            return pointChange;
        }
    }

}
