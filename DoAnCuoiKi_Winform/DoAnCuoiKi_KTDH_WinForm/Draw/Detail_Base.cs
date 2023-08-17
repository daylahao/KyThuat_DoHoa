using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKi_KTDH_WinForm.Draw;
using System.Windows.Forms;
namespace DoAnCuoiKi_KTDH_WinForm.Draw
{
    public class Detail_Base
    {
        public List<DataDetail> DataObject;
        public void LoadDataDetail(Panel ContainerDetail)
        {
            ContainerDetail.Controls.Clear();
            foreach (DataDetail Data in DataObject)
            {
                FlowLayoutPanel _panel = new FlowLayoutPanel();
                _panel.Dock = DockStyle.Top;
                _panel.AutoSize = true;
                _panel.BackColor = System.Drawing.Color.Gray;
                _panel.Padding = new Padding(3, 3, 3, 3);
                _panel.BorderStyle = BorderStyle.FixedSingle;
                Label pointstartlabel = new Label();
                pointstartlabel.Text = Data.name;
                pointstartlabel.AutoSize = true;
                pointstartlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                _panel.Controls.Add(pointstartlabel);
                if (Data.Sx.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Điểm đầu = { x=" + Data.Sx.ToString() + " y= " + Data.Sy.ToString() + "}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.Ex.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Điểm Cuối = { x=" + Data.Ex.ToString() + " y= " + Data.Ey.ToString() + "}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.R.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Bán kính = {"+ Data.R.ToString()+"}";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.centerx.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Tâm = { X="+Data.centerx.ToString() +"Y= "+Data.centery.ToString() + " }";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                if (Data.height.HasValue)
                {
                    pointstartlabel = new Label();
                    pointstartlabel.Text = "Chiều cao" + Data.height.ToString() + "dài " + Data.width.ToString() + " }";
                    pointstartlabel.AutoSize = true;
                    _panel.Controls.Add(pointstartlabel);
                }
                ContainerDetail.Controls.Add(_panel);
            }
        }
    }
    public class DataDetail
    {
        public string name { get; set; }
        public int? Sx { get; set; }
        public int? Sy { get; set; }
        public int? Ex { get; set; }
        public int? Ey { get; set; }
        public int? centerx { get; set; }
        public int? centery { get; set; }
        public int? R { get; set; }
        public int? height { get; set; }
        public int? width { get; set; }
    }
}
