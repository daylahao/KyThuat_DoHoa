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
    public partial class Xoay : Form
    {
        public class DataDialog
        {
            public Draw.Point Center;
            public int Angle;
        }
        public DataDialog Data;
        public Xoay()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Cx, Cy, Angle;
           if(int.TryParse(startintputx.Text, out Cx) && int.TryParse(startintputy.Text, out Cy)&&int.TryParse(textBox2.Text,out Angle))
            {
                Data = new DataDialog();
                Data.Center = new Draw.Point(Cx, Cy);
                Data.Angle = Angle;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
