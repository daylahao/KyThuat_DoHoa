
namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    partial class DialogForm3Dcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.centerinputy = new System.Windows.Forms.TextBox();
            this.centerinputx = new System.Windows.Forms.TextBox();
            this.centerinputz = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputheight = new System.Windows.Forms.TextBox();
            this.panel_box = new System.Windows.Forms.TableLayoutPanel();
            this.Group_Rong = new System.Windows.Forms.GroupBox();
            this.inputrongbox = new System.Windows.Forms.TextBox();
            this.Group_Dai = new System.Windows.Forms.GroupBox();
            this.inputwidthbox = new System.Windows.Forms.TextBox();
            this.Group_BanKinh = new System.Windows.Forms.GroupBox();
            this.inputcyclineradius = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_box.SuspendLayout();
            this.Group_Rong.SuspendLayout();
            this.Group_Dai.SuspendLayout();
            this.Group_BanKinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_accept, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 55);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_accept.Location = new System.Drawing.Point(379, 3);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(109, 55);
            this.btn_accept.TabIndex = 1;
            this.btn_accept.Text = "Chấp nhận";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 104);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.71079F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.28921F));
            this.tableLayoutPanel2.Controls.Add(this.Group_BanKinh, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel_box, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(491, 104);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tâm Gốc";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.Controls.Add(this.centerinputz, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.centerinputy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.centerinputx, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(290, 28);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // centerinputy
            // 
            this.centerinputy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerinputy.Location = new System.Drawing.Point(97, 3);
            this.centerinputy.Name = "centerinputy";
            this.centerinputy.Size = new System.Drawing.Size(88, 20);
            this.centerinputy.TabIndex = 3;
            // 
            // centerinputx
            // 
            this.centerinputx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerinputx.Location = new System.Drawing.Point(3, 3);
            this.centerinputx.Name = "centerinputx";
            this.centerinputx.Size = new System.Drawing.Size(88, 20);
            this.centerinputx.TabIndex = 2;
            // 
            // centerinputz
            // 
            this.centerinputz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerinputz.Location = new System.Drawing.Point(191, 3);
            this.centerinputz.Name = "centerinputz";
            this.centerinputz.Size = new System.Drawing.Size(96, 20);
            this.centerinputz.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputheight);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(305, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 47);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chiều cao";
            // 
            // inputheight
            // 
            this.inputheight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputheight.Location = new System.Drawing.Point(3, 16);
            this.inputheight.Name = "inputheight";
            this.inputheight.Size = new System.Drawing.Size(177, 20);
            this.inputheight.TabIndex = 3;
            // 
            // panel_box
            // 
            this.panel_box.ColumnCount = 2;
            this.panel_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_box.Controls.Add(this.Group_Rong, 0, 0);
            this.panel_box.Controls.Add(this.Group_Dai, 1, 0);
            this.panel_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_box.Location = new System.Drawing.Point(3, 56);
            this.panel_box.Name = "panel_box";
            this.panel_box.RowCount = 1;
            this.panel_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_box.Size = new System.Drawing.Size(296, 45);
            this.panel_box.TabIndex = 9;
            // 
            // Group_Rong
            // 
            this.Group_Rong.Controls.Add(this.inputrongbox);
            this.Group_Rong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Rong.Location = new System.Drawing.Point(3, 3);
            this.Group_Rong.Name = "Group_Rong";
            this.Group_Rong.Size = new System.Drawing.Size(142, 39);
            this.Group_Rong.TabIndex = 0;
            this.Group_Rong.TabStop = false;
            this.Group_Rong.Text = "Chiều rộng";
            // 
            // inputrongbox
            // 
            this.inputrongbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputrongbox.Location = new System.Drawing.Point(3, 16);
            this.inputrongbox.Name = "inputrongbox";
            this.inputrongbox.Size = new System.Drawing.Size(136, 20);
            this.inputrongbox.TabIndex = 3;
            // 
            // Group_Dai
            // 
            this.Group_Dai.Controls.Add(this.inputwidthbox);
            this.Group_Dai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_Dai.Location = new System.Drawing.Point(151, 3);
            this.Group_Dai.Name = "Group_Dai";
            this.Group_Dai.Size = new System.Drawing.Size(142, 39);
            this.Group_Dai.TabIndex = 1;
            this.Group_Dai.TabStop = false;
            this.Group_Dai.Text = "Chiều dài";
            // 
            // inputwidthbox
            // 
            this.inputwidthbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputwidthbox.Location = new System.Drawing.Point(3, 16);
            this.inputwidthbox.Name = "inputwidthbox";
            this.inputwidthbox.Size = new System.Drawing.Size(136, 20);
            this.inputwidthbox.TabIndex = 3;
            // 
            // Group_BanKinh
            // 
            this.Group_BanKinh.Controls.Add(this.inputcyclineradius);
            this.Group_BanKinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Group_BanKinh.Location = new System.Drawing.Point(305, 56);
            this.Group_BanKinh.Name = "Group_BanKinh";
            this.Group_BanKinh.Size = new System.Drawing.Size(183, 45);
            this.Group_BanKinh.TabIndex = 10;
            this.Group_BanKinh.TabStop = false;
            this.Group_BanKinh.Text = "Bán kính";
            // 
            // inputcyclineradius
            // 
            this.inputcyclineradius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputcyclineradius.Location = new System.Drawing.Point(3, 16);
            this.inputcyclineradius.Name = "inputcyclineradius";
            this.inputcyclineradius.Size = new System.Drawing.Size(177, 20);
            this.inputcyclineradius.TabIndex = 3;
            // 
            // DialogForm3Dcs
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(491, 165);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DialogForm3Dcs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DialogForm3D";
            this.Load += new System.EventHandler(this.DialogForm3Dcs_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_box.ResumeLayout(false);
            this.Group_Rong.ResumeLayout(false);
            this.Group_Rong.PerformLayout();
            this.Group_Dai.ResumeLayout(false);
            this.Group_Dai.PerformLayout();
            this.Group_BanKinh.ResumeLayout(false);
            this.Group_BanKinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox centerinputy;
        private System.Windows.Forms.TextBox centerinputx;
        private System.Windows.Forms.TextBox centerinputz;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputheight;
        private System.Windows.Forms.GroupBox Group_BanKinh;
        private System.Windows.Forms.TextBox inputcyclineradius;
        private System.Windows.Forms.TableLayoutPanel panel_box;
        private System.Windows.Forms.GroupBox Group_Rong;
        private System.Windows.Forms.TextBox inputrongbox;
        private System.Windows.Forms.GroupBox Group_Dai;
        private System.Windows.Forms.TextBox inputwidthbox;
    }
}