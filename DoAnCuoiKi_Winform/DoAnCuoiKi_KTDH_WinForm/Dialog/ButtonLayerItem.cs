using System;
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
namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    public partial class ButtonLayerItem : UserControl
    {
        private Image ThumbButton { get; set; }
        private string namebutton { get; set; }
        public List<DataDetail> ListPointData { get; set; }
        public int i { get; set; }
        public ButtonLayerItem()
        {
            InitializeComponent();
        }

        public void Add(ObjectShape Shape)
        {
            if(Shape.name!=null)
            this.namebutton = Shape.name;
            else
            {
                this.namebutton = "noname";
            }
            this.ListPointData = Shape.Infoshape;
            switch (this.namebutton)
            {
                case "Hình tròn":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.CircleIcon;
                        break;
                    }
                case "Hình đa giác":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.RectangleIcon;
                        break;
                    }
                case "Hình tam giác":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.TriangleIcon;
                        break;
                    }
                case "Cây táng tròn":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.TreeCircleIcon;
                        break;
                    }
                case "Cây táng tam giác":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.TreeTriangleIcon;
                        break;
                    }
                case "Mây":
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.Cloud;
                        break;
                    }
                default:
                    {
                        this.ThumbButton = DoAnCuoiKi_KTDH_WinForm.Properties.Resources.RefeshIcon;
                        break;
                    }
            }
        }
        public void UpdatePoint(List<DataDetail> _list)
        {
            this.ListPointData = _list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm._BoxDetail.DataObject.Clear();
            MainForm._BoxDetail.DataObject = ListPointData;
            View_Animation.DataInfoShow = ListPointData;
            View_Animation.numberindex = i;
            MainForm.LoadDetailMenu();
        }
        private void ButtonLayerItem_Load(object sender, EventArgs e)
        {
            this.button1.Text = namebutton;
            this.button1.BackgroundImage = ThumbButton;
        }
    }
}
