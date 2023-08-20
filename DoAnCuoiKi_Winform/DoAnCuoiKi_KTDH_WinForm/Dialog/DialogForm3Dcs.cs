using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    public partial class DialogForm3Dcs : Form
    {
        public bool Cylinder = false;
        public class DataDialog
        {
            public int x {get; set; }
            public int y {get; set;}
            public int z { get; set; }
            public int height { get; set; }
            public int rong { get; set; }
            public int width { get; set; }
            public int radius { get; set; }
        }
        public DataDialog Data;
        public DialogForm3Dcs()
        {
            Data = new DataDialog();
            InitializeComponent();
        }

        private void DialogForm3Dcs_Load(object sender, EventArgs e)
        {
            if (Cylinder)
            {
                panel_box.Visible = false;
                Group_BanKinh.Visible = true;
            }
            else
            {
                panel_box.Visible = true;
                Group_BanKinh.Visible = false;
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            int x, y,z, height, width,rong, radius;
            
            if(!Cylinder&&int.TryParse(centerinputx.Text, out x)&& int.TryParse(centerinputy.Text, out y)&&int.TryParse(centerinputz.Text,out z)&& int.TryParse(inputheight.Text, out height)&& int.TryParse(inputwidthbox.Text, out width)&& int.TryParse(inputrongbox.Text, out rong))
            {
                Data.x = x;
                Data.y = y;
                Data.z = z;
                Data.width = width;
                Data.rong = rong;
                Data.height = height;
                DialogResult = DialogResult.OK;
            }
            else if(Cylinder && int.TryParse(centerinputx.Text, out x) && int.TryParse(centerinputy.Text, out y) && int.TryParse(centerinputz.Text, out z) && int.TryParse(inputheight.Text, out height) && int.TryParse(inputcyclineradius.Text, out radius))
            {
                Data.x = x;
                Data.y = y;
                Data.z = z;
                Data.radius = radius;
                Data.height = height;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
