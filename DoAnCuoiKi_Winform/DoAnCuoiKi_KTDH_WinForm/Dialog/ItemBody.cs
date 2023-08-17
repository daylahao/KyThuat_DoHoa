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
    public partial class ItemBody : UserControl
    {
        public event EventHandler ButtonClick;
        public string itemname;
        public Image thumb;
        Color HoverColor = Color.Orange,DefaultColor = Color.OrangeRed;
        public ItemBody()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ItemBody_Click(sender, e);
        }

        private void ItemBody_Click(object sender, EventArgs e)
        {
            Button1_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ItemBody_Click(sender, e);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        private void ItemBody_Load(object sender, EventArgs e)
        {
            label1.Text = itemname;
            pictureBox1.BackgroundImage = thumb;
        }

        private void ItemBody_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackColor = DefaultBackColor ;
        }

        private void ItemBody_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackColor = HoverColor;
        }
    }
}
