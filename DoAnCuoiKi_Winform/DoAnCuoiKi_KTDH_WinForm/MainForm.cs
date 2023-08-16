using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKi_KTDH_WinForm.view;
namespace DoAnCuoiKi_KTDH_WinForm
{
    public partial class MainForm : Form
    {
        public static bool togglegrid = true;
        public static int UnitSize = 5;
        private view.View_2D View2D;
        public MainForm()
        {
            InitializeComponent();
            ViewTab.SelectedIndex = 0;
            View2D = new View_2D();
            View2D.view = ViewPic2D;
            View2D.LoadUIView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            switch (ViewTab.SelectedIndex)
            {
                case 0: // 2D
                    {
                        break;
                    }
                case 1: //3D
                    {
                        break;
                    }
                case 2://Animation
                    {
                        break;
                    }
            }
        }

        private void ViewTab_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        #region Vẽ 2D
        private void view2D_MouseDown(object sender, MouseEventArgs e)
        {
            View2D.click_putpixel(sender, e);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            View2D.LoadUIView();
        }
        #endregion

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DoAnCuoiKi_KTDH_WinForm.Dialog.InfoDialogForm _infoform = new DoAnCuoiKi_KTDH_WinForm.Dialog.InfoDialogForm())
            {
                _infoform.ShowDialog();
            }
        }
    }
    public class Size
    {
        public int width { get; set; }
        public int height { get; set; }
    }
}
