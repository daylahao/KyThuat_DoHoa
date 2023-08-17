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
    public partial class LineDialogForm : Form
    {
        public class dialogdata {
            public int Sx { get; set; }
            public int Sy { get; set; }
            public int Ex { get; set; }
            public int Ey { get; set; }
            public Color colorline { get; set; }
            public string style { get; set; }
        }
        public dialogdata data;
        public LineDialogForm()
        {
            InitializeComponent();
             data = new dialogdata();
        }

        private void LineDialogForm_Load(object sender, EventArgs e)
        {
            /*           foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
                       {
                           if (prop.PropertyType.FullName == "System.Drawing.Color")
                               //comboBox1.Items.Add(prop.Name);
                       }
                       comboBox1.SelectedItem = "Black";*/
            colorbox.DataSource = typeof(Color).GetProperties()
               .Where(x => x.PropertyType == typeof(Color))
               .Select(x => x.GetValue(null)).ToList();
            colorbox.MaxDropDownItems = 10;
            colorbox.IntegralHeight = false;
            colorbox.DrawMode = DrawMode.OwnerDrawFixed;
            colorbox.DropDownStyle = ComboBoxStyle.DropDownList;
            colorbox.DrawItem += comboBox1_DrawItem;
            colorbox.SelectedItem = Color.Black;
            Stylelinecombobox.SelectedIndex = 0;
        }
        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = colorbox.GetItemText(colorbox.Items[e.Index]);
                var color = (Color)colorbox.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, colorbox.Font, r2,
                    colorbox.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void btn_accept_Click(object sender, EventArgs e)
        {
            int Sx, Sy, Ex, Ey;
            if (int.TryParse(startintputx.Text, out Sx) && int.TryParse(startintputy.Text, out Sy) && int.TryParse(endinputx.Text, out Ex) && int.TryParse(endinputy.Text, out Ey))
            {
                data.Sx = Sx;
                data.Sy = Sy;
                data.Ex = Ex;
                data.Ey = Ey;
                data.colorline = (Color)colorbox.SelectedItem;
                data.style = Stylelinecombobox.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }
        public class ColorInfo
        {
            public string Text { get; set; }
            public Color Color { get; set; }

            public ColorInfo(string text, Color color)
            {
                Text = text;
                Color = color;
            }
        }
    }
}
