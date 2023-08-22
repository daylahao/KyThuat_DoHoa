
namespace DoAnCuoiKi_KTDH_WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.container_menu = new System.Windows.Forms.Panel();
            this.toolboxgroup = new System.Windows.Forms.GroupBox();
            this.group_btn = new System.Windows.Forms.Panel();
            this.container_body = new System.Windows.Forms.Panel();
            this.ViewTab = new System.Windows.Forms.TabControl();
            this.tab2D = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.ViewPic2D = new System.Windows.Forms.PictureBox();
            this.tab3D = new System.Windows.Forms.TabPage();
            this.view3D = new System.Windows.Forms.PictureBox();
            this.tabanimation = new System.Windows.Forms.TabPage();
            this.Container_Control_Animtaion = new System.Windows.Forms.Panel();
            this.btn_playtimer = new System.Windows.Forms.Button();
            this.viewanim = new System.Windows.Forms.PictureBox();
            this.MenuHead = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSang2DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSang3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnSangAnimationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệnLướiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ẩnThanhCôngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ẩnThanhChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.làmMớiViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerdetail_right = new System.Windows.Forms.Panel();
            this.detailgroup = new System.Windows.Forms.GroupBox();
            this.panel_detail = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.container_itemlist_bottom = new System.Windows.Forms.Panel();
            this.itemgroup = new System.Windows.Forms.GroupBox();
            this.buttonLayerItem1 = new DoAnCuoiKi_KTDH_WinForm.Dialog.ButtonLayerItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.container_menu.SuspendLayout();
            this.toolboxgroup.SuspendLayout();
            this.container_body.SuspendLayout();
            this.ViewTab.SuspendLayout();
            this.tab2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPic2D)).BeginInit();
            this.tab3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view3D)).BeginInit();
            this.tabanimation.SuspendLayout();
            this.Container_Control_Animtaion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewanim)).BeginInit();
            this.MenuHead.SuspendLayout();
            this.containerdetail_right.SuspendLayout();
            this.detailgroup.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.container_itemlist_bottom.SuspendLayout();
            this.itemgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // container_menu
            // 
            this.container_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container_menu.Controls.Add(this.toolboxgroup);
            this.container_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.container_menu.Location = new System.Drawing.Point(0, 24);
            this.container_menu.Name = "container_menu";
            this.container_menu.Size = new System.Drawing.Size(144, 445);
            this.container_menu.TabIndex = 0;
            // 
            // toolboxgroup
            // 
            this.toolboxgroup.Controls.Add(this.group_btn);
            this.toolboxgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolboxgroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toolboxgroup.Location = new System.Drawing.Point(0, 0);
            this.toolboxgroup.Name = "toolboxgroup";
            this.toolboxgroup.Size = new System.Drawing.Size(144, 445);
            this.toolboxgroup.TabIndex = 0;
            this.toolboxgroup.TabStop = false;
            this.toolboxgroup.Text = "Công cụ";
            // 
            // group_btn
            // 
            this.group_btn.AutoScroll = true;
            this.group_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_btn.Location = new System.Drawing.Point(3, 16);
            this.group_btn.Name = "group_btn";
            this.group_btn.Size = new System.Drawing.Size(138, 426);
            this.group_btn.TabIndex = 0;
            // 
            // container_body
            // 
            this.container_body.Controls.Add(this.ViewTab);
            this.container_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container_body.Location = new System.Drawing.Point(144, 24);
            this.container_body.Name = "container_body";
            this.container_body.Size = new System.Drawing.Size(751, 445);
            this.container_body.TabIndex = 1;
            // 
            // ViewTab
            // 
            this.ViewTab.Controls.Add(this.tab2D);
            this.ViewTab.Controls.Add(this.tab3D);
            this.ViewTab.Controls.Add(this.tabanimation);
            this.ViewTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTab.Location = new System.Drawing.Point(0, 0);
            this.ViewTab.Name = "ViewTab";
            this.ViewTab.SelectedIndex = 0;
            this.ViewTab.Size = new System.Drawing.Size(751, 445);
            this.ViewTab.TabIndex = 0;
            this.ViewTab.SelectedIndexChanged += new System.EventHandler(this.ViewTab_SelectedIndexChanged);
            // 
            // tab2D
            // 
            this.tab2D.Controls.Add(this.button2);
            this.tab2D.Controls.Add(this.ViewPic2D);
            this.tab2D.Location = new System.Drawing.Point(4, 22);
            this.tab2D.Name = "tab2D";
            this.tab2D.Padding = new System.Windows.Forms.Padding(3);
            this.tab2D.Size = new System.Drawing.Size(743, 419);
            this.tab2D.TabIndex = 0;
            this.tab2D.Text = "2D";
            this.tab2D.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = global::DoAnCuoiKi_KTDH_WinForm.Properties.Resources.RefeshIcon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(710, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 25);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.resetView2D);
            // 
            // ViewPic2D
            // 
            this.ViewPic2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewPic2D.Location = new System.Drawing.Point(3, 3);
            this.ViewPic2D.Name = "ViewPic2D";
            this.ViewPic2D.Size = new System.Drawing.Size(737, 413);
            this.ViewPic2D.TabIndex = 0;
            this.ViewPic2D.TabStop = false;
            this.ViewPic2D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.view2D_MouseDown);
            this.ViewPic2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPic2D_MouseMove);
            this.ViewPic2D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPic2D_MouseUp);
            // 
            // tab3D
            // 
            this.tab3D.Controls.Add(this.view3D);
            this.tab3D.Location = new System.Drawing.Point(4, 22);
            this.tab3D.Name = "tab3D";
            this.tab3D.Padding = new System.Windows.Forms.Padding(3);
            this.tab3D.Size = new System.Drawing.Size(743, 419);
            this.tab3D.TabIndex = 1;
            this.tab3D.Text = "3D";
            this.tab3D.UseVisualStyleBackColor = true;
            // 
            // view3D
            // 
            this.view3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view3D.Location = new System.Drawing.Point(3, 3);
            this.view3D.Name = "view3D";
            this.view3D.Size = new System.Drawing.Size(737, 413);
            this.view3D.TabIndex = 0;
            this.view3D.TabStop = false;
            // 
            // tabanimation
            // 
            this.tabanimation.Controls.Add(this.Container_Control_Animtaion);
            this.tabanimation.Controls.Add(this.viewanim);
            this.tabanimation.Location = new System.Drawing.Point(4, 22);
            this.tabanimation.Name = "tabanimation";
            this.tabanimation.Size = new System.Drawing.Size(743, 419);
            this.tabanimation.TabIndex = 2;
            this.tabanimation.Text = "Chuyển Động";
            this.tabanimation.UseVisualStyleBackColor = true;
            // 
            // Container_Control_Animtaion
            // 
            this.Container_Control_Animtaion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Container_Control_Animtaion.Controls.Add(this.btn_playtimer);
            this.Container_Control_Animtaion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Container_Control_Animtaion.Location = new System.Drawing.Point(0, 378);
            this.Container_Control_Animtaion.Name = "Container_Control_Animtaion";
            this.Container_Control_Animtaion.Size = new System.Drawing.Size(743, 41);
            this.Container_Control_Animtaion.TabIndex = 1;
            // 
            // btn_playtimer
            // 
            this.btn_playtimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_playtimer.BackgroundImage = global::DoAnCuoiKi_KTDH_WinForm.Properties.Resources.PlayIcon;
            this.btn_playtimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_playtimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playtimer.Location = new System.Drawing.Point(332, 3);
            this.btn_playtimer.Name = "btn_playtimer";
            this.btn_playtimer.Size = new System.Drawing.Size(65, 35);
            this.btn_playtimer.TabIndex = 1;
            this.btn_playtimer.UseVisualStyleBackColor = true;
            this.btn_playtimer.Click += new System.EventHandler(this.Click_btnPlayAnimation);
            // 
            // viewanim
            // 
            this.viewanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewanim.Location = new System.Drawing.Point(0, 0);
            this.viewanim.Name = "viewanim";
            this.viewanim.Size = new System.Drawing.Size(743, 419);
            this.viewanim.TabIndex = 0;
            this.viewanim.TabStop = false;
            // 
            // MenuHead
            // 
            this.MenuHead.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.giaoDiệnToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.MenuHead.Location = new System.Drawing.Point(0, 0);
            this.MenuHead.Name = "MenuHead";
            this.MenuHead.Size = new System.Drawing.Size(1091, 24);
            this.MenuHead.TabIndex = 2;
            this.MenuHead.Text = "MenuHead";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "Chung";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnSang2DToolStripMenuItem,
            this.chuyểnSang3DToolStripMenuItem,
            this.chuyểnSangAnimationToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // chuyểnSang2DToolStripMenuItem
            // 
            this.chuyểnSang2DToolStripMenuItem.Name = "chuyểnSang2DToolStripMenuItem";
            this.chuyểnSang2DToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chuyểnSang2DToolStripMenuItem.Text = "Chuyển sang 2D";
            this.chuyểnSang2DToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSang2DToolStripMenuItem_Click);
            // 
            // chuyểnSang3DToolStripMenuItem
            // 
            this.chuyểnSang3DToolStripMenuItem.Name = "chuyểnSang3DToolStripMenuItem";
            this.chuyểnSang3DToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chuyểnSang3DToolStripMenuItem.Text = "Chuyển sang 3D";
            this.chuyểnSang3DToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSang3DToolStripMenuItem_Click);
            // 
            // chuyểnSangAnimationToolStripMenuItem
            // 
            this.chuyểnSangAnimationToolStripMenuItem.Name = "chuyểnSangAnimationToolStripMenuItem";
            this.chuyểnSangAnimationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.chuyểnSangAnimationToolStripMenuItem.Text = "Chuyển sang animation";
            this.chuyểnSangAnimationToolStripMenuItem.Click += new System.EventHandler(this.chuyểnSangAnimationToolStripMenuItem_Click);
            // 
            // giaoDiệnToolStripMenuItem
            // 
            this.giaoDiệnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiệnLướiToolStripMenuItem,
            this.ẩnThanhCôngCụToolStripMenuItem,
            this.ẩnThanhChiTiếtToolStripMenuItem,
            this.làmMớiViewToolStripMenuItem});
            this.giaoDiệnToolStripMenuItem.Name = "giaoDiệnToolStripMenuItem";
            this.giaoDiệnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.giaoDiệnToolStripMenuItem.Text = "Giao Diện";
            // 
            // hiệnLướiToolStripMenuItem
            // 
            this.hiệnLướiToolStripMenuItem.Name = "hiệnLướiToolStripMenuItem";
            this.hiệnLướiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hiệnLướiToolStripMenuItem.Text = "Ẩn Lưới Trên View";
            this.hiệnLướiToolStripMenuItem.Click += new System.EventHandler(this.hiệnLướiToolStripMenuItem_Click);
            // 
            // ẩnThanhCôngCụToolStripMenuItem
            // 
            this.ẩnThanhCôngCụToolStripMenuItem.Name = "ẩnThanhCôngCụToolStripMenuItem";
            this.ẩnThanhCôngCụToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ẩnThanhCôngCụToolStripMenuItem.Text = "Ẩn Thanh Công Cụ";
            this.ẩnThanhCôngCụToolStripMenuItem.Click += new System.EventHandler(this.ẩnThanhCôngCụToolStripMenuItem_Click);
            // 
            // ẩnThanhChiTiếtToolStripMenuItem
            // 
            this.ẩnThanhChiTiếtToolStripMenuItem.Name = "ẩnThanhChiTiếtToolStripMenuItem";
            this.ẩnThanhChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ẩnThanhChiTiếtToolStripMenuItem.Text = "Ẩn Thanh Chi Tiết";
            this.ẩnThanhChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.ẩnThanhChiTiếtToolStripMenuItem_Click);
            // 
            // làmMớiViewToolStripMenuItem
            // 
            this.làmMớiViewToolStripMenuItem.Name = "làmMớiViewToolStripMenuItem";
            this.làmMớiViewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.làmMớiViewToolStripMenuItem.Text = "Làm Mới View";
            this.làmMớiViewToolStripMenuItem.Click += new System.EventHandler(this.ResetView);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // containerdetail_right
            // 
            this.containerdetail_right.Controls.Add(this.detailgroup);
            this.containerdetail_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.containerdetail_right.Location = new System.Drawing.Point(895, 24);
            this.containerdetail_right.Name = "containerdetail_right";
            this.containerdetail_right.Size = new System.Drawing.Size(196, 445);
            this.containerdetail_right.TabIndex = 0;
            // 
            // detailgroup
            // 
            this.detailgroup.Controls.Add(this.panel_detail);
            this.detailgroup.Controls.Add(this.flowLayoutPanel1);
            this.detailgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailgroup.Location = new System.Drawing.Point(0, 0);
            this.detailgroup.Name = "detailgroup";
            this.detailgroup.Size = new System.Drawing.Size(196, 445);
            this.detailgroup.TabIndex = 0;
            this.detailgroup.TabStop = false;
            this.detailgroup.Text = "Chi tiết";
            // 
            // panel_detail
            // 
            this.panel_detail.AllowDrop = true;
            this.panel_detail.AutoScroll = true;
            this.panel_detail.AutoSize = true;
            this.panel_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_detail.Location = new System.Drawing.Point(3, 16);
            this.panel_detail.Name = "panel_detail";
            this.panel_detail.Padding = new System.Windows.Forms.Padding(5);
            this.panel_detail.Size = new System.Drawing.Size(190, 374);
            this.panel_detail.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 390);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(190, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 33);
            this.button3.TabIndex = 0;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // container_itemlist_bottom
            // 
            this.container_itemlist_bottom.Controls.Add(this.itemgroup);
            this.container_itemlist_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.container_itemlist_bottom.Location = new System.Drawing.Point(0, 469);
            this.container_itemlist_bottom.Name = "container_itemlist_bottom";
            this.container_itemlist_bottom.Size = new System.Drawing.Size(1091, 110);
            this.container_itemlist_bottom.TabIndex = 3;
            this.container_itemlist_bottom.Visible = false;
            // 
            // itemgroup
            // 
            this.itemgroup.Controls.Add(this.buttonLayerItem1);
            this.itemgroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemgroup.Location = new System.Drawing.Point(0, 0);
            this.itemgroup.Name = "itemgroup";
            this.itemgroup.Size = new System.Drawing.Size(1091, 110);
            this.itemgroup.TabIndex = 0;
            this.itemgroup.TabStop = false;
            this.itemgroup.Text = "Vật xuất hiện";
            // 
            // buttonLayerItem1
            // 
            this.buttonLayerItem1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLayerItem1.Location = new System.Drawing.Point(3, 16);
            this.buttonLayerItem1.Name = "buttonLayerItem1";
            this.buttonLayerItem1.Size = new System.Drawing.Size(123, 91);
            this.buttonLayerItem1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 579);
            this.Controls.Add(this.container_body);
            this.Controls.Add(this.container_menu);
            this.Controls.Add(this.containerdetail_right);
            this.Controls.Add(this.MenuHead);
            this.Controls.Add(this.container_itemlist_bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuHead;
            this.Name = "MainForm";
            this.Text = "DoAnCuoiKi_KTDH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.container_menu.ResumeLayout(false);
            this.toolboxgroup.ResumeLayout(false);
            this.container_body.ResumeLayout(false);
            this.ViewTab.ResumeLayout(false);
            this.tab2D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPic2D)).EndInit();
            this.tab3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.view3D)).EndInit();
            this.tabanimation.ResumeLayout(false);
            this.Container_Control_Animtaion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewanim)).EndInit();
            this.MenuHead.ResumeLayout(false);
            this.MenuHead.PerformLayout();
            this.containerdetail_right.ResumeLayout(false);
            this.detailgroup.ResumeLayout(false);
            this.detailgroup.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.container_itemlist_bottom.ResumeLayout(false);
            this.itemgroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel container_menu;
        private System.Windows.Forms.Panel container_body;
        private System.Windows.Forms.MenuStrip MenuHead;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệnLướiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSang3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSangAnimationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnSang2DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ẩnThanhCôngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem làmMớiViewToolStripMenuItem;
        private System.Windows.Forms.GroupBox toolboxgroup;
        private System.Windows.Forms.TabControl ViewTab;
        private System.Windows.Forms.TabPage tab2D;
        private System.Windows.Forms.TabPage tab3D;
        private System.Windows.Forms.PictureBox view3D;
        private System.Windows.Forms.TabPage tabanimation;
        private System.Windows.Forms.PictureBox viewanim;
        private System.Windows.Forms.Panel containerdetail_right;
        private System.Windows.Forms.GroupBox detailgroup;
        private System.Windows.Forms.Panel container_itemlist_bottom;
        private System.Windows.Forms.GroupBox itemgroup;
        private System.Windows.Forms.PictureBox ViewPic2D;
        private System.Windows.Forms.Panel group_btn;
        private System.Windows.Forms.Panel panel_detail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Container_Control_Animtaion;
        private System.Windows.Forms.Button btn_playtimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem ẩnThanhChiTiếtToolStripMenuItem;
        private Dialog.ButtonLayerItem buttonLayerItem1;
    }
}

