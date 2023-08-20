
namespace DoAnCuoiKi_KTDH_WinForm.Dialog
{
    partial class TreeTriangleDialogForm
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
            this.btn_Accecpt = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Style = new System.Windows.Forms.GroupBox();
            this.inputcount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.centerinputy = new System.Windows.Forms.TextBox();
            this.centerinputx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.inputheight = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputwidth = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Style.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputcount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.20301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.79699F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Accecpt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 128);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Accecpt
            // 
            this.btn_Accecpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Accecpt.Location = new System.Drawing.Point(256, 3);
            this.btn_Accecpt.Name = "btn_Accecpt";
            this.btn_Accecpt.Size = new System.Drawing.Size(107, 33);
            this.btn_Accecpt.TabIndex = 2;
            this.btn_Accecpt.Text = "Chấp nhận";
            this.btn_Accecpt.UseVisualStyleBackColor = true;
            this.btn_Accecpt.Click += new System.EventHandler(this.btn_Accecpt_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_close.Location = new System.Drawing.Point(3, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(73, 33);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel2.Controls.Add(this.Style, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(366, 128);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Style
            // 
            this.Style.Controls.Add(this.inputcount);
            this.Style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Style.Location = new System.Drawing.Point(188, 67);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(175, 58);
            this.Style.TabIndex = 8;
            this.Style.TabStop = false;
            this.Style.Text = "Số tán cây";
            // 
            // inputcount
            // 
            this.inputcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputcount.Location = new System.Drawing.Point(3, 16);
            this.inputcount.Name = "inputcount";
            this.inputcount.Size = new System.Drawing.Size(169, 20);
            this.inputcount.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tâm Gốc";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.centerinputy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.centerinputx, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(173, 39);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // centerinputy
            // 
            this.centerinputy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerinputy.Location = new System.Drawing.Point(89, 3);
            this.centerinputy.Name = "centerinputy";
            this.centerinputy.Size = new System.Drawing.Size(81, 20);
            this.centerinputy.TabIndex = 3;
            // 
            // centerinputx
            // 
            this.centerinputx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerinputx.Location = new System.Drawing.Point(3, 3);
            this.centerinputx.Name = "centerinputx";
            this.centerinputx.Size = new System.Drawing.Size(80, 20);
            this.centerinputx.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(188, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(175, 58);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputheight);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chiều cao";
            // 
            // inputheight
            // 
            this.inputheight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputheight.Location = new System.Drawing.Point(3, 16);
            this.inputheight.Name = "inputheight";
            this.inputheight.Size = new System.Drawing.Size(75, 20);
            this.inputheight.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inputwidth);
            this.groupBox3.Location = new System.Drawing.Point(90, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(82, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chiều ngang";
            // 
            // inputwidth
            // 
            this.inputwidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputwidth.Location = new System.Drawing.Point(3, 16);
            this.inputwidth.Name = "inputwidth";
            this.inputwidth.Size = new System.Drawing.Size(76, 20);
            this.inputwidth.TabIndex = 3;
            // 
            // TreeTriangleDialogForm
            // 
            this.AcceptButton = this.btn_Accecpt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(366, 167);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TreeTriangleDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TreeTriangleDialogForm";
            this.Load += new System.EventHandler(this.TreeTriangleDialogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Style.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputcount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox centerinputy;
        private System.Windows.Forms.TextBox centerinputx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputheight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox inputwidth;
        private System.Windows.Forms.GroupBox Style;
        private System.Windows.Forms.NumericUpDown inputcount;
        private System.Windows.Forms.Button btn_Accecpt;
        private System.Windows.Forms.Button btn_close;
    }
}