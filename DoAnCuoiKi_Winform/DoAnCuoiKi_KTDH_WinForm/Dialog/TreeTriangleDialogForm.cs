using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    public partial class TreeTriangleDialogForm : Form
    {
        public class dialogdata
        {
            public int Sx { get; set; }
            public int Sy { get; set; }
            public int Ex { get; set; }
            public int Ey { get; set; }
            public int height { get; set; }
            public int width { get; set; }
            public int centerx { get; set; }
            public int centery { get; set; }
            public Color colorline { get; set; }
            public int count { get; set; }
        }
        public dialogdata data;
        public TreeTriangleDialogForm()
        {
            InitializeComponent();
            data = new dialogdata();
        }

        private void TreeTriangleDialogForm_Load(object sender, EventArgs e)
        {
            inputcount.Value = 1;
        }
        private void btn_Accecpt_Click(object sender, EventArgs e)
        {
            int centerx,centery,height,width,count;
            if (int.TryParse(centerinputx.Text, out centerx) && int.TryParse(centerinputy.Text, out centery) && int.TryParse(inputheight.Text, out height) && int.TryParse(inputwidth.Text, out width)&&inputcount.Value>0)
            {
                data.Sx = centerx-width/2;
                data.Sy = centery;
                data.Ex = centerx + width / 2;
                data.Ey = centery + height;
                data.height = height;
                data.width = width;
                data.centerx = centerx;
                data.centery = centery;
                data.count = (int)inputcount.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }
    }
}
